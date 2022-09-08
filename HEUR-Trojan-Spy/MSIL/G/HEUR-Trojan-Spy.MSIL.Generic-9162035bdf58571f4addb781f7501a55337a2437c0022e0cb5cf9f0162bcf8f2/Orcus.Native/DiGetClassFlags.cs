using System;

namespace Orcus.Native;

[Flags]
public enum DiGetClassFlags : uint
{
	DIGCF_DEFAULT = 1u,
	DIGCF_PRESENT = 2u,
	DIGCF_ALLCLASSES = 4u,
	DIGCF_PROFILE = 8u,
	DIGCF_DEVICEINTERFACE = 0x10u
}
