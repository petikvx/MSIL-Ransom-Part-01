using System.Xml.Linq;
using ns0;
using ns12;

namespace ns9;

internal class Class235 : Class229
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

	public override Interface11? ParentNode
	{
		get
		{
			if (((XObject)Text).get_Parent() == null)
			{
				return null;
			}
			return Class7.smethod_484((XObject)(object)((XObject)Text).get_Parent());
		}
	}

	public Class235(XText xtext_0)
		: base((XObject?)(object)xtext_0)
	{
	}
}
