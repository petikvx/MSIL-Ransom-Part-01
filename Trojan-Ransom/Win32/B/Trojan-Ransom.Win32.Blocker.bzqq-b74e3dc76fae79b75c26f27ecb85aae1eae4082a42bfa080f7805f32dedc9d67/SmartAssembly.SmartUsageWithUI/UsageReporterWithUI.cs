using System;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartUsageWithUI;

internal class UsageReporterWithUI : UsageReporter1
{
	private const string SmartAssemblyReportUsageValue = "SmartAssemblyReportUsage";

	private const string FirstRunPlaceholder = "Unknown";

	internal static readonly string ApplicationName;

	internal static readonly string CompanyName;

	private static bool? s_CanSendReportThisSession;

	public static void FeatureUsed(uint featureId)
	{
		UsageReporterWithUI usageReporterWithUI = default(UsageReporterWithUI);
		try
		{
			usageReporterWithUI = new UsageReporterWithUI();
			usageReporterWithUI.RecordFeatureUsed(featureId);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, usageReporterWithUI, featureId);
			throw;
		}
	}

	public static void DynamicFeatureUsed(string featureName)
	{
		UsageReporterWithUI usageReporterWithUI = default(UsageReporterWithUI);
		try
		{
			usageReporterWithUI = new UsageReporterWithUI();
			usageReporterWithUI.RecordFeatureUsed(featureName);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, usageReporterWithUI, featureName);
			throw;
		}
	}

	protected override void ReportUsage(UsageReportSender1 sender)
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
			return CheckAgreedToUsageReports();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	private static bool CheckAgreedToUsageReports()
	{
		try
		{
			if (!s_CanSendReportThisSession.HasValue)
			{
				ChooseWhetherToSendReport();
			}
			return s_CanSendReportThisSession.Value;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static void ChooseWhetherToSendReport()
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
				text = "Software\\" + CompanyName + "\\" + ApplicationName;
				registryKey = Registry.CurrentUser.CreateSubKey(text);
				value = registryKey.GetValue("SmartAssemblyReportUsage");
				if (value == null)
				{
					registryKey.SetValue("SmartAssemblyReportUsage", bool.FalseString);
					flag = AskUserForReportUsageConfirm();
					registryKey.SetValue("SmartAssemblyReportUsage", flag.ToString(), RegistryValueKind.String);
					s_CanSendReportThisSession = flag;
				}
				else
				{
					s_CanSendReportThisSession = Convert.ToBoolean(value);
				}
			}
			catch
			{
				s_CanSendReportThisSession = false;
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

	private static bool AskUserForReportUsageConfirm()
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
				((IDisposable)confirmFeatureUsageReportingForm)?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, confirmFeatureUsageReportingForm, flag);
			throw;
		}
	}

	static UsageReporterWithUI()
	{
		try
		{
			ApplicationName = "server2";
			CompanyName = "[Unknown company]";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
