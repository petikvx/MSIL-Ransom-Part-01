using System;

namespace X11;

[Flags]
internal enum ChangeWindowFlags
{
	CWX = 1,
	CWY = 2,
	CWWidth = 4,
	CWHeight = 8,
	CWBorderWidth = 0x10,
	CWSibling = 0x20,
	CWStackMode = 0x40
}
