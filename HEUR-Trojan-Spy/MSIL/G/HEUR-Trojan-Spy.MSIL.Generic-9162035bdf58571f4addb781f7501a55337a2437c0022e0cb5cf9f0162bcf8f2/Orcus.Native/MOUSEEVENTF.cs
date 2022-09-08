using System;

namespace Orcus.Native;

[Flags]
internal enum MOUSEEVENTF : uint
{
	ABSOLUTE = 0x8000u,
	HWHEEL = 0x1000u,
	MOVE = 1u,
	MOVE_NOCOALESCE = 0x2000u,
	LEFTDOWN = 2u,
	LEFTUP = 4u,
	RIGHTDOWN = 8u,
	RIGHTUP = 0x10u,
	MIDDLEDOWN = 0x20u,
	MIDDLEUP = 0x40u,
	VIRTUALDESK = 0x4000u,
	WHEEL = 0x800u,
	XDOWN = 0x80u,
	XUP = 0x100u
}
