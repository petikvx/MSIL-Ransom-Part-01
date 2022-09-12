using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using ns0;
using ns1;
using ns12;

namespace ns16;

internal class Class230 : Class229, Interface11, Interface14
{
	[CompilerGenerated]
	private readonly XDeclaration xdeclaration_0;

	internal XDeclaration Declaration
	{
		[CompilerGenerated]
		get
		{
			return xdeclaration_0;
		}
	}

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

	public Class230(XDeclaration xdeclaration_1)
		: base(null)
	{
		xdeclaration_0 = xdeclaration_1;
	}
}
