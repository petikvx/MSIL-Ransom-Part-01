using System;

namespace Orcus.Native;

internal struct MOUSEINPUT
{
	internal int dx;

	internal int dy;

	internal int mouseData;

	internal MOUSEEVENTF dwFlags;

	internal uint time;

	internal UIntPtr dwExtraInfo;
}
