namespace Gecko.WebIDL;

public class NodeIterator : WebIDLBase
{
	public nsIDOMNode Root => GetProperty<nsIDOMNode>("root");

	public nsIDOMNode ReferenceNode => GetProperty<nsIDOMNode>("referenceNode");

	public bool PointerBeforeReferenceNode => GetProperty<bool>("pointerBeforeReferenceNode");

	public uint WhatToShow => GetProperty<uint>("whatToShow");

	public nsISupports Filter => GetProperty<nsISupports>("filter");

	public NodeIterator(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMNode NextNode()
	{
		return CallMethod<nsIDOMNode>("nextNode", new object[0]);
	}

	public nsIDOMNode PreviousNode()
	{
		return CallMethod<nsIDOMNode>("previousNode", new object[0]);
	}

	public void Detach()
	{
		CallVoidMethod("detach");
	}
}
