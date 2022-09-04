using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace EW5H3oYChfNlwZGh;

public class gc7sevs5_2DbwwpXCYiAsRNI
{
	private static string pK9xrV1iUdA;

	public static string get
	{
		get
		{
			if (pK9xrV1iUdA != null)
			{
				return pK9xrV1iUdA;
			}
			List<string> list = new List<string>();
			list.Add(QfmnMcWBxwMv2rE9_t);
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
			string text = QfmnMcWBxwMv2rE9_t;
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
				return pK9xrV1iUdA = "4.0";
			case "3.5":
				return pK9xrV1iUdA = "3.5";
			case "2.0":
			case "3.0":
				return pK9xrV1iUdA = "2.0";
			default:
				return pK9xrV1iUdA = QfmnMcWBxwMv2rE9_t;
			}
		}
	}

	private static string QfmnMcWBxwMv2rE9_t
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
