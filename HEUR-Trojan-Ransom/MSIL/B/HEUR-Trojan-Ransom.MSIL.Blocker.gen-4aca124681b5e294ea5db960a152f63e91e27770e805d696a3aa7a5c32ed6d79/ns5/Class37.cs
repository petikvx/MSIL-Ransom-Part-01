using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns4;

namespace ns5;

internal sealed class Class37
{
	private struct Struct11
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct11(Rectangle rectangle_0)
		{
			int_0 = rectangle_0.Left;
			int_1 = rectangle_0.Top;
			int_3 = rectangle_0.Bottom;
			int_2 = rectangle_0.Right;
		}
	}

	private struct Struct12
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

	private static bool bool_0;

	private static Struct12 struct12_0;

	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, out IntPtr intptr_0, out IntPtr intptr_1, int int_1);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct11 struct11_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct12 struct12_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[SpecialName]
	private static Struct12 smethod_0()
	{
		if (!bool_0)
		{
			struct12_0 = default(Struct12);
			try
			{
				struct12_0.int_0 = Marshal.SizeOf(typeof(Struct12));
				GetVersionEx(ref struct12_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
		return struct12_0;
	}

	[SpecialName]
	internal static bool smethod_1()
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
	internal static bool smethod_2()
	{
		return smethod_0().byte_0 == 1;
	}

	[SpecialName]
	internal static string smethod_3()
	{
		return smethod_0().string_0;
	}

	public static Icon smethod_4()
	{
		try
		{
			return smethod_5();
		}
		catch (Exception)
		{
			return Class32.smethod_1(getString_0(107387393));
		}
	}

	private static Icon smethod_5()
	{
		IntPtr intptr_ = IntPtr.Zero;
		IntPtr intptr_2 = IntPtr.Zero;
		if (ExtractIconEx(Application.get_ExecutablePath(), -1, out intptr_2, out intptr_2, 1) > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, out intptr_, out intptr_2, 1);
			if (intptr_ != IntPtr.Zero)
			{
				return Icon.FromHandle(intptr_);
			}
		}
		return null;
	}

	internal static int smethod_6(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		try
		{
			return smethod_8(graphics_0, string_0, font_0, int_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)smethod_7(graphics_0, string_0, font_0, int_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	private static int smethod_7(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	private static int smethod_8(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		Struct11 struct11_ = new Struct11(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct11_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct11_.int_3 - struct11_.int_1;
	}

	static Class37()
	{
		Strings.CreateGetStringDelegate(typeof(Class37));
	}
}
