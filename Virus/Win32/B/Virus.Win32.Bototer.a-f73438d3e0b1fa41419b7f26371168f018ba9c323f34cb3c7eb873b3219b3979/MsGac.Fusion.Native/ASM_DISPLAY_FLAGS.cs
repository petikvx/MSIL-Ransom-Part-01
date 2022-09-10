using System;

namespace MsGac.Fusion.Native;

[Flags]
internal enum ASM_DISPLAY_FLAGS
{
	VERSION = 1,
	CULTURE = 2,
	PUBLIC_KEY_TOKEN = 4,
	PUBLIC_KEY = 8,
	CUSTOM = 0x10,
	PROCESSORARCHITECTURE = 0x20,
	LANGUAGEID = 0x40
}
