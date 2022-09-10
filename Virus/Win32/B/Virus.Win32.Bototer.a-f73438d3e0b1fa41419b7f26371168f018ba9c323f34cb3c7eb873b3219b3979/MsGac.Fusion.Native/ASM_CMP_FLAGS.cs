using System;

namespace MsGac.Fusion.Native;

[Flags]
internal enum ASM_CMP_FLAGS
{
	NAME = 1,
	MAJOR_VERSION = 2,
	MINOR_VERSION = 4,
	BUILD_NUMBER = 8,
	REVISION_NUMBER = 0x10,
	PUBLIC_KEY_TOKEN = 0x20,
	CULTURE = 0x40,
	CUSTOM = 0x80,
	ALL = 0xFF,
	DEFAULT = 0x100
}
