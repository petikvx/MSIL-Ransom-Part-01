using System;

namespace Gecko;

[Flags]
public enum GeckoWindowFlags
{
	Default = 1,
	WindowBorders = 2,
	WindowClose = 4,
	WindowResize = 8,
	MenuBar = 0x10,
	ToolBar = 0x20,
	LocationBar = 0x40,
	StatusBar = 0x80,
	PersonalToolbar = 0x100,
	ScrollBars = 0x200,
	TitleBar = 0x400,
	Extra = 0x800,
	CreateWithSize = 0x1000,
	CreateWithPosition = 0x2000,
	WindowMin = 0x4000,
	WindowPopup = 0x8000,
	WindowRaised = 0x2000000,
	WindowLowered = 0x4000000,
	CenterScreen = 0x8000000,
	Dependent = 0x10000000,
	Modal = 0x20000000,
	OpenAsDialog = 0x40000000,
	OpenAsChrome = int.MinValue,
	All = 0xFFE
}
