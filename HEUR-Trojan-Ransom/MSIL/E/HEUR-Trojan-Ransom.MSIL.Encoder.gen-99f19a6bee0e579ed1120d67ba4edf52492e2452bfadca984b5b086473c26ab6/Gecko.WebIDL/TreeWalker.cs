namespace Gecko.WebIDL;

public class TreeWalker : WebIDLBase
{
	public nsIDOMNode Root => GetProperty<nsIDOMNode>("root");

	public uint WhatToShow => GetProperty<uint>("whatToShow");

	public nsISupports Filter => GetProperty<nsISupports>("filter");

	public nsIDOMNode CurrentNode
	{
		get
		{
			return GetProperty<nsIDOMNode>("currentNode");
		}
		set
		{
			SetProperty("currentNode", value);
		}
	}

	public TreeWalker(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMNode ParentNode()
	{
		return CallMethod<nsIDOMNode>("parentNode", new object[0]);
	}

	public nsIDOMNode FirstChild()
	{
		return CallMethod<nsIDOMNode>("firstChild", new object[0]);
	}

	public nsIDOMNode LastChild()
	{
		return CallMethod<nsIDOMNode>("lastChild", new object[0]);
	}

	public nsIDOMNode PreviousSibling()
	{
		return CallMethod<nsIDOMNode>("previousSibling", new object[0]);
	}

	public nsIDOMNode NextSibling()
	{
		return CallMethod<nsIDOMNode>("nextSibling", new object[0]);
	}

	public nsIDOMNode PreviousNode()
	{
		return CallMethod<nsIDOMNode>("previousNode", new object[0]);
	}

	public nsIDOMNode NextNode()
	{
		return CallMethod<nsIDOMNode>("nextNode", new object[0]);
	}
}
