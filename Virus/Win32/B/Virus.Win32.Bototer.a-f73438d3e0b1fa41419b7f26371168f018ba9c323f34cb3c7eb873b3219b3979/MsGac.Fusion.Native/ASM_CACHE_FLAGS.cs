using System;

namespace MsGac.Fusion.Native;

[Flags]
internal enum ASM_CACHE_FLAGS
{
	ASM_CACHE_ZAP = 1,
	ASM_CACHE_GAC = 2,
	ASM_CACHE_DOWNLOAD = 4
}
