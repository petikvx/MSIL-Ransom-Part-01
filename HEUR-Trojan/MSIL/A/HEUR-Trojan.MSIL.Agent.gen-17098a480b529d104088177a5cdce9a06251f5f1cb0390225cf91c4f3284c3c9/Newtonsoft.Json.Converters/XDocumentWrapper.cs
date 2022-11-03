using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters;

internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode
{
	private XDocument Document => (XDocument)base.WrappedNode;

	public override List<IXmlNode> ChildNodes
	{
		get
		{
			List<IXmlNode> childNodes = base.ChildNodes;
			if (Document.get_Declaration() != null && (childNodes.Count == 0 || childNodes[0].NodeType != XmlNodeType.XmlDeclaration))
			{
				childNodes.Insert(0, new XDeclarationWrapper(Document.get_Declaration()));
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

	public IXmlElement? DocumentElement
	{
		get
		{
			if (Document.get_Root() == null)
			{
				return null;
			}
			return new XElementWrapper(Document.get_Root());
		}
	}

	public XDocumentWrapper(XDocument document)
		: base((XContainer)(object)document)
	{
	}

	public IXmlNode CreateComment(string? text)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new XObjectWrapper((XObject?)new XComment(text));
	}

	public IXmlNode CreateTextNode(string? text)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new XObjectWrapper((XObject?)new XText(text));
	}

	public IXmlNode CreateCDataSection(string? data)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new XObjectWrapper((XObject?)new XCData(data));
	}

	public IXmlNode CreateWhitespace(string? text)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new XObjectWrapper((XObject?)new XText(text));
	}

	public IXmlNode CreateSignificantWhitespace(string? text)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		return new XObjectWrapper((XObject?)new XText(text));
	}

	public IXmlNode CreateXmlDeclaration(string? version, string? encoding, string? standalone)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		return new XDeclarationWrapper(new XDeclaration(version, encoding, standalone));
	}

	public IXmlNode CreateXmlDocumentType(string? name, string? publicId, string? systemId, string? internalSubset)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		return new XDocumentTypeWrapper(new XDocumentType(name, publicId, systemId, internalSubset));
	}

	public IXmlNode CreateProcessingInstruction(string target, string? data)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new XProcessingInstructionWrapper(new XProcessingInstruction(target, data));
	}

	public IXmlElement CreateElement(string elementName)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		return new XElementWrapper(new XElement(XName.op_Implicit(elementName)));
	}

	public IXmlElement CreateElement(string qualifiedName, string namespaceUri)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		return new XElementWrapper(new XElement(XName.Get(MiscellaneousUtils.GetLocalName(qualifiedName), namespaceUri)));
	}

	public IXmlNode CreateAttribute(string name, string? value)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		return new XAttributeWrapper(new XAttribute(XName.op_Implicit(name), (object)value));
	}

	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string? value)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		return new XAttributeWrapper(new XAttribute(XName.Get(MiscellaneousUtils.GetLocalName(qualifiedName), namespaceUri), (object)value));
	}

	public override IXmlNode AppendChild(IXmlNode newChild)
	{
		if (newChild is XDeclarationWrapper xDeclarationWrapper)
		{
			Document.set_Declaration(xDeclarationWrapper.Declaration);
			return xDeclarationWrapper;
		}
		return base.AppendChild(newChild);
	}
}
