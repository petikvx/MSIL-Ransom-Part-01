using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class Class32
{
	private struct Struct6
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct6(Rectangle rectangle_0)
		{
			Class52.KPUgGmhz2nAeI();
			int_0 = rectangle_0.Left;
			int_1 = rectangle_0.Top;
			int_3 = rectangle_0.Bottom;
			int_2 = rectangle_0.Right;
		}
	}

	private struct Struct7
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

	internal struct Struct8
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

	private static Struct7 struct7_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct6 struct6_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct7 struct7_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.Dll")]
	private static extern void GetSystemInfo(ref Struct8 struct8_0);

	[SpecialName]
	private static Struct7 smethod_0()
	{
		if (!bool_0)
		{
			struct7_0 = default(Struct7);
			try
			{
				struct7_0.int_0 = Marshal.SizeOf(typeof(Struct7));
				GetVersionEx(ref struct7_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
		return struct7_0;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		try
		{
			Struct8 struct8_ = default(Struct8);
			GetSystemInfo(ref struct8_);
			return struct8_.ushort_0 == 9;
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
			return Class24.smethod_1("default");
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
		Struct6 struct6_ = new Struct6(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct6_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct6_.int_3 - struct6_.int_1;
	}
}
