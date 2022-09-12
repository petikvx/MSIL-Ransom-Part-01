using System.Xml.Linq;
using ns13;
using ns17;
using ns4;

namespace ns12;

internal class Class238 : Class229
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

	public override Interface11? ParentNode
	{
		get
		{
			if (((XObject)Attribute).get_Parent() == null)
			{
				return null;
			}
			return Class131.smethod_633((XObject)(object)((XObject)Attribute).get_Parent());
		}
	}

	public Class238(XAttribute xattribute_0)
		: base((XObject?)(object)xattribute_0)
	{
	}
}
