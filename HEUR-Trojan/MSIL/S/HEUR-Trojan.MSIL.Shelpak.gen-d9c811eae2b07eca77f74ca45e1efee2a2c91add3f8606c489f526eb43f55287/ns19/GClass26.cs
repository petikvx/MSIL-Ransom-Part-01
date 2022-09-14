using System;
using Microsoft.Win32;
using ns1;
using ns20;

namespace ns19;

public static class GClass26
{
	private static readonly string string_0 = "Software\\" + GClass10.string_15;

	public static bool smethod_0(string string_1, byte[] byte_0)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(string_0, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(string_1, byte_0, RegistryValueKind.Binary);
			return true;
		}
		catch (Exception ex)
		{
			GClass27.smethod_3(ex.Message);
		}
		return false;
	}

	public static byte[] smethod_1(string string_1)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(string_0);
			return (byte[])registryKey.GetValue(string_1);
		}
		catch (Exception ex)
		{
			GClass27.smethod_3(ex.Message);
		}
		return null;
	}

	public static bool smethod_2(string string_1)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(string_0);
			registryKey.DeleteValue(string_1);
			return true;
		}
		catch (Exception ex)
		{
			GClass27.smethod_3(ex.Message);
		}
		return false;
	}

	public static bool smethod_3()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("", writable: true);
			registryKey.DeleteSubKeyTree(string_0);
			return true;
		}
		catch (Exception ex)
		{
			GClass27.smethod_3(ex.Message);
		}
		return false;
	}
}
