using System;
using System.Windows.Forms;
using Microsoft.Win32;
using ns5;
using ns7;
using ns8;

namespace ns9;

internal sealed class Class48 : Class47
{
	internal static readonly string string_0 = "BOMBS";

	internal static readonly string string_1 = "[Unknown company]";

	private static bool? nullable_0;

	public static void smethod_0(uint uint_0)
	{
		Class48 @class = new Class48();
		@class.method_0(uint_0);
	}

	public static void smethod_1(string string_2)
	{
		Class48 @class = new Class48();
		@class.method_1(string_2);
	}

	protected override void vmethod_0(Class37 class37_0)
	{
		class37_0.method_6();
	}

	protected override bool vmethod_1()
	{
		return smethod_2();
	}

	private static bool smethod_2()
	{
		if (!nullable_0.HasValue)
		{
			smethod_3();
		}
		return nullable_0.Value;
	}

	private static void smethod_3()
	{
		RegistryKey registryKey = null;
		try
		{
			string subkey = "Software\\" + string_1 + "\\" + string_0;
			registryKey = Registry.CurrentUser.CreateSubKey(subkey);
			object value = registryKey.GetValue("SmartAssemblyReportUsage");
			if (value == null)
			{
				registryKey.SetValue("SmartAssemblyReportUsage", bool.FalseString);
				bool value2 = smethod_4();
				registryKey.SetValue("SmartAssemblyReportUsage", value2.ToString(), RegistryValueKind.String);
				nullable_0 = value2;
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

	private static bool smethod_4()
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
			((IDisposable)(object)confirmFeatureUsageReportingForm)?.Dispose();
		}
	}
}
