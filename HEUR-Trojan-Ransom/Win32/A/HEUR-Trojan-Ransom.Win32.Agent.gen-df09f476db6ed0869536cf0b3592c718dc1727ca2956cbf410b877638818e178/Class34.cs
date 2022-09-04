using System;
using System.Globalization;
using System.Net;
using System.Text;
using System.Xml;

internal abstract class Class34
{
	internal static readonly CultureInfo cultureInfo_0;

	protected GClass1 gclass1_0;

	protected Class34(GClass1 gclass1_1)
	{
		Class51.smethod_0();
		base._002Ector();
		gclass1_0 = gclass1_1;
	}

	protected WebRequest method_0(string string_0, string string_1, out byte[] byte_0)
	{
		string text = "http://" + gclass1_0.method_0().ToString() + gclass1_0.method_2();
		GClass3.smethod_4("Initiating request to: {0}", text);
		Uri requestUri = new Uri(text);
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUri);
		httpWebRequest.KeepAlive = false;
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "text/xml; charset=\"utf-8\"";
		httpWebRequest.Headers.Add("SOAPACTION", "\"" + gclass1_0.method_3() + "#" + string_0 + "\"");
		string s = "<s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\"><s:Body><u:" + string_0 + " xmlns:u=\"" + gclass1_0.method_3() + "\">" + string_1 + "</u:" + string_0 + "></s:Body></s:Envelope>\r\n\r\n";
		byte_0 = Encoding.UTF8.GetBytes(s);
		return httpWebRequest;
	}

	public static Class34 smethod_0(GClass1 gclass1_1, string string_0)
	{
		XmlNode xmlNode = null;
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(string_0);
		XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
		xmlNamespaceManager.AddNamespace("errorNs", "urn:schemas-upnp-org:control-1-0");
		xmlNamespaceManager.AddNamespace("responseNs", gclass1_1.method_3());
		if ((xmlNode = xmlDocument.SelectSingleNode("//errorNs:UPnPError", xmlNamespaceManager)) != null)
		{
			return new Class35(Convert.ToInt32(xmlNode["errorCode"]!.InnerText, CultureInfo.InvariantCulture), xmlNode["errorDescription"]!.InnerText);
		}
		if ((xmlNode = xmlDocument.SelectSingleNode("//responseNs:AddPortMappingResponse", xmlNamespaceManager)) != null)
		{
			return new Class42();
		}
		if ((xmlNode = xmlDocument.SelectSingleNode("//responseNs:DeletePortMappingResponse", xmlNamespaceManager)) != null)
		{
			return new Class43();
		}
		if ((xmlNode = xmlDocument.SelectSingleNode("//responseNs:GetExternalIPAddressResponse", xmlNamespaceManager)) != null)
		{
			return new Class44(xmlNode["NewExternalIPAddress"]!.InnerText);
		}
		if ((xmlNode = xmlDocument.SelectSingleNode("//responseNs:GetGenericPortMappingEntryResponse", xmlNamespaceManager)) != null)
		{
			return new Class45(xmlNode, bool_1: true);
		}
		if ((xmlNode = xmlDocument.SelectSingleNode("//responseNs:GetSpecificPortMappingEntryResponse", xmlNamespaceManager)) != null)
		{
			return new Class45(xmlNode, bool_1: false);
		}
		GClass3.smethod_4("Unknown message returned. Please send me back the following XML:");
		GClass3.smethod_4(string_0);
		return null;
	}

	public abstract WebRequest vmethod_0(out byte[] byte_0);

	internal static void smethod_1(XmlWriter xmlWriter_0, string string_0, string string_1)
	{
		xmlWriter_0.WriteStartElement(string_0);
		xmlWriter_0.WriteString(string_1);
		xmlWriter_0.WriteEndElement();
	}

	internal static XmlWriter smethod_2(StringBuilder stringBuilder_0)
	{
		XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
		xmlWriterSettings.ConformanceLevel = ConformanceLevel.Fragment;
		return XmlWriter.Create(stringBuilder_0, xmlWriterSettings);
	}

	static Class34()
	{
		Class51.smethod_0();
		cultureInfo_0 = CultureInfo.InvariantCulture;
	}
}
