using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns4;

namespace ns7;

internal sealed class Class35
{
	private struct Struct18
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct18(Rectangle rectangle)
		{
			int_0 = rectangle.Left;
			int_1 = rectangle.Top;
			int_3 = rectangle.Bottom;
			int_2 = rectangle.Right;
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

	private const int int_0 = 16;

	private const int int_1 = 1024;

	private const int int_2 = 2048;

	private const int int_3 = 1;

	private const int int_4 = 89;

	private const int int_5 = 9;

	private static bool bool_0;

	private static Struct19 struct19_0;

	private static Struct19 VersionInfo
	{
		get
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
	}

	internal static bool IsX64
	{
		get
		{
			try
			{
				Struct20 lpSystemInfo = default(Struct20);
				GetSystemInfo(ref lpSystemInfo);
				return lpSystemInfo.ushort_0 == 9;
			}
			catch
			{
				return false;
			}
		}
	}

	internal static bool IsServerR2
	{
		get
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
	}

	internal static bool IsWorkstation => VersionInfo.byte_0 == 1;

	internal static string ServicePack => VersionInfo.string_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string lpszFile, int nIconIndex, ref int phiconLarge, ref int phiconSmall, int nIcons);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr hDC, string text, int textLength, ref Struct18 lpRect, int format);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr hDC, IntPtr hGdiObj);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct19 o);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int smIndex);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref Struct20 lpSystemInfo);

	public static Icon smethod_0()
	{
		try
		{
			return smethod_1();
		}
		catch (Exception)
		{
			return Class28.smethod_1("default");
		}
	}

	private static Icon smethod_1()
	{
		int phiconLarge = 0;
		int phiconLarge2 = 0;
		int num = ExtractIconEx(Application.get_ExecutablePath(), -1, ref phiconLarge2, ref phiconLarge2, 1);
		if (num > 0)
		{
			ExtractIconEx(Application.get_ExecutablePath(), 0, ref phiconLarge, ref phiconLarge2, 1);
			if (phiconLarge != 0)
			{
				return Icon.FromHandle(new IntPtr(phiconLarge));
			}
		}
		return null;
	}

	internal static int smethod_2(Graphics graphics, string text, Font font, int width)
	{
		try
		{
			return smethod_4(graphics, text, font, width);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)smethod_3(graphics, text, font, width) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	private static int smethod_3(Graphics graphics, string text, Font font, int width)
	{
		return Size.Ceiling(graphics.MeasureString(text, font, width)).Height;
	}

	private static int smethod_4(Graphics graphics, string text, Font font, int width)
	{
		Struct18 lpRect = new Struct18(new Rectangle(0, 0, width, 10000));
		IntPtr hdc = graphics.GetHdc();
		IntPtr hGdiObj = font.ToHfont();
		IntPtr hGdiObj2 = SelectObject(hdc, hGdiObj);
		DrawText(hdc, text, -1, ref lpRect, 3088);
		SelectObject(hdc, hGdiObj2);
		graphics.ReleaseHdc(hdc);
		return lpRect.int_3 - lpRect.int_1;
	}
}
