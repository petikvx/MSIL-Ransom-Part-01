using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class Win32
{
	private struct Struct22
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct22(Rectangle rectangle_0)
		{
			try
			{
				int_0 = SimpleZip.Class7.smethod_2(ref rectangle_0, 286, 294);
				int_1 = Class40.smethod_4(ref rectangle_0, 97, 47);
				int_3 = Class33.smethod_4(ref rectangle_0, 1006, 909);
				int_2 = rectangle_0.Right;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, rectangle_0);
				throw;
			}
		}

		static Struct22()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	private struct Struct23
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

		static Struct23()
		{
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
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
			try
			{
				SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
	}

	private static bool bool_0;

	private static Struct23 struct23_0;

	[DllImport("shell32")]
	private static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	[DllImport("user32", CharSet = CharSet.Unicode)]
	private static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Struct22 struct22_0, int int_1);

	[DllImport("gdi32.dll")]
	private static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.Dll")]
	private static extern short GetVersionEx(ref Struct23 struct23_1);

	[DllImport("user32.dll")]
	private static extern int GetSystemMetrics(int int_0);

	[DllImport("kernel32.dll")]
	private static extern void GetSystemInfo(ref SYSTEM_INFO system_INFO_0);

	[SpecialName]
	private static Struct23 smethod_0()
	{
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		try
		{
			if (!bool_0)
			{
				num = 1;
				struct23_0 = default(Struct23);
				try
				{
					num2 = 2;
					struct23_0.int_0 = ReportExceptionEventArgs.smethod_1(SendingReportFeedbackEventArgs1.smethod_0(typeof(Struct23).TypeHandle, 421, 478), 207, 189);
					num2 = 0;
					GetVersionEx(ref struct23_0);
					bool_0 = true;
				}
				catch
				{
				}
			}
			num3 = 3;
			return struct23_0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, num2, num3);
			throw;
		}
	}

	[SpecialName]
	internal static bool smethod_1()
	{
		SYSTEM_INFO system_INFO_ = default(SYSTEM_INFO);
		bool flag = default(bool);
		try
		{
			try
			{
				system_INFO_ = default(SYSTEM_INFO);
				GetSystemInfo(ref system_INFO_);
				flag = system_INFO_.wProcessorArchitecture == 9;
				return flag;
			}
			catch
			{
				flag = false;
				return flag;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, system_INFO_, flag);
			throw;
		}
	}

	[SpecialName]
	internal static bool smethod_2()
	{
		bool flag = default(bool);
		try
		{
			try
			{
				flag = GetSystemMetrics(89) != 0;
				return flag;
			}
			catch
			{
				flag = false;
				return flag;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, flag);
			throw;
		}
	}

	[SpecialName]
	internal static bool smethod_3()
	{
		try
		{
			return smethod_0().byte_0 == 1;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException1(exception, num);
			throw;
		}
	}

	[SpecialName]
	internal static string smethod_4()
	{
		try
		{
			return smethod_0().string_0;
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException1(exception, num);
			throw;
		}
	}

	public static Icon GetApplicationIcon()
	{
		Icon val = default(Icon);
		try
		{
			try
			{
				val = smethod_5();
				return val;
			}
			catch (Exception)
			{
				val = Class22.smethod_1("default");
				return val;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, val);
			throw;
		}
	}

	private static Icon smethod_5()
	{
		int int_ = default(int);
		int int_2 = default(int);
		int num = default(int);
		int num2 = default(int);
		try
		{
			int_ = 0;
			int_2 = 0;
			num = ExtractIconEx(UsageCounts.smethod_5(63, 36), -1, ref int_2, ref int_2, 1);
			num2 = 7;
			if (num > 0)
			{
				num2 = 4;
				ExtractIconEx(UsageCounts.smethod_5(172, 183), 0, ref int_, ref int_2, 1);
				num2 = 0;
				if (int_ != 0)
				{
					num2 = 8;
					return Icon.FromHandle(new IntPtr(int_));
				}
				num2 = 3;
			}
			else
			{
				num2 = 3;
			}
			return null;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, int_, int_2, num, num2);
			throw;
		}
	}

	internal static int smethod_6(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		int num = default(int);
		int num2 = default(int);
		try
		{
			try
			{
				num = smethod_8(graphics_0, string_0, font_0, int_0);
				return num;
			}
			catch (Exception)
			{
				try
				{
					num = AutoHeightLabel.smethod_3((double)smethod_7(graphics_0, string_0, font_0, int_0) * 1.1, 795, 857);
					return num;
				}
				catch (Exception)
				{
				}
			}
			num2 = 1;
			return 0;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, num, num2, graphics_0, string_0, font_0, int_0);
			throw;
		}
	}

	private static int smethod_7(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		Size size = default(Size);
		int num = default(int);
		try
		{
			size = UsageReportSender.smethod_17(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_6(graphics_0, string_0, font_0, int_0, 463, 406), 794, 848);
			num = 0;
			return size.Height;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, size, num, graphics_0, string_0, font_0, int_0);
			throw;
		}
	}

	private static int smethod_8(Graphics graphics_0, string string_0, Font font_0, int int_0)
	{
		Struct22 struct22_ = default(Struct22);
		int num = default(int);
		int num2 = default(int);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		try
		{
			struct22_ = new Struct22(new Rectangle(0, 0, int_0, 10000));
			num = 3088;
			num2 = 0;
			intPtr = ReportSender1.smethod_7(graphics_0, 911, 947);
			intPtr2 = DoNotEncodeStringsAttribute.smethod_3(font_0, 445, 434);
			num2 = 2;
			intPtr3 = SelectObject(intPtr, intPtr2);
			DrawText(intPtr, string_0, -1, ref struct22_, 3088);
			num2 = 1;
			SelectObject(intPtr, intPtr3);
			AESCryptoIndirector.smethod_1(graphics_0, intPtr, 903, 997);
			num2 = 3;
			return struct22_.int_3 - struct22_.int_1;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException10(exception, struct22_, num, intPtr, intPtr2, intPtr3, num2, graphics_0, string_0, font_0, int_0);
			throw;
		}
	}

	public Win32()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static Win32()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static Stream smethod_9(Assembly assembly_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					return assembly_0.GetManifestResourceStream(string_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, assembly_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static long smethod_10(FileInfo fileInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 119:
					return fileInfo_0.Length;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, fileInfo_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_11(WebClientProtocol webClientProtocol_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 38:
					webClientProtocol_0.set_Url(string_0);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, webClientProtocol_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_12(CheckBox checkBox_0, EventHandler eventHandler_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					checkBox_0.add_CheckedChanged(eventHandler_0);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, checkBox_0, eventHandler_0, int_0, int_1);
			throw;
		}
	}

	internal static long smethod_13(ref IntPtr intptr_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 60:
					return intptr_0.ToInt64();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, intptr_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_14(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 93:
					return string_0.LastIndexOf(string_1);
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_15(Control control_0, Color color_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 3;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 82:
					control_0.set_BackColor(color_0);
					return;
				}
				num = 3;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, color_0, int_0, int_1);
			throw;
		}
	}

	internal static FieldInfo[] smethod_16(Type type_0, BindingFlags bindingFlags_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 2:
					return type_0.GetFields(bindingFlags_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, type_0, bindingFlags_0, int_0, int_1);
			throw;
		}
	}
}
