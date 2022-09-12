using System.Collections.Generic;
using System.Xml;
using ns1;
using ns17;
using ns5;
using ns6;

namespace ns9;

internal class Class224 : Interface11
{
	private readonly XmlNode xmlNode_0;

	private List<Interface11>? list_0;

	private List<Interface11>? list_1;

	public object? WrappedNode => xmlNode_0;

	public XmlNodeType NodeType => xmlNode_0.NodeType;

	public virtual string? LocalName => xmlNode_0.LocalName;

	public List<Interface11> ChildNodes
	{
		get
		{
			if (list_0 == null)
			{
				if (!xmlNode_0.HasChildNodes)
				{
					list_0 = Class27.list_0;
				}
				else
				{
					list_0 = new List<Interface11>(xmlNode_0.ChildNodes.Count);
					foreach (XmlNode childNode in xmlNode_0.ChildNodes)
					{
						list_0!.Add(smethod_0(childNode));
					}
				}
			}
			return list_0;
		}
	}

	protected virtual bool HasChildNodes => xmlNode_0.HasChildNodes;

	public List<Interface11> Attributes
	{
		get
		{
			if (list_1 == null)
			{
				if (!HasAttributes)
				{
					list_1 = Class27.list_0;
				}
				else
				{
					list_1 = new List<Interface11>(xmlNode_0.Attributes!.Count);
					foreach (XmlAttribute item in xmlNode_0.Attributes!)
					{
						list_1!.Add(smethod_0(item));
					}
				}
			}
			return list_1;
		}
	}

	private bool HasAttributes
	{
		get
		{
			if (xmlNode_0 is XmlElement xmlElement)
			{
				return xmlElement.HasAttributes;
			}
			XmlAttributeCollection? attributes = xmlNode_0.Attributes;
			if (attributes == null)
			{
				return false;
			}
			return attributes!.Count > 0;
		}
	}

	public Interface11? ParentNode
	{
		get
		{
			XmlNode xmlNode = ((xmlNode_0 is XmlAttribute xmlAttribute) ? xmlAttribute.OwnerElement : xmlNode_0.ParentNode);
			if (xmlNode == null)
			{
				return null;
			}
			return smethod_0(xmlNode);
		}
	}

	public string? Value
	{
		get
		{
			return xmlNode_0.Value;
		}
		set
		{
			xmlNode_0.Value = value;
		}
	}

	public string? NamespaceUri => xmlNode_0.NamespaceURI;

	public Class224(XmlNode xmlNode_1)
	{
		xmlNode_0 = xmlNode_1;
	}

	internal static Interface11 smethod_0(XmlNode xmlNode_1)
	{
		return xmlNode_1.NodeType switch
		{
			XmlNodeType.XmlDeclaration => new Class227((XmlDeclaration)xmlNode_1), 
			XmlNodeType.DocumentType => new Class228((XmlDocumentType)xmlNode_1), 
			XmlNodeType.Element => new Class226((XmlElement)xmlNode_1), 
			_ => new Class224(xmlNode_1), 
		};
	}

	public Interface11 imethod_0(Interface11 interface11_0)
	{
		Class224 @class = (Class224)interface11_0;
		xmlNode_0.AppendChild(@class.xmlNode_0);
		list_0 = null;
		list_1 = null;
		return interface11_0;
	}
}
