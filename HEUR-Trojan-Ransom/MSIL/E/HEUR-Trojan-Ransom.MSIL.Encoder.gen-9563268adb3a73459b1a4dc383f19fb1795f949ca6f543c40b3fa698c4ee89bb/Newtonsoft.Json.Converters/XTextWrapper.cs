using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XTextWrapper : XObjectWrapper
{
	private XText Text => (XText)base.WrappedNode;

	public override string? Value
	{
		get
		{
			return Text.get_Value();
		}
		set
		{
			Text.set_Value(value);
		}
	}

	public override IXmlNode? ParentNode
	{
		get
		{
			if (((XObject)Text).get_Parent() == null)
			{
				return null;
			}
			return XContainerWrapper.WrapNode((XObject)(object)((XObject)Text).get_Parent());
		}
	}

	public XTextWrapper(XText text)
		: base((XObject?)(object)text)
	{
	}
}
