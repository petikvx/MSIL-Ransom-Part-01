using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns7;

namespace ns4;

internal class Class40
{
	private struct Struct18
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct18(Rectangle rectangle_0)
		{
			int_0 = rectangle_0.Left;
			int_1 = rectangle_0.Top;
			int_3 = rectangle_0.Bottom;
			int_2 = rectangle_0.Right;
		}
	}

	private struct Struct19
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

	public struct Struct20
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

	private static Struct19 struct19_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct18 struct18_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct19 struct19_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref Struct20 struct20_0);

	[SpecialName]
	private static Struct19 smethod_0()
	{
		if (!bool_0)
		{
			struct19_0 = default(Struct19);
			try
			{
				struct19_0.int_0 = Marshal.SizeOf(typeof(Struct19));
				GetVersionEx(ref struct19_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
		return struct19_0;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		try
		{
			Struct20 struct20_ = default(Struct20);
			GetSystemInfo(ref struct20_);
			return struct20_.ushort_0 == 9;
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
			return Class34.smethod_1("default");
		}
	}

	private unsafe static Icon smethod_6()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		*(int*)((byte*)ptr + 8) = ExtractIconEx(Application.get_ExecutablePath(), -1, ref *(int*)((byte*)ptr + 4), ref *(int*)((byte*)ptr + 4), 1);
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref *(int*)ptr, ref *(int*)((byte*)ptr + 4), 1);
			if (*(int*)ptr != 0)
			{
				return Icon.FromHandle(new IntPtr(*(int*)ptr));
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
		Struct18 struct18_ = new Struct18(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct18_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct18_.int_3 - struct18_.int_1;
	}
}
