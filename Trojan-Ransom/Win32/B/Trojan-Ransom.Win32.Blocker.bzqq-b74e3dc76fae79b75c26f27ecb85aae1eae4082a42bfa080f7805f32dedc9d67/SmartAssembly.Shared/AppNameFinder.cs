using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Security.Policy;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.Shared;

public sealed class AppNameFinder
{
	public static string AppName
	{
		get
		{
			try
			{
				return HeaderControl.smethod_0(AppNameMinusVersion, " ", MajorVersion, 552, 550);
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}
	}

	public static int MajorVersion
	{
		get
		{
			Version version = default(Version);
			try
			{
				version = new Version("6.7.0.239");
				return UsageCounts.smethod_0(version, 40, 45);
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, version, num);
				throw;
			}
		}
	}

	public static string AppNameMinusVersion
	{
		get
		{
			try
			{
				return "SmartAssembly";
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException1(exception, num);
				throw;
			}
		}
	}

	private AppNameFinder()
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

	static AppNameFinder()
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

	internal static void smethod_0(ButtonBase buttonBase_0, bool bool_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 59:
					buttonBase_0.set_UseVisualStyleBackColor(bool_0);
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, buttonBase_0, bool_0, int_0, int_1);
			throw;
		}
	}

	internal static byte smethod_1(ref Color color_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 34:
					return color_0.R;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, color_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_2(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 70:
					return string_0.Contains(string_1);
				case 71:
					return string_0.StartsWith(string_1);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_0, string_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(BinaryWriter binaryWriter_0, ulong ulong_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 92:
					binaryWriter_0.Write(ulong_0);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, binaryWriter_0, ulong_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_4(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 102:
					return type_0.FullName;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}

	internal static Assembly smethod_5(byte[] byte_0, byte[] byte_1, Evidence evidence_0, int int_0, int int_1)
	{
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 71:
					return Assembly.Load(byte_0, byte_1, evidence_0);
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, byte_0, byte_1, evidence_0, int_0, int_1);
			throw;
		}
	}
}
