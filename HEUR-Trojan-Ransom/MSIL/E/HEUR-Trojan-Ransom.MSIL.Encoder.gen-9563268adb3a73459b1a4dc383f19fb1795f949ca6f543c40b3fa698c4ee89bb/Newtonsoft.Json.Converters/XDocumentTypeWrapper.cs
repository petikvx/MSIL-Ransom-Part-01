using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XDocumentTypeWrapper : XObjectWrapper, IXmlNode, IXmlDocumentType
{
	private readonly XDocumentType _documentType;

	public string Name => _documentType.get_Name();

	public string System => _documentType.get_SystemId();

	public string Public => _documentType.get_PublicId();

	public string InternalSubset => _documentType.get_InternalSubset();

	public override string? LocalName => "DOCTYPE";

	public XDocumentTypeWrapper(XDocumentType documentType)
		: base((XObject?)(object)documentType)
	{
		_documentType = documentType;
	}
}
