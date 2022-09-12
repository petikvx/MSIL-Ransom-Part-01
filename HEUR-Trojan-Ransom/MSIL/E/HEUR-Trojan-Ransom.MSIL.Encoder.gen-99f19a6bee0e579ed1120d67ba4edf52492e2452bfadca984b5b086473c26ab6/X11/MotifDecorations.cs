using System;

namespace X11;

[Flags]
internal enum MotifDecorations
{
	All = 1,
	Border = 2,
	ResizeH = 4,
	Title = 8,
	Menu = 0x10,
	Minimize = 0x20,
	Maximize = 0x40
}
