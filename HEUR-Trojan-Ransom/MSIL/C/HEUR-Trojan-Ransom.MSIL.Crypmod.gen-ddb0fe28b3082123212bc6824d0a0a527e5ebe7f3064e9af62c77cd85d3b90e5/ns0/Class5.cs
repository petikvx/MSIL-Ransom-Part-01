using System;
using System.Runtime.InteropServices;
using ns1;

namespace ns0;

internal sealed class Class5
{
	public struct Struct1
	{
		public int int_0;

		public int int_1;

		public IntPtr intptr_0;

		public int int_2;
	}

	public struct Struct2
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	public struct Struct3
	{
		public Struct2 struct2_0;

		public Struct2 struct2_1;

		public Struct2 struct2_2;

		public IntPtr intptr_0;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 40)]
	private struct Struct4
	{
	}

	public const int int_0 = 6;

	public const int int_1 = 131;

	public const int int_2 = 132;

	public const int int_3 = 133;

	public const int int_4 = 160;

	public const int int_5 = 161;

	public const int int_6 = 162;

	public const int int_7 = 163;

	public const int int_8 = 174;

	public const int int_9 = 175;

	public const int int_10 = 674;

	public const int int_11 = 675;

	public const int int_12 = 4;

	public const int int_13 = 8;

	public const int int_14 = 65536;

	private static readonly Array array_0;

	private static readonly object object_0 = new char[20];

	private static readonly Array array_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static byte[] smethod_0()
	{
		return MintToggleSwitch.smethod_0(Class3.smethod_0(), new byte[36]
		{
			126, 232, 6, 209, 229, 197, 124, 250, 162, 222,
			107, 16, 192, 120, 152, 191, 252, 7, 139, 2,
			111, 115, 27, 216, 212, 73, 156, 71, 227, 206,
			172, 65, 118, 40, 171, 70
		});
	}

	[DllImport("gdi32.dll")]
	public static extern IntPtr AddFontMemResourceEx(IntPtr intptr_0, int int_15, IntPtr intptr_1, ref int int_16);

	[DllImport("user32.dll")]
	public static extern bool AnimateWindow(IntPtr intptr_0, int int_15, int int_16);

	[DllImport("user32.dll")]
	public static extern bool GetClientRect(IntPtr intptr_0, ref Struct2 struct2_0);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr intptr_0, ref Struct2 struct2_0);

	[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("user32.dll")]
	public static extern bool TrackMouseEvent(ref Struct1 struct1_0);

	static Class5()
	{
		char[] array = new char[8];
		array[2] = '➰';
		array[7] = '㽂';
		array[1] = '㳹';
		array[3] = '⣪';
		array[4] = 'リ';
		array[5] = 'ᓦ';
		array[6] = '\u1a79';
		array[0] = 'ⳁ';
		array_1 = new string[2];
		array_0 = array;
	}
}
