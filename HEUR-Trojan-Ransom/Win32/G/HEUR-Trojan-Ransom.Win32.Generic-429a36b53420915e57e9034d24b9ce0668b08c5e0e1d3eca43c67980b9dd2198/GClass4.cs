using System;
using System.IO;
using System.Xml;

public class GClass4
{
	public static string string_0 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "\\Microsoft\\CLView\\Required.xml");

	private GClass1 gclass1_0 = new GClass1("123");

	public GClass4()
	{
		if (!File.Exists(string_0))
		{
			method_0();
		}
	}

	private void method_0()
	{
		if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\\\Microsoft"))
		{
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\\\Microsoft");
		}
		if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\\\Microsoft\\\\CLView"))
		{
			Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\\\Microsoft\\\\CLView");
		}
		XmlDocument xmlDocument = new XmlDocument();
		XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", null, null);
		xmlDeclaration.Encoding = "UTF-8";
		xmlDocument.AppendChild(xmlDeclaration);
		XmlElement newChild = xmlDocument.CreateElement("", "ConfigFile", "");
		xmlDocument.AppendChild(newChild);
		XmlElement xmlElement = xmlDocument.CreateElement("", "MtrlPath", "");
		xmlElement.InnerText = "";
		xmlDocument.ChildNodes.Item(1)!.AppendChild(xmlElement);
		XmlElement xmlElement2 = xmlDocument.CreateElement("", "RestarterPath", "");
		xmlElement2.InnerText = "";
		xmlDocument.ChildNodes.Item(1)!.AppendChild(xmlElement2);
		gclass1_0.method_3(xmlDocument.OuterXml, string_0);
	}

	private void method_1(string string_1)
	{
		XmlDocument xmlDocument = new XmlDocument();
		string xml = gclass1_0.method_4(string_0);
		xmlDocument.LoadXml(xml);
		xmlDocument.DocumentElement!.SelectSingleNode("//MtrlPath")!.InnerText = string_1;
		gclass1_0.method_3(xmlDocument.OuterXml, string_0);
	}

	private void method_2(string string_1)
	{
		XmlDocument xmlDocument = new XmlDocument();
		string xml = gclass1_0.method_4(string_0);
		xmlDocument.LoadXml(xml);
		xmlDocument.DocumentElement!.SelectSingleNode("//RestarterPath")!.InnerText = string_1;
		gclass1_0.method_3(xmlDocument.OuterXml, string_0);
	}

	private string method_3()
	{
		XmlDocument xmlDocument = new XmlDocument();
		StreamReader streamReader = new StreamReader(string_0);
		string string_ = streamReader.ReadToEnd();
		string_ = gclass1_0.method_2(string_);
		streamReader.Close();
		try
		{
			xmlDocument.LoadXml(string_);
		}
		catch
		{
			return null;
		}
		return xmlDocument.DocumentElement!.SelectSingleNode("//RestarterPath")!.InnerText;
	}

	private string method_4()
	{
		XmlDocument xmlDocument = new XmlDocument();
		StreamReader streamReader = new StreamReader(string_0);
		string string_ = streamReader.ReadToEnd();
		string_ = gclass1_0.method_2(string_);
		streamReader.Close();
		try
		{
			xmlDocument.LoadXml(string_);
		}
		catch
		{
			return null;
		}
		return xmlDocument.DocumentElement!.SelectSingleNode("//MtrlPath")!.InnerText;
	}
}
