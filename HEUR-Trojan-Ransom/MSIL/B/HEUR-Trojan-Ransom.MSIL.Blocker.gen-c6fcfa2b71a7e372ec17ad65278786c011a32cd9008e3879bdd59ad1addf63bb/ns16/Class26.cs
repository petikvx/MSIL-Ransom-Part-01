using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using ns1;
using ns13;
using ns17;
using ns18;
using ns3;
using ns4;
using ns5;
using ns9;

namespace ns16;

internal class Class26 : Class8
{
	internal static readonly List<Interface11> list_0 = new List<Interface11>();

	private const string string_0 = "#text";

	private const string string_1 = "#comment";

	private const string string_2 = "#cdata-section";

	private const string string_3 = "#whitespace";

	private const string string_4 = "#significant-whitespace";

	private const string string_5 = "?xml";

	private const string string_6 = "http://james.newtonking.com/projects/json";

	[CompilerGenerated]
	private string? string_7;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	public string? DeserializeRootElementName
	{
		[CompilerGenerated]
		get
		{
			return string_7;
		}
		[CompilerGenerated]
		set
		{
			string_7 = value;
		}
	}

	public bool WriteArrayAttribute
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool OmitRootObject
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public bool EncodeSpecialCharacters
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public override void vmethod_0(Class37 class37_0, object? object_0, Class33 class33_0)
	{
		if (object_0 == null)
		{
			class37_0.vmethod_17();
			return;
		}
		Interface11 interface11_ = Class131.smethod_734(this, object_0);
		XmlNamespaceManager xmlNamespaceManager_ = new XmlNamespaceManager(new NameTable());
		method_0(interface11_, xmlNamespaceManager_);
		if (!OmitRootObject)
		{
			class37_0.vmethod_3();
		}
		method_3(class37_0, interface11_, xmlNamespaceManager_, !OmitRootObject);
		if (!OmitRootObject)
		{
			class37_0.vmethod_4();
		}
	}

	private void method_0(Interface11 interface11_0, XmlNamespaceManager xmlNamespaceManager_0)
	{
		List<Interface11> list = null;
		Interface11 @interface = interface11_0;
		while ((@interface = @interface.ParentNode) != null)
		{
			if (@interface.NodeType == XmlNodeType.Element)
			{
				if (list == null)
				{
					list = new List<Interface11>();
				}
				list.Add(@interface);
			}
		}
		if (list == null)
		{
			return;
		}
		list.Reverse();
		foreach (Interface11 item in list)
		{
			xmlNamespaceManager_0.PushScope();
			foreach (Interface11 attribute in item.Attributes)
			{
				if (attribute.NamespaceUri == "http://www.w3.org/2000/xmlns/" && attribute.LocalName != "xmlns")
				{
					xmlNamespaceManager_0.AddNamespace(attribute.LocalName, attribute.Value);
				}
			}
		}
	}

	internal bool method_1(Interface11 interface11_0)
	{
		foreach (Interface11 attribute in interface11_0.Attributes)
		{
			if (attribute.LocalName == "Array" && attribute.NamespaceUri == "http://james.newtonking.com/projects/json")
			{
				return XmlConvert.ToBoolean(attribute.Value);
			}
		}
		return false;
	}

	private void method_2(Class37 class37_0, Interface11 interface11_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_3)
	{
		switch (interface11_0.ChildNodes.Count)
		{
		case 1:
		{
			string text = Class131.smethod_623(xmlNamespaceManager_0, this, interface11_0.ChildNodes[0]);
			Class131.smethod_322(class37_0, bool_3, text, xmlNamespaceManager_0, interface11_0.ChildNodes, this);
			return;
		}
		case 0:
			return;
		}
		Dictionary<string, object> dictionary = null;
		string text2 = null;
		for (int i = 0; i < interface11_0.ChildNodes.Count; i++)
		{
			Interface11 @interface = interface11_0.ChildNodes[i];
			string text3 = Class131.smethod_623(xmlNamespaceManager_0, this, @interface);
			object value;
			if (dictionary == null)
			{
				if (text2 == null)
				{
					text2 = text3;
					continue;
				}
				if (text3 == text2)
				{
					continue;
				}
				dictionary = new Dictionary<string, object>();
				if (i > 1)
				{
					List<Interface11> list = new List<Interface11>(i);
					for (int j = 0; j < i; j++)
					{
						list.Add(interface11_0.ChildNodes[j]);
					}
					dictionary.Add(text2, list);
				}
				else
				{
					dictionary.Add(text2, interface11_0.ChildNodes[0]);
				}
				dictionary.Add(text3, @interface);
			}
			else if (!dictionary.TryGetValue(text3, out value))
			{
				dictionary.Add(text3, @interface);
			}
			else
			{
				List<Interface11> list2 = value as List<Interface11>;
				if (list2 == null)
				{
					list2 = (List<Interface11>)(dictionary[text3] = new List<Interface11> { (Interface11)value });
				}
				list2.Add(@interface);
			}
		}
		if (dictionary == null)
		{
			Class131.smethod_322(class37_0, bool_3, text2, xmlNamespaceManager_0, interface11_0.ChildNodes, this);
			return;
		}
		foreach (KeyValuePair<string, object> item in dictionary)
		{
			if (item.Value is List<Interface11> list3)
			{
				Class131.smethod_322(class37_0, bool_3, item.Key, xmlNamespaceManager_0, list3, this);
			}
			else
			{
				Class131.smethod_253(this, class37_0, xmlNamespaceManager_0, bool_3, (Interface11)item.Value, item.Key);
			}
		}
	}

	internal void method_3(Class37 class37_0, Interface11 interface11_0, XmlNamespaceManager xmlNamespaceManager_0, bool bool_3)
	{
		switch (interface11_0.NodeType)
		{
		case XmlNodeType.Element:
			if (method_1(interface11_0) && smethod_0(interface11_0) && interface11_0.ChildNodes.Count > 0)
			{
				method_2(class37_0, interface11_0, xmlNamespaceManager_0, bool_3: false);
				break;
			}
			xmlNamespaceManager_0.PushScope();
			foreach (Interface11 attribute in interface11_0.Attributes)
			{
				if (attribute.NamespaceUri == "http://www.w3.org/2000/xmlns/")
				{
					string prefix = ((attribute.LocalName != "xmlns") ? XmlConvert.DecodeName(attribute.LocalName) : string.Empty);
					string value = attribute.Value;
					if (value == null)
					{
						throw new JsonSerializationException("Namespace attribute must have a value.");
					}
					xmlNamespaceManager_0.AddNamespace(prefix, value);
				}
			}
			if (bool_3)
			{
				class37_0.vmethod_9(Class131.smethod_623(xmlNamespaceManager_0, this, interface11_0));
			}
			if (!method_7(interface11_0.Attributes) && interface11_0.ChildNodes.Count == 1 && interface11_0.ChildNodes[0].NodeType == XmlNodeType.Text)
			{
				class37_0.vmethod_21(interface11_0.ChildNodes[0].Value);
			}
			else if (interface11_0.ChildNodes.Count == 0 && interface11_0.Attributes.Count == 0)
			{
				if (((Interface13)interface11_0).IsEmpty)
				{
					class37_0.vmethod_17();
				}
				else
				{
					class37_0.vmethod_21(string.Empty);
				}
			}
			else
			{
				class37_0.vmethod_3();
				for (int i = 0; i < interface11_0.Attributes.Count; i++)
				{
					method_3(class37_0, interface11_0.Attributes[i], xmlNamespaceManager_0, bool_3: true);
				}
				method_2(class37_0, interface11_0, xmlNamespaceManager_0, bool_3: true);
				class37_0.vmethod_4();
			}
			xmlNamespaceManager_0.PopScope();
			break;
		case XmlNodeType.Comment:
			if (bool_3)
			{
				class37_0.vmethod_59(interface11_0.Value);
			}
			break;
		case XmlNodeType.DocumentType:
		{
			Interface15 interface2 = (Interface15)interface11_0;
			class37_0.vmethod_9(Class131.smethod_623(xmlNamespaceManager_0, this, interface11_0));
			class37_0.vmethod_3();
			if (!Class108.smethod_0(interface2.Name))
			{
				class37_0.vmethod_9("@name");
				class37_0.vmethod_21(interface2.Name);
			}
			if (!Class108.smethod_0(interface2.Public))
			{
				class37_0.vmethod_9("@public");
				class37_0.vmethod_21(interface2.Public);
			}
			if (!Class108.smethod_0(interface2.System))
			{
				class37_0.vmethod_9("@system");
				class37_0.vmethod_21(interface2.System);
			}
			if (!Class108.smethod_0(interface2.InternalSubset))
			{
				class37_0.vmethod_9("@internalSubset");
				class37_0.vmethod_21(interface2.InternalSubset);
			}
			class37_0.vmethod_4();
			break;
		}
		case XmlNodeType.Document:
		case XmlNodeType.DocumentFragment:
			method_2(class37_0, interface11_0, xmlNamespaceManager_0, bool_3);
			break;
		case XmlNodeType.Attribute:
		case XmlNodeType.Text:
		case XmlNodeType.CDATA:
		case XmlNodeType.ProcessingInstruction:
		case XmlNodeType.Whitespace:
		case XmlNodeType.SignificantWhitespace:
			if ((!(interface11_0.NamespaceUri == "http://www.w3.org/2000/xmlns/") || !(interface11_0.Value == "http://james.newtonking.com/projects/json")) && (!(interface11_0.NamespaceUri == "http://james.newtonking.com/projects/json") || !(interface11_0.LocalName == "Array")))
			{
				if (bool_3)
				{
					class37_0.vmethod_9(Class131.smethod_623(xmlNamespaceManager_0, this, interface11_0));
				}
				class37_0.vmethod_21(interface11_0.Value);
			}
			break;
		default:
			throw new JsonSerializationException("Unexpected XmlNodeType when serializing nodes: " + interface11_0.NodeType);
		case XmlNodeType.XmlDeclaration:
		{
			Interface14 @interface = (Interface14)interface11_0;
			class37_0.vmethod_9(Class131.smethod_623(xmlNamespaceManager_0, this, interface11_0));
			class37_0.vmethod_3();
			if (!Class108.smethod_0(@interface.Version))
			{
				class37_0.vmethod_9("@version");
				class37_0.vmethod_21(@interface.Version);
			}
			if (!Class108.smethod_0(@interface.Encoding))
			{
				class37_0.vmethod_9("@encoding");
				class37_0.vmethod_21(@interface.Encoding);
			}
			if (!Class108.smethod_0(@interface.Standalone))
			{
				class37_0.vmethod_9("@standalone");
				class37_0.vmethod_21(@interface.Standalone);
			}
			class37_0.vmethod_4();
			break;
		}
		}
	}

	private static bool smethod_0(Interface11 interface11_0)
	{
		foreach (Interface11 childNode in interface11_0.ChildNodes)
		{
			if (childNode.LocalName != interface11_0.LocalName)
			{
				return false;
			}
		}
		return true;
	}

	public override object? vmethod_1(Class28 class28_0, Type type_0, object? object_0, Class33 class33_0)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		switch (class28_0.TokenType)
		{
		case JsonToken.Null:
			return null;
		default:
			throw Class131.smethod_38(class28_0, "XmlNodeConverter can only convert JSON that begins with an object.");
		case JsonToken.StartObject:
		{
			XmlNamespaceManager xmlNamespaceManager_ = new XmlNamespaceManager(new NameTable());
			Interface12 @interface = null;
			Interface11 interface2 = null;
			if (typeof(XObject).IsAssignableFrom(type_0))
			{
				if (type_0 != typeof(XContainer) && type_0 != typeof(XDocument) && type_0 != typeof(XElement) && type_0 != typeof(XNode) && type_0 != typeof(XObject))
				{
					throw Class131.smethod_38(class28_0, "XmlNodeConverter only supports deserializing XDocument, XElement, XContainer, XNode or XObject.");
				}
				@interface = new Class233(new XDocument());
				interface2 = @interface;
			}
			if (typeof(XmlNode).IsAssignableFrom(type_0))
			{
				if (type_0 != typeof(XmlDocument) && type_0 != typeof(XmlElement) && type_0 != typeof(XmlNode))
				{
					throw Class131.smethod_38(class28_0, "XmlNodeConverter only supports deserializing XmlDocument, XmlElement or XmlNode.");
				}
				@interface = new Class225(new XmlDocument
				{
					XmlResolver = null
				});
				interface2 = @interface;
			}
			if (@interface != null && interface2 != null)
			{
				if (!Class108.smethod_0(DeserializeRootElementName))
				{
					Class131.smethod_496(this, class28_0, @interface, interface2, DeserializeRootElementName, xmlNamespaceManager_);
				}
				else
				{
					Class131.smethod_167(class28_0);
					method_6(class28_0, @interface, xmlNamespaceManager_, interface2);
				}
				if (type_0 == typeof(XElement))
				{
					XElement val = (XElement)@interface.DocumentElement!.WrappedNode;
					((XNode)val).Remove();
					return (object?)val;
				}
				if (type_0 == typeof(XmlElement))
				{
					return @interface.DocumentElement!.WrappedNode;
				}
				return @interface.WrappedNode;
			}
			throw Class131.smethod_38(class28_0, "Unexpected type when converting XML: " + type_0);
		}
		}
	}

	internal void method_4(Class28 class28_0, Interface12 interface12_0, Interface11 interface11_0, string string_8, XmlNamespaceManager xmlNamespaceManager_0, string? string_9, Dictionary<string, string?>? dictionary_0)
	{
		Interface13 @interface = Class131.smethod_129(interface12_0, string_9, this, xmlNamespaceManager_0, string_8);
		interface11_0.imethod_0(@interface);
		if (dictionary_0 != null)
		{
			foreach (KeyValuePair<string, string> item in dictionary_0!)
			{
				string text = XmlConvert.EncodeName(item.Key);
				string prefix = Class131.smethod_16(item.Key);
				Interface11 interface11_ = ((!Class108.smethod_0(prefix)) ? interface12_0.imethod_12(text, xmlNamespaceManager_0.LookupNamespace(prefix) ?? string.Empty, item.Value) : interface12_0.imethod_11(text, item.Value));
				@interface.imethod_1(interface11_);
			}
		}
		switch (class28_0.TokenType)
		{
		case JsonToken.EndObject:
			xmlNamespaceManager_0.RemoveNamespace(string.Empty, xmlNamespaceManager_0.DefaultNamespace);
			break;
		default:
			xmlNamespaceManager_0.PushScope();
			method_6(class28_0, interface12_0, xmlNamespaceManager_0, @interface);
			xmlNamespaceManager_0.PopScope();
			xmlNamespaceManager_0.RemoveNamespace(string.Empty, xmlNamespaceManager_0.DefaultNamespace);
			break;
		case JsonToken.Integer:
		case JsonToken.Float:
		case JsonToken.String:
		case JsonToken.Boolean:
		case JsonToken.Date:
		case JsonToken.Bytes:
		{
			string text2 = Class131.smethod_656(class28_0);
			if (text2 != null)
			{
				@interface.imethod_0(interface12_0.imethod_2(text2));
			}
			break;
		}
		case JsonToken.Null:
			break;
		}
	}

	internal void method_5(Class28 class28_0, Interface12 interface12_0, string string_8, Interface11 interface11_0, XmlNamespaceManager xmlNamespaceManager_0)
	{
		string text = Class131.smethod_16(string_8);
		Interface13 @interface = Class131.smethod_129(interface12_0, text, this, xmlNamespaceManager_0, string_8);
		interface11_0.imethod_0(@interface);
		int num = 0;
		while (class28_0.vmethod_0() && class28_0.TokenType != JsonToken.EndArray)
		{
			Class131.smethod_382(this, class28_0, interface12_0, xmlNamespaceManager_0, string_8, (Interface11)@interface);
			num++;
		}
		if (WriteArrayAttribute)
		{
			Class131.smethod_370(interface12_0, @interface, this);
		}
		if (num != 1 || !WriteArrayAttribute)
		{
			return;
		}
		foreach (Interface11 childNode in @interface.ChildNodes)
		{
			if (childNode is Interface13 interface2 && interface2.LocalName == string_8)
			{
				Class131.smethod_370(interface12_0, interface2, this);
				break;
			}
		}
	}

	private void method_6(Class28 class28_0, Interface12 interface12_0, XmlNamespaceManager xmlNamespaceManager_0, Interface11 interface11_0)
	{
		string text3 = default(string);
		do
		{
			switch (class28_0.TokenType)
			{
			case JsonToken.Comment:
				interface11_0.imethod_0(interface12_0.imethod_1((string)class28_0.Value));
				break;
			case JsonToken.PropertyName:
				if (interface11_0.NodeType != XmlNodeType.Document || interface12_0.DocumentElement == null)
				{
					string text2 = class28_0.Value!.ToString();
					Class131.smethod_167(class28_0);
					if (class28_0.TokenType == JsonToken.StartArray)
					{
						int num = 0;
						while (class28_0.vmethod_0() && class28_0.TokenType != JsonToken.EndArray)
						{
							Class131.smethod_382(this, class28_0, interface12_0, xmlNamespaceManager_0, text2, interface11_0);
							num++;
						}
						if (num != 1 || !WriteArrayAttribute)
						{
							break;
						}
						Class131.smethod_526(ref text3, out string prefix, text2);
						string text4 = (Class108.smethod_0(prefix) ? xmlNamespaceManager_0.DefaultNamespace : xmlNamespaceManager_0.LookupNamespace(prefix));
						foreach (Interface11 childNode in interface11_0.ChildNodes)
						{
							if (childNode is Interface13 @interface && @interface.LocalName == text3 && @interface.NamespaceUri == text4)
							{
								Class131.smethod_370(interface12_0, @interface, this);
								break;
							}
						}
					}
					else
					{
						Class131.smethod_382(this, class28_0, interface12_0, xmlNamespaceManager_0, text2, interface11_0);
					}
					break;
				}
				throw Class131.smethod_38(class28_0, "JSON root object has multiple properties. The root object must have a single property in order to create a valid XML document. Consider specifying a DeserializeRootElementName.");
			case JsonToken.StartConstructor:
			{
				string text = class28_0.Value!.ToString();
				while (class28_0.vmethod_0() && class28_0.TokenType != JsonToken.EndConstructor)
				{
					Class131.smethod_382(this, class28_0, interface12_0, xmlNamespaceManager_0, text, interface11_0);
				}
				break;
			}
			default:
				throw Class131.smethod_38(class28_0, "Unexpected JsonToken when deserializing node: " + class28_0.TokenType);
			case JsonToken.EndObject:
			case JsonToken.EndArray:
				return;
			}
		}
		while (class28_0.vmethod_0());
	}

	private bool method_7(List<Interface11> list_1)
	{
		foreach (Interface11 item in list_1)
		{
			if (!(item.NamespaceUri == "http://james.newtonking.com/projects/json") && (!(item.NamespaceUri == "http://www.w3.org/2000/xmlns/") || !(item.Value == "http://james.newtonking.com/projects/json")))
			{
				return true;
			}
		}
		return false;
	}

	public override bool vmethod_2(Type type_0)
	{
		if (type_0.smethod_16("System.Xml.Linq.XObject", bool_0: false))
		{
			return Class131.smethod_236(type_0, this);
		}
		if (type_0.smethod_16("System.Xml.XmlNode", bool_0: false))
		{
			return Class131.smethod_36(type_0, this);
		}
		return false;
	}
}
