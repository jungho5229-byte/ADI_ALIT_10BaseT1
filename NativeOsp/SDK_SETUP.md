# OspBridge.dll 빌드 환경 설정

EdgeStudio 없이 빌드하려면 아래 파일들을 `NativeOsp/sdk/` 폴더에 복사하세요.

## 복사 원본 경로
```
C:\Analog Devices\EdgeStudio 3.8.0\sdk\
```

## 복사할 폴더/파일 목록

### 헤더 폴더 (폴더째로 복사)
```
sdk\app\utils\                → NativeOsp/sdk/app/utils/
sdk\lib\common\inc\           → NativeOsp/sdk/lib/common/inc/
sdk\lib\common\regmaps\       → NativeOsp/sdk/lib/common/regmaps/
sdk\lib\dbg\inc\              → NativeOsp/sdk/lib/dbg/inc/
sdk\lib\e2bcore\inc\          → NativeOsp/sdk/lib/e2bcore/inc/
sdk\lib\eal\inc\              → NativeOsp/sdk/lib/eal/inc/
sdk\lib\network\inc\          → NativeOsp/sdk/lib/network/inc/
sdk\lib\oaspi\inc\            → NativeOsp/sdk/lib/oaspi/inc/
sdk\lib\osal\inc\             → NativeOsp/sdk/lib/osal/inc/
sdk\lib\pal\inc\              → NativeOsp/sdk/lib/pal/inc/
sdk\lib\ptp\inc\              → NativeOsp/sdk/lib/ptp/inc/
```

### 바이너리 .a 파일 (소스 비공개, 파일만 복사)
```
sdk\lib\bin\liboaspi_win_x64.a  → NativeOsp/sdk/lib/bin/liboaspi_win_x64.a
sdk\lib\bin\libe2b_win_x64.a    → NativeOsp/sdk/lib/bin/libe2b_win_x64.a
```

## 빌드 방법 (MinGW + CMake 필요)

```bat
cd NativeOsp
mkdir cmake-build
cd cmake-build
cmake .. -G "Ninja" -DCMAKE_C_COMPILER=gcc
ninja
```

빌드 완료 후 `NativeOsp/build/OspBridge.dll` 이 생성되면
`bin/Debug/OspBridge.dll` 에 복사하세요.

## 참고

- MinGW (gcc): https://winlibs.com 에서 다운로드
- CMake: https://cmake.org/download
- Ninja: https://ninja-build.org
