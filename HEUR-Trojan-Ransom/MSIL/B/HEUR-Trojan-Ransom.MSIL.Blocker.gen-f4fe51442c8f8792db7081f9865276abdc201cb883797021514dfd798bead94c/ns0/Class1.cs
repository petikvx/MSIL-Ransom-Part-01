using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using Fm;

namespace ns0;

internal sealed class Class1 : XmlDocumentFragment
{
	public override XmlElement this[string string_0] => base[string_0];

	public override XmlElement this[string string_0, string string_1] => base[string_0, string_1];

	public override string String_0
	{
		get
		{
			return base.Value;
		}
		set
		{
			base.Value = value;
		}
	}

	public override XmlNodeList XmlNodeList_0 => base.ChildNodes;

	public override XmlNode XmlNode_0 => base.PreviousSibling;

	public override XmlNode XmlNode_1 => base.NextSibling;

	public override XmlAttributeCollection XmlAttributeCollection_0 => base.Attributes;

	public override XmlNode XmlNode_2 => base.FirstChild;

	public override XmlNode XmlNode_3 => base.LastChild;

	public override bool Boolean_0 => base.HasChildNodes;

	public override string String_1 => base.NamespaceURI;

	public override string String_2
	{
		get
		{
			return base.Prefix;
		}
		set
		{
			base.Prefix = value;
		}
	}

	public override bool Boolean_1 => base.IsReadOnly;

	public override string String_3
	{
		get
		{
			return base.InnerText;
		}
		set
		{
			base.InnerText = value;
		}
	}

	public override string String_4 => base.OuterXml;

	public override IXmlSchemaInfo IXmlSchemaInfo_0 => base.SchemaInfo;

	public override string String_5 => base.BaseURI;

	public override string String_6 => base.Name;

	public override string String_7 => base.LocalName;

	public override XmlNodeType XmlNodeType_0 => base.NodeType;

	public override XmlNode XmlNode_4 => base.ParentNode;

	public override XmlDocument XmlDocument_0 => base.OwnerDocument;

	public override string String_8
	{
		get
		{
			return base.InnerXml;
		}
		set
		{
			base.InnerXml = value;
		}
	}

	protected internal Class1(XmlDocument xmlDocument_0)
		: base(xmlDocument_0)
	{
	}

	internal static void smethod_0()
	{
		Program.Main();
	}

	public override XmlNode vmethod_0(XmlNode xmlNode_0)
	{
		return base.AppendChild(xmlNode_0);
	}

	public override XmlNode vmethod_1()
	{
		return base.Clone();
	}

	public override XmlNode vmethod_2(bool bool_0)
	{
		return CloneNode(bool_0);
	}

	public override XPathNavigator vmethod_3()
	{
		return base.CreateNavigator();
	}

	public override bool vmethod_4(object object_0)
	{
		return base.Equals(object_0);
	}

	public override int vmethod_5()
	{
		return base.GetHashCode();
	}

	public override string vmethod_6(string string_0)
	{
		return base.GetNamespaceOfPrefix(string_0);
	}

	public override string vmethod_7(string string_0)
	{
		return base.GetPrefixOfNamespace(string_0);
	}

	public override XmlNode vmethod_8(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.InsertAfter(xmlNode_0, xmlNode_1);
	}

	public override XmlNode vmethod_9(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.InsertBefore(xmlNode_0, xmlNode_1);
	}

	public override void vmethod_10()
	{
		base.Normalize();
	}

	public override XmlNode vmethod_11(XmlNode xmlNode_0)
	{
		return base.PrependChild(xmlNode_0);
	}

	public override void vmethod_12()
	{
		base.RemoveAll();
	}

	public override XmlNode vmethod_13(XmlNode xmlNode_0)
	{
		return base.RemoveChild(xmlNode_0);
	}

	public override XmlNode vmethod_14(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.ReplaceChild(xmlNode_0, xmlNode_1);
	}

	public override bool vmethod_15(string string_0, string string_1)
	{
		return base.Supports(string_0, string_1);
	}

	public override string vmethod_16()
	{
		return base.ToString();
	}

	public override void vmethod_17(XmlWriter xmlWriter_0)
	{
		WriteContentTo(xmlWriter_0);
	}

	public override void vmethod_18(XmlWriter xmlWriter_0)
	{
		WriteTo(xmlWriter_0);
	}
}
