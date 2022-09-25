using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns6;

namespace ns8;

internal class Class55
{
	private struct Struct20
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct20(Rectangle rectangle_0)
		{
			int_0 = rectangle_0.Left;
			int_1 = rectangle_0.Top;
			int_3 = rectangle_0.Bottom;
			int_2 = rectangle_0.Right;
		}
	}

	private struct Struct21
	{
		public int int_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public byte byte_0;

		private byte byte_1;
	}

	internal struct Struct22
	{
		public ushort ushort_0;

		private ushort ushort_1;

		public uint uint_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	private static bool bool_0;

	private static Struct21 struct21_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct20 struct20_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct21 struct21_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref Struct22 struct22_0);

	[SpecialName]
	private static Struct21 smethod_0()
	{
		if (!bool_0)
		{
			struct21_0 = default(Struct21);
			try
			{
				struct21_0.int_0 = Marshal.SizeOf(typeof(Struct21));
				GetVersionEx(ref struct21_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
		return struct21_0;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		try
		{
			Struct22 struct22_ = default(Struct22);
			GetSystemInfo(ref struct22_);
			return struct22_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	[SpecialName]
	internal static bool smethod_2()
	{
		try
		{
			return GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	[SpecialName]
	internal static bool smethod_3()
	{
		return smethod_0().byte_0 == 1;
	}

	[SpecialName]
	internal static string smethod_4()
	{
		return smethod_0().string_0;
	}

	public static Icon smethod_5()
	{
		try
		{
			return smethod_6();
		}
		catch (Exception)
		{
			return Class49.smethod_1("default");
		}
	}

	private static Icon smethod_6()
	{
		int int_ = 0;
		int int_2 = 0;
		int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref int_, ref int_2, 1);
			if (int_ != 0)
			{
				return Icon.FromHandle(new IntPtr(int_));
			}
		}
		return null;
	}

	internal static int smethod_7(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		try
		{
			return smethod_9(graphics_0, string_0, font_0, int_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)smethod_8(graphics_0, string_0, font_0, int_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	private static int smethod_8(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	private static int smethod_9(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		Struct20 struct20_ = new Struct20(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct20_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct20_.int_3 - struct20_.int_1;
	}
}
