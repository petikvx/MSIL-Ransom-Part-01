using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using dg3ypDAonQcOidMs0w;

internal static class Class11
{
	internal enum Enum0
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	public const byte byte_0 = 16;

	public const byte byte_1 = 20;

	public const byte byte_2 = 144;

	public const byte byte_3 = 160;

	public const byte byte_4 = 161;

	public const byte byte_5 = 162;

	public const byte byte_6 = 163;

	public const byte byte_7 = 164;

	public const byte byte_8 = 165;

	public const byte byte_9 = 91;

	public const byte byte_10 = 92;

	public const byte byte_11 = 145;

	public const byte byte_12 = 45;

	public const byte byte_13 = 17;

	public const byte byte_14 = 18;

	public const byte byte_15 = 231;

	private static int int_0;

	private static int int_1;

	private static byte[] byte_16;

	private static bool bool_0;

	internal static Class11 YNyWW56xZptsgNFdL1V;

	internal static void smethod_0(int virtualKeyCode, int fuState, out char[] chars)
	{
	}

	internal static void smethod_1(int virtualKeyCode, int scanCode, int fuState, out char[] chars)
	{
	}

	internal static void smethod_2(int virtualKeyCode, int scanCode, int fuState, IntPtr dwhkl, out char[] chars)
	{
	}

	private static void smethod_3(int vk, int sc, IntPtr hkl)
	{
	}

	private static IntPtr smethod_4()
	{
		return (IntPtr)(object)null;
	}

	[DllImport("user32.dll")]
	[Obsolete("Use ToUnicodeEx instead")]
	public static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

	[DllImport("user32.dll")]
	public static extern int ToUnicodeEx(int wVirtKey, int wScanCode, byte[] lpKeyState, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder pwszBuff, int cchBuff, int wFlags, IntPtr dwhkl);

	[DllImport("user32.dll")]
	public static extern int GetKeyboardState(byte[] pbKeyState);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern short GetKeyState(int vKey);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern int MapVirtualKeyEx(int uCode, int uMapType, IntPtr dwhkl);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr GetKeyboardLayout(int dwLayout);

	static Class11()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		pPkGaZ64d70Vc03VDhC();
		pqyG4e6hssdm3hsfHGD();
		NqR0Wl6wAsaalVmLJVq();
		int_0 = 0;
		int_1 = 0;
		byte_16 = new byte[256];
		bool_0 = false;
	}

	internal static IntPtr yFmcjd6pOBp2PVi1UYc()
	{
		return (IntPtr)(object)null;
	}

	internal static bool EhsVLD6LfnqGbhNAkEJ()
	{
		return true;
	}

	internal static Class11 BFF5876JQiBk5EYbJoc()
	{
		return null;
	}

	internal static object pCrkRp6mgV7pLXPxLim(object object_0)
	{
		return null;
	}

	internal static bool SlZvrS68NRZiNhTIUST(object object_0, Keys key)
	{
		return true;
	}

	internal static bool yACFTm6rGY7p0u7VG3c(object object_0, Keys key)
	{
		return true;
	}

	internal static int aavITt6EwqbnESKIfon(object object_0)
	{
		return 0;
	}

	internal static void DEYh7s6OF5DtZ7QwGMT(int vk, int sc, IntPtr hkl)
	{
	}

	internal static int tOvYF56iHwZVL9vwGax(object object_0)
	{
		return 0;
	}

	internal static char VLnif069UD2A4uZETxl(object object_0, int int_2)
	{
		return '\0';
	}

	internal static object PMHYPm65hVIv9UWACxI(object object_0)
	{
		return null;
	}

	internal static void pPkGaZ64d70Vc03VDhC()
	{
	}

	internal static void pqyG4e6hssdm3hsfHGD()
	{
	}

	internal static void NqR0Wl6wAsaalVmLJVq()
	{
	}
}
