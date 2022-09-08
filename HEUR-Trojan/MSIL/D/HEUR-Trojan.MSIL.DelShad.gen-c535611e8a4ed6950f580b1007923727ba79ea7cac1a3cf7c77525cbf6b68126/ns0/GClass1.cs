using System;
using System.Text;
using Microsoft.Win32;

namespace ns0;

public static class GClass1
{
	public static RegistryKey registryKey_0;

	private static RegistryKey smethod_0()
	{
		return Registry.CurrentUser.CreateSubKey(Encoding.UTF8.GetString(Convert.FromBase64String("VGltZVRpbWU=")));
	}

	public static void smethod_1(string string_0)
	{
		registryKey_0.SetValue(string_0, Encoding.UTF8.GetString(Convert.FromBase64String("MQ==")));
	}

	public static string[] smethod_2()
	{
		return registryKey_0.GetValueNames();
	}

	public static void smethod_3()
	{
		registryKey_0 = smethod_0();
	}
}
