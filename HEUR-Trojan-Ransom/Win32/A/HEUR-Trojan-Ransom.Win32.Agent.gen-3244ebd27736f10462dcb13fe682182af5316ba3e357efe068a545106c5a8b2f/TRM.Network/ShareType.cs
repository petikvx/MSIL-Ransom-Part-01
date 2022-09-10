using System;

namespace TRM.Network;

[Flags]
public enum ShareType
{
	Disk = 0,
	Printer = 1,
	Device = 2,
	IPC = 3,
	Special = int.MinValue
}
