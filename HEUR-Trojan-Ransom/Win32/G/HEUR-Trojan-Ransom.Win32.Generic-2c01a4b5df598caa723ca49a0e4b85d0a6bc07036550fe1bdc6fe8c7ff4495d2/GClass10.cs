using System.IO;
using System.Xml;

public class GClass10
{
	private GClass1 gclass1_0 = new GClass1("123");

	public void method_0(string string_0)
	{
		XmlDocument xmlDocument = new XmlDocument();
		XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", null, null);
		xmlDeclaration.Encoding = "UTF-8";
		xmlDocument.AppendChild(xmlDeclaration);
		XmlElement newChild = xmlDocument.CreateElement("", "MtrlLogs", "");
		xmlDocument.AppendChild(newChild);
		XmlElement xmlElement = xmlDocument.CreateElement("", "SentDate", "");
		xmlElement.InnerText = "";
		xmlDocument.ChildNodes.Item(1)!.AppendChild(xmlElement);
		XmlElement xmlElement2 = xmlDocument.CreateElement("", "LogContent", "");
		xmlElement2.InnerText = "";
		xmlDocument.ChildNodes.Item(1)!.AppendChild(xmlElement2);
		gclass1_0.method_3(xmlDocument.OuterXml, string_0);
	}

	public string method_1(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return "";
		}
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
		return xmlDocument.DocumentElement!.SelectSingleNode("//LogContent")!.InnerText;
	}

	public void method_2(string string_0, string string_1)
	{
		if (!File.Exists(string_0))
		{
			return;
		}
		XmlDocument xmlDocument = new XmlDocument();
		StreamReader streamReader = new StreamReader(string_0);
		string string_2 = streamReader.ReadToEnd();
		string_2 = gclass1_0.method_2(string_2);
		streamReader.Close();
		try
		{
			xmlDocument.LoadXml(string_2);
			xmlDocument.DocumentElement!.SelectSingleNode("//SentDate")!.InnerText = string_1;
			gclass1_0.method_3(xmlDocument.OuterXml, string_0);
		}
		catch
		{
			method_0(string_0);
		}
	}

	public void method_3(string string_0, string string_1)
	{
		if (File.Exists(string_0))
		{
			XmlDocument xmlDocument = new XmlDocument();
			string xml = gclass1_0.method_4(string_0);
			xmlDocument.LoadXml(xml);
			xmlDocument.DocumentElement!.SelectSingleNode("//LogContent")!.InnerText = string_1;
			gclass1_0.method_3(xmlDocument.OuterXml, string_0);
		}
	}
}
