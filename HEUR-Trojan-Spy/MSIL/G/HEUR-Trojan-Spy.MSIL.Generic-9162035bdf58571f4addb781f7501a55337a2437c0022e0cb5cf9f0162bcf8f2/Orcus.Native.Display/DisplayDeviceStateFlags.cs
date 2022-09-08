using System;

namespace Orcus.Native.Display;

[Flags]
internal enum DisplayDeviceStateFlags
{
	AttachedToDesktop = 1,
	MultiDriver = 2,
	PrimaryDevice = 4,
	MirroringDriver = 8,
	VGACompatible = 0x10,
	Removable = 0x20,
	ModesPruned = 0x8000000,
	Remote = 0x4000000,
	Disconnect = 0x2000000
}
