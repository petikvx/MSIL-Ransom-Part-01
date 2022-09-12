using System.Xml;
using ns12;
using ns17;
using ns18;
using ns19;
using ns9;

namespace ns1;

internal class Class225 : Class224, Interface11, Interface12
{
	private readonly XmlDocument xmlDocument_0;

	public Interface13? DocumentElement
	{
		get
		{
			if (xmlDocument_0.DocumentElement == null)
			{
				return null;
			}
			return new Class226(xmlDocument_0.DocumentElement);
		}
	}

	public Class225(XmlDocument xmlDocument_1)
		: base(xmlDocument_1)
	{
		xmlDocument_0 = xmlDocument_1;
	}

	public Interface11 imethod_1(string? string_0)
	{
		return new Class224(xmlDocument_0.CreateComment(string_0));
	}

	public Interface11 imethod_2(string? string_0)
	{
		return new Class224(xmlDocument_0.CreateTextNode(string_0));
	}

	public Interface11 imethod_3(string? string_0)
	{
		return new Class224(xmlDocument_0.CreateCDataSection(string_0));
	}

	public Interface11 imethod_4(string? string_0)
	{
		return new Class224(xmlDocument_0.CreateWhitespace(string_0));
	}

	public Interface11 imethod_5(string? string_0)
	{
		return new Class224(xmlDocument_0.CreateSignificantWhitespace(string_0));
	}

	public Interface11 imethod_6(string? string_0, string? string_1, string? string_2)
	{
		return new Class227(xmlDocument_0.CreateXmlDeclaration(string_0, string_1, string_2));
	}

	public Interface11 imethod_7(string? string_0, string? string_1, string? string_2, string? string_3)
	{
		return new Class228(xmlDocument_0.CreateDocumentType(string_0, string_1, string_2, null));
	}

	public Interface11 imethod_8(string string_0, string? string_1)
	{
		return new Class224(xmlDocument_0.CreateProcessingInstruction(string_0, string_1));
	}

	public Interface13 imethod_9(string string_0)
	{
		return new Class226(xmlDocument_0.CreateElement(string_0));
	}

	public Interface13 imethod_10(string string_0, string string_1)
	{
		return new Class226(xmlDocument_0.CreateElement(string_0, string_1));
	}

	public Interface11 imethod_11(string string_0, string? string_1)
	{
		return new Class224(xmlDocument_0.CreateAttribute(string_0))
		{
			Value = string_1
		};
	}

	public Interface11 imethod_12(string string_0, string string_1, string? string_2)
	{
		return new Class224(xmlDocument_0.CreateAttribute(string_0, string_1))
		{
			Value = string_2
		};
	}
}
