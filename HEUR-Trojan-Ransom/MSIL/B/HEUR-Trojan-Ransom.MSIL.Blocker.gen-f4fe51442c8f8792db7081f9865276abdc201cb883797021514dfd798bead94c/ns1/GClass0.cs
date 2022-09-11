using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using ns0;

namespace ns1;

public class GClass0 : XmlCDataSection
{
	public override XmlNodeList ChildNodes => base.ChildNodes;

	public override XmlAttributeCollection Attributes => base.Attributes;

	public override XmlDocument OwnerDocument => base.OwnerDocument;

	public override XmlNode FirstChild => base.FirstChild;

	public override XmlNode LastChild => base.LastChild;

	public override bool HasChildNodes => base.HasChildNodes;

	public override string NamespaceURI => base.NamespaceURI;

	public override string Prefix
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

	public override bool IsReadOnly => base.IsReadOnly;

	public override string OuterXml => base.OuterXml;

	public override string InnerXml
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

	public override IXmlSchemaInfo SchemaInfo => base.SchemaInfo;

	public override string BaseURI => base.BaseURI;

	public override XmlNode PreviousSibling => base.PreviousSibling;

	public override XmlNode NextSibling => base.NextSibling;

	public override string Value
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

	public override string InnerText
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

	public override string Data
	{
		get
		{
			return base.Data;
		}
		set
		{
			base.Data = value;
		}
	}

	public override int Length => base.Length;

	public override string Name => base.Name;

	public override string LocalName => base.LocalName;

	public override XmlNodeType NodeType => base.NodeType;

	public override XmlNode ParentNode => base.ParentNode;

	public override XmlElement this[string string_0, string string_1] => base[string_0, string_1];

	public override XmlElement this[string string_0] => base[string_0];

	static GClass0()
	{
		LXButton.smethod_0();
	}

	[STAThread]
	public static void Main()
	{
		Class1.smethod_0();
	}

	public override string vmethod_0()
	{
		return base.ToString();
	}

	public override bool vmethod_1(object object_0)
	{
		return base.Equals(object_0);
	}

	public override int vmethod_2()
	{
		return base.GetHashCode();
	}

	public override XPathNavigator vmethod_3()
	{
		return base.CreateNavigator();
	}

	public override XmlNode vmethod_4(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.InsertBefore(xmlNode_0, xmlNode_1);
	}

	public override XmlNode vmethod_5(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.InsertAfter(xmlNode_0, xmlNode_1);
	}

	public override XmlNode vmethod_6(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.ReplaceChild(xmlNode_0, xmlNode_1);
	}

	public override XmlNode vmethod_7(XmlNode xmlNode_0)
	{
		return base.RemoveChild(xmlNode_0);
	}

	public override XmlNode vmethod_8(XmlNode xmlNode_0)
	{
		return base.PrependChild(xmlNode_0);
	}

	public override XmlNode vmethod_9(XmlNode xmlNode_0)
	{
		return base.AppendChild(xmlNode_0);
	}

	public override void vmethod_10()
	{
		base.Normalize();
	}

	public override bool vmethod_11(string string_0, string string_1)
	{
		return base.Supports(string_0, string_1);
	}

	public override XmlNode vmethod_12()
	{
		return base.Clone();
	}

	public override void vmethod_13()
	{
		base.RemoveAll();
	}

	public override string vmethod_14(string string_0)
	{
		return base.GetNamespaceOfPrefix(string_0);
	}

	public override string vmethod_15(string string_0)
	{
		return base.GetPrefixOfNamespace(string_0);
	}

	public override string vmethod_16(int int_0, int int_1)
	{
		return base.Substring(int_0, int_1);
	}

	public override void vmethod_17(string string_0)
	{
		base.AppendData(string_0);
	}

	public override void vmethod_18(int int_0, string string_0)
	{
		base.InsertData(int_0, string_0);
	}

	public override void vmethod_19(int int_0, int int_1)
	{
		base.DeleteData(int_0, int_1);
	}

	public override void vmethod_20(int int_0, int int_1, string string_0)
	{
		base.ReplaceData(int_0, int_1, string_0);
	}

	public override XmlNode vmethod_21(bool bool_0)
	{
		return CloneNode(bool_0);
	}

	public override void vmethod_22(XmlWriter xmlWriter_0)
	{
		WriteTo(xmlWriter_0);
	}

	public override void vmethod_23(XmlWriter xmlWriter_0)
	{
		WriteContentTo(xmlWriter_0);
	}

	protected internal GClass0(string string_0, XmlDocument xmlDocument_0)
		: base(string_0, xmlDocument_0)
	{
	}
}
