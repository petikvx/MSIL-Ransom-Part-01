using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace ELiiZIZsmnkXtAYV3eOEAphwNQfX;

public class MJK_tuW0kjAsp8Db0vlruCeggM2PBAlY95ihfh
{
	private static string bGHT35XGKtYP8L;

	public static string get
	{
		get
		{
			if (bGHT35XGKtYP8L != null)
			{
				return bGHT35XGKtYP8L;
			}
			List<string> list = new List<string>();
			list.Add(qBp8OTlh1hZwCNTI8JEUa4YAhPkE);
			List<string> list2 = new List<string>();
			list2.Add("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v2.0.50727");
			list2.Add("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.0");
			list2.Add("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v3.5");
			list2.Add("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Client");
			list2.Add("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\v4\\Full");
			foreach (string item in list2)
			{
				try
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(item);
					if (registryKey != null)
					{
						string input = (string)registryKey.GetValue("Version");
						int num = (int)registryKey.GetValue("Install");
						if (num == 1)
						{
							list.Add(Regex.Replace(Regex.Replace(input, "[^0-9\\.]", ""), "([0-9]+\\.[0-9]+)\\..*", "$1"));
						}
						input = null;
					}
					registryKey = null;
				}
				catch
				{
				}
			}
			string text = qBp8OTlh1hZwCNTI8JEUa4YAhPkE;
			double num2 = 0.0;
			foreach (string item2 in list)
			{
				try
				{
					double num3 = double.Parse(Regex.Replace(item2, "\\.", ","));
					if (num3 > num2)
					{
						text = item2;
						num2 = num3;
					}
				}
				catch
				{
				}
			}
			list = null;
			list2 = null;
			switch (text.ToString().Trim())
			{
			case "4.0":
			case "4.5":
				return bGHT35XGKtYP8L = "4.0";
			case "3.5":
				return bGHT35XGKtYP8L = "3.5";
			case "2.0":
			case "3.0":
				return bGHT35XGKtYP8L = "2.0";
			default:
				return bGHT35XGKtYP8L = qBp8OTlh1hZwCNTI8JEUa4YAhPkE;
			}
		}
	}

	private static string qBp8OTlh1hZwCNTI8JEUa4YAhPkE
	{
		get
		{
			Version version = Environment.OSVersion.Version;
			if (version.Major == 6 && version.Minor >= 2)
			{
				return "4.0";
			}
			return "2.0";
		}
	}
}
