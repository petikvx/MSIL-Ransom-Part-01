using System;
using System.Runtime.InteropServices;
using ns1;

namespace ns0;

internal sealed class Class5
{
	public struct Struct2
	{
		public int int_0;

		public int int_1;

		public IntPtr intptr_0;

		public int int_2;
	}

	public struct Struct3
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	public struct Struct4
	{
		public Struct3 struct3_0;

		public Struct3 struct3_1;

		public Struct3 struct3_2;

		public IntPtr intptr_0;
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

	internal static byte[] smethod_0()
	{
		return MintToggleSwitch.smethod_0(Class3.smethod_0(), new byte[36]
		{
			2, 19, 3, 4, 10, 9, 20, 15, 8, 12,
			14, 7, 6, 5, 16, 11, 8, 13, 9, 20,
			2, 12, 15, 16, 5, 17, 4, 7, 1, 19,
			6, 3, 15, 2, 18, 12
		});
	}

	[DllImport("gdi32.dll")]
	public static extern IntPtr AddFontMemResourceEx(IntPtr intptr_0, int int_15, IntPtr intptr_1, ref int int_16);

	[DllImport("user32.dll")]
	public static extern bool AnimateWindow(IntPtr intptr_0, int int_15, int int_16);

	[DllImport("user32.dll")]
	public static extern bool GetClientRect(IntPtr intptr_0, ref Struct3 struct3_0);

	[DllImport("user32.dll")]
	public static extern IntPtr GetWindowDC(IntPtr intptr_0);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr intptr_0, ref Struct3 struct3_0);

	[DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
	public static extern int SetWindowTheme(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("user32.dll")]
	public static extern bool TrackMouseEvent(ref Struct2 struct2_0);
}
