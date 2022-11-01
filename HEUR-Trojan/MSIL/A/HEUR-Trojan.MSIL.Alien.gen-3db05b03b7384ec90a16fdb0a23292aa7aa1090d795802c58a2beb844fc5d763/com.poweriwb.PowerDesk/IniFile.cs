using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

namespace com.poweriwb.PowerDesk;

public class IniFile
{
	public const string DEF_RECYCLE_10 = "10";

	public static string DEFAULT_SECTION = "Default";

	public string path;

	public static int capacity = 1024;

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	private static extern int GetPrivateProfileString(string section, string key, string defaultValue, StringBuilder value, int size, string filePath);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	private static extern int GetPrivateProfileString(string section, string key, string defaultValue, [In][Out] char[] value, int size, string filePath);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	private static extern int GetPrivateProfileSection(string section, IntPtr keyValue, int size, string filePath);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool WritePrivateProfileString(string section, string key, string value, string filePath);

	public IniFile(string INIPath)
	{
		path = INIPath;
	}

	public void WriteValue(string Section, string Key, string Value)
	{
		WritePrivateProfileString(Section, Key, Value, path);
	}

	public void WriteValue(string Key, string Value)
	{
		WriteValue_UTF8(DEFAULT_SECTION, Key, Value);
	}

	private string ReadValue(string Section, string Key)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		GetPrivateProfileString(Section, Key, "", stringBuilder, 255, path);
		return stringBuilder.ToString();
	}

	public List<string> GetSections()
	{
		List<string> list = new List<string>();
		string[] array = App.iniApprovalList.ReadAllSection_Reg();
		for (int i = 0; i < array.Length; i++)
		{
			list.Add(array[i]);
		}
		return list;
	}

	public string ReadValue(string Section, string Key, string defaultValue)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		GetPrivateProfileString(Section, Key, defaultValue, stringBuilder, 255, path);
		return stringBuilder.ToString();
	}

	public string ReadValue(string Key)
	{
		return ReadValue_UTF8(DEFAULT_SECTION, Key);
	}

	internal string ReadValueDefault(string p, string p_2)
	{
		string text = ReadValue_UTF8(DEFAULT_SECTION, p);
		if (text == "")
		{
			WriteValue_UTF8(DEFAULT_SECTION, p, p_2);
			text = p_2;
		}
		return text;
	}

	public string ReadValue_UTF8(string section, string key, string defaultValue = "")
	{
		StringBuilder stringBuilder = new StringBuilder(capacity);
		GetPrivateProfileString(section, key, defaultValue, stringBuilder, stringBuilder.Capacity, path);
		return stringBuilder.ToString();
	}

	public string[] ReadSections_UTF8()
	{
		char[] value;
		int privateProfileString;
		while (true)
		{
			value = new char[capacity];
			privateProfileString = GetPrivateProfileString(null, null, "", value, capacity, path);
			if (privateProfileString != 0)
			{
				if (privateProfileString < capacity - 2)
				{
					break;
				}
				capacity *= 2;
				continue;
			}
			return null;
		}
		string text = new string(value, 0, privateProfileString);
		char[] separator = new char[1];
		return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
	}

	public string[] ReadKeys_UTF8(string section)
	{
		char[] value;
		int privateProfileString;
		while (true)
		{
			value = new char[capacity];
			string key = null;
			privateProfileString = GetPrivateProfileString(section, key, "", value, capacity, path);
			if (privateProfileString != 0)
			{
				if (privateProfileString < capacity - 2)
				{
					break;
				}
				capacity *= 2;
				continue;
			}
			return null;
		}
		string text = new string(value, 0, privateProfileString);
		char[] separator = new char[1];
		return text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
	}

	public string[] ReadKeyValuePairs_UTF8(string section)
	{
		IntPtr intPtr;
		int privateProfileSection;
		while (true)
		{
			intPtr = Marshal.AllocCoTaskMem(capacity * 2);
			privateProfileSection = GetPrivateProfileSection(section, intPtr, capacity, path);
			if (privateProfileSection != 0)
			{
				if (privateProfileSection < capacity - 2)
				{
					break;
				}
				Marshal.FreeCoTaskMem(intPtr);
				capacity *= 2;
				continue;
			}
			Marshal.FreeCoTaskMem(intPtr);
			return null;
		}
		string text = Marshal.PtrToStringAuto(intPtr, privateProfileSection - 1);
		Marshal.FreeCoTaskMem(intPtr);
		char[] separator = new char[1];
		return text.Split(separator);
	}

	public bool WriteValue_UTF8(string section, string key, string value)
	{
		return WritePrivateProfileString(section, key, value, path);
	}

	public bool DeleteSection_UTF8(string section)
	{
		return WritePrivateProfileString(section, null, null, path);
	}

	public bool DeleteKey_UTF8(string section, string key)
	{
		return WritePrivateProfileString(section, key, null, path);
	}

	internal void WriteValue_UTF8(string p, string p_2)
	{
		WriteValue_UTF8(DEFAULT_SECTION, p, p_2);
	}

	internal void WriteValue_Reg(string section, string key, string value)
	{
		RegiHelperSrc.Instance.WriteValue_Reg(section.Replace(Utils.SEPA, "|"), key, value);
	}

	internal string ReadValue_Reg(string section, string key, string value)
	{
		return RegiHelperSrc.Instance.ReadValue_Reg(section.Replace(Utils.SEPA, "|"), key, value);
	}

	internal string[] ReadAllSection_Reg()
	{
		return RegiHelperSrc.Instance.ReadAllSection_Reg();
	}

	internal List<string> ReadURLProtocols()
	{
		List<string> list = new List<string>();
		RegistryKey registryKey = null;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("Software\\Classes");
		}
		else
		{
			registryKey = Registry.LocalMachine.OpenSubKey("Software\\Classes");
		}
		if (registryKey != null)
		{
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				if (registryKey.OpenSubKey(subKeyNames[i])!.GetValue("URL Protocol") != null || registryKey.OpenSubKey(subKeyNames[i])!.GetValue("URL Protocol_GoldStar") != null)
				{
					list.Add("AUP," + subKeyNames[i]);
				}
			}
		}
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("Software\\Classes");
		}
		else
		{
			registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes");
		}
		if (registryKey != null)
		{
			string[] subKeyNames = registryKey.GetSubKeyNames();
			for (int i = 0; i < subKeyNames.Length; i++)
			{
				if (registryKey.OpenSubKey(subKeyNames[i])!.GetValue("URL Protocol") != null || registryKey.OpenSubKey(subKeyNames[i])!.GetValue("URL Protocol_GoldStar") != null)
				{
					list.Add("UUP," + subKeyNames[i]);
				}
			}
		}
		return list;
	}

	internal List<string> ReadAppOutBlockList()
	{
		List<string> list = new List<string>();
		RegistryKey registryKey = null;
		if (Utils.Is64OS())
		{
			RegistryKey registryKey2 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey2.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules");
		}
		else
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\SharedAccess\\Parameters\\FirewallPolicy\\FirewallRules");
		}
		if (registryKey != null)
		{
			string[] valueNames = registryKey.GetValueNames();
			string text = "";
			for (int i = 0; i < valueNames.Length; i++)
			{
				if (32 == valueNames[i].Length && -1 == valueNames[i].IndexOf("-"))
				{
					text = registryKey.GetValue(valueNames[i])!.ToString();
					if (-1 < text.IndexOf("Dir=Out", 0, StringComparison.CurrentCultureIgnoreCase) && (-1 < text.IndexOf("Name=Not Deny ", 0, StringComparison.CurrentCultureIgnoreCase) || -1 < text.IndexOf("Name=Deny ", 0, StringComparison.CurrentCultureIgnoreCase)))
					{
						list.Add(valueNames[i] + "," + text);
					}
				}
			}
		}
		return list;
	}
}
