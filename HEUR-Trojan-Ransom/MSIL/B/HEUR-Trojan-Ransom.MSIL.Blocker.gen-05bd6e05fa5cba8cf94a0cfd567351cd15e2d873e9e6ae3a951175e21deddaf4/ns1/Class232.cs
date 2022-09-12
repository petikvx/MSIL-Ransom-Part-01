using System.Collections.Generic;
using System.Xml.Linq;
using ns10;
using ns5;
using ns7;

namespace ns1;

internal class Class232 : Class229
{
	private List<Interface11>? list_0;

	private XContainer Container => (XContainer)base.WrappedNode;

	public override List<Interface11> ChildNodes
	{
		get
		{
			if (list_0 == null)
			{
				if (!HasChildNodes)
				{
					list_0 = Class27.list_0;
				}
				else
				{
					list_0 = new List<Interface11>();
					foreach (XNode item in Container.Nodes())
					{
						list_0!.Add(Class4.smethod_355((XObject)(object)item));
					}
				}
			}
			return list_0;
		}
	}

	protected virtual bool HasChildNodes => Container.get_LastNode() != null;

	public override Interface11? ParentNode
	{
		get
		{
			if (((XObject)Container).get_Parent() == null)
			{
				return null;
			}
			return Class4.smethod_355((XObject)(object)((XObject)Container).get_Parent());
		}
	}

	public Class232(XContainer xcontainer_0)
		: base((XObject?)(object)xcontainer_0)
	{
	}

	public override Interface11 imethod_0(Interface11 interface11_0)
	{
		Container.Add(interface11_0.WrappedNode);
		list_0 = null;
		return interface11_0;
	}
}
