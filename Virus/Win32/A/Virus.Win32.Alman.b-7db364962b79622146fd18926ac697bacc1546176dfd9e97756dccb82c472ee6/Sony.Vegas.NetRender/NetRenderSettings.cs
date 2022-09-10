using System.Xml;

namespace Sony.Vegas.NetRender;

public class NetRenderSettings
{
	internal const string theDefaultSettingsFileName = "VegSrv.settings";

	private string myFilePath;

	private XmlDocument myXmlDoc;

	public extern string FilePath { get; }

	public extern XmlDocument Doc { get; }

	public extern XmlElement Root { get; }

	public extern NetRenderSettings();

	public extern NetRenderSettings(string settingsFile);

	public extern XmlElement GetElt(string xpath);

	private extern void Load();

	public void Save()
	{
		/*Error: ldloc 0 (out-of-bounds)*/;
		_ = 6;
		/*Error near IL_0003: Invalid metadata token*/;
	}
}
