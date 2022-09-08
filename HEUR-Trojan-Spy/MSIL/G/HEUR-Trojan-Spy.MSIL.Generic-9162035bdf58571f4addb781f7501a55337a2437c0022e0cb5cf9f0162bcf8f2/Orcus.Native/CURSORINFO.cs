using System;

namespace Orcus.Native;

public struct CURSORINFO
{
	public int cbSize;

	public int flags;

	public IntPtr hCursor;

	public POINTAPI ptScreenPos;
}
