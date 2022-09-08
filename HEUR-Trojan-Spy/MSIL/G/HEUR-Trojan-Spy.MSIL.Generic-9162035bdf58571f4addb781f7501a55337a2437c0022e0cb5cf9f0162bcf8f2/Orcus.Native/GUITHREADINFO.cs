using System;
using System.Drawing;

namespace Orcus.Native;

public struct GUITHREADINFO
{
	public int cbSize;

	public int flags;

	public IntPtr hwndActive;

	public IntPtr hwndFocus;

	public IntPtr hwndCapture;

	public IntPtr hwndMenuOwner;

	public IntPtr hwndMoveSize;

	public IntPtr hwndCaret;

	public Rectangle rcCaret;
}
