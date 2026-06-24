cmake_minimum_required(VERSION 3.16)

project(OspBridge C)

# ============================================================================
# SDK 루트 경로 설정
#
# EdgeStudio 없이 빌드하려면:
#   1. NativeOsp/sdk/ 폴더를 만들고 아래 파일들을 복사해 넣으세요.
#
#   [헤더 폴더] — C:/Analog Devices/EdgeStudio 3.8.0/sdk/ 에서 복사
#     sdk/app/utils/
#     sdk/lib/common/inc/
#     sdk/lib/common/regmaps/
#     sdk/lib/dbg/inc/
#     sdk/lib/e2bcore/inc/
#     sdk/lib/eal/inc/
#     sdk/lib/network/inc/
#     sdk/lib/oaspi/inc/
#     sdk/lib/osal/inc/
#     sdk/lib/pal/inc/
#     sdk/lib/ptp/inc/
#
#   [바이너리 .a] — C:/Analog Devices/EdgeStudio 3.8.0/sdk/lib/bin/ 에서 복사
#     sdk/lib/bin/liboaspi_win_x64.a
#     sdk/lib/bin/libe2b_win_x64.a
#
#   [소스 .obj] — cmake-build 폴더가 있으면 자동으로 사용됨 (이미 포함)
#
# EdgeStudio 가 설치된 PC 에서 빌드할 경우:
#   아래 SDK_ROOT 를 EdgeStudio 설치 경로로 변경하면 됩니다.
#   set(SDK_ROOT "C:/Analog Devices/EdgeStudio 3.8.0/sdk")
# ============================================================================

# 프로젝트 내 sdk/ 폴더를 우선 사용, 없으면 EdgeStudio 설치 경로 fallback
if(EXISTS "${CMAKE_CURRENT_SOURCE_DIR}/sdk")
    set(SDK_ROOT "${CMAKE_CURRENT_SOURCE_DIR}/sdk")
    message(STATUS "[OspBridge] SDK: 프로젝트 내 sdk/ 폴더 사용 (${SDK_ROOT})")
elseif(EXISTS "C:/Analog Devices/EdgeStudio 3.8.0/sdk")
    set(SDK_ROOT "C:/Analog Devices/EdgeStudio 3.8.0/sdk")
    message(STATUS "[OspBridge] SDK: EdgeStudio 설치 경로 사용 (${SDK_ROOT})")
else()
    message(FATAL_ERROR
        "[OspBridge] SDK를 찾을 수 없습니다.\n"
        "  방법 1: NativeOsp/sdk/ 폴더에 EdgeStudio SDK 파일을 복사하세요.\n"
        "  방법 2: EdgeStudio 3.8.0을 설치하세요.\n"
        "  자세한 내용은 NativeOsp/CMakeLists.txt 상단 주석을 참고하세요."
    )
endif()

set(LIB_ROOT  "${SDK_ROOT}/lib")
set(APP_UTILS "${SDK_ROOT}/app/utils")

set(Target win_x64)
set(OS noOS)
set(COMPILE_DEFS  -D_DEBUG -DCORE0 -DDEBUG -DUSE_EAL -DCUST_BOARD -DWIN_X64 -DADI_USE_STDLIB_IMPL -DNoOS)
set(COMPILE_OPTS  -Wall -Wextra -Wformat -Wno-unused-variable -Wno-unused-parameter -Wno-unused-function
                  -fdata-sections -ffunction-sections -O3 -std=gnu11)

add_subdirectory("${LIB_ROOT}/common" "${CMAKE_BINARY_DIR}/common")
add_subdirectory("${LIB_ROOT}/pal"     "${CMAKE_BINARY_DIR}/pal")
add_subdirectory("${LIB_ROOT}/network" "${CMAKE_BINARY_DIR}/network")
add_subdirectory("${LIB_ROOT}/eal"     "${CMAKE_BINARY_DIR}/eal")
add_subdirectory("${LIB_ROOT}/osal"    "${CMAKE_BINARY_DIR}/osal")

include_directories(
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
    "${APP_UTILS}"
    "${CMAKE_CURRENT_SOURCE_DIR}"
    "${CMAKE_CURRENT_SOURCE_DIR}/utils"
)

link_directories("${LIB_ROOT}/bin")

file(GLOB APP_UTIL_SOURCES "${APP_UTILS}/*.c")

add_library(OspBridge SHARED
    ${APP_UTIL_SOURCES}
    "${CMAKE_CURRENT_SOURCE_DIR}/adi_Eth10BaseT1s_cfg.c"
    "${CMAKE_CURRENT_SOURCE_DIR}/ex_fioOsp.c"
    "${CMAKE_CURRENT_SOURCE_DIR}/utils/fioOsp.c"
    $<TARGET_OBJECTS:Common>
    $<TARGET_OBJECTS:Pal>
    $<TARGET_OBJECTS:Network>
    $<TARGET_OBJECTS:Eal>
    $<TARGET_OBJECTS:Osal>
)

target_compile_definitions(OspBridge PRIVATE ${COMPILE_DEFS})
target_compile_options(OspBridge PRIVATE ${COMPILE_OPTS})
target_link_libraries(OspBridge PRIVATE oaspi_win_x64 e2b_win_x64)
target_link_options(OspBridge PRIVATE "LINKER:--gc-sections")

set_target_properties(OspBridge PROPERTIES
    PREFIX ""
    RUNTIME_OUTPUT_DIRECTORY "${CMAKE_CURRENT_SOURCE_DIR}/build"
    LIBRARY_OUTPUT_DIRECTORY "${CMAKE_CURRENT_SOURCE_DIR}/build"
    ARCHIVE_OUTPUT_DIRECTORY "${CMAKE_CURRENT_SOURCE_DIR}/build"
)

# 빌드 후 PAL DLL(ftd2xx 래퍼 등)을 build/ 폴더로 복사
add_custom_command(
    TARGET OspBridge POST_BUILD
    COMMAND ${CMAKE_COMMAND} -E copy_directory
        "${LIB_ROOT}/pal/pal_win_x64/lib"
        "$<TARGET_FILE_DIR:OspBridge>"
)
