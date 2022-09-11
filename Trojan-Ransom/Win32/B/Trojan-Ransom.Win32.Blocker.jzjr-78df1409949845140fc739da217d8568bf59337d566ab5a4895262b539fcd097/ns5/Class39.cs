using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns5;

internal sealed class Class39
{
	private struct Struct10
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct10(Rectangle rectangle)
		{
			int_0 = rectangle.Left;
			int_1 = rectangle.Top;
			int_3 = rectangle.Bottom;
			int_2 = rectangle.Right;
		}
	}

	private struct Struct11
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

	public struct Struct12
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

	private static Struct11 struct11_0;

	private static Struct11 VersionInfo
	{
		get
		{
			if (!bool_0)
			{
				struct11_0 = default(Struct11);
				try
				{
					struct11_0.int_0 = Marshal.SizeOf(typeof(Struct11));
					GetVersionEx(ref struct11_0);
					bool_0 = true;
				}
				catch
				{
				}
			}
			return struct11_0;
		}
	}

	internal static bool IsX64
	{
		get
		{
			try
			{
				Struct12 struct12_ = default(Struct12);
				GetSystemInfo(ref struct12_);
				return struct12_.ushort_0 == 9;
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
	private static extern int ExtractIconEx(string string_0, int int_6, ref int int_7, ref int int_8, int int_9);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_6, ref Struct10 struct10_0, int int_7);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct11 struct11_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_6);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref Struct12 struct12_0);

	public static Icon smethod_0()
	{
		try
		{
			return smethod_1();
		}
		catch (Exception)
		{
			return Class32.smethod_1("default");
		}
	}

	private unsafe static Icon smethod_1()
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

	internal static int smethod_2(Graphics graphics_0, string string_0, Font font_0, int int_6)
	{
		try
		{
			return smethod_4(graphics_0, string_0, font_0, int_6);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)smethod_3(graphics_0, string_0, font_0, int_6) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	private static int smethod_3(Graphics graphics_0, string string_0, Font font_0, int int_6)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_6)).Height;
	}

	private static int smethod_4(Graphics graphics_0, string string_0, Font font_0, int int_6)
	{
		Struct10 struct10_ = new Struct10(new Rectangle(0, 0, int_6, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct10_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct10_.int_3 - struct10_.int_1;
	}
}
