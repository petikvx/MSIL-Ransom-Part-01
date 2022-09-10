using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Win32;

public class GClass0
{
	public enum GEnum0
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10
	}

	public static readonly GClass0 gclass0_0 = new GClass0();

	private bool bool_0;

	private string string_0 = "SOFTWARE\\" + Application.get_ProductName().ToUpper();

	private RegistryKey registryKey_0 = Registry.LocalMachine;

	[SpecialName]
	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	public void method_1(bool bool_1)
	{
		bool_0 = bool_1;
	}

	[SpecialName]
	public string method_2()
	{
		return string_0;
	}

	[SpecialName]
	public void method_3(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	public RegistryKey method_4()
	{
		return registryKey_0;
	}

	[SpecialName]
	public void method_5(RegistryKey registryKey_1)
	{
		registryKey_0 = registryKey_1;
	}

	private GClass0()
	{
	}

	public string method_6(string string_1)
	{
		RegistryKey registryKey = registryKey_0;
		RegistryKey registryKey2 = registryKey.OpenSubKey(string_0);
		if (registryKey2 == null)
		{
			return null;
		}
		try
		{
			return (string)registryKey2.GetValue(string_1.ToUpper());
		}
		catch (Exception exception_)
		{
			method_12(exception_, "Reading registry " + string_1.ToUpper());
			return null;
		}
	}

	public bool method_7(string string_1, object object_0)
	{
		try
		{
			RegistryKey registryKey = registryKey_0;
			RegistryKey registryKey2 = registryKey.CreateSubKey(string_0);
			registryKey2.SetValue(string_1.ToUpper(), object_0);
			return true;
		}
		catch (Exception exception_)
		{
			method_12(exception_, "Writing registry " + string_1.ToUpper());
			return false;
		}
	}

	public bool method_8(string string_1)
	{
		try
		{
			RegistryKey registryKey = registryKey_0;
			RegistryKey registryKey2 = registryKey.CreateSubKey(string_0);
			if (registryKey2 == null)
			{
				return true;
			}
			registryKey2.DeleteValue(string_1);
			return true;
		}
		catch (Exception exception_)
		{
			method_12(exception_, "Deleting SubKey " + string_0);
			return false;
		}
	}

	public bool method_9()
	{
		try
		{
			RegistryKey registryKey = registryKey_0;
			RegistryKey registryKey2 = registryKey.OpenSubKey(string_0);
			if (registryKey2 != null)
			{
				registryKey.DeleteSubKeyTree(string_0);
			}
			return true;
		}
		catch (Exception exception_)
		{
			method_12(exception_, "Deleting SubKey " + string_0);
			return false;
		}
	}

	public int method_10()
	{
		try
		{
			RegistryKey registryKey = registryKey_0;
			return registryKey.OpenSubKey(string_0)?.SubKeyCount ?? 0;
		}
		catch (Exception exception_)
		{
			method_12(exception_, "Retriving subkeys of " + string_0);
			return 0;
		}
	}

	public int method_11()
	{
		try
		{
			RegistryKey registryKey = registryKey_0;
			return registryKey.OpenSubKey(string_0)?.ValueCount ?? 0;
		}
		catch (Exception exception_)
		{
			method_12(exception_, "Retriving keys of " + string_0);
			return 0;
		}
	}

	private void method_12(Exception exception_0, string string_1)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (bool_0)
		{
			MessageBox.Show(exception_0.Message, string_1, (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}
}
