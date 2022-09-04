using System;

namespace Lexplorer;

[Flags]
internal enum ProcessAccessFlags : uint
{
	All = 0x1F0FFFu,
	Terminate = 1u,
	CreateThread = 2u,
	VMOperation = 8u,
	VMRead = 0x10u,
	VMWrite = 0x20u,
	DupHandle = 0x40u,
	SetInformation = 0x200u,
	QueryInformation = 0x400u,
	Synchronize = 0x100000u
}
