using System.Collections.Generic;
using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XContainerWrapper : XObjectWrapper
{
	private List<IXmlNode>? _childNodes;

	private XContainer Container => (XContainer)base.WrappedNode;

	public override List<IXmlNode> ChildNodes
	{
		get
		{
			if (_childNodes == null)
			{
				if (!HasChildNodes)
				{
					_childNodes = XmlNodeConverter.EmptyChildNodes;
				}
				else
				{
					_childNodes = new List<IXmlNode>();
					foreach (XNode item in Container.Nodes())
					{
						_childNodes!.Add(WrapNode((XObject)(object)item));
					}
				}
			}
			return _childNodes;
		}
	}

	protected virtual bool HasChildNodes => Container.get_LastNode() != null;

	public override IXmlNode? ParentNode
	{
		get
		{
			if (((XObject)Container).get_Parent() == null)
			{
				return null;
			}
			return WrapNode((XObject)(object)((XObject)Container).get_Parent());
		}
	}

	public XContainerWrapper(XContainer container)
		: base((XObject?)(object)container)
	{
	}

	internal static IXmlNode WrapNode(XObject node)
	{
		XDocument val = (XDocument)(object)((node is XDocument) ? node : null);
		if (val != null)
		{
			return new XDocumentWrapper(val);
		}
		XElement val2 = (XElement)(object)((node is XElement) ? node : null);
		if (val2 != null)
		{
			return new XElementWrapper(val2);
		}
		XContainer val3 = (XContainer)(object)((node is XContainer) ? node : null);
		if (val3 != null)
		{
			return new XContainerWrapper(val3);
		}
		XProcessingInstruction val4 = (XProcessingInstruction)(object)((node is XProcessingInstruction) ? node : null);
		if (val4 != null)
		{
			return new XProcessingInstructionWrapper(val4);
		}
		XText val5 = (XText)(object)((node is XText) ? node : null);
		if (val5 != null)
		{
			return new XTextWrapper(val5);
		}
		XComment val6 = (XComment)(object)((node is XComment) ? node : null);
		if (val6 != null)
		{
			return new XCommentWrapper(val6);
		}
		XAttribute val7 = (XAttribute)(object)((node is XAttribute) ? node : null);
		if (val7 != null)
		{
			return new XAttributeWrapper(val7);
		}
		XDocumentType val8 = (XDocumentType)(object)((node is XDocumentType) ? node : null);
		if (val8 != null)
		{
			return new XDocumentTypeWrapper(val8);
		}
		return new XObjectWrapper(node);
	}

	public override IXmlNode AppendChild(IXmlNode newChild)
	{
		Container.Add(newChild.WrappedNode);
		_childNodes = null;
		return newChild;
	}
}
