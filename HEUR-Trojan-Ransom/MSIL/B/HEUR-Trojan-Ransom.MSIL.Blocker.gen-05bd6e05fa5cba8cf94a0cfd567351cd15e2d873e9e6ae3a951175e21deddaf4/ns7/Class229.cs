using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using ns5;

namespace ns7;

internal class Class229 : Interface11
{
	private readonly XObject? xobject_0;

	public object? WrappedNode => xobject_0;

	public virtual XmlNodeType NodeType
	{
		get
		{
			XObject? obj = xobject_0;
			if (obj == null)
			{
				return XmlNodeType.None;
			}
			return obj!.get_NodeType();
		}
	}

	public virtual string? LocalName => null;

	public virtual List<Interface11> ChildNodes => Class27.list_0;

	public virtual List<Interface11> Attributes => Class27.list_0;

	public virtual Interface11? ParentNode => null;

	public virtual string? Value
	{
		get
		{
			return null;
		}
		set
		{
			throw new InvalidOperationException();
		}
	}

	public virtual string? NamespaceUri => null;

	public Class229(XObject? xobject_1)
	{
		xobject_0 = xobject_1;
	}

	public virtual Interface11 imethod_0(Interface11 interface11_0)
	{
		throw new InvalidOperationException();
	}
}
