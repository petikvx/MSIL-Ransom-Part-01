using System;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;

namespace ns0;

internal sealed class Class35 : UsageReporter
{
	internal static readonly string string_0;

	internal static readonly string string_1;

	private static bool? nullable_0;

	public static void smethod_0(uint uint_0)
	{
		Class35 @class = default(Class35);
		try
		{
			@class = new Class35();
			@class.RecordFeatureUsed(uint_0);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, @class, uint_0);
			throw;
		}
	}

	public static void smethod_1(string string_2)
	{
		Class35 @class = default(Class35);
		try
		{
			@class = new Class35();
			@class.RecordFeatureUsed(string_2);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, @class, string_2);
			throw;
		}
	}

	protected override void ReportUsage(UsageReportSender sender)
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

	protected override bool CanReportUsage()
	{
		try
		{
			return smethod_2();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	private static bool smethod_2()
	{
		try
		{
			if (!nullable_0.HasValue)
			{
				smethod_3();
			}
			return nullable_0.Value;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static void smethod_3()
	{
		RegistryKey registryKey = default(RegistryKey);
		string text = default(string);
		object value = default(object);
		bool flag = default(bool);
		try
		{
			registryKey = null;
			try
			{
				text = "Software\\" + string_1 + "\\" + string_0;
				registryKey = Registry.CurrentUser.CreateSubKey(text);
				value = registryKey.GetValue("SmartAssemblyReportUsage");
				if (value == null)
				{
					registryKey.SetValue("SmartAssemblyReportUsage", bool.FalseString);
					flag = smethod_4();
					registryKey.SetValue("SmartAssemblyReportUsage", flag.ToString(), RegistryValueKind.String);
					nullable_0 = flag;
				}
				else
				{
					nullable_0 = Convert.ToBoolean(value);
				}
			}
			catch
			{
				nullable_0 = false;
			}
			finally
			{
				registryKey?.Close();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, registryKey, text, value, flag);
			throw;
		}
	}

	private static bool smethod_4()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		ConfirmFeatureUsageReportingForm confirmFeatureUsageReportingForm = default(ConfirmFeatureUsageReportingForm);
		bool flag = default(bool);
		try
		{
			confirmFeatureUsageReportingForm = new ConfirmFeatureUsageReportingForm();
			try
			{
				((Form)confirmFeatureUsageReportingForm).ShowDialog();
				flag = (int)((Form)confirmFeatureUsageReportingForm).get_DialogResult() == 6;
				return flag;
			}
			finally
			{
				((IDisposable)(object)confirmFeatureUsageReportingForm)?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, confirmFeatureUsageReportingForm, flag);
			throw;
		}
	}

	static Class35()
	{
		DESCryptoIndirector.smethod_0();
		try
		{
			string_0 = "Nc0j6W1Ag";
			string_1 = "x3S5NtHe";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
