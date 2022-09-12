using System.Xml;
using ns12;
using ns17;
using ns3;

namespace ns19;

internal class Class228 : Class224, Interface11, Interface15
{
	private readonly XmlDocumentType xmlDocumentType_0;

	public string Name => xmlDocumentType_0.Name;

	public string System => xmlDocumentType_0.SystemId;

	public string Public => xmlDocumentType_0.PublicId;

	public string InternalSubset => xmlDocumentType_0.InternalSubset;

	public override string? LocalName => "DOCTYPE";

	public Class228(XmlDocumentType xmlDocumentType_1)
		: base(xmlDocumentType_1)
	{
		xmlDocumentType_0 = xmlDocumentType_1;
	}
}
