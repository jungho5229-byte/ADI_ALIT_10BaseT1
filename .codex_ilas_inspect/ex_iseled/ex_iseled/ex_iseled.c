/*******************************************************************************
Copyright (c) 2022-2025 - Analog Devices Inc. All Rights Reserved.
This software is proprietary & confidential to Analog Devices, Inc.
and its licensors.
******************************************************************************
 * \file: ex_iseled.c
 * \brief: This is the application main file for ISELED
 * Developed by: Automotive Software and Systems team, Bangalore, India
*****************************************************************************/
/** \addtogroup app
 *  @{
 */

/*================================= INCLUDES ================================*/
#include "ex_iseled.h"

/*================================= DEFINES =================================*/

/*================================ PROTOTYPES ===============================*/
static void InitSystem(void);
static void InitThread(void *arg);
static void CreateThreads(void);
static void CreateE2bApp(void);
static void AppThread1Fxn(void *arg);
static void HouseKeepingFxn(void *arg);
static void PrintHelpContents(void);
static void ConsoleRun(void);
static void adi_network_cbk(uint32_t nDevNum, ADI_NETWORK_EVT eEvent, void *pData);
static void EalTopCallbackFunc(uint32_t nInstNum, ADI_EAL_CBK_EVT eCbkEventType, const void *pArg);
static void EalRemoteNodeCbk(uint32_t nInstNum, uint32_t nRemoteNum, ADI_EAL_NODE_CBK_EVT eCbkEventType,
                             const void *pArg);
static void EalDiagCallback(uint32_t nInstNum, uint32_t nRemoteNum,
                            ADI_EAL_DIAG_CBK_EVT eCbkEventType, const void *pArg);
static void AppIseledCbk(uint32_t nInstNum, ADI_EAL_ISELED_HANDLE hIseledHandle, ADI_EAL_ISELED_CBK_EVT eIseledCbkEvent,
                         const void *pArg);

/*=================================== DATA ==================================*/
/* --------------------------- Application data ---------------------------- */
/*! MAC-PHY config */
ADI_MEM_DATA_CRIT_CACHE
static ADI_NETWORK_MACPHY_CFG goMacPhyCfg;

ADI_MEM_DATA_CRIT_CACHE
static APP_DATA goAppData;

/*! EAL  config */
ADI_MEM_DATA_CRIT_CACHE
static ADI_EAL_ISELED_CFG goIseledCfg;

ADI_MEM_DATA_CRIT_CACHE
static ADI_EAL_ISELED_HANDLE ghIseledHandle;

ADI_MEM_DATA_CRIT_CACHE
ADI_MEM_ALIGN4
static uint8_t ganIseledMemory[ISELED0_MEM_SIZE];

ADI_MEM_DATA_CRIT_CACHE
static ADI_EAL_DIAG_CFG goDiagCfg;

/* --------------------- The MAC address mapping table --------------------- */
ADI_MEM_DATA_CRIT_CACHE
static uint8_t ganRemoteMacAddrMap[NUM_REMOTE_NODES][6u];

/* Thread stack */
ADI_MEM_DATA_CRIT_CACHE
static uint8_t  ganInitThreadStack[9000];
ADI_MEM_DATA_CRIT_CACHE
static uint8_t  ganAppThreadStack[4500];
ADI_MEM_DATA_CRIT_CACHE
static uint8_t  ganHouseKeepingThreadStack[4500];

/* Task control blocks */
ADI_MEM_DATA_CRIT_CACHE
static uint8_t  ganInitThreadTcb[PRJ_OSAL_TCB_SIZE];
ADI_MEM_DATA_CRIT_CACHE
static uint8_t  ganAppThreadTcb[PRJ_OSAL_TCB_SIZE];
ADI_MEM_DATA_CRIT_CACHE
static uint8_t  ganHouseKeepingThreadTcb[PRJ_OSAL_TCB_SIZE];

/* Configurations for the threads */
ADI_MEM_DATA_CRIT_CACHE
static PRJ_OSAL_THREAD_CFG goInitThreadCfg;
ADI_MEM_DATA_CRIT_CACHE
static PRJ_OSAL_THREAD_CFG goAppThreadCfg;
ADI_MEM_DATA_CRIT_CACHE
static PRJ_OSAL_THREAD_CFG goHouseKeepingThreadCfg;

/* Thread handles */
ADI_MEM_DATA_CRIT_CACHE
static PRJ_OSAL_THREAD_HANDLE ghAppThread;
ADI_MEM_DATA_CRIT_CACHE
static PRJ_OSAL_THREAD_HANDLE ghHouseKeepingThread;

ADI_MEM_DATA_CRIT_CACHE
uint8_t ganColours[3u][3u] =
{
    {100u, 0u, 0u,},
    {0u, 100u, 0u},
    {0u, 0u, 100u},
};

ADI_MEM_DATA_CRIT_CACHE
ADI_E2BCORE_ISELED_FAST_TXN_PAYLOAD gaoFastModeData[] =
{
    {
        .pData         = &ganColours[0u][0u],
        .nAddress      = 0x00u,
        .nInstruction  = 0x04u,
    },
};

/*=================================== CODE ==================================*/
/**
 * @brief The application main entry point
 */
ADI_MEM_CODE_NOCRIT
int main(void)
{
#ifdef __NUCLEO_STM32__
    /* Initialize the platform abstraction layer */
    adi_pal_init();
#endif /* !__NUCLEO_STM32__ */
    PRJ_OSAL_THREAD_HANDLE hInitThread;

    goInitThreadCfg.bIsOneShot = true;
    goInitThreadCfg.nPriority = PRJ_OSAL_THREAD_MAX_PRIORITY;
    goInitThreadCfg.nStackSize  = sizeof(ganInitThreadStack);
    goInitThreadCfg.pStackMem  = (void *)&ganInitThreadStack;
    goInitThreadCfg.nTaskControlBlockSize  =  sizeof(ganInitThreadTcb);
    goInitThreadCfg.pTaskControlBlockMem  = (void *)&ganInitThreadTcb;
    goInitThreadCfg.pArgument  = NULL;
    goInitThreadCfg.pfThread  = InitThread;

    prj_osal_createThread(&goInitThreadCfg, &hInitThread);

    /* Start the scheduler. */
    prj_osal_startScheduler();

    /* Shouldn't reach here!! */
    ADI_DBG_ERROR();

    return 0;

}

/*=================================== STATIC ==================================*/
/**
 * @brief     Function for Init thread
 *
 * @param [in] arg Pointer for arguments
 */
ADI_MEM_CODE_CRIT
static void InitThread(void *pArg)
{
    /* Initializes the network and configures MACPHY */
    InitSystem();

    /* Initializes E2b stack and configures the network */
    CreateE2bApp();

    /* Create application threads */
    CreateThreads();
}

/** @brief Performs all the system initializations */
ADI_MEM_CODE_CRIT
static void InitSystem(void)
{
    uint32_t *pnNumDevices = NULL;
    ADI_NETWORK_DEVINFO *paoNetworkDevInfo = NULL;
    ADI_E2BCORE_VERSION oStackVersion;
    ADI_E2BCORE_BUILD_INFO oBuildInfo;

    /* Initialize the application data */
    (void) ADI_MEMSET(&goAppData, 0, sizeof(APP_DATA));

#ifndef __NUCLEO_STM32__
    /* Initialize the platform abstraction layer */
    adi_pal_init();
#endif /* __NUCLEO_STM32__ */

    /* Initialize the application utils layer */
    app_utils_init();

#if defined(__EV_SC594_SOM__)
    adi_pal_platformLedSet(SOM_SC594_LED2, true);
#endif

    /* Setup the console or terminal settings */
    app_utils_setupConsole();

    ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT,
                "\r\n===========================================================================\r\n");
    ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT,
                "                            Example - ISELED\r\n\r\n");
    ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT,
                "- Periodically updates the ISELED LEDs.\r\n");
    ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT,
                "- Interfaces used: ISELED.\r\n");
    ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT,
                "===========================================================================\r\n");

    /* Read library info */
    adi_e2bcore_getBuildInfo(&oBuildInfo);
    adi_e2bcore_getVersion(&oStackVersion);

    /* Print library and application info */
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "App build time   : %s %s\r\n", __DATE__, __TIME__);
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "E2blib build time: %s\r\n", oBuildInfo.sBuildTime);
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "E2B Stack version: "UINT32_FORMATTER"."UINT32_FORMATTER"."UINT32_FORMATTER"\r\n\r\n",
                oStackVersion.nMajorVersion, oStackVersion.nMinorVersion, oStackVersion.nPatchVersion);

    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Host name: %s \r\n", HOST_NAME_STR);
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Os type: %s \r\n", OS_TYPE);
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Initialization sequence started\r\n");
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Platform Abstraction Layer initialized\r\n");

    /* Initialize the network layer */
    adi_network_init();
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Network layer initialized\r\n");

    adi_network_registerCallback(&adi_network_cbk);

    /* Get the list of devices attached to the controller */
    adi_network_getDevices(&pnNumDevices, &paoNetworkDevInfo);
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Got the list of network devices\r\n");

    for(uint32_t i = 0u; i < *pnNumDevices; i++)
    {
        ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "\tId: "UINT32_FORMATTER", Desc: %s\r\n", paoNetworkDevInfo[i].nId,
                    paoNetworkDevInfo[i].sDesc);
    }

    /* Set the controller's MAC address */
    adi_network_setControllerMacAddr(oEth10BaseT1sNtwrkCfg.anMacAddr);

    /* Open the chosen device from the above list.
    The ADI_NETWORK_DEV_IDX macro should be changed depending on the devices connected */
    (void)ADI_MEMSET(&goMacPhyCfg, 0, sizeof(ADI_NETWORK_MACPHY_CFG));
    goMacPhyCfg.nSpiFreq    = 15000000U;
    goMacPhyCfg.nClkPha     = 0U;
    goMacPhyCfg.nClkPol     = 0U;
    goMacPhyCfg.eCPS        = ADI_NETWORK_CPS_32BYTES;
    goMacPhyCfg.bFTSE       = false;
    goMacPhyCfg.bRXCTE      = false;
    goMacPhyCfg.bTXCTE      = false;
    goMacPhyCfg.bGPTPCntrEn = false;
    goMacPhyCfg.bMacTimer   = false;
    goMacPhyCfg.bEnableRxBufferOverflowInt = true;
    goMacPhyCfg.bEnableSqiInt = false;
    goMacPhyCfg.bEnableSscInt = false;
    goMacPhyCfg.bEnableWkSlp = false;

    /* Open the chosen device from the above list.
       The ADI_NETWORK_DEV_IDX macro should be changed
       depending on the devices connected */
    adi_network_openDevice(ADI_NETWORK_DEV_IDX, &goMacPhyCfg);
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Opened the network device: Id: "UINT32_FORMATTER", Desc: %s\r\n",
                paoNetworkDevInfo[ADI_NETWORK_DEV_IDX].nId,
                paoNetworkDevInfo[ADI_NETWORK_DEV_IDX].sDesc);

#ifdef SNIFFER_MODE_EN
    adi_network_openDevice(ADI_NETWORK_ETH_IDX, &goMacPhyCfg);
    ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Opened the sniffer device: Id: "UINT32_FORMATTER", Desc: %s\r\n",
                paoNetworkDevInfo[ADI_NETWORK_ETH_IDX].nId,
                paoNetworkDevInfo[ADI_NETWORK_ETH_IDX].sDesc);
    ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "Waiting for PHY link-up...\r\n");
    adi_pal_waitMicroSec(5ULL * SEC_TO_US);
#endif

#if defined(__EV_SC594_SOM__)
    adi_pal_platformLedSet(SOM_SC594_LED5, true);
#endif
}

/** @brief Initialize E2B stack as required by application */
ADI_MEM_CODE_CRIT
static void CreateE2bApp(void)
{
    ADI_EAL_STATUS eEalStatus;

    /* Save the MAC addresses */
    app_utils_mac64To8(&ganRemoteMacAddrMap[APP_REMOTE_1][0u], REMOTE1_MAC_ADDR);

    /* Initialize EAL */
    adi_eal_init();

    /* Create an instance of EAL mapping instance number with the device index */
    adi_eal_createInstance(0U, ADI_NETWORK_DEV_IDX, &oEth10BaseT1sNtwrkCfg);

#ifdef SNIFFER_MODE_EN
    /* Enable frame duplication */
    adi_eal_setFrameDuplication(0U,  true);
#endif

    /* Register for EAL module callback */
    adi_eal_registerCallback(0U, &EalTopCallbackFunc);

    /* Register for node callbacks */
    adi_eal_registerNodeCallback(0U, &EalRemoteNodeCbk);

    /* Simulate switch booting up first with (NUM_REMOTE_NODES + 1) PlcaNodeCnt */
    adi_network_setPlca(ADI_NETWORK_DEV_IDX, true, NUM_REMOTE_NODES + 1U, CTRL_PLCA_ID);
    adi_network_flushTxBuffer(ADI_NETWORK_DEV_IDX, 0ull);

    /* Do a LV die reset */
    eEalStatus = adi_eal_resetRemoteLvDie(0U, ADI_EAL_ALL_REMOTES);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to reset remote nodes' LV die");
    adi_network_flushTxTimed(ADI_EAL_LV_RESET_WAIT_TIME_NS);

    /* Set the input enable for the SA_IF pins */
    eEalStatus = adi_eal_setInputEnable(0U, ADI_EAL_ALL_REMOTES, 0xFFFU);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed set the input enable for the SA_IF pins");
    adi_network_flushTxBuffer(ADI_NETWORK_DEV_IDX, 0ULL);

    /* Set bit to sample MAC address LSBs */
    eEalStatus = adi_eal_setMacAddrSampling(0U, ADI_EAL_ALL_REMOTES, true);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Setting bit to sample mac address failed");
    adi_network_flushTxBuffer(ADI_NETWORK_DEV_IDX, 0ULL);

    /* Set the PLCA ID for remote 1 */
    ADI_EAL_NODE_PLCA_ID_CFG oRemoteNode1PlcaIdCfg;
    ADI_MEMSET(&oRemoteNode1PlcaIdCfg, 0, sizeof(ADI_EAL_NODE_PLCA_ID_CFG));
    oRemoteNode1PlcaIdCfg.nMaskOfPlcaIdsUsed = 0x01U;
    oRemoteNode1PlcaIdCfg.anPlcaID[0U] = 1U;
    eEalStatus = adi_eal_setRemotePlcaId(0U, &ganRemoteMacAddrMap[APP_REMOTE_1][0u], &oRemoteNode1PlcaIdCfg,
                                         oEth10BaseT1sNtwrkCfg.aoRemoteCfgs[APP_REMOTE_1].nNodeRegVlanTag);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to set PLCA ID of remote node 1");
    adi_network_flushTxBuffer(ADI_NETWORK_DEV_IDX, 0ULL);

    /* Enable PLCA for the remote node */
    eEalStatus = adi_eal_setPlcaEn(0U, ADI_EAL_ALL_REMOTES, true);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to enable PLCA");
    adi_network_flushTxBuffer(ADI_NETWORK_DEV_IDX, 0ULL);

    /* Perform the discovery and register the MAC address of each remote */
    eEalStatus = adi_eal_startDiscoverySeq(0U);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Disc sequence start failed");
    // Wait for discovery to finish
    adi_network_flushTxTimed(ADI_EAL_DISC_TIMEOUT_NS);
    // Stop the discovery sequence
    eEalStatus = adi_eal_stopDiscoverySeq(0U);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Disc sequence failed");
    ADI_DBG_ENSURE(goAppData.nMacCnt == NUM_REMOTE_NODES, "Failed to discover required remote nodes");

    /* Clear MAC addr sampling from SA_IF pins */
    eEalStatus = adi_eal_setMacAddrSampling(0U, ADI_EAL_ALL_REMOTES, false);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to clear sample MAC address bit");

    /* Read the revision number of the remotes */
    eEalStatus = adi_eal_getRevision(0U, ADI_EAL_ALL_REMOTES);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to read revision number");
    adi_network_flushTxTimed(10ULL * MS_TO_NS);

    /* Configure the network */
    eEalStatus = adi_eal_configureNetwork(0U);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to configure network");

    /* Initialize EAL Diag module */
    goDiagCfg.pfDiagCallback = &EalDiagCallback;
    eEalStatus = adi_eal_diagInit(0U, &goDiagCfg);
    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to initialize Diag module");

    /******  Create EAL interfaces ******/
    /* Remote-1: ISELED interface */
    goIseledCfg.nInstNum = 0U;
    goIseledCfg.nRemoteNum = 0U;
    goIseledCfg.nIntfNum = 0U;
    goIseledCfg.nIseledCfgQDepth = 20U;
    goIseledCfg.pEalIseledMemory = &ganIseledMemory[0U];
    goIseledCfg.nEalIseledMemorySize = ISELED0_MEM_SIZE;
    ADI_ASSERT_BUFFER_ALIGNED_4(goIseledCfg.pEalIseledMemory);
    eEalStatus = adi_eal_iseledOpen(&goIseledCfg, &ghIseledHandle);
    ADI_DBG_REQUIRE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to open an ISELED instance");

    /* Register for ISELED callback */
    eEalStatus = adi_eal_iseledRegisterCallback(ghIseledHandle, &AppIseledCbk);
    ADI_DBG_REQUIRE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to register callback");

    /* Initialize ISELED driver */
    IseledInitDrv(APP_REMOTE_1, ghIseledHandle);

    /* Reset the ISELED strip */
    IseledResetStrip(APP_REMOTE_1);
    adi_network_flushTxBuffer(ADI_NETWORK_DEV_IDX, 0ull);
    adi_network_flushTxTimed(100ull * MS_TO_NS);

    /* Initialize the ISELED strip */
    IseledInitStrip(APP_REMOTE_1);
    adi_network_flushTxBuffer(ADI_NETWORK_DEV_IDX, 0ull);
    adi_network_flushTxTimed(100ull * MS_TO_NS);

#if defined(__EV_SC594_SOM__)
    adi_pal_platformLedSet(SOM_SC594_LED4, true);
#endif
}

/**
 * @brief Create threads for application and housekeeping tasks
 *
 */
ADI_MEM_CODE_CRIT
static void CreateThreads(void)
{

    PrintHelpContents();

    ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "\r\n\r\nSwitching to run mode\r\n");

    goAppData.eAppMode = APP_MODE_RUN;

    goAppThreadCfg.bIsOneShot = false;
    goAppThreadCfg.nPriority = 2;
    goAppThreadCfg.nStackSize = sizeof(ganAppThreadStack);
    goAppThreadCfg.pStackMem = (void *)&ganAppThreadStack;
    goAppThreadCfg.nTaskControlBlockSize = sizeof(ganAppThreadTcb);
    goAppThreadCfg.pTaskControlBlockMem = (void *)&ganAppThreadTcb;
    goAppThreadCfg.pArgument = NULL;
    goAppThreadCfg.pfThread = AppThread1Fxn;

    goHouseKeepingThreadCfg.bIsOneShot = false;
    goHouseKeepingThreadCfg.nPriority = 1;
    goHouseKeepingThreadCfg.nStackSize = sizeof(ganHouseKeepingThreadStack);
    goHouseKeepingThreadCfg.pStackMem = (void *)&ganHouseKeepingThreadStack;
    goHouseKeepingThreadCfg.nTaskControlBlockSize = sizeof(ganHouseKeepingThreadTcb);
    goHouseKeepingThreadCfg.pTaskControlBlockMem = (void *)&ganHouseKeepingThreadTcb;
    goHouseKeepingThreadCfg.pArgument = NULL;
    goHouseKeepingThreadCfg.pfThread = HouseKeepingFxn;

    prj_osal_createThread(&goAppThreadCfg, &ghAppThread);
    prj_osal_createThread(&goHouseKeepingThreadCfg, &ghHouseKeepingThread);
}

/**
 * @brief      Application thread function
 *
 * @param [in] arg Pointer for arguments
 */
ADI_MEM_CODE_CRIT
static void AppThread1Fxn(void *pArg)
{
    ADI_EAL_STATUS eEalStatus;
    static uint8_t temp = 0u;

    if(goAppData.eAppMode == APP_MODE_RUN)
    {
        gaoFastModeData[0U].pData = &ganColours[temp][0U];
        eEalStatus = IseledSetRgb(APP_REMOTE_1, ADI_EAL_ISELED_NORMAL_MODE, gaoFastModeData, 0x01u, 0xFFu, 0x00u);
        ADI_DBG_REQUIRE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to set register in run app\n");
        temp = (temp + 1u) % 3u;
    }

    prj_osal_sleepThread(ghAppThread, 100U);
}

/**
 * @brief      Function for housekeeping tasks
 *
 * @param [in] arg Pointer for arguments
 */
ADI_MEM_CODE_CRIT
static void HouseKeepingFxn(void *pArg)
{
    /* Function that sends out the frames, clearing the buffer.
         This must be periodically called to actually send out the frames */

    adi_network_run();

    /* See if there is some console data to be sent or processed */
    ConsoleRun();

    /* Sleep for 1 ms */
    prj_osal_sleepThread(ghHouseKeepingThread, 1U);
}

/** @brief Print the list of Supported application commands */
ADI_MEM_CODE_CRIT
static void PrintHelpContents(void)
{
#ifndef USE_CLI
    app_utils_printHelpContents();
#endif
}

/** @brief  Function for handling application console commands */
ADI_MEM_CODE_CRIT
static void ConsoleRun(void)
{
    bool bCmdProcessed = app_utils_consoleRun(ADI_NETWORK_DEV_IDX, &goAppData.eAppCmd, &goAppData.eAppMode);

    if(!bCmdProcessed)
    {
        if(goAppData.eAppCmd == APP_CMD_INTF_STAT)
        {
            ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "\r\n");
            ADI_PAL_LOG(ADI_CONSOLE_PROMPT, " ");
            adi_eal_iseledReadStatus(ghIseledHandle);
        }
    }

    goAppData.eAppCmd = APP_CMD_NONE;
}

/*================================= CALLBACKS =================================*/
/**
 * @brief Callback from the network layer
 *
 * @param nDevNum The device number for which this callback is for
 * @param eEvent The type of event this callback is for
 * @param pData The data corresponding to this event
 */
ADI_MEM_CODE_CRIT
static void adi_network_cbk(uint32_t nDevNum, ADI_NETWORK_EVT eEvent, void *pData)
{
    /* ---------------- Code ---------------- */
    /* Handle the different cases of callback events */
    switch(eEvent)
    {
        case ADI_NETWORK_EVT_ETH10_RX_RECEIVED:
        {
            /* When a frame is received, network callback is called with this event */
            /* Get the RX frame data */
            ADI_NETWORK_EVT_ETH10_RX_RECEIVED_DATA *poRxEth10Dat = (ADI_NETWORK_EVT_ETH10_RX_RECEIVED_DATA *)pData;
            uint16_t nEthType = (uint16_t)poRxEth10Dat->pRxData[12u] << 8u | poRxEth10Dat->pRxData[13u];

#ifdef SNIFFER_MODE_EN
            /* Send all the received frames (from T1S) to the Ethernet in sniffer mode */
            ADI_NETWORK_FRAME_CFG oNwFrameCfg;
            (void) ADI_MEMSET(&oNwFrameCfg, 0, sizeof(ADI_NETWORK_FRAME_CFG));

            // ~~~~~ Network frame configurations ~~~~~
            oNwFrameCfg.bDuplicate      = false;
            oNwFrameCfg.bLenInclMacHdr  = true;
            oNwFrameCfg.eMacRoutingInfo = ADI_MACPHY_ROUTE_PORT0_LP;
            oNwFrameCfg.eTsReg          = ADI_TS_EGRESS_NONE;
            oNwFrameCfg.nFrameType      = ADI_E2BCORE_ETYPE;
            oNwFrameCfg.nLenByte        = poRxEth10Dat->nLength;
            oNwFrameCfg.panPhysAddr     = NULL;

            uint8_t *pBuffer = NULL;

            /* Get a buffer from network layer */
            ADI_NETWORK_ERR eNwErr = adi_network_getTxBuffer(ADI_NETWORK_ETH_IDX, &pBuffer, &oNwFrameCfg);

            /* Check if buffer is available */
            if(eNwErr == ADI_NETWORK_OK)
            {
                /* Copy the frame data */
                ADI_MEMCPY(pBuffer, poRxEth10Dat->pRxData, poRxEth10Dat->nLength);

                /* Transmit the Ethernet frame */
                adi_network_transmit(ADI_NETWORK_ETH_IDX, &oNwFrameCfg);
            }

#endif

            if(nEthType == ADI_E2BCORE_ETYPE)
            {
                /* Call the e2bcore layer to process this frame and give appropriate
                   callbacks with the messages and transactions */
                adi_e2bcore_processFrame(0u, poRxEth10Dat->pRxData, (uint32_t)poRxEth10Dat->nLength);
            }


            break;
        }

        case ADI_NETWORK_EVT_MAC_STATUS:
        {
            /* Stats data */
            ADI_NETWORK_EVT_MAC_STATUS_DATA *poStatsDat = (ADI_NETWORK_EVT_MAC_STATUS_DATA *)pData;
            app_utils_logCtrlMacStatus(poStatsDat);
            break;
        }

        case ADI_NETWORK_EVT_PHY_STATUS:
        {
            ADI_NETWORK_EVT_PHY_STATUS_DATA *poStatsDat = (ADI_NETWORK_EVT_PHY_STATUS_DATA *)pData;
            app_utils_logCtrlPhyStatus(poStatsDat);
            break;
        }

        case ADI_NETWORK_EVT_PLCA_STATUS:
        {
            ADI_NETWORK_EVT_PLCA_STATUS_DATA *poStatusDat = (ADI_NETWORK_EVT_PLCA_STATUS_DATA *)pData;
            app_utils_logCtrlPlcaStatus(poStatusDat);
            break;
        }

        case ADI_NETWORK_EVT_PTP_STATUS:
        {
            ADI_NETWORK_EVT_PTP_STATUS_DATA *poStatusDat = (ADI_NETWORK_EVT_PTP_STATUS_DATA *)pData;
            app_utils_logCtrlPtpStatus(poStatusDat);
            break;
        }

        case ADI_NETWORK_EVT_PCS_STATUS:
        {
            ADI_NETWORK_EVT_PCS_STATUS_DATA *poStatusDat = (ADI_NETWORK_EVT_PCS_STATUS_DATA *)pData;
            app_utils_logCtrlPcsStatus(poStatusDat);
            break;
        }

        case ADI_NETWORK_EVT_ERR:
        {
            /* Error event in the network */
            ADI_NETWORK_EVT_ERR_DATA *poNwErrDat = (ADI_NETWORK_EVT_ERR_DATA *)pData;
            /* ------------------------------------------------------------ */
            ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Network error: %d\r\n", poNwErrDat->eErrType);

            /* ------------------------------------------------------------ */
            ADI_DBG_ERROR();
            break;
        }

        case ADI_NETWORK_EVT_READ_REG:
        {
            ADI_NETWORK_EVT_READ_REG_DATA *poRegDat = (ADI_NETWORK_EVT_READ_REG_DATA *)pData;
            app_utils_logCtrlRegRead(poRegDat);
            break;
        }

        default:
        {
            /* Nothing to do */
            break;
        }
    }
}

/** EAL Top level callback */
ADI_MEM_CODE_CRIT
static void EalTopCallbackFunc(uint32_t nInstNum, ADI_EAL_CBK_EVT eCbkEventType, const void *pArg)
{
    ADI_EAL_STATUS eEalStatus;

    switch(eCbkEventType)
    {
        case ADI_EAL_CBK_EVT_ERR:
        {
            ADI_DBG_ERROR();
            break;
        }

        case ADI_EAL_CBK_EVT_MAC_ADDR_RCVD:
        {
            ADI_EAL_CBK_EVT_MAC_ADDR_RCVD_DATA panMacAddr = (ADI_EAL_CBK_EVT_MAC_ADDR_RCVD_DATA)pArg;

            // Check the MAC address from some mapping
            for(uint32_t i = 0U; i < NUM_REMOTE_NODES; i++)
            {
                if(ADI_MEMCMP(panMacAddr, ganRemoteMacAddrMap[i], 6U) == 0)
                {
                    eEalStatus = adi_eal_writeMacAddr(nInstNum, i, panMacAddr);
                    ADI_DBG_ENSURE(eEalStatus == ADI_EAL_STATUS_SUCCESS, "Failed to update the MAC address");
                    goAppData.nMacCnt++;

                    break;
                }
            }

            break;
        }
    }
}

/** EAL Node level callback */
ADI_MEM_CODE_CRIT
static void EalRemoteNodeCbk(uint32_t nInstNum, uint32_t nRemoteNum,
                             ADI_EAL_NODE_CBK_EVT eCbkEventType, const void *pArg)
{
    switch(eCbkEventType)
    {
        case ADI_EAL_NODE_CBK_EVT_PING_RCVD:
        {
            app_utils_logPingRcvd(nRemoteNum);
            break;
        }

        case ADI_EAL_NODE_CBK_EVT_ERR:
        {
            ADI_DBG_ERROR();
            break;
        }

        case ADI_EAL_NODE_CBK_EVT_REG_READ_RESP:
        {
            break;
        }

        case ADI_EAL_NODE_CBK_EVT_REVNUM_RCVD:
        {
            ADI_EAL_NODE_REV_NUM *poEalRevNum = (ADI_EAL_NODE_REV_NUM *)pArg;
            ADI_PAL_LOG(ADI_CONSOLE_PROMPT, "Remote" UINT32_FORMATTER "  Major Revision Number: 0x" UINT32_HEX_FORMATTER
                        ", Minor Revision Number: 0x" UINT32_HEX_FORMATTER "\r\n",
                        nRemoteNum + 1U, poEalRevNum->nMajorRevNum, poEalRevNum->nMinorRevNum);
            break;
        }

        default:
        {
            ADI_DBG_ERROR();
            break;
        }
    }
}

/** EAL diag callback */
ADI_MEM_CODE_CRIT
static void EalDiagCallback(uint32_t nInstNum, uint32_t nRemoteNum, ADI_EAL_DIAG_CBK_EVT eCbkEventType,
                            const void *pArg)
{
    switch(eCbkEventType)
    {
        case ADI_EAL_DIAG_CBK_EVT_MAC_STATUS:
        {
            ADI_EAL_DIAG_CBK_EVT_MAC_STATUS_DATA *poStatusData = (ADI_EAL_DIAG_CBK_EVT_MAC_STATUS_DATA *)pArg;
            app_utils_logRemoteMacStatus(poStatusData, nRemoteNum);
            break;
        }

        case ADI_EAL_DIAG_CBK_EVT_PLCA_STATUS:
        {
            ADI_EAL_DIAG_CBK_EVT_PLCA_STATUS_DATA *poStatusData = (ADI_EAL_DIAG_CBK_EVT_PLCA_STATUS_DATA *)pArg;
            app_utils_logRemotePlcaStatus(poStatusData, nRemoteNum);
            break;
        }

        case ADI_EAL_DIAG_CBK_EVT_PHY_STATUS:
        {
            ADI_EAL_DIAG_CBK_EVT_PHY_STATUS_DATA *poStatusDat = (ADI_EAL_DIAG_CBK_EVT_PHY_STATUS_DATA *)pArg;
            app_utils_logRemotePhyStatus(poStatusDat, nRemoteNum);
            break;
        }

        case ADI_EAL_DIAG_CBK_EVT_PCS_STATUS:
        {
            ADI_EAL_DIAG_CBK_EVT_PCS_STATUS_DATA *poStatusDat = (ADI_EAL_DIAG_CBK_EVT_PCS_STATUS_DATA *)pArg;
            app_utils_logRemotePcsStatus(poStatusDat, nRemoteNum);
            break;
        }

        case ADI_EAL_DIAG_CBK_EVT_PTP_STATUS:
        {
            ADI_EAL_DIAG_CBK_EVT_PTP_STATUS_DATA *poStatusData = (ADI_EAL_DIAG_CBK_EVT_PTP_STATUS_DATA *)pArg;
            app_utils_logRemotePtpStatus(poStatusData, nRemoteNum);
            break;
        }

        default:
        {
            break;
        }
    }
}

/** EAL ISELED interface callback */
ADI_MEM_CODE_NOCRIT
static void AppIseledCbk(uint32_t nInstNum, ADI_EAL_ISELED_HANDLE hIseledHandle, ADI_EAL_ISELED_CBK_EVT eIseledCbkEvent,
                         const void *pArg)
{
    ADI_DBG_REQUIRE(hIseledHandle != NULL, "ISELED handle is null");

    switch(eIseledCbkEvent)
    {
        case ADI_EAL_ISELED_CBK_EVT_ISELED_READ_RESP:
        {
            ADI_DBG_REQUIRE(pArg != NULL, "Pointer to argument is null");
            EAL_ISELED_DATA *poEalIseledData = (EAL_ISELED_DATA *)hIseledHandle;
            ADI_EAL_ISELED_CBK_EVT_ISELED_READ_RESP_DATA *oIseledCfg = (ADI_EAL_ISELED_CBK_EVT_ISELED_READ_RESP_DATA *)pArg;
            ADI_E2BCORE_ISELED_FAST_TXN_PAYLOAD *oRxData = (ADI_E2BCORE_ISELED_FAST_TXN_PAYLOAD *)oIseledCfg->pPayload;

            ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "ISELED write (ID = 0x%02X)\r\n", oIseledCfg->oTxnHdr.nE2bId);

            if(oIseledCfg->oTxnHdr.bSetExpectedNumResp)
            {
                uint16_t nExpectedNumResp = oIseledCfg->oTxnHdr.nExpectedNumResp;
                ADI_PAL_LOG(ADI_CONSOLE_PROMPT, " Address \t Instruction \t Data \r\n");

                for(uint8_t nLC = 0; nLC < nExpectedNumResp; nLC++)
                {
                    ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "\t0x%02x\t 0x%02x\t\t 0x%02x 0x%02x 0x%02x\r\n", oRxData[nLC].nAddress,
                                oRxData[nLC].nInstruction, oRxData[nLC].pData[0u], oRxData[nLC].pData[1u], oRxData[nLC].nCrc);
                }
            }

            app_utils_addLineSeparator(true);

            break;
        }

        case ADI_EAL_ISELED_CBK_EVT_ISELED_WRITE_RESP:
        {
            ADI_DBG_REQUIRE(pArg != NULL, "Pointer to argument is null");
            EAL_ISELED_DATA *poEalIseledData = (EAL_ISELED_DATA *)hIseledHandle;
            ADI_EAL_ISELED_CBK_EVT_ISELED_WRITE_RESP_DATA *oIseledCfg = (ADI_EAL_ISELED_CBK_EVT_ISELED_WRITE_RESP_DATA *)pArg;
            ADI_E2BCORE_ISELED_FAST_TXN_PAYLOAD *oRxData = (ADI_E2BCORE_ISELED_FAST_TXN_PAYLOAD *)oIseledCfg->pPayload;

            ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "ISELED write Response (ID = 0x%02X)\r\n", oIseledCfg->oTxnHdr.nE2bId);
            break;
        }

        case ADI_EAL_ISELED_CBK_EVT_INTF_STATUS_EVT:
        {
            EAL_ISELED_DATA *poEalIseledData = (EAL_ISELED_DATA *)hIseledHandle;
            EAL_ISELED_INST_DATA *poEalIseledInstData = poEalIseledData->apoInstData[0U];
            ADI_EAL_ISELED_CBK_EVT_INTF_STATUS_EVT_DATA *poStatsDat = (ADI_EAL_ISELED_CBK_EVT_INTF_STATUS_EVT_DATA *)pArg;
            ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "Status read of ISELED" UINT32_FORMATTER " on Remote" UINT32_FORMATTER "\r\n",
                        poEalIseledInstData->oId.nIntfNum,
                        poEalIseledInstData->oId.nRemoteNum + 1U);
            adi_eal_diagLogIseledStatus(poStatsDat);
            app_utils_addLineSeparator(true);
            break;
        }

        case ADI_EAL_ISELED_CBK_EVT_FIFO_STATUS_EVT:
        {
            EAL_ISELED_DATA *poEalIseledData = (EAL_ISELED_DATA *)hIseledHandle;
            EAL_ISELED_INST_DATA *poEalIseledInstData = poEalIseledData->apoInstData[0U];
            ADI_EAL_ISELED_CBK_EVT_FIFO_STATUS_EVT_DATA *poStatsDat = (ADI_EAL_ISELED_CBK_EVT_FIFO_STATUS_EVT_DATA *)pArg;
            ADI_PAL_LOG(ADI_CONSOLE_NO_PROMPT, "FIFO stats of ISELED" UINT32_FORMATTER " on Remote" UINT32_FORMATTER "\r\n",
                        poEalIseledInstData->oId.nIntfNum,
                        poEalIseledInstData->oId.nRemoteNum + 1U);
            adi_eal_diagLogFifoStatus(poStatsDat);
            app_utils_addLineSeparator(true);
            break;
        }

        case ADI_EAL_ISELED_CBK_EVT_REG_READ_RESP:
        {
            break;
        }

        case ADI_EAL_ISELED_CBK_EVT_MAILBOX_ACK:
        {
            ADI_DBG_REQUIRE(pArg != NULL, "Pointer to argument is null");
            break;
        }

        default:
        {
            ADI_DBG_ERROR();
            break;
        }
    }

}

/** RX command callback */
ADI_MEM_CODE_CRIT
void app_utils_rxCmdCbk(uint8_t *anRxData, uint32_t nLength)
{
    bool bCmdProcessed = app_utils_parseRxCommand(anRxData, nLength, &goAppData.eAppCmd, &goAppData.eAppMode);

    if(!bCmdProcessed)
    {
        goAppData.eAppCmd = APP_CMD_INVALID;
    }
}

/** PAL Callback */
ADI_MEM_CODE_CRIT
void adi_pal_appCbk(uint32_t nId, ADI_PAL_APP_EVT eEvent, const void *pData)
{
    switch(eEvent)
    {
        case ADI_PAL_EVT_FATAL_ERR:
        {
            // TODO: Switch to error state and do some error handling
            adi_pal_fatalError();
            break;
        }

        case ADI_PAL_EVT_CLI_TX:
        {
            const ADI_PAL_EVT_CLI_TXDATA *poTxData = (const ADI_PAL_EVT_CLI_TXDATA *)pData;
            app_utils_log(poTxData->pTxData, poTxData->nLength);
            break;
        }

        case ADI_PAL_EVT_CLI_RX:
        {
            const uint8_t *pnRxByte = (const uint8_t *)pData;
            app_utils_processRxByte(*pnRxByte);
            break;
        }

        default:
        {
            break;
        }
    }
}

/** @} */

/**
 * EOF: https://www.analog.com/
 */

