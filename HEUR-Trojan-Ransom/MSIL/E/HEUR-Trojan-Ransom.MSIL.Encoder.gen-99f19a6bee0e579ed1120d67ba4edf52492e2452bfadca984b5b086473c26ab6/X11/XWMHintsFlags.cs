using System;

namespace X11;

[Flags]
internal enum XWMHintsFlags
{
	InputHint = 1,
	StateHint = 2,
	IconPixmapHint = 4,
	IconWindowHint = 8,
	IconPositionHint = 0x10,
	IconMaskHint = 0x20,
	WindowGroupHint = 0x40,
	AllHints = 0x7F
}
