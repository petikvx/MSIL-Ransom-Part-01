using System;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.License;

public class License
{
	public static bool Validate()
	{
		bool flag = default(bool);
		try
		{
			try
			{
				flag = smethod_0();
				return flag;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException1(exception2, flag);
			throw;
		}
	}

	public static void ValidateDLL()
	{
		try
		{
			try
			{
				smethod_0();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException0(exception2);
			throw;
		}
	}

	private static bool smethod_0()
	{
		int num = default(int);
		DateTime dateTime_ = default(DateTime);
		bool flag = default(bool);
		try
		{
			try
			{
				num = 4;
				dateTime_ = DoNotObfuscateTypeAttribute.smethod_0("2013-08-15T05:46:54", 27, 11);
				if (!SimpleZip.Class15.smethod_1(UsageReportSender.smethod_9(718, 732), dateTime_, 672, 679))
				{
					num = 5;
					if (!SecurityExceptionEventArgs.smethod_0(UsageReportSender.smethod_9(130, 144), DoNotEncodeStringsAttribute.smethod_0(ref dateTime_, -21.0, 248, 133), 139, 150))
					{
						num = 2;
						if (Class4.smethod_0() == null)
						{
							try
							{
								smethod_1();
							}
							catch
							{
							}
						}
						flag = true;
						return flag;
					}
					num = 1;
				}
				else
				{
					num = 1;
				}
				throw new Exception("This assembly has been built with an evaluation version of SmartAssembly, which has expired.");
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, dateTime_);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException3(exception2, dateTime_, flag, num);
			throw;
		}
	}

	private static void smethod_1()
	{
		try
		{
			try
			{
				Class2.smethod_8("This assembly has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed.", 550, 557);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException0(exception2);
			throw;
		}
	}

	public License()
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

	static License()
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

	internal static DialogResult smethod_2(Form form_0, int int_0, int int_1)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 123:
					return form_0.ShowDialog();
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, form_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_3(Control control_0, Padding padding_0, int int_0, int int_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 108:
					control_0.set_Padding(padding_0);
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, padding_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_4(Control control_0, string string_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 1;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 87:
					control_0.set_Text(string_0);
					return;
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, control_0, string_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_5(float float_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 20:
					return Convert.ToInt32(float_0);
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, float_0, int_0, int_1);
			throw;
		}
	}

	internal static bool smethod_6(string string_0, string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 45:
					return string_0.EndsWith(string_1);
				case 46:
					return string_0 != string_1;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_0, string_1, int_0, int_1);
			throw;
		}
	}
}
