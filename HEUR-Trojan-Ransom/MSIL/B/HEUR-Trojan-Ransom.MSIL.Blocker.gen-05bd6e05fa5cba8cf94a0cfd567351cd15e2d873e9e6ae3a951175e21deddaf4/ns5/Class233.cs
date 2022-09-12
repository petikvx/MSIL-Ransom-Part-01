using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using ns1;
using ns10;
using ns11;
using ns13;
using ns15;
using ns7;
using ns8;
using ns9;

namespace ns5;

internal class Class233 : Class232, Interface11, Interface12
{
	private XDocument Document => (XDocument)base.WrappedNode;

	public override List<Interface11> ChildNodes
	{
		get
		{
			List<Interface11> childNodes = base.ChildNodes;
			if (Document.get_Declaration() != null && (childNodes.Count == 0 || childNodes[0].NodeType != XmlNodeType.XmlDeclaration))
			{
				childNodes.Insert(0, new Class230(Document.get_Declaration()));
			}
			return childNodes;
		}
	}

	protected override bool HasChildNodes
	{
		get
		{
			if (base.HasChildNodes)
			{
				return true;
			}
			return Document.get_Declaration() != null;
		}
	}

	public Interface13? DocumentElement
	{
		get
		{
			if (Document.get_Root() == null)
			{
				return null;
			}
			return new Class234(Document.get_Root());
		}
	}

	public Class233(XDocument xdocument_0)
		: base((XContainer)(object)xdocument_0)
	{
	}

	public Interface11 imethod_1(string? string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new Class229((XObject?)new XComment(string_0));
	}

	public Interface11 imethod_2(string? string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new Class229((XObject?)new XText(string_0));
	}

	public Interface11 imethod_3(string? string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new Class229((XObject?)new XCData(string_0));
	}

	public Interface11 imethod_4(string? string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new Class229((XObject?)new XText(string_0));
	}

	public Interface11 imethod_5(string? string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new Class229((XObject?)new XText(string_0));
	}

	public Interface11 imethod_6(string? string_0, string? string_1, string? string_2)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		return new Class230(new XDeclaration(string_0, string_1, string_2));
	}

	public Interface11 imethod_7(string? string_0, string? string_1, string? string_2, string? string_3)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		return new Class231(new XDocumentType(string_0, string_1, string_2, string_3));
	}

	public Interface11 imethod_8(string string_0, string? string_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Class237(new XProcessingInstruction(string_0, string_1));
	}

	public Interface13 imethod_9(string string_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		return new Class234(new XElement(XName.op_Implicit(string_0)));
	}

	public Interface13 imethod_10(string string_0, string string_1)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		return new Class234(new XElement(XName.Get(Class4.smethod_425(string_0), string_1)));
	}

	public Interface11 imethod_11(string string_0, string? string_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		return new Class238(new XAttribute(XName.op_Implicit(string_0), (object)string_1));
	}

	public Interface11 imethod_12(string string_0, string string_1, string? string_2)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		return new Class238(new XAttribute(XName.Get(Class4.smethod_425(string_0), string_1), (object)string_2));
	}

	public override Interface11 imethod_0(Interface11 interface11_0)
	{
		if (interface11_0 is Class230 @class)
		{
			Document.set_Declaration(@class.Declaration);
			return @class;
		}
		return base.imethod_0(interface11_0);
	}
}
