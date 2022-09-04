using System;

namespace Lexplorer;

[Flags]
public enum SnapshotFlags : uint
{
	HeapList = 1u,
	Process = 2u,
	Thread = 4u,
	Module = 8u,
	Module32 = 0x10u,
	Inherit = 0x80000000u,
	All = 0x1Fu,
	NoHeaps = 0x40000000u
}
