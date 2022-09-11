using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace White.Core.WindowsAPI;

public struct CursorInfo
{
	public uint size;

	public uint flags;

	public IntPtr handle;

	public Point point;

	public static CursorInfo New()
	{
		CursorInfo result = default(CursorInfo);
		result.size = (uint)Marshal.SizeOf(typeof(CursorInfo));
		return result;
	}
}
