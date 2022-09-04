using System;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartUsageCore;

namespace SmartAssembly.SmartUsageWithUI;

internal class UsageReporterWithUI : UsageReporter
{
	private const string SmartAssemblyReportUsageValue = "SmartAssemblyReportUsage";

	private const string FirstRunPlaceholder = "Unknown";

	internal static readonly string ApplicationName = "Kaspersky Internet Security 2016";

	internal static readonly string CompanyName = "Kaspersky Internet Security 2016";

	private static bool? s_CanSendReportThisSession;

	public static void FeatureUsed(uint featureId)
	{
		UsageReporterWithUI usageReporterWithUI = new UsageReporterWithUI();
		usageReporterWithUI.RecordFeatureUsed(featureId);
	}

	public static void DynamicFeatureUsed(string featureName)
	{
		UsageReporterWithUI usageReporterWithUI = new UsageReporterWithUI();
		usageReporterWithUI.RecordFeatureUsed(featureName);
	}

	protected override void ReportUsage(UsageReportSender sender)
	{
		sender.SendReport();
	}

	protected override bool CanReportUsage()
	{
		return CheckAgreedToUsageReports();
	}

	private static bool CheckAgreedToUsageReports()
	{
		if (!s_CanSendReportThisSession.HasValue)
		{
			ChooseWhetherToSendReport();
		}
		return s_CanSendReportThisSession.Value;
	}

	private static void ChooseWhetherToSendReport()
	{
		RegistryKey registryKey = null;
		try
		{
			string subkey = "Software\\" + CompanyName + "\\" + ApplicationName;
			registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			object value = registryKey.GetValue("SmartAssemblyReportUsage");
			if (value == null)
			{
				registryKey.SetValue("SmartAssemblyReportUsage", bool.FalseString);
				bool value2 = AskUserForReportUsageConfirm();
				registryKey.SetValue("SmartAssemblyReportUsage", value2.ToString(), RegistryValueKind.String);
				s_CanSendReportThisSession = value2;
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

	private static bool AskUserForReportUsageConfirm()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		ConfirmFeatureUsageReportingForm confirmFeatureUsageReportingForm = new ConfirmFeatureUsageReportingForm();
		try
		{
			((Form)confirmFeatureUsageReportingForm).ShowDialog();
			return (int)((Form)confirmFeatureUsageReportingForm).get_DialogResult() == 6;
		}
		finally
		{
			((IDisposable)confirmFeatureUsageReportingForm)?.Dispose();
		}
	}
}
