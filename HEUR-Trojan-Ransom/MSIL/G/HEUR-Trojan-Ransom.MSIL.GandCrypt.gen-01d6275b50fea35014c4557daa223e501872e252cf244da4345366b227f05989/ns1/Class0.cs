using System.Data;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

namespace ns1;

internal sealed class Class0 : XmlDataDocument
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

	public override string String_3 => base.OuterXml;

	public override XmlNodeType XmlNodeType_0 => base.NodeType;

	public override XmlNode XmlNode_4 => base.ParentNode;

	public override XmlDocumentType XmlDocumentType_0 => base.DocumentType;

	public override string String_4 => base.Name;

	public override string String_5 => base.LocalName;

	public override XmlDocument XmlDocument_0 => base.OwnerDocument;

	public override XmlResolver XmlResolver_0
	{
		set
		{
			base.XmlResolver = value;
		}
	}

	public override bool Boolean_1 => base.IsReadOnly;

	public override string String_6
	{
		set
		{
			base.InnerText = value;
		}
	}

	public override string String_7
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

	public override IXmlSchemaInfo IXmlSchemaInfo_0 => base.SchemaInfo;

	public override string String_8 => base.BaseURI;

	public Class0()
	{
	}

	public Class0(DataSet dataSet_0)
		: base(dataSet_0)
	{
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

	public override XmlAttribute vmethod_3(string string_0, string string_1, string string_2)
	{
		return base.CreateAttribute(string_0, string_1, string_2);
	}

	public override XmlCDataSection vmethod_4(string string_0)
	{
		return base.CreateCDataSection(string_0);
	}

	public override XmlComment vmethod_5(string string_0)
	{
		return base.CreateComment(string_0);
	}

	public override XmlDocumentFragment vmethod_6()
	{
		return base.CreateDocumentFragment();
	}

	public override XmlDocumentType vmethod_7(string string_0, string string_1, string string_2, string string_3)
	{
		return base.CreateDocumentType(string_0, string_1, string_2, string_3);
	}

	public override XmlElement vmethod_8(string string_0, string string_1, string string_2)
	{
		return CreateElement(string_0, string_1, string_2);
	}

	public override XmlEntityReference vmethod_9(string string_0)
	{
		return CreateEntityReference(string_0);
	}

	public override XPathNavigator vmethod_10()
	{
		return CreateNavigator();
	}

	public override XmlNode vmethod_11(XmlNodeType xmlNodeType_0, string string_0, string string_1, string string_2)
	{
		return base.CreateNode(xmlNodeType_0, string_0, string_1, string_2);
	}

	public override XmlNode vmethod_12(string string_0, string string_1, string string_2)
	{
		return base.CreateNode(string_0, string_1, string_2);
	}

	public override XmlNode vmethod_13(XmlNodeType xmlNodeType_0, string string_0, string string_1)
	{
		return base.CreateNode(xmlNodeType_0, string_0, string_1);
	}

	public override XmlProcessingInstruction vmethod_14(string string_0, string string_1)
	{
		return base.CreateProcessingInstruction(string_0, string_1);
	}

	public override XmlSignificantWhitespace vmethod_15(string string_0)
	{
		return base.CreateSignificantWhitespace(string_0);
	}

	public override XmlText vmethod_16(string string_0)
	{
		return base.CreateTextNode(string_0);
	}

	public override XmlWhitespace vmethod_17(string string_0)
	{
		return base.CreateWhitespace(string_0);
	}

	public override XmlDeclaration vmethod_18(string string_0, string string_1, string string_2)
	{
		return base.CreateXmlDeclaration(string_0, string_1, string_2);
	}

	public override bool vmethod_19(object object_0)
	{
		return base.Equals(object_0);
	}

	public override XmlElement vmethod_20(string string_0)
	{
		return GetElementById(string_0);
	}

	public override XmlNodeList vmethod_21(string string_0, string string_1)
	{
		return base.GetElementsByTagName(string_0, string_1);
	}

	public override XmlNodeList vmethod_22(string string_0)
	{
		return GetElementsByTagName(string_0);
	}

	public override int vmethod_23()
	{
		return base.GetHashCode();
	}

	public override string vmethod_24(string string_0)
	{
		return base.GetNamespaceOfPrefix(string_0);
	}

	public override string vmethod_25(string string_0)
	{
		return base.GetPrefixOfNamespace(string_0);
	}

	public override XmlNode vmethod_26(XmlNode xmlNode_0, bool bool_0)
	{
		return base.ImportNode(xmlNode_0, bool_0);
	}

	public override XmlNode vmethod_27(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.InsertAfter(xmlNode_0, xmlNode_1);
	}

	public override XmlNode vmethod_28(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.InsertBefore(xmlNode_0, xmlNode_1);
	}

	public override void vmethod_29(string string_0)
	{
		Load(string_0);
	}

	public override void vmethod_30(Stream stream_0)
	{
		Load(stream_0);
	}

	public override void vmethod_31(TextReader textReader_0)
	{
		Load(textReader_0);
	}

	public override void vmethod_32(XmlReader xmlReader_0)
	{
		Load(xmlReader_0);
	}

	public override void vmethod_33(string string_0)
	{
		base.LoadXml(string_0);
	}

	public override void vmethod_34()
	{
		base.Normalize();
	}

	public override XmlNode XnZ8W7J0pkdUMTDDHh2mFUaL2DNlkle2Nqc821ep0xjJxE4kgOxeJgYmhnx05YJLqEkMgjvgM8Fv0g1g9kduwrGUOTi1h9GJ2WdGbaWvz8H6ISpI0ta2zxTwh5WFcQHIBnQK(XmlNode xmlNode_0)
	{
		return base.PrependChild(xmlNode_0);
	}

	public override XmlNode vmethod_35(XmlReader xmlReader_0)
	{
		return base.ReadNode(xmlReader_0);
	}

	public override void vmethod_36()
	{
		base.RemoveAll();
	}

	public override XmlNode vmethod_37(XmlNode xmlNode_0)
	{
		return base.RemoveChild(xmlNode_0);
	}

	public override XmlNode vmethod_38(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return base.ReplaceChild(xmlNode_0, xmlNode_1);
	}

	public override void vmethod_39(string string_0)
	{
		base.Save(string_0);
	}

	public override void vmethod_40(Stream stream_0)
	{
		base.Save(stream_0);
	}

	public override void vmethod_41(TextWriter textWriter_0)
	{
		base.Save(textWriter_0);
	}

	public override void vmethod_42(XmlWriter xmlWriter_0)
	{
		base.Save(xmlWriter_0);
	}

	public override bool vmethod_43(string string_0, string string_1)
	{
		return base.Supports(string_0, string_1);
	}

	public override string vmethod_44()
	{
		return base.ToString();
	}

	public override void vmethod_45(XmlWriter xmlWriter_0)
	{
		WriteContentTo(xmlWriter_0);
	}

	public override void vmethod_46(XmlWriter xmlWriter_0)
	{
		WriteTo(xmlWriter_0);
	}

	protected override XmlAttribute vmethod_47(string string_0, string string_1, string string_2)
	{
		return base.CreateDefaultAttribute(string_0, string_1, string_2);
	}

	protected override XPathNavigator vmethod_48(XmlNode xmlNode_0)
	{
		return CreateNavigator(xmlNode_0);
	}
}
