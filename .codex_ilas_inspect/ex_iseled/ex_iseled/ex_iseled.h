/*******************************************************************************
 Copyright (c) 2022-2024 - Analog Devices Inc. All Rights Reserved.
 This software is proprietary & confidential to Analog Devices, Inc.
 and its licensors.
 ******************************************************************************
 * \file: ex_iseled.h
 * \brief: The header file for the application
 * Developed by: Automotive Software and Systems team, Bangalore, India
 *****************************************************************************/
/** \addtogroup app
 * @{
 */

#ifndef EX_ISELED_H
#define EX_ISELED_H

/*================================= INCLUDES ================================*/
#include "adi_Eth10BaseT1s_cfg.h"       /* E2B Network configuration */
#include "adi_pal.h"                    /* Platform abstraction layer */
#include "adi_dbg.h"                    /* Debug interface */
#include "adi_network.h"                /* Network layer */
#include "adi_app_utils.h"              /* Include common utilities */
#include "adi_eal_diag.h"               /* Diagnostics */
#include "adi_eal.h"                    /* E2B abstraction layer */
#include "adi_eal_iseled.h"             /* EAL ISELED header */
#include "iseled.h"                     /* ISELED driver header */

/*================================= DEFINES =================================*/
#if defined(__EV_SC594_SOM__)
#define ADI_NETWORK_DEV_IDX     (1u)    /*!< The index of the SPI device used */
#define ADI_NETWORK_ETH_IDX     (2u)    /*!< The index of the ethernet device used */
#elif defined(RPI3_RASPBIAN)
#define ADI_NETWORK_DEV_IDX     (0u)    /*!< The index of the SPI device used */
#define ADI_NETWORK_ETH_IDX     (2u)    /*!< The index of the ethernet device used */
#elif defined(WIN_X64)
#define ADI_NETWORK_DEV_IDX     (0u)    /*!< The index of the SPI device used */
#define ADI_NETWORK_ETH_IDX     (4u)    /*!< The index of the ethernet device used */
#elif defined(__NUCLEO_STM32__)
#define ADI_NETWORK_DEV_IDX     (0u)    /*!< The index of the SPI device used */
#define ADI_NETWORK_ETH_IDX     (1u)    /*!< The index of the ethernet device used */
#elif defined(LINUX)
#define ADI_NETWORK_DEV_IDX     (0u)    /*!< The index of the SPI device used */
#define ADI_NETWORK_ETH_IDX     (2u)    /*!< The index of the ethernet device used */
#else
#define ADI_NETWORK_DEV_IDX     (0u)    /*!< The index of the SPI device used */
#define ADI_NETWORK_ETH_IDX     (4u)    /*!< The index of the ethernet device used */
#endif

#define NUM_REMOTE_NODES        (1u)
#define CTRL_PLCA_ID            (0u)
#define ISELED0_MEM_SIZE        (ADI_EAL_ISELED_UNICAST_INST_MEM_SIZE(20U))

/*================================ DATA TYPES ===============================*/
/** Application data */
typedef struct APP_DATA
{
    uint32_t eAppMode;        /*!< Application mode */
    uint32_t eAppCmd;         /*!< Application command */
    uint64_t nPrevReadTime;   /*!< Time at which the ISELED LEDs were updated previously */
    uint32_t nMacCnt;         /*!< Number of MAC addresses received as part of discovery */
} APP_DATA;

#endif /* EX_ISELED_H */

/** @} */

/**
 * EOF: https://www.analog.com/
 */
