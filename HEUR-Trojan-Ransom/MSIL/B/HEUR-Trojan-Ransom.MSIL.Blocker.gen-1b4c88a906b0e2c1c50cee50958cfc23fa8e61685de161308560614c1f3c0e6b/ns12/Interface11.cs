using System.Collections.Generic;
using System.Xml;

namespace ns12;

internal interface Interface11
{
	XmlNodeType NodeType { get; }

	string? LocalName { get; }

	List<Interface11> ChildNodes { get; }

	List<Interface11> Attributes { get; }

	Interface11? ParentNode { get; }

	string? Value { get; set; }

	string? NamespaceUri { get; }

	object? WrappedNode { get; }

	Interface11 imethod_0(Interface11 interface11_0);
}
