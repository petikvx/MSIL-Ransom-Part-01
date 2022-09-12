using System;

namespace X11;

[Flags]
internal enum KeyMasks
{
	ShiftMask = 1,
	LockMask = 2,
	ControlMask = 4,
	Mod1Mask = 8,
	Mod2Mask = 0x10,
	Mod3Mask = 0x20,
	Mod4Mask = 0x40,
	Mod5Mask = 0x80,
	ModMasks = 0xF8
}
