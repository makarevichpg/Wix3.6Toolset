 #include "precomp.h"

#pragma section(".wixburn",read)

// If these defaults ever change, be sure to update constants in burn\engine\section.cpp as well.
#pragma data_seg(push, ".wixburn")
static DWORD dwMagic = 0x00f14300;
static DWORD dwVersion = 0x00000002;

static GUID guidBundleId = { };

static DWORD dwStubSize = 0;
static DWORD dwOriginalChecksum = 0;
static DWORD dwOriginalSignatureOffset = 0;
static DWORD dwOriginalSignatureSize = 0;

static DWORD dwContainerFormat = 1;
static DWORD dwContainerCount = 0;
static DWORD qwBootstrapperApplicationContainerSize = 0;
static DWORD qwAttachedContainerSize = 0;
#pragma data_seg(pop)
