using System;
using Microsoft.Win32;

namespace Jesus_Ransom;

internal class RegKey : IRegKey, IDisposable
{
	private RegistryKey reg;

	public void Create(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException("name is empty");
		}
		if (Config.HKEY == HKEY.ClassesRoot)
		{
			reg = Registry.ClassesRoot.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.CurrentUser)
		{
			reg = Registry.CurrentUser.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.LocalMachine)
		{
			reg = Registry.LocalMachine.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.Users)
		{
			reg = Registry.Users.OpenSubKey(Config.Address, writable: true);
		}
		else
		{
			reg = Registry.CurrentConfig.OpenSubKey(Config.Address, writable: true);
		}
		if (reg.OpenSubKey(name) == null)
		{
			reg.CreateSubKey(name);
		}
		reg.Close();
	}

	public void Delete(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException("name is empty");
		}
		if (Config.HKEY == HKEY.ClassesRoot)
		{
			reg = Registry.ClassesRoot.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.CurrentUser)
		{
			reg = Registry.CurrentUser.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.LocalMachine)
		{
			reg = Registry.LocalMachine.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.Users)
		{
			reg = Registry.Users.OpenSubKey(Config.Address, writable: true);
		}
		else
		{
			reg = Registry.CurrentConfig.OpenSubKey(Config.Address, writable: true);
		}
		if (reg.OpenSubKey(name) != null)
		{
			reg.DeleteSubKeyTree(name);
		}
		reg.Close();
	}

	public string[] GetNames()
	{
		if (Config.HKEY == HKEY.ClassesRoot)
		{
			reg = Registry.ClassesRoot.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.CurrentUser)
		{
			reg = Registry.CurrentUser.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.LocalMachine)
		{
			reg = Registry.LocalMachine.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.Users)
		{
			reg = Registry.Users.OpenSubKey(Config.Address, writable: true);
		}
		else
		{
			reg = Registry.CurrentConfig.OpenSubKey(Config.Address, writable: true);
		}
		string[] subKeyNames = reg.GetSubKeyNames();
		reg.Close();
		return subKeyNames;
	}

	public bool Exists(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException("name is empty");
		}
		if (Config.HKEY == HKEY.ClassesRoot)
		{
			reg = Registry.ClassesRoot.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.CurrentUser)
		{
			reg = Registry.CurrentUser.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.LocalMachine)
		{
			reg = Registry.LocalMachine.OpenSubKey(Config.Address, writable: true);
		}
		else if (Config.HKEY == HKEY.Users)
		{
			reg = Registry.Users.OpenSubKey(Config.Address, writable: true);
		}
		else
		{
			reg = Registry.CurrentConfig.OpenSubKey(Config.Address, writable: true);
		}
		bool result = false;
		string[] subKeyNames = reg.GetSubKeyNames();
		string[] array = subKeyNames;
		foreach (string text in array)
		{
			if (text.Contains(name))
			{
				result = true;
			}
		}
		reg.Close();
		return result;
	}

	public void Dispose()
	{
		reg.Close();
		reg.Dispose();
	}
}
