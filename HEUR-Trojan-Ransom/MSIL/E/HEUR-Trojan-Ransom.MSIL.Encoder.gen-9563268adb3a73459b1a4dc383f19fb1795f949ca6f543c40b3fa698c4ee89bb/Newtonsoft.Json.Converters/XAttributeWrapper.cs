using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XAttributeWrapper : XObjectWrapper
{
	private XAttribute Attribute => (XAttribute)base.WrappedNode;

	public override string? Value
	{
		get
		{
			return Attribute.get_Value();
		}
		set
		{
			Attribute.set_Value(value);
		}
	}

	public override string? LocalName => Attribute.get_Name().get_LocalName();

	public override string? NamespaceUri => Attribute.get_Name().get_NamespaceName();

	public override IXmlNode? ParentNode
	{
		get
		{
			if (((XObject)Attribute).get_Parent() == null)
			{
				return null;
			}
			return XContainerWrapper.WrapNode((XObject)(object)((XObject)Attribute).get_Parent());
		}
	}

	public XAttributeWrapper(XAttribute attribute)
		: base((XObject?)(object)attribute)
	{
	}
}
