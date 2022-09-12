using System.Collections.Generic;
using System.Xml.Linq;
using ns0;
using ns10;
using ns12;
using ns15;
using ns16;
using ns6;

namespace ns3;

internal class Class234 : Class232, Interface11, Interface13
{
	private List<Interface11>? list_1;

	private XElement Element => (XElement)base.WrappedNode;

	public override List<Interface11> Attributes
	{
		get
		{
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			if (list_1 == null)
			{
				if (!Element.get_HasAttributes() && !method_0(NamespaceUri))
				{
					list_1 = Class27.list_0;
				}
				else
				{
					list_1 = new List<Interface11>();
					foreach (XAttribute item in Element.Attributes())
					{
						list_1!.Add(new Class238(item));
					}
					string namespaceUri = NamespaceUri;
					if (method_0(namespaceUri))
					{
						list_1!.Insert(0, new Class238(new XAttribute(XName.op_Implicit("xmlns"), (object)namespaceUri)));
					}
				}
			}
			return list_1;
		}
	}

	public override string? Value
	{
		get
		{
			return Element.get_Value();
		}
		set
		{
			Element.set_Value(value);
		}
	}

	public override string? LocalName => Element.get_Name().get_LocalName();

	public override string? NamespaceUri => Element.get_Name().get_NamespaceName();

	public bool IsEmpty => Element.get_IsEmpty();

	public Class234(XElement xelement_0)
		: base((XContainer)(object)xelement_0)
	{
	}

	public void imethod_1(Interface11 interface11_0)
	{
		Class229 @class = (Class229)interface11_0;
		((XContainer)Element).Add(@class.WrappedNode);
		list_1 = null;
	}

	private bool method_0(string string_0)
	{
		if (!Class109.smethod_0(string_0) && string_0 != ParentNode?.NamespaceUri && Class109.smethod_0(imethod_2(string_0)))
		{
			bool flag = false;
			if (Element.get_HasAttributes())
			{
				foreach (XAttribute item in Element.Attributes())
				{
					if (item.get_Name().get_LocalName() == "xmlns" && Class109.smethod_0(item.get_Name().get_NamespaceName()) && item.get_Value() == string_0)
					{
						flag = true;
					}
				}
			}
			if (!flag)
			{
				return true;
			}
		}
		return false;
	}

	public override Interface11 imethod_0(Interface11 interface11_0)
	{
		Interface11 result = base.imethod_0(interface11_0);
		list_1 = null;
		return result;
	}

	public string imethod_2(string string_0)
	{
		return Element.GetPrefixOfNamespace(XNamespace.op_Implicit(string_0));
	}
}
