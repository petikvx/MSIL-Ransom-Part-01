using System;

namespace X11;

[Flags]
internal enum MouseKeyMasks
{
	Button1Mask = 0x100,
	Button2Mask = 0x200,
	Button3Mask = 0x400,
	Button4Mask = 0x800,
	Button5Mask = 0x1000
}
