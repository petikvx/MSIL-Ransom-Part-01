using System;

namespace Orcus.Native;

[Flags]
public enum AssocF : uint
{
	None = 0u,
	Init_NoRemapCLSID = 1u,
	Init_ByExeName = 2u,
	Open_ByExeName = 2u,
	Init_DefaultToStar = 4u,
	Init_DefaultToFolder = 8u,
	NoUserSettings = 0x10u,
	NoTruncate = 0x20u,
	Verify = 0x40u,
	RemapRunDll = 0x80u,
	NoFixUps = 0x100u,
	IgnoreBaseClass = 0x200u,
	Init_IgnoreUnknown = 0x400u,
	Init_FixedProgId = 0x800u,
	IsProtocol = 0x1000u,
	InitForFile = 0x2000u
}
