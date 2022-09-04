using System;
using System.Runtime.InteropServices;

public sealed class recycly
{
	public enum RecycleFlags : uint
	{
		SHRB_NOCONFIRMATION = 1u,
		SHRB_NOPROGRESSUI = 2u,
		SHRB_NOSOUND = 4u
	}

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
	public static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
}
