/*****************************************************************************
Copyright (c) 2026 - Analog Devices Inc. All Rights Reserved.
This software is proprietary & confidential to Analog Devices, Inc.
and its licensors.
*******************************************************************************
 * @file         : adi_Eth10BaseT1s_cfg.h
 * @brief        : This header file is auto generated from
                   EdgeStudio v4.0.0 - ex_iseled.e2bprj project
 * @author       : Automotive Software and Systems team, Bangalore, India
 * @date         : Mon Apr 27 2026 23:01:53 GMT+0530 (India Standard Time)
******************************************************************************/

/* =========================================================================
   |                   SELECTIVE INTERFACE DEFINES                         |
   ========================================================================= */
#ifndef ADI_E2B_IFACE_ISELED_ENABLED
#define ADI_E2B_IFACE_ISELED_ENABLED
#endif
#ifndef ADI_E2B_IFACE_SMC_ENABLED
#define ADI_E2B_IFACE_SMC_ENABLED
#endif
#ifndef ADI_E2B_IFACE_SQI_ENABLED
#define ADI_E2B_IFACE_SQI_ENABLED
#endif
#ifndef ADI_E2B_IFACE_SSC_ENABLED
#define ADI_E2B_IFACE_SSC_ENABLED
#endif
#ifndef ADI_E2B_IFACE_TOPDISC_ENABLED
#define ADI_E2B_IFACE_TOPDISC_ENABLED
#endif
#ifndef ADI_E2B_IFACE_WKSLP_ENABLED
#define ADI_E2B_IFACE_WKSLP_ENABLED
#endif
#ifndef ADI_E2B_IFACE_DIAG_ENABLED
#define ADI_E2B_IFACE_DIAG_ENABLED
#endif

/* =========================================================================
   |                               INCLUDES                                |
   ========================================================================= */
#include "adi_e2bcore.h"                     /*!< E2BCore header */
#include "adi_maclce_reg.h"                  /*!< MACLCE header */

/* =========================================================================
   |                                DEFINES                                |
   ========================================================================= */
#define CONTROLLER1_MAC_ADDR (0x00e022fe70f0ULL)
#define REMOTE1_MAC_ADDR (0x00e022fe7001ULL)
#define REMOTE1_MULTIMAC_ADDR (0x01e022fe7000ULL)

#define GET_ID(InstNum, RemoteNum, IntfNum) \
{ \
    .nInstNum   = InstNum,    \
    .nRemoteNum = RemoteNum,  \
    .nIntfNum   = IntfNum     \
}

#define MAC_64_TO_8(nMacAddr) \
{\
    (nMacAddr & 0xFF0000000000ULL) >> 40U, \
    (nMacAddr & 0x00FF00000000ULL) >> 32U, \
    (nMacAddr & 0x0000FF000000ULL) >> 24U, \
    (nMacAddr & 0x000000FF0000ULL) >> 16U, \
    (nMacAddr & 0x00000000FF00ULL) >> 8U,  \
    (nMacAddr & 0x0000000000FFULL) >> 0U   \
}

/* =========================================================================
   |                                DATA                                   |
   ========================================================================= */
extern ADI_E2BCORE_CFG oEth10BaseT1sNtwrkCfg;

/* =========================================================================
   |                          CALLBACK PROTOTYPES                          |
   ========================================================================= */

extern void Eth10BaseT1sCbk(const ADI_E2BCORE_ID *poID, ADI_E2BCORE_CBKTYPE eType, void *poParam, bool bIsTxFrame, void *pCbParam);
extern void RemoteNodeCbk(const ADI_E2BCORE_ID *poID, ADI_E2BCORE_CBKTYPE eType, void *poParam, bool bIsTxFrame, void *pCbParam);
extern void IseledInterfaceCbk(const ADI_E2BCORE_ID *poID, ADI_E2BCORE_CBKTYPE eType, void *poParam, bool bIsTxFrame, void *pCbParam);



/** @} */

/*
 * EOF: www.analog.com
*/
