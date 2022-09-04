using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Shared;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class Win32
{
	private struct Struct12
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct12(Rectangle rectangle_0)
		{
			int_0 = UsageReportSender.smethod_4(ref rectangle_0, 679, 715);
			int_1 = rectangle_0.Top;
			int_3 = rectangle_0.Bottom;
			int_2 = rectangle_0.Right;
		}

		[SecuritySafeCritical]
		static Struct12()
		{
			Class32.smethod_1();
		}
	}

	private struct Struct13
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

		[SecuritySafeCritical]
		static Struct13()
		{
			Class32.smethod_1();
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

		[SecuritySafeCritical]
		static SYSTEM_INFO()
		{
			Class32.smethod_1();
		}
	}

	private static bool bool_0;

	private static Struct13 struct13_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct12 struct12_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct13 struct13_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref SYSTEM_INFO system_INFO_0);

	[SpecialName]
	private static Struct13 smethod_0()
	{
		if (!bool_0)
		{
			struct13_0 = default(Struct13);
			try
			{
				struct13_0.int_0 = Marshal.SizeOf(Class26.smethod_1(typeof(Struct13).TypeHandle, 166, 130));
				GetVersionEx(ref struct13_0);
				bool_0 = true;
			}
			catch
			{
			}
		}
		return struct13_0;
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
			return Class21.smethod_1("default");
		}
	}

	private static Icon smethod_5()
	{
		int int_ = 0;
		int int_2 = 0;
		int num = ExtractIconEx(AppNameFinder.smethod_0(179, 145), -1, ref int_2, ref int_2, 1);
		if (num > 0)
		{
			ExtractIconEx(AppNameFinder.smethod_0(714, 744), 0, ref int_, ref int_2, 1);
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
		Struct12 struct12_ = new Struct12(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = SendingReportFeedbackEventArgs1.smethod_1(font_0, 884, 866);
		IntPtr intptr_2 = SelectObject(hdc, intptr_);
		DrawText(hdc, string_0, -1, ref struct12_, 3088);
		SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct12_.int_3 - struct12_.int_1;
	}

	[SecuritySafeCritical]
	static Win32()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static Process smethod_9(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 96:
				return Process.GetCurrentProcess();
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_10(Form form_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 104:
				Application.Run(form_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_11(object object_0, object object_1, object object_2, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return string.Concat(object_0, object_1, object_2);
			}
		}
	}

	[SecuritySafeCritical]
	internal static object smethod_12(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 75:
				return registryKey_0.GetValue(string_0, object_0);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_13(MemberInfo memberInfo_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 70:
				return memberInfo_0.Name;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_14(StackTrace stackTrace_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 38:
				return stackTrace_0.FrameCount;
			}
		}
	}
}
