# /****************************************************************************
# Copyright (c) 2022-2024 - Analog Devices Inc. All Rights Reserved.
# This software is proprietary & confidential to Analog Devices, Inc.
# and its licensors.
# *****************************************************************************
#  * \file: CMakeLists.txt
#  * \brief: CMake file for building executable file of ISELED example.
#  * Developed by: Automotive Software and Systems team, Bangalore, India
# ****************************************************************************/

# Set the minimum CMake version required
cmake_minimum_required(VERSION 3.16)

# Set "This" variable for use in multiple places
set(This ex_iseled)
set(Sniffer ex_iseledSniffer)

set(LIB_ROOT "${CMAKE_CURRENT_SOURCE_DIR}/../../lib")
set(APP_UTILS "${CMAKE_CURRENT_SOURCE_DIR}/../utils")

# Add the paths for the include files
include_directories(
    # Library includes
    "${LIB_ROOT}/common/inc"
    "${LIB_ROOT}/common/regmaps"
    "${LIB_ROOT}/dbg/inc"
    "${LIB_ROOT}/e2bcore/inc"
    "${LIB_ROOT}/network/inc"
    "${LIB_ROOT}/eal/inc"
    "${LIB_ROOT}/oaspi/inc"
    "${LIB_ROOT}/pal/inc"
    "${LIB_ROOT}/ptp/inc"
    "${LIB_ROOT}/osal/inc"

    # App includes
    "./"
    "${APP_UTILS}"
)

# Add the paths for library files
link_directories("${LIB_ROOT}/bin" "${LIB_ROOT}/pal/inc/pigpio")

# Add the application sources
file(GLOB SOURCES
    "./*.c"
    "${APP_UTILS}/*.c"
)

# Create executables for all the applications from these sources
add_executable(${This} "${SOURCES}")
add_executable(${Sniffer} "${SOURCES}")

# Set the CMake build type as Debug.
set(CMAKE_BUILD_TYPE Debug)

set(COMPILE_DEFS -D_DEBUG -DCORE0 -DDEBUG -DADI_DEBUG -DUSE_EAL -DCUST_BOARD -DADI_USE_STDLIB_IMPL)
set(LINK_LIBS $<TARGET_OBJECTS:Common> $<TARGET_OBJECTS:Pal> $<TARGET_OBJECTS:Network> Eal $<TARGET_OBJECTS:Osal>)
set(COMPILE_OPTS -Wall -Wextra -Wformat -Wno-unused-variable -Wno-unused-parameter -Wno-unused-function -fdata-sections -ffunction-sections -O3)

# Add link, compile options specific to the target
if(Target STREQUAL "win_x64")
    # Add compile definitions
    target_compile_definitions(${This} PRIVATE ${COMPILE_DEFS} -DWIN_X64)
    target_compile_definitions(${Sniffer} PRIVATE ${COMPILE_DEFS} -DWIN_X64 -DSNIFFER_MODE_EN)

    # Add libraries to link
    target_link_libraries(${This} ${LINK_LIBS} oaspi_win_x64 e2b_win_x64)
    target_link_libraries(${Sniffer} ${LINK_LIBS} oaspi_win_x64 e2b_win_x64)

    # Add compile options
    target_compile_options(${This} PRIVATE ${COMPILE_OPTS})
    target_compile_options(${Sniffer} PRIVATE ${COMPILE_OPTS})

    # Add link options
    target_link_options(${This} PUBLIC "LINKER:--gc-sections")
    target_link_options(${Sniffer} PUBLIC "LINKER:--gc-sections")

    # Copy Ftdi dlls after build
    add_custom_command(
            TARGET ${This}
            POST_BUILD
            COMMAND ${CMAKE_COMMAND} -E copy_directory
                ${LIB_ROOT}/pal/pal_win_x64/lib
                ${CMAKE_CURRENT_BINARY_DIR}
        )
    add_custom_command(
            TARGET ${Sniffer}
            POST_BUILD
            COMMAND ${CMAKE_COMMAND} -E copy_directory
                ${LIB_ROOT}/pal/pal_win_x64/lib
                ${CMAKE_CURRENT_BINARY_DIR}
        )

elseif(Target STREQUAL "sc594_som")
    # Add compile definitions
    target_compile_definitions(${This} PRIVATE ${COMPILE_DEFS} -D__EV_SC594_SOM__)
    target_compile_definitions(${Sniffer} PRIVATE ${COMPILE_DEFS} -D__EV_SC594_SOM__ -DSNIFFER_MODE_EN)

    # Add libraries to link
    target_link_libraries(${This} ${LINK_LIBS}  oaspi_sc594_som e2b_sc594_som)
    target_link_libraries(${Sniffer} ${LINK_LIBS}  oaspi_sc594_som e2b_sc594_som)

    # Add compile options
    target_compile_options(${This} PRIVATE ${COMPILE_OPTS} -mproc=ADSP-SC594 -msi-revision=0.0)
    target_compile_options(${Sniffer} PRIVATE ${COMPILE_OPTS} -mproc=ADSP-SC594 -msi-revision=0.0)

    # Add link options
    target_link_options(${This} PRIVATE -T${LIB_ROOT}/pal/pal_sc594_som/system/linker/app.ld -mproc=ADSP-SC594 -msi-revision=0.0 -Wl,--gc-sections -Wl,-Map=${This}.map -mdebug-libs)
    target_link_options(${Sniffer} PRIVATE -T${LIB_ROOT}/pal/pal_sc594_som/system/linker/app.ld -mproc=ADSP-SC594 -msi-revision=0.0 -Wl,--gc-sections -Wl,-Map=${Sniffer}.map -mdebug-libs)

    # Set output directory for executables
    set_target_properties(${This} PROPERTIES RUNTIME_OUTPUT_DIRECTORY "${LIB_ROOT}/pal/pal_sc594_som/bin")
    set_target_properties(${Sniffer} PROPERTIES RUNTIME_OUTPUT_DIRECTORY "${LIB_ROOT}/pal/pal_sc594_som/bin")

    if (CMAKE_HOST_WIN32)
        # Generate LDR file
        add_custom_command(
            TARGET ${This}
            POST_BUILD
            COMMAND
            cd ${LIB_ROOT}/pal/pal_sc594_som/Loader &&
            copy /Y ..\\bin\\${This} . &&
            "${COMPILER_INST_PATH}/elfloader.exe" -proc ADSP-SC594 -core0=${This} -init sc594w_init_Core0 -b SPI -f BINARY -Width 8 -bcode 0x1 -o ${This}.ldr &&
            del ${This}
        )
        # Generate LDR file
        add_custom_command(
            TARGET ${Sniffer}
            POST_BUILD
            COMMAND
            cd ${LIB_ROOT}/pal/pal_sc594_som/Loader &&
            copy /Y ..\\bin\\${Sniffer} . &&
            "${COMPILER_INST_PATH}/elfloader.exe" -proc ADSP-SC594 -core0=${Sniffer} -init sc594w_init_Core0 -b SPI -f BINARY -Width 8 -bcode 0x1 -o ${Sniffer}.ldr &&
            del ${Sniffer}
        )
    endif()

elseif(Target STREQUAL "rpi")
    # Add compile definitions
    target_compile_definitions(${This} PRIVATE ${COMPILE_DEFS} -DRPI3_RASPBIAN)
    target_compile_definitions(${Sniffer} PRIVATE ${COMPILE_DEFS} -DRPI3_RASPBIAN -DSNIFFER_MODE_EN)

    # Add libraries to link
    target_link_libraries(${This} ${LINK_LIBS} oaspi_rpi e2b_rpi pthread dl pigpio)
    target_link_libraries(${Sniffer} ${LINK_LIBS} oaspi_rpi e2b_rpi pthread dl pigpio)

    # Add compile options
    target_compile_options(${This} PRIVATE ${COMPILE_OPTS})
    target_compile_options(${Sniffer} PRIVATE ${COMPILE_OPTS})

    # Add link options
    target_link_options(${This} PUBLIC "LINKER:--gc-sections")
    target_link_options(${Sniffer} PUBLIC "LINKER:--gc-sections")

elseif(Target STREQUAL "linux")
    # Add compile definitions
    target_compile_definitions(${This} PRIVATE ${COMPILE_DEFS} -DLINUX)
    target_compile_definitions(${Sniffer} PRIVATE ${COMPILE_DEFS} -DLINUX -DSNIFFER_MODE_EN)

    # Add libraries to link
    target_link_libraries(${This} ${LINK_LIBS} oaspi_linux e2b_linux pthread dl)
    target_link_libraries(${Sniffer} ${LINK_LIBS} oaspi_linux e2b_linux pthread dl)

    # Add compile options
    target_compile_options(${This} PRIVATE ${COMPILE_OPTS})
    target_compile_options(${Sniffer} PRIVATE ${COMPILE_OPTS})

    # Add link options
    target_link_options(${This} PUBLIC "LINKER:--gc-sections")
    target_link_options(${Sniffer} PUBLIC "LINKER:--gc-sections")

elseif(Target STREQUAL "nng")
    # Add compile definitions
    target_compile_definitions(${This} PRIVATE ${COMPILE_DEFS} -DLINUX)
    target_compile_definitions(${Sniffer} PRIVATE ${COMPILE_DEFS} -DLINUX -DSNIFFER_MODE_EN)

    # Add libraries to link
    target_link_libraries(${This} ${LINK_LIBS} oaspi_linux e2b_linux pthread nng stdc++)
    target_link_libraries(${Sniffer} ${LINK_LIBS} oaspi_linux e2b_linux pthread nng stdc++)

    # Add compile options
    target_compile_options(${This} PRIVATE ${COMPILE_OPTS})
    target_compile_options(${Sniffer} PRIVATE ${COMPILE_OPTS})

    # Add link options
    target_link_options(${This} PUBLIC "LINKER:--gc-sections")
    target_link_options(${Sniffer} PUBLIC "LINKER:--gc-sections")

elseif(Target STREQUAL "f746zg")
    # Add compile definitions
    target_compile_definitions(${This} PRIVATE ${COMPILE_DEFS}
          __NUCLEO_STM32__
          STM32
          STM32F746ZGTx
          STM32F7
          NUCLEO_F746ZG
          USE_HAL_DRIVER
          STM32F746xx
    )
    target_compile_definitions(${Sniffer} PRIVATE ${COMPILE_DEFS}
          __NUCLEO_STM32__
          STM32
          STM32F746ZGTx
          STM32F7
          NUCLEO_F746ZG
          USE_HAL_DRIVER
          STM32F746xx
          SNIFFER_MODE_EN
    )

    # Add libraries to link
    target_link_libraries(${This} ${LINK_LIBS} oaspi_f746zg e2b_f746zg)
    target_link_libraries(${Sniffer} ${LINK_LIBS} oaspi_f746zg e2b_f746zg)

    # Add compile options
    target_compile_options(${This} PRIVATE ${COMPILE_OPTS}
        -fstack-usage
        --specs=nano.specs
        -mcpu=cortex-m7
        -mfpu=fpv4-sp-d16
        -mfloat-abi=hard
        -mthumb
        -std=gnu11
        -g3
        -O3
    )
    target_compile_options(${Sniffer} PRIVATE ${COMPILE_OPTS}
        -fstack-usage
        --specs=nano.specs
        -mcpu=cortex-m7
        -mfpu=fpv4-sp-d16
        -mfloat-abi=hard
        -mthumb
        -std=gnu11
        -g3
        -O3
    )

    # Add link options
    target_link_options(${This} PUBLIC -T${LIB_ROOT}/pal/pal_nucleo_f746zg/STM32F746ZGTX_FLASH.ld -mcpu=cortex-m7 --specs=nosys.specs -Wl,-Map=${This}.map -Wl,--gc-sections -u _printf_float  -mfpu=fpv5-sp-d16 -mfloat-abi=hard -mthumb -Wl,--start-group -lc -lm -Wl,--end-group)
    target_link_options(${Sniffer} PUBLIC -T${LIB_ROOT}/pal/pal_nucleo_f746zg/STM32F746ZGTX_FLASH.ld -mcpu=cortex-m7 --specs=nosys.specs -Wl,-Map=${Sniffer}.map -Wl,--gc-sections -u _printf_float  -mfpu=fpv5-sp-d16 -mfloat-abi=hard -mthumb -Wl,--start-group -lc -lm -Wl,--end-group)

    add_custom_command(
      TARGET ${This}
      POST_BUILD
      COMMAND
      ${STM_BIN_PATH}/arm-none-eabi-objdump -h ${This}.elf > ${This}.txt &&
      copy /Y ${This}.txt ..\\..\\ &&
      del ${This}.txt
      )
endif()
