using System;
using System.Collections;
using Microsoft.Win32;

namespace OpenNETCF.Desktop.Communication;

public class AutoStartApps : CollectionBase
{
	private string m_key;

	public string this[int index] => (string)base.List[index];

	internal AutoStartApps(string RegKey)
	{
		m_key = RegKey;
		string[] array = null;
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m_key);
			array = new string[registryKey.ValueCount];
			string[] valueNames = registryKey.GetValueNames();
			for (int i = 0; i < array.Length; i++)
			{
				base.List.Add((string)registryKey.GetValue(valueNames[i]));
			}
			registryKey.Close();
		}
		catch (Exception)
		{
		}
	}

	public void Add(string AppPath)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m_key, writable: true);
		registryKey.SetValue(Guid.NewGuid().ToString(), AppPath);
		registryKey.Close();
		base.List.Add(AppPath);
	}

	public void Remove(string AppPath)
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m_key, writable: true);
		string[] valueNames = registryKey.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			if (string.Compare((string)registryKey.GetValue(valueNames[i]), AppPath, ignoreCase: true) == 0)
			{
				registryKey.DeleteValue(valueNames[i], throwOnMissingValue: false);
				break;
			}
		}
		registryKey.Close();
		base.List.Remove(AppPath);
	}

	public new void Clear()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m_key, writable: true);
		string[] valueNames = registryKey.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			registryKey.DeleteValue(valueNames[i], throwOnMissingValue: false);
		}
		registryKey.Close();
		base.List.Clear();
	}

	public new void RemoveAt(int Index)
	{
		string strB = (string)base.List[Index];
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(m_key, writable: true);
		string[] valueNames = registryKey.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			if (string.Compare((string)registryKey.GetValue(valueNames[i]), strB, ignoreCase: true) == 0)
			{
				registryKey.DeleteValue(valueNames[i], throwOnMissingValue: false);
				break;
			}
		}
		registryKey.Close();
		base.List.RemoveAt(Index);
	}
}
