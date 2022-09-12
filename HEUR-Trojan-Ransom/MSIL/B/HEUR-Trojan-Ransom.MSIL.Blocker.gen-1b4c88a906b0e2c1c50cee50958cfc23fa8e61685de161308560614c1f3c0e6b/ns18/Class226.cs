using System.Xml;
using ns12;
using ns15;
using ns6;

namespace ns18;

internal class Class226 : Class224, Interface11, Interface13
{
	private readonly XmlElement xmlElement_0;

	public bool IsEmpty => xmlElement_0.IsEmpty;

	public Class226(XmlElement xmlElement_1)
		: base(xmlElement_1)
	{
		xmlElement_0 = xmlElement_1;
	}

	public void imethod_1(Interface11 interface11_0)
	{
		Class224 @class = (Class224)interface11_0;
		xmlElement_0.SetAttributeNode((XmlAttribute)@class.WrappedNode);
	}

	public string imethod_2(string string_0)
	{
		return xmlElement_0.GetPrefixOfNamespace(string_0);
	}
}
