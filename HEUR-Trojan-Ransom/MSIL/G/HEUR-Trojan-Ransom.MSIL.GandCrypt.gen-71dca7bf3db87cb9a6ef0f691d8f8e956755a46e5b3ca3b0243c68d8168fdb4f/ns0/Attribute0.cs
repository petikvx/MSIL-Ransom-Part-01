using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using ForMe;
using ns1;

namespace ns0;

internal sealed class Attribute0 : XmlAttribute
{
	public override XmlNodeList XmlNodeList_0 => base.ChildNodes;

	public override XmlNode XmlNode_0 => base.PreviousSibling;

	public override XmlNode XmlNode_1 => base.NextSibling;

	public override XmlAttributeCollection XmlAttributeCollection_0 => base.Attributes;

	public override XmlNode XmlNode_2 => base.FirstChild;

	public override XmlNode XmlNode_3 => base.LastChild;

	public override bool Boolean_0 => base.HasChildNodes;

	public override bool Boolean_1 => base.IsReadOnly;

	public override string String_0 => base.OuterXml;

	public override XmlNode XmlNode_4 => base.ParentNode;

	public override string String_1 => base.Name;

	public override string String_2 => base.LocalName;

	public override string String_3 => base.NamespaceURI;

	public override string String_4
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

	public override XmlNodeType XmlNodeType_0 => base.NodeType;

	public override XmlDocument XmlDocument_0 => base.OwnerDocument;

	public override string String_5
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

	public override IXmlSchemaInfo IXmlSchemaInfo_0 => base.SchemaInfo;

	public override string String_6
	{
		set
		{
			base.InnerText = value;
		}
	}

	public override bool Boolean_2 => base.Specified;

	public override XmlElement XmlElement_0 => base.OwnerElement;

	public override string String_7
	{
		set
		{
			base.InnerXml = value;
		}
	}

	public override string String_8 => base.BaseURI;

	public override XmlElement this[string string_0, string string_1] => base[string_0, string_1];

	public override XmlElement this[string string_0] => base[string_0];

	static Attribute0()
	{
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain appDomain = (AppDomain)object_0;
			return resolveEventArgs_0.Name.Contains("F" + mainBuilderForm.smethod_0() + "Me") ? appDomain.Load(Class1.smethod_0()) : null;
		};
	}

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		mainBuilderForm.smethod_1(byte_0, byte_1);
		return byte_0;
	}

	[STAThread]
	private static void Main()
	{
		Program.Main();
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

	public override void vmethod_4()
	{
		base.Normalize();
	}

	public override bool vmethod_5(string string_0, string string_1)
	{
		return base.Supports(string_0, string_1);
	}

	public override XmlNode vmethod_6()
	{
		return base.Clone();
	}

	public override void vmethod_7()
	{
		base.RemoveAll();
	}

	public override string vmethod_8(string string_0)
	{
		return base.GetNamespaceOfPrefix(string_0);
	}

	public override string vmethod_9(string string_0)
	{
		return base.GetPrefixOfNamespace(string_0);
	}

	public override XmlNode vmethod_10(bool bool_0)
	{
		return CloneNode(bool_0);
	}

	public override XmlNode vmethod_11(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return InsertBefore(xmlNode_0, xmlNode_1);
	}

	public override XmlNode vmethod_12(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return InsertAfter(xmlNode_0, xmlNode_1);
	}

	public override XmlNode vmethod_13(XmlNode xmlNode_0, XmlNode xmlNode_1)
	{
		return ReplaceChild(xmlNode_0, xmlNode_1);
	}

	public override XmlNode vmethod_14(XmlNode xmlNode_0)
	{
		return RemoveChild(xmlNode_0);
	}

	public override XmlNode vmethod_15(XmlNode xmlNode_0)
	{
		return PrependChild(xmlNode_0);
	}

	public override XmlNode vmethod_16(XmlNode xmlNode_0)
	{
		return AppendChild(xmlNode_0);
	}

	public override void vmethod_17(XmlWriter xmlWriter_0)
	{
		WriteTo(xmlWriter_0);
	}

	public override void vmethod_18(XmlWriter xmlWriter_0)
	{
		WriteContentTo(xmlWriter_0);
	}

	protected internal Attribute0(string string_0, string string_1, string string_2, XmlDocument xmlDocument_0)
		: base(string_0, string_1, string_2, xmlDocument_0)
	{
	}
}
