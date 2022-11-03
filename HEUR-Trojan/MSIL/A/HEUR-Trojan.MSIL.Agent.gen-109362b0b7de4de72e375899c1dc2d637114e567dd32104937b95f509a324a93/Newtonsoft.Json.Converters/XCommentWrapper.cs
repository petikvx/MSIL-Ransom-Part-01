using System.Xml.Linq;

namespace Newtonsoft.Json.Converters;

internal class XCommentWrapper : XObjectWrapper
{
	private XComment Text => (XComment)base.WrappedNode;

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

	public XCommentWrapper(XComment text)
		: base((XObject?)(object)text)
	{
	}
}
