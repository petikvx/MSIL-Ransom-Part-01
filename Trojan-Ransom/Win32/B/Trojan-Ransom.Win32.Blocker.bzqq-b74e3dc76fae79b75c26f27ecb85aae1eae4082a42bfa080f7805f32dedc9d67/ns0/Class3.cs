using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsCore.UI;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class3
{
	[SpecialName]
	public static string smethod_0()
	{
		string text = default(string);
		try
		{
			try
			{
				text = HeaderControl.smethod_0(smethod_2(), " ", smethod_1(), 200, 198);
				return text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, text);
			throw;
		}
	}

	[SpecialName]
	public static int smethod_1()
	{
		Version version = default(Version);
		int num = default(int);
		try
		{
			try
			{
				version = new Version("6.7.0.103");
				num = UsageCounts.smethod_0(version, 500, 497);
				return num;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, version);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, version, num);
			throw;
		}
	}

	[SpecialName]
	public static string smethod_2()
	{
		string text = default(string);
		try
		{
			try
			{
				text = "SmartAssembly";
				return text;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, text);
			throw;
		}
	}

	static Class3()
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

	internal static MethodInfo smethod_3(PropertyInfo propertyInfo_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 95:
					return propertyInfo_0.GetSetMethod();
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, propertyInfo_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_4(int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 117:
					return Math.Min(int_0, int_1);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static int smethod_5(Stream stream_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 94:
					return stream_0.ReadByte();
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, stream_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_6(string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 4:
					return Directory.Exists(string_0);
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_7(ref ushort ushort_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 8:
					return ushort_0.ToString(string_0);
				}
				num = 7;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, ushort_0, string_0, int_0, int_1);
			throw;
		}
	}
}
