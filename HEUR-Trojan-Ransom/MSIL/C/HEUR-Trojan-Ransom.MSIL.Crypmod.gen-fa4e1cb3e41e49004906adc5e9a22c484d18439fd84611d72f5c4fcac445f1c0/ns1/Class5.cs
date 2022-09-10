using System;
using System.Runtime.InteropServices;

namespace ns1;

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
}
