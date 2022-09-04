using System;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Attributes;
using SmartAssembly.License;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace ns0;

internal sealed class Class38 : UsageReporter
{
	internal static readonly string string_0;

	internal static readonly string string_1;

	private static bool? nullable_0;

	public static void smethod_0(uint uint_0)
	{
		Class38 @class = default(Class38);
		try
		{
			try
			{
				@class = new Class38();
				@class.RecordFeatureUsed(uint_0);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, @class, uint_0);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, @class, uint_0);
			throw;
		}
	}

	public static void smethod_1(string string_2)
	{
		Class38 @class = default(Class38);
		try
		{
			try
			{
				@class = new Class38();
				@class.RecordFeatureUsed(string_2);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, @class, string_2);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, @class, string_2);
			throw;
		}
	}

	protected override void ReportUsage(UsageReportSender sender)
	{
		try
		{
			try
			{
				sender.SendReport();
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, this, sender);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, this, sender);
			throw;
		}
	}

	protected override bool CanReportUsage()
	{
		bool flag = default(bool);
		try
		{
			try
			{
				flag = smethod_2();
				return flag;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException1(exception, this);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, flag, this);
			throw;
		}
	}

	private static bool smethod_2()
	{
		int num = default(int);
		bool value = default(bool);
		try
		{
			try
			{
				num = 5;
				if (!nullable_0.HasValue)
				{
					smethod_3();
				}
				value = nullable_0.Value;
				return value;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException0(exception);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException2(exception2, value, num);
			throw;
		}
	}

	private static void smethod_3()
	{
		int num = default(int);
		RegistryKey registryKey = default(RegistryKey);
		int num2 = default(int);
		string o = default(string);
		object obj = default(object);
		bool flag = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		try
		{
			try
			{
				num = 1;
				registryKey = null;
				try
				{
					try
					{
						num2 = 5;
						o = Class17.smethod_9("Software\\", string_1, "\\", string_0, 357, 301);
						num2 = 0;
						registryKey = SmartAssembly.SmartExceptionsCore.DoNotObfuscateAttribute.smethod_0(Registry.CurrentUser, o, 655, 690);
						obj = Form0.smethod_0(registryKey, "SmartAssemblyReportUsage", 224, 150);
						num2 = 1;
						if (obj != null)
						{
							nullable_0 = FatalExceptionEventArgs.smethod_0(obj, 604, 571);
							goto IL_00dc;
						}
						Class21.smethod_0(registryKey, "SmartAssemblyReportUsage", bool.FalseString, 775, 832);
						flag = smethod_4();
						num2 = 9;
						PoweredByAttribute.smethod_0(registryKey, "SmartAssemblyReportUsage", flag.ToString(), RegistryValueKind.String, 645, 715);
						num2 = 7;
						nullable_0 = flag;
					}
					catch
					{
						nullable_0 = false;
						goto IL_00dc;
					}
					goto end_IL_0005;
					IL_00dc:
					num3 = 2;
					end_IL_0005:;
				}
				finally
				{
					num4 = 5;
					registryKey?.Close();
				}
				num5 = 1;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException4(exception, registryKey, o, obj, flag);
				throw;
			}
			num6 = 1;
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException10(exception2, registryKey, o, obj, flag, num, num2, num3, num4, num5, num6);
			throw;
		}
	}

	private static bool smethod_4()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		ConfirmFeatureUsageReportingForm_1 confirmFeatureUsageReportingForm_ = default(ConfirmFeatureUsageReportingForm_1);
		bool flag = default(bool);
		int num = default(int);
		bool flag2 = default(bool);
		try
		{
			try
			{
				confirmFeatureUsageReportingForm_ = new ConfirmFeatureUsageReportingForm_1();
				try
				{
					License.smethod_2((Form)(object)confirmFeatureUsageReportingForm_, 576, 571);
					flag = (int)Class28.smethod_1((Form)(object)confirmFeatureUsageReportingForm_, 471, 435) == 6;
				}
				finally
				{
					num = 0;
					((IDisposable)(object)confirmFeatureUsageReportingForm_)?.Dispose();
				}
				flag2 = flag;
				return flag2;
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException2(exception, confirmFeatureUsageReportingForm_, flag);
				throw;
			}
		}
		catch (Exception exception2)
		{
			StackFrameHelper.CreateException4(exception2, confirmFeatureUsageReportingForm_, flag, flag2, num);
			throw;
		}
	}

	public Class38()
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

	static Class38()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
			try
			{
				string_0 = "server1";
				string_1 = "[Unknown company]";
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
}
