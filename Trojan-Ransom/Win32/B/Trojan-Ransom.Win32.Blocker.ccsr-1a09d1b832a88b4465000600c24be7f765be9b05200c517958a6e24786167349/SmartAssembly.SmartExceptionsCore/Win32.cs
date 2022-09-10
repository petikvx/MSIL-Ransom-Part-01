using System;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.SmartExceptionsWithUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class Win32
{
	private struct Struct23
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct23(Rectangle rectangle_0)
		{
			int_0 = UsageReportSender.smethod_2(ref rectangle_0, 864, 784);
			int_1 = Class32.smethod_1(ref rectangle_0, 390, 442);
			int_3 = rectangle_0.Bottom;
			int_2 = rectangle_0.Right;
		}

		static Struct23()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	private struct Struct24
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

		internal byte byte_1;

		static Struct24()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	public struct SYSTEM_INFO
	{
		public ushort wProcessorArchitecture;

		public uint dwPageSize;

		public IntPtr lpMinimumApplicationAddress;

		public IntPtr lpMaximumApplicationAddress;

		public IntPtr dwActiveProcessorMask;

		public uint dwNumberOfProcessors;

		public uint dwProcessorType;

		public uint dwAllocationGranularity;

		public ushort wProcessorLevel;

		public ushort wProcessorRevision;

		internal ushort ushort_0;

		static SYSTEM_INFO()
		{
			DESCryptoIndirector.smethod_0();
		}
	}

	private static bool bool_0;

	private static Struct24 struct24_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct23 struct23_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct24 struct24_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref SYSTEM_INFO system_INFO_0);

	[SpecialName]
	private static Struct24 smethod_0()
	{
		if (!bool_0)
		{
			struct24_0 = default(Struct24);
			try
			{
				struct24_0.int_0 = SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_2(DoNotEncodeStringsAttribute.smethod_0(typeof(Struct24).TypeHandle, 554, 627), 96, 110);
				GetVersionEx(ref struct24_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
		return struct24_0;
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
			return Class19.smethod_1("default");
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
				return ReportSender1.smethod_1((double)smethod_7(graphics_0, string_0, font_0, int_0) * 1.1, 74, 102);
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
		Struct23 struct23_ = new Struct23(new Rectangle(0, 0, int_0, 10000));
		IntPtr intptr_ = Class29.smethod_2(graphics_0, 305, 326);
		IntPtr intptr_2 = Class37.smethod_2(font_0, 791, 813);
		IntPtr intptr_3 = SelectObject(intptr_, intptr_2);
		DrawText(intptr_, string_0, -1, ref struct23_, 3088);
		SelectObject(intptr_, intptr_3);
		UnhandledExceptionHandlerWithUI.smethod_3(graphics_0, intptr_, 320, 307);
		return struct23_.int_3 - struct23_.int_1;
	}

	static Win32()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static bool smethod_9(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 24:
				return string_0.StartsWith(string_1);
			}
		}
	}

	internal static string smethod_10(Exception exception_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 117:
				return exception_0.StackTrace;
			case 118:
				return exception_0.ToString();
			}
		}
	}

	internal static void smethod_11(SymmetricAlgorithm symmetricAlgorithm_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 29:
				symmetricAlgorithm_0.GenerateIV();
				return;
			}
		}
	}

	internal static byte[] smethod_12(Encoding encoding_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 110:
				return encoding_0.GetBytes(string_0);
			}
		}
	}

	internal static char smethod_13(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 109:
				return Conversions.ToChar(string_0);
			}
		}
	}

	internal static byte[] smethod_14(MemoryStream memoryStream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 3:
				return memoryStream_0.ToArray();
			}
		}
	}
}
