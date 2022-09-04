using System;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace ns0;

internal sealed class Class4
{
	[NonSerialized]
	internal static GetString getString_0;

	static Class4()
	{
		Strings.CreateGetStringDelegate(typeof(Class4));
	}

	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class5.smethod_0());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class5.smethod_1());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue(getString_0(416), null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}
}
