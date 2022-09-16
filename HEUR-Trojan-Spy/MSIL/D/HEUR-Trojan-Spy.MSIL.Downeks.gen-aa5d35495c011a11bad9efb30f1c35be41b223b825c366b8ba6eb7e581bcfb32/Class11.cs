using System;
using System.Runtime.InteropServices;
using System.Text;
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

	private static Class11 ynaoBGv1vVZqMQvbOsQ;

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
		e3hcFSv2ePJjYAtYJE8();
		WP6RZJql8gZrNhVA9v.w65ov7siki();
		Hu6tW5vwQ7uO1IRuhPD();
		int_0 = 0;
		int_1 = 0;
		byte_16 = new byte[256];
		bool_0 = false;
	}

	internal static IntPtr JKuDjnvkE9SYYnmOqlv()
	{
		return (IntPtr)(object)null;
	}

	internal static bool QwfhyvvpjVmJygGmRDi()
	{
		return true;
	}

	internal static Class11 S9EByUvVhca1YVwZreI()
	{
		return null;
	}

	internal static object QredWCvYMiWDgYYJlBZ()
	{
		return null;
	}

	internal static object gIOIq7vFoF8o9f3gj3q(object object_0)
	{
		return null;
	}

	internal static void U8DOfvvlGIDtlynBn76(int vk, int sc, IntPtr hkl)
	{
	}

	internal static char BduQJ1vgRfyu4HEpQsD(object object_0, int int_2)
	{
		return '\0';
	}

	internal static int CFHbXQvakVMB5ShgiSM(object object_0)
	{
		return 0;
	}

	internal static object glYopovjXQfUl6MLj1A(object object_0)
	{
		return null;
	}

	internal static int Ui13JJvn4iLErdiMELQ(object object_0)
	{
		return 0;
	}

	internal static void e3hcFSv2ePJjYAtYJE8()
	{
	}

	internal static void Hu6tW5vwQ7uO1IRuhPD()
	{
	}
}
