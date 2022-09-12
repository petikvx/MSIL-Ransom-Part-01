using System.Xml;
using ns5;
using ns6;
using ns9;

namespace ns1;

internal class Class227 : Class224, Interface11, Interface14
{
	private readonly XmlDeclaration xmlDeclaration_0;

	public string Version => xmlDeclaration_0.Version;

	public string Encoding
	{
		get
		{
			return xmlDeclaration_0.Encoding;
		}
		set
		{
			xmlDeclaration_0.Encoding = value;
		}
	}

	public string Standalone
	{
		get
		{
			return xmlDeclaration_0.Standalone;
		}
		set
		{
			xmlDeclaration_0.Standalone = value;
		}
	}

	public Class227(XmlDeclaration xmlDeclaration_1)
		: base(xmlDeclaration_1)
	{
		xmlDeclaration_0 = xmlDeclaration_1;
	}
}
