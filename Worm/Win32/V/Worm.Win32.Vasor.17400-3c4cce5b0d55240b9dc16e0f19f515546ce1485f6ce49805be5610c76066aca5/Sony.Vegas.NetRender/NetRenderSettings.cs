using System.IO;
using System.Text;
using System.Xml;

namespace Sony.Vegas.NetRender;

public class NetRenderSettings
{
	internal const string theDefaultSettingsFileName = "VegSrv.settings";

	private string myFilePath = null;

	private XmlDocument myXmlDoc = null;

	public string FilePath => myFilePath;

	public XmlDocument Doc => myXmlDoc;

	public XmlElement Root => myXmlDoc.DocumentElement;

	public NetRenderSettings()
	{
		Load();
	}

	public NetRenderSettings(string settingsFile)
	{
		myFilePath = Path.GetFullPath(settingsFile);
		Load();
	}

	public XmlElement GetElt(string xpath)
	{
		return myXmlDoc.SelectSingleNode(xpath) as XmlElement;
	}

	private void Load()
	{
		string text = myFilePath;
		if (myFilePath == null || string.Empty == myFilePath)
		{
			myFilePath = Path.Combine(AppPathHelpers.get_ApplicationDataPath(), "VegSrv.settings");
			if (File.Exists(myFilePath))
			{
				text = myFilePath;
			}
		}
		myXmlDoc = new XmlDocument();
		if (null == text)
		{
			myXmlDoc.AppendChild(myXmlDoc.CreateElement("settings"));
		}
		else
		{
			myXmlDoc.Load(text);
		}
	}

	public void Save()
	{
		XmlTextWriter xmlTextWriter = null;
		try
		{
			xmlTextWriter = new XmlTextWriter(myFilePath, new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.IndentChar = ' ';
			xmlTextWriter.Indentation = 2;
			myXmlDoc.WriteTo(xmlTextWriter);
		}
		catch
		{
		}
		finally
		{
			if (null != xmlTextWriter)
			{
				xmlTextWriter.Close();
			}
		}
	}
}
