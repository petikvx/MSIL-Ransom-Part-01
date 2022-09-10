using System;
using System.Runtime.InteropServices;

namespace OpenNETCF.Desktop.Communication;

public class RAPIException : Exception
{
	private const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 256;

	private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

	private const int FORMAT_MESSAGE_FROM_STRING = 1024;

	private const int FORMAT_MESSAGE_FROM_HMODULE = 2048;

	private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

	private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;

	private const int FORMAT_MESSAGE_MAX_WIDTH_MASK = 255;

	private int win32Error;

	public int Win32Error => win32Error;

	public RAPIException(string Message)
		: base(Message + " " + GetErrorMessage(Marshal.GetLastWin32Error()))
	{
		win32Error = RAPI.CeGetLastError();
	}

	public RAPIException(Exception ex)
		: base(ex.Message)
	{
		win32Error = 0;
	}

	public RAPIException(string Message, int ErrorCode)
		: base(Message + " " + GetErrorMessage(ErrorCode))
	{
		win32Error = ErrorCode;
	}

	internal static string GetErrorMessage(int ErrNo)
	{
		if (ErrNo == 0)
		{
			return "";
		}
		IntPtr lpBuffer;
		int num = FormatMessage(4352, 0, ErrNo, 0, out lpBuffer, 0, null);
		if (num == 0)
		{
			return string.Format("Error {0} (0x{0:X})", ErrNo);
		}
		string result = Marshal.PtrToStringUni(lpBuffer, num);
		LocalFree(lpBuffer);
		return result;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	internal static extern int FormatMessage(int dwFlags, int lpSource, int dwMessageId, int dwLanguageId, out IntPtr lpBuffer, int nSize, int[] Arguments);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr LocalFree(IntPtr hMem);
}
