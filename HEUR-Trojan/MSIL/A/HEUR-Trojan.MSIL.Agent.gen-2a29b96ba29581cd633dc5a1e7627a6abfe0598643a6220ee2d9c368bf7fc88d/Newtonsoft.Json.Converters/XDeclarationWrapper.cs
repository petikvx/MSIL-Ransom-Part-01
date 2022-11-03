using System.Xml;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode
{
	internal XDeclaration Declaration { get; }

	public override XmlNodeType NodeType => XmlNodeType.XmlDeclaration;

	public string Version => Declaration.get_Version();

	public string Encoding
	{
		get
		{
			return Declaration.get_Encoding();
		}
		set
		{
			Declaration.set_Encoding(value);
		}
	}

	public string Standalone
	{
		get
		{
			return Declaration.get_Standalone();
		}
		set
		{
			Declaration.set_Standalone(value);
		}
	}

	public XDeclarationWrapper(XDeclaration declaration)
		: base(null)
	{
		Declaration = declaration;
	}
}
