using System.Linq;
using Microsoft.Win32;

namespace ShrugTwo;

public class BetterReg
{
	public RegistryKey regKey { get; private set; }

	public BetterReg(RegistryKey mainKey, string registryKey, bool write = false)
	{
		regKey = mainKey.OpenSubKey(registryKey, write);
	}

	public object ReadValue(string valName)
	{
		return regKey.GetValue(valName);
	}

	public string ReadValueStr(string valName)
	{
		return (string)regKey.GetValue(valName);
	}

	public bool SubKeyExists(string subKeyName)
	{
		return regKey.GetSubKeyNames().ToList().Contains(subKeyName);
	}

	public bool ValueExists(string valName)
	{
		return regKey.GetValueNames().ToList().Contains(valName);
	}

	public void AddSubKey(string subKeyName, bool redirect = true, bool write = false)
	{
		if (!SubKeyExists(subKeyName))
		{
			regKey.CreateSubKey(subKeyName);
			if (redirect)
			{
				regKey = regKey.OpenSubKey(subKeyName, write);
			}
		}
	}

	public void SetValue(string valName, object value)
	{
		regKey.SetValue(valName, value);
	}

	public void DeleteValue(string valName)
	{
		regKey.DeleteValue(valName, throwOnMissingValue: false);
	}

	public void DeleteSubKey(string subKeyName, bool tree = false)
	{
		if (tree)
		{
			regKey.DeleteSubKeyTree(subKeyName, throwOnMissingSubKey: false);
		}
		else
		{
			regKey.DeleteSubKey(subKeyName, throwOnMissingSubKey: false);
		}
	}

	public void OpenSubKey(string subKeyName, bool write = false)
	{
		regKey = regKey.OpenSubKey(subKeyName, write);
	}
}
