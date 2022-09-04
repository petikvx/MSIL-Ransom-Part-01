using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns2;

namespace SmartAssembly.SmartExceptionsCore;

public sealed class Win32
{
	private struct Struct4
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct4(Rectangle rectangle_0)
		{
			int_0 = rectangle_0.Left;
			int_1 = rectangle_0.Top;
			int_3 = rectangle_0.Bottom;
			int_2 = rectangle_0.Right;
		}
	}

	private struct Struct5
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

	public struct SYSTEM_INFO
	{
		public ushort wProcessorArchitecture;

		private ushort ushort_0;

		public uint dwPageSize;

		public IntPtr lpMinimumApplicationAddress;

		public IntPtr lpMaximumApplicationAddress;

		public IntPtr dwActiveProcessorMask;

		public uint dwNumberOfProcessors;

		public uint dwProcessorType;

		public uint dwAllocationGranularity;

		public ushort wProcessorLevel;

		public ushort wProcessorRevision;
	}

	[NonSerialized]
	internal static GetString getString_0;

	private static bool bool_0;

	private static Struct5 struct5_0;

	static Win32()
	{
		Strings.CreateGetStringDelegate(typeof(Win32));
	}

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct4 struct4_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct5 struct5_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.Dll")]
	private static extern void GetSystemInfo(ref SYSTEM_INFO system_INFO_0);

	[SpecialName]
	private static Struct5 smethod_0()
	{
		if (!bool_0)
		{
			struct5_0 = default(Struct5);
			try
			{
				struct5_0.int_0 = Marshal.SizeOf(typeof(Struct5));
				GetVersionEx(ref struct5_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
		return struct5_0;
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		try
		{
			SYSTEM_INFO system_INFO_ = default(SYSTEM_INFO);
			GetSystemInfo(ref system_INFO_);
			return system_INFO_.wProcessorArchitecture == 9;
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

	public static Icon GetApplicationIcon()
	{
		try
		{
			return smethod_5();
		}
		catch (Exception)
		{
			return Class12.smethod_1(getString_0(4060));
		}
	}

	private static Icon smethod_5()
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
		Struct4 struct4_ = new Struct4(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct4_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct4_.int_3 - struct4_.int_1;
	}
}
