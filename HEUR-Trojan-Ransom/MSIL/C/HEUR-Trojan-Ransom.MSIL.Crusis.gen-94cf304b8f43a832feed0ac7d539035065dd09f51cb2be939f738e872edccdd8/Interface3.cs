using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;

internal interface Interface3
{
	XmlElement this[string string_0] { get; }

	XmlElement this[string string_0, string string_1] { get; }

	XmlAttributeCollection XmlAttributeCollection_0 { get; }

	string String_0 { get; }

	XmlNodeList XmlNodeList_0 { get; }

	XmlNode XmlNode_0 { get; }

	bool Boolean_0 { get; }

	string String_1 { set; }

	string String_2 { set; }

	bool Boolean_1 { get; }

	XmlNode XmlNode_1 { get; }

	string String_3 { get; }

	string String_4 { get; }

	string String_5 { get; }

	XmlNode XmlNode_2 { get; }

	XmlNodeType XmlNodeType_0 { get; }

	string String_6 { get; }

	XmlDocument XmlDocument_0 { get; }

	XmlElement XmlElement_0 { get; }

	XmlNode XmlNode_3 { get; }

	string String_7 { get; set; }

	XmlNode XmlNode_4 { get; }

	IXmlSchemaInfo IXmlSchemaInfo_0 { get; }

	bool Boolean_2 { get; }

	string String_8 { get; set; }

	XmlNode imethod_0(XmlNode xmlNode_0);

	XmlNode imethod_1();

	XmlNode imethod_2(bool bool_0);

	XPathNavigator imethod_3();

	bool imethod_4(object object_0);

	int imethod_5();

	string imethod_6(string string_0);

	string imethod_7(string string_0);

	XmlNode imethod_8(XmlNode xmlNode_0, XmlNode xmlNode_1);

	XmlNode imethod_9(XmlNode xmlNode_0, XmlNode xmlNode_1);

	void imethod_10();

	XmlNode imethod_11(XmlNode xmlNode_0);

	void imethod_12();

	XmlNode imethod_13(XmlNode xmlNode_0);

	XmlNode imethod_14(XmlNode xmlNode_0, XmlNode xmlNode_1);

	bool imethod_15(string string_0, string string_1);

	string imethod_16();

	void imethod_17(XmlWriter xmlWriter_0);

	void imethod_18(XmlWriter xmlWriter_0);
}
