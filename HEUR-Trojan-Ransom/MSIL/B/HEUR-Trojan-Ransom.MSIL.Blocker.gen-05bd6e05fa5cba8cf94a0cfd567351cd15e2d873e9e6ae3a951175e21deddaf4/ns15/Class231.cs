using System.Xml.Linq;
using ns3;
using ns5;
using ns7;

namespace ns15;

internal class Class231 : Class229, Interface11, Interface15
{
	private readonly XDocumentType xdocumentType_0;

	public string Name => xdocumentType_0.get_Name();

	public string System => xdocumentType_0.get_SystemId();

	public string Public => xdocumentType_0.get_PublicId();

	public string InternalSubset => xdocumentType_0.get_InternalSubset();

	public override string? LocalName => "DOCTYPE";

	public Class231(XDocumentType xdocumentType_1)
		: base((XObject?)(object)xdocumentType_1)
	{
		xdocumentType_0 = xdocumentType_1;
	}
}
