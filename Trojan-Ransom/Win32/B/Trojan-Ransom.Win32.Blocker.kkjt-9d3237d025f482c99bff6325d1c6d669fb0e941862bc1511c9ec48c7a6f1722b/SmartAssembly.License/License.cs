using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.Attributes;
using SmartAssembly.Shared;
using ns0;

namespace SmartAssembly.License;

public class License
{
	private static void smethod_0()
	{
		try
		{
			Form0.smethod_0(typeof(Application).TypeHandle, 189, 226).InvokeMember(AppRegistryKeys.smethod_0(512389566, 5), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
		}
		catch (MissingMethodException)
		{
		}
		Class4.Class5.Class6.Class7.smethod_11(324, 355);
	}

	public static bool Validate()
	{
		return smethod_1(bool_0: false);
	}

	public static void ValidateDLL()
	{
		smethod_1(bool_0: true);
	}

	private static bool smethod_1(bool bool_0)
	{
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		DateTime dateTime_ = smethod_6(AppRegistryKeys.smethod_0(512389521, 7), 550, 626);
		if (!Class1.smethod_3(smethod_7(116, 13), dateTime_, 757, 744) && !Class1.smethod_3(smethod_7(815, 854), Form0.smethod_1(ref dateTime_, -21.0, 761, 731), 695, 681))
		{
			if (AppPathFinder.ReadInstalledSaPath() == null)
			{
				try
				{
					Form0 form = new Form0(AppRegistryKeys.smethod_0(512389368, 1), AppRegistryKeys.smethod_0(512390016, 1), AppRegistryKeys.smethod_0(512389364, 5));
					smethod_0();
					Class4.Class5.Class6.Class7.smethod_13((Control)(object)form, Class4.Class5.smethod_3(80, 43), 874, 781);
					Class4.Class5.smethod_4((Form)(object)form, 129, 129);
				}
				catch
				{
				}
				return false;
			}
			return true;
		}
		string object_ = DoNotDistributeAttribute.smethod_3(AppRegistryKeys.smethod_4(smethod_5(544, 628), 922, 913), 641, 721);
		string text = AppNameFinder.smethod_2(AppRegistryKeys.smethod_0(512389510, 6), object_, DoNotDistributeAttribute.smethod_4(ref dateTime_, AppRegistryKeys.smethod_0(512389274, 1), 1010, 900), 904, 1008);
		if (bool_0)
		{
			throw new Exception(text);
		}
		Form0 form_ = new Form0(text, AppRegistryKeys.smethod_0(512389250, 5), AppRegistryKeys.smethod_0(512389367, 6));
		smethod_0();
		Class4.Class5.Class6.Class7.smethod_12((Form)(object)form_, 619, 604);
		return false;
	}

	[SecuritySafeCritical]
	static License()
	{
		AppPathFinder.smethod_3();
	}

	[SecuritySafeCritical]
	internal static object smethod_2(RegistryKey registryKey_0, string string_0, object object_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 68:
				return Class4.Class5.Class6.smethod_7(registryKey_0, string_0, object_0, 210, 208);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3(RegistryKey registryKey_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 17:
				Class4.smethod_13(registryKey_0, 533, 514);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static int smethod_4(Version version_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 72:
				return Class4.Class5.smethod_5(version_0, 965, 922);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_5(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return Class4.smethod_14(396, 498);
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime smethod_6(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 84:
				return Class4.smethod_15(string_0, 1, 80);
			}
		}
	}

	[SecuritySafeCritical]
	internal static DateTime smethod_7(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 121:
				return Class0.smethod_13(996, 968);
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool smethod_8(string string_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 34:
				return Class4.smethod_16(string_0, string_1, 427, 398);
			}
		}
	}

	[SecuritySafeCritical]
	internal static Assembly smethod_9(ResolveEventArgs resolveEventArgs_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 90:
				return Class4.Class5.Class6.smethod_8(resolveEventArgs_0, 94, 59);
			}
		}
	}
}
