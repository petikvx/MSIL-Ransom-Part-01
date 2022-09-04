using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.Shared;

public sealed class AppRegistryKeys
{
	public static string SubkeyApplication => Class35.smethod_8("Software\\Red Gate\\", AppNameFinder.AppName, 185, 215);

	public static string WowSubkeyApplication => Class35.smethod_8("Software\\Wow6432Node\\Red Gate\\", AppNameFinder.AppName, 922, 1012);

	public static object GetRegistryEntry(string valueName, object defaultValue)
	{
		using RegistryKey registryKey = DoNotObfuscateAttribute.smethod_0(Registry.LocalMachine, SubkeyApplication, 705, 712);
		if (registryKey == null)
		{
			return defaultValue;
		}
		return Win32.smethod_12(registryKey, valueName, defaultValue, 603, 528);
	}

	private AppRegistryKeys()
	{
	}

	[SecuritySafeCritical]
	static AppRegistryKeys()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				control_0.SuspendLayout();
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(ButtonBase buttonBase_0, FlatStyle flatStyle_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				buttonBase_0.set_FlatStyle(flatStyle_0);
				return;
			}
		}
	}
}
