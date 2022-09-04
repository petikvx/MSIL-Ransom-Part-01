using System;

namespace Lexplorer;

internal struct KEYBDINPUT
{
	internal short wVk;

	internal short wScan;

	internal KEYEVENTF dwFlags;

	internal int time;

	internal UIntPtr dwExtraInfo;
}
