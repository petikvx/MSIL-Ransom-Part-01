using System;

namespace ns0;

[Flags]
public enum GEnum0 : ulong
{
	Delete = 0x10000uL,
	Synchronize = 0x100000uL,
	GenericRead = 0x80000000uL,
	GenericWrite = 0x40000000uL,
	GenericExecute = 0x20000000uL,
	GenericAll = 0x10000000uL
}
