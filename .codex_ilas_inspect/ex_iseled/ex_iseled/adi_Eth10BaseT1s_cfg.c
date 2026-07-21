/*****************************************************************************
Copyright (c) 2026 - Analog Devices Inc. All Rights Reserved.
This software is proprietary & confidential to Analog Devices, Inc.
and its licensors.
*******************************************************************************
 * @file         : adi_Eth10BaseT1s_cfg.c
 * @brief        : This configuration file is auto generated from
                   EdgeStudio v4.0.0 - ex_iseled.e2bprj project
 * @author       : Automotive Software and Systems team, Bangalore, India
 * @date         : Mon Apr 27 2026 23:01:53 GMT+0530 (India Standard Time)
******************************************************************************/

/* =========================================================================
   |                               INCLUDES                                |
   ========================================================================= */
#include "adi_Eth10BaseT1s_cfg.h"

/* =========================================================================
   |                                REGMAPS                                |
   ========================================================================= */
/* =========================== INTERFACE REGMAPS =========================== */
ADI_MEM_DATA_CRIT_CACHE
static ADI_E2BCORE_REG_ADDR_VAL aoRemote1Iseled1IfRegMap[] =
{
    /* 0x0000U : 0x00A20925U */
    {
        .nAddr = ISELED_CONTROL_NW_ADDR,
        .nVal  = (ISELED_CONTROL_RESET_VAL &
				 ~(BITM_ISELED_CONTROL_TRANSACTION_HEADER_ENABLE |
				 BITM_ISELED_CONTROL_ILAS_MODE |
				 BITM_ISELED_CONTROL_RESYNCHRONIZATION_REQUIRED |
				 BITM_ISELED_CONTROL_ENABLE_UPSTREAM_ECCO |
				 BITM_ISELED_CONTROL_ENABLE_READ_TIME_TAG_ECCO |
				 BITM_ISELED_CONTROL_ENABLE_READ_TIME_TAG |
				 BITM_ISELED_CONTROL_TRANSACTION_TRIGGER |
				 BITM_ISELED_CONTROL_TRIGGER_MODE |
				 BITM_ISELED_CONTROL_ISELED_ENABLE |
				 BITM_ISELED_CONTROL_CHANNEL_MODE |
				 BITM_ISELED_CONTROL_TX_FIFO_RESET |
				 BITM_ISELED_CONTROL_RX_FIFO_RESET |
				 BITM_ISELED_CONTROL_SOFT_RESET)) |
				 ((0x1U << BITP_ISELED_CONTROL_TRANSACTION_HEADER_ENABLE) |
				 (0x0U << BITP_ISELED_CONTROL_ILAS_MODE) |
				 (0x0U << BITP_ISELED_CONTROL_RESYNCHRONIZATION_REQUIRED) |
				 (0x1U << BITP_ISELED_CONTROL_ENABLE_UPSTREAM_ECCO) |
				 (0x0U << BITP_ISELED_CONTROL_ENABLE_READ_TIME_TAG_ECCO) |
				 (0x0U << BITP_ISELED_CONTROL_ENABLE_READ_TIME_TAG) |
				 (0x0U << BITP_ISELED_CONTROL_TRANSACTION_TRIGGER) |
				 (0x1U << BITP_ISELED_CONTROL_TRIGGER_MODE) |
				 (0x1U << BITP_ISELED_CONTROL_ISELED_ENABLE) |
				 (0x2U << BITP_ISELED_CONTROL_CHANNEL_MODE) |
				 (0x0U << BITP_ISELED_CONTROL_TX_FIFO_RESET) |
				 (0x0U << BITP_ISELED_CONTROL_RX_FIFO_RESET) |
				 (0x0U << BITP_ISELED_CONTROL_SOFT_RESET))
    },
    /* 0x0004U : 0x00C11F28U */
    {
        .nAddr = ISELED_INSTRUCTION_NW_ADDR,
        .nVal  = (ISELED_INSTRUCTION_RESET_VAL &
				 ~(BITM_ISELED_INSTRUCTION_DOWNSTREAM_PACKET_LENGTH)) |
				 ((0x28U << BITP_ISELED_INSTRUCTION_DOWNSTREAM_PACKET_LENGTH))
    },
    /* 0x0010U : 0x00000001U */
    {
        .nAddr = ISELED_TRANSACTION_HEADER_NW_ADDR,
        .nVal  = (ISELED_TRANSACTION_HEADER_RESET_VAL &
				 ~(BITM_ISELED_TRANSACTION_HEADER_NUM_PACKED_TRANSACTIONS)) |
				 ((0x1U << BITP_ISELED_TRANSACTION_HEADER_NUM_PACKED_TRANSACTIONS))
    },
};

/* ============================== FIFO REGMAPS ============================= */
ADI_MEM_DATA_CRIT_CACHE
static ADI_E2BCORE_REG_ADDR_VAL aoRemote1Iseled1FifoRegMap[] =
{
    /* 0x0000U : 0x0C008000U */
    {
        .nAddr = FIFO_CONTROL_NW_ADDR,
        .nVal  = (FIFO_CONTROL_RESET_VAL &
				 ~(BITM_FIFO_CONTROL_READ_MODE)) |
				 ((0x3U << BITP_FIFO_CONTROL_READ_MODE))
    },
    /* 0x0004U : 0x002BC001U */
    {
        .nAddr = FIFO_READ_BLOCK_SIZES_NW_ADDR,
        .nVal  = (FIFO_READ_BLOCK_SIZES_RESET_VAL &
				 ~(BITM_FIFO_READ_BLOCK_SIZES_READ_BLOCK_SIZE_INSTANTANEOUS |
				 BITM_FIFO_READ_BLOCK_SIZES_READ_BLOCK_SIZE)) |
				 ((0x1U << BITP_FIFO_READ_BLOCK_SIZES_READ_BLOCK_SIZE_INSTANTANEOUS) |
				 (0x578U << BITP_FIFO_READ_BLOCK_SIZES_READ_BLOCK_SIZE))
    },
    /* 0x0028U : 0x00001D4CU */
    {
        .nAddr = FIFO_READ_BLOCK_TIME_NW_ADDR,
        .nVal  = (FIFO_READ_BLOCK_TIME_RESET_VAL &
				 ~(BITM_FIFO_READ_BLOCK_TIME_READ_BLOCK_TIME_INSTANTANEOUS)) |
				 ((0x1d4cU << BITP_FIFO_READ_BLOCK_TIME_READ_BLOCK_TIME_INSTANTANEOUS))
    },
};

/* ============================= REMOTE REGMAPS ============================= */
ADI_MEM_DATA_CRIT_CACHE
static ADI_E2BCORE_REG_ADDR_VAL aoRemote1RegMap[] =
{
    /* 0x0024U : 0x22FE7001U */
    {
        .nAddr = LCE_DEVICE_MAC_ADDRESS_LOWER_NW_ADDR,
        .nVal  = (REMOTE1_MAC_ADDR & 0x0000FFFFFFFFull) << BITP_LCE_DEVICE_MAC_ADDRESS_LOWER_DEVICE_MAC_ADDRESS_LOWER
    },
    /* 0x0028U : 0x01E000E0U */
    {
        .nAddr = LCE_DEVICE_MULTICAST_ADDRESS_UPPER_NW_ADDR,
        .nVal  = (LCE_DEVICE_MULTICAST_ADDRESS_UPPER_RESET_VAL &
				 ~(BITM_LCE_DEVICE_MULTICAST_ADDRESS_UPPER_DEVICE_MAC_ADDRESS_UPPER |
				 BITM_LCE_DEVICE_MULTICAST_ADDRESS_UPPER_MULTICAST_MAC_ADDRESS_UPPER)) |
				 ((0xe0U << BITP_LCE_DEVICE_MULTICAST_ADDRESS_UPPER_DEVICE_MAC_ADDRESS_UPPER) |
				 (0x1e0U << BITP_LCE_DEVICE_MULTICAST_ADDRESS_UPPER_MULTICAST_MAC_ADDRESS_UPPER))
    },
    /* 0xD000U : 0x77777077U */
    {
        .nAddr = HOST_IF_TO_INTF_MUX_NW_ADDR,
        .nVal  = (HOST_IF_TO_INTF_MUX_RESET_VAL &
				 ~(BITM_HOST_IF_TO_INTF_MUX_TO_INTF_MUX_2)) |
				 ((0x0U << BITP_HOST_IF_TO_INTF_MUX_TO_INTF_MUX_2))
    },
    /* 0xD008U : 0x000FFFE2U */
    {
        .nAddr = HOST_IF_FROM_INT_MUX_NW_ADDR,
        .nVal  = (HOST_IF_FROM_INT_MUX_RESET_VAL &
				 ~(BITM_HOST_IF_FROM_INT_MUX_FROM_INTF_MUX_0)) |
				 ((0x2U << BITP_HOST_IF_FROM_INT_MUX_FROM_INTF_MUX_0))
    },
    /* 0xD014U : 0xFF43FFFFU */
    {
        .nAddr = HOST_IF_INPUT_SELECTOR2_NW_ADDR,
        .nVal  = (HOST_IF_INPUT_SELECTOR2_RESET_VAL &
				 ~(BITM_HOST_IF_INPUT_SELECTOR2_ISELED0_SIO_N_INPUT_SELECTOR |
				 BITM_HOST_IF_INPUT_SELECTOR2_ISELED0_SIO_P_INPUT_SELECTOR)) |
				 ((0x3U << BITP_HOST_IF_INPUT_SELECTOR2_ISELED0_SIO_N_INPUT_SELECTOR) |
				 (0x4U << BITP_HOST_IF_INPUT_SELECTOR2_ISELED0_SIO_P_INPUT_SELECTOR))
    },
    /* 0xD024U : 0x3F3F3F0CU */
    {
        .nAddr = HOST_IF_OUTPUT_SELECTOR1_NW_ADDR,
        .nVal  = (HOST_IF_OUTPUT_SELECTOR1_RESET_VAL &
				 ~(BITM_HOST_IF_OUTPUT_SELECTOR1_IO4_OUTPUT_SELECTOR)) |
				 ((0xcU << BITP_HOST_IF_OUTPUT_SELECTOR1_IO4_OUTPUT_SELECTOR))
    },
    /* 0xD02CU : 0x00000FFFU */
    {
        .nAddr = HOST_IF_SA_IF_BUS_CONFIGURATION_NW_ADDR,
        .nVal  = (HOST_IF_SA_IF_BUS_CONFIGURATION_RESET_VAL &
				 ~(BITM_HOST_IF_SA_IF_BUS_CONFIGURATION_SA_IF_INPUT_ENABLE)) |
				 ((0xfffU << BITP_HOST_IF_SA_IF_BUS_CONFIGURATION_SA_IF_INPUT_ENABLE))
    },
    /* 0xFC00U : 0x00000001U */
    {
        .nAddr = 0xfc00U,
        .nVal  = 0x1U
    },
    /* 0xFC04U : 0x00000002U */
    {
        .nAddr = 0xfc04U,
        .nVal  = 0x2U
    },
    /* 0xFC14U : 0x00000020U */
    {
        .nAddr = 0xfc14U,
        .nVal  = 0x20U
    },
};

/* =========================================================================
   |                            CONFIGURATIONS                             |
   ========================================================================= */
/* ======================= INTERFACE CONFIGURATIONS ======================== */
ADI_MEM_DATA_CRIT_CACHE
static ADI_E2BCORE_IF_CONFIG aoRemote1IfConfig[4] =
{
    [0U] =
    {
        /* ========== CONFIGS FOR INTERFACE: Iseled1 ========== */
        .oId           = GET_ID(0U, 0U, 0U),
        .bEnabled      = true,
        .eIfType       = ADI_E2BCORE_IF_TYPE_ISELED,
        .nIfTopic      = 1,
        .nNumIfReg     = (sizeof(aoRemote1Iseled1IfRegMap) / sizeof(ADI_E2BCORE_REG_ADDR_VAL)),
        .aoIfRegData   = aoRemote1Iseled1IfRegMap,
        .nFifoTopic    = 5,
        .nNumFifoReg   = (sizeof(aoRemote1Iseled1FifoRegMap) / sizeof(ADI_E2BCORE_REG_ADDR_VAL)),
        .aoFifoRegData = aoRemote1Iseled1FifoRegMap,
        .pfIntfCb      = &IseledInterfaceCbk,
    },
    [1U] =
    {
        /* ========== DISABLED INTERFACE 1 ========== */
        .bEnabled      = false,
    },
    [2U] =
    {
        /* ========== DISABLED INTERFACE 2 ========== */
        .bEnabled      = false,
    },
    [3U] =
    {
        /* ========== DISABLED INTERFACE 3 ========== */
        .bEnabled      = false,
    },
};


/* ========================= REMOTE CONFIGURATIONS ========================== */
ADI_MEM_DATA_CRIT_CACHE
static ADI_E2BCORE_REMOTE_CONFIG aoEth10BaseT1sRemoteConfig[1] =
{
    [0U] =
    {
        /* ========== CONFIGS FOR REMOTE: Remote1 ========== */
        .oId            = GET_ID(0U, 0U, 0xFFFFFFFFU),
        .anMacAddr      = MAC_64_TO_8(REMOTE1_MAC_ADDR),
        .bEnabled       = true,
        .nNumRegisters  = (sizeof(aoRemote1RegMap) / sizeof(ADI_E2BCORE_REG_ADDR_VAL)),
        .aoRegData      = aoRemote1RegMap,
        .nNumIf         = 4,
        .aoIntfConfigs  = aoRemote1IfConfig,
        .pfRemoteCb     = &RemoteNodeCbk
    },
};

/* ========================= NETWORK CONFIGURATION ========================= */
ADI_MEM_DATA_CRIT_CACHE
ADI_E2BCORE_CFG oEth10BaseT1sNtwrkCfg =
{
    .anMacAddr          = MAC_64_TO_8(CONTROLLER1_MAC_ADDR),
    .nNumNodes          = 1U,
    .aoRemoteCfgs       = aoEth10BaseT1sRemoteConfig,
    .pfLibCb            = &Eth10BaseT1sCbk,
    .bInitializeNetwork = true,
};



/** @} */

/*
 * EOF: www.analog.com
*/
