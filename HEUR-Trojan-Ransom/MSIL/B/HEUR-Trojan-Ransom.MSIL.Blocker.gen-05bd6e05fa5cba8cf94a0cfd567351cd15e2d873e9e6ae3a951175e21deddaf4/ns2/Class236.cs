using System.Xml.Linq;
using ns10;
using ns5;
using ns7;

namespace ns2;

internal class Class236 : Class229
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

	public override Interface11? ParentNode
	{
		get
		{
			if (((XObject)Text).get_Parent() == null)
			{
				return null;
			}
			return Class4.smethod_355((XObject)(object)((XObject)Text).get_Parent());
		}
	}

	public Class236(XComment xcomment_0)
		: base((XObject?)(object)xcomment_0)
	{
	}
}
