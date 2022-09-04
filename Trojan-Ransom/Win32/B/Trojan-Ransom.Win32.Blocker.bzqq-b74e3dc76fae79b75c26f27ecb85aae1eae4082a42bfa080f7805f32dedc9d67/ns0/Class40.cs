using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class40
{
	public static Bitmap smethod_0(string string_0)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		Stream stream = default(Stream);
		Bitmap val = default(Bitmap);
		int num2 = default(int);
		Bitmap val2 = default(Bitmap);
		int num3 = default(int);
		try
		{
			try
			{
				try
				{
					num = 5;
					stream = Win32.smethod_9(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_1(673, 713), SendingReportFeedbackEventArgs1.smethod_3("SmartAssembly.SmartUsageWithUI.Resources.", string_0, ".png", 353, 349), 662, 760);
					num = 0;
					val = ((stream == null) ? ((Bitmap)null) : new Bitmap(stream));
				}
				catch
				{
					val = null;
				}
				num2 = 4;
				val2 = val;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, stream, val, string_0);
				throw;
			}
			num3 = 3;
			return val2;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException7(exception2, stream, val, val2, num, num2, num3, string_0);
			throw;
		}
	}

	public Class40()
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

	static Class40()
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

	internal static int smethod_1(int int_0, int int_1, int int_2, int int_3)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 88:
					return Math.Max(int_0, int_1);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, int_0, int_1, int_2, int_3);
			throw;
		}
	}

	internal static int smethod_2(ref DateTime dateTime_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					return dateTime_0.Month;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, dateTime_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_3(StackTrace stackTrace_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 15:
					return stackTrace_0.FrameCount;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, stackTrace_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_4(ref Rectangle rectangle_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 78:
					return rectangle_0.Top;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, rectangle_0, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_5(string string_0, int int_0, int int_1, int int_2)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_2 ^ int_1)
				{
				case 93:
					return string_0.Remove(int_0);
				case 94:
					return string_0.Substring(int_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_0, int_0, int_1, int_2);
			throw;
		}
	}

	internal static ulong smethod_6(BinaryReader binaryReader_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 79:
					return binaryReader_0.ReadUInt64();
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, binaryReader_0, int_0, int_1);
			throw;
		}
	}
}
