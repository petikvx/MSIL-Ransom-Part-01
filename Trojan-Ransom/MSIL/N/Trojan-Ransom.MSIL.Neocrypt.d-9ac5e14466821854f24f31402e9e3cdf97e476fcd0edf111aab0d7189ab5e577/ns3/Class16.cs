using System.Runtime.InteropServices;

namespace ns3;

internal class Class16
{
	private const int int_0 = 128;

	private const int int_1 = 64;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int FindWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpClassName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

	public static void smethod_0()
	{
		string lpClassName = "Shell_traywnd";
		string lpWindowName = "";
		int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
		SetWindowPos(hwnd, 0, 0, 0, 0, 0, 128);
	}

	public static void smethod_1()
	{
		string lpClassName = "Shell_traywnd";
		string lpWindowName = "";
		int hwnd = FindWindowA(ref lpClassName, ref lpWindowName);
		SetWindowPos(hwnd, 0, 0, 0, 0, 0, 64);
	}
}
