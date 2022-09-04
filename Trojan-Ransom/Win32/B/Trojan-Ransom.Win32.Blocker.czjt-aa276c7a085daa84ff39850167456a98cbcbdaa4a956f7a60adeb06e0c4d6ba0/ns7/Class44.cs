using System;
using Microsoft.Win32;
using ns3;
using ns5;
using ns9;

namespace ns7;

internal class Class44 : Class43
{
	internal static readonly string string_0 = "gMpc7UzuH9";

	internal static readonly string string_1 = "gMpc7UzuH9";

	internal static bool? nullable_0;

	protected override void vmethod_0(Class33 class33_0)
	{
		Class24.smethod_21(class33_0);
	}

	protected override bool vmethod_1()
	{
		return Class24.smethod_25();
	}

	internal static void smethod_0()
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
				bool value2 = Class24.smethod_134();
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
}
