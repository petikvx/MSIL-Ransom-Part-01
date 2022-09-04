using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Lexplorer;

internal class Class26
{
	private string _id;

	public string ID => _id;

	public bool Is64BitOs => Environment.Is64BitOperatingSystem;

	public string MachineLanguage => CultureInfo.CurrentCulture.EnglishName;

	public string MachineName => Uri.EscapeDataString(Environment.MachineName);

	public int TimeZoneOffset => (int)TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).TotalHours;

	public string OSVersion => Environment.OSVersion.VersionString;

	public Class26()
	{
		byte[] array = GenerateUserId();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X"));
		}
		_id = stringBuilder.ToString();
	}

	public string[] GetInstalledLanguages()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		List<string> list = new List<string>();
		foreach (InputLanguage item in (ReadOnlyCollectionBase)(object)InputLanguage.get_InstalledInputLanguages())
		{
			InputLanguage val = item;
			list.Add(val.get_Culture().TwoLetterISOLanguageName);
		}
		return list.ToArray();
	}

	public string[] GetBrowserList()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\Clients\\StartMenuInternet");
		if (registryKey == null)
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Clients\\StartMenuInternet");
		}
		if (registryKey == null)
		{
			return new string[1] { "iexplore.exe" };
		}
		return registryKey.GetSubKeyNames();
	}

	public string GetAntivirusName()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		string text = "\\\\" + Environment.MachineName;
		OperatingSystem oSVersion = Environment.OSVersion;
		text = ((oSVersion.Version.Major < 6) ? (text + "\\root\\SecurityCenter") : (text + "\\root\\SecurityCenter2"));
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(text, "SELECT * FROM AntivirusProduct");
			ManagementObjectCollection val2 = val.Get();
			string text2 = string.Empty;
			ManagementObjectEnumerator enumerator = val2.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementBaseObject current = enumerator.get_Current();
					text2 = string.Concat(text2, current.GetPropertyValue("displayName"), ";");
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text2;
		}
		catch
		{
			return string.Empty;
		}
	}

	protected byte[] GenerateUserId()
	{
		string s = GetMotherboardSerial() + Is64BitOs + MachineLanguage + MachineName + OSVersion;
		MD5 mD = MD5.Create();
		return mD.ComputeHash(Encoding.UTF8.GetBytes(s));
	}

	private string GetCpuId()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		string empty = string.Empty;
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				return ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
					.ToString();
			}
			return empty;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	private string GetMotherboardSerial()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
		ManagementObjectCollection val2 = val.Get();
		string result = "";
		ManagementObjectEnumerator enumerator = val2.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				result = (string)((ManagementBaseObject)val3).get_Item("SerialNumber");
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}
}
