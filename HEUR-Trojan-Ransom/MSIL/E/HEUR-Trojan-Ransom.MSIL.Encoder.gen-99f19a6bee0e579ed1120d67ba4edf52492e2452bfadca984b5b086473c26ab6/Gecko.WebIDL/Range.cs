namespace Gecko.WebIDL;

public class Range : WebIDLBase
{
	public nsIDOMNode StartContainer => GetProperty<nsIDOMNode>("startContainer");

	public uint StartOffset => GetProperty<uint>("startOffset");

	public nsIDOMNode EndContainer => GetProperty<nsIDOMNode>("endContainer");

	public uint EndOffset => GetProperty<uint>("endOffset");

	public bool Collapsed => GetProperty<bool>("collapsed");

	public nsIDOMNode CommonAncestorContainer => GetProperty<nsIDOMNode>("commonAncestorContainer");

	public Range(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetStart(nsIDOMNode refNode, uint offset)
	{
		CallVoidMethod("setStart", refNode, offset);
	}

	public void SetEnd(nsIDOMNode refNode, uint offset)
	{
		CallVoidMethod("setEnd", refNode, offset);
	}

	public void SetStartBefore(nsIDOMNode refNode)
	{
		CallVoidMethod("setStartBefore", refNode);
	}

	public void SetStartAfter(nsIDOMNode refNode)
	{
		CallVoidMethod("setStartAfter", refNode);
	}

	public void SetEndBefore(nsIDOMNode refNode)
	{
		CallVoidMethod("setEndBefore", refNode);
	}

	public void SetEndAfter(nsIDOMNode refNode)
	{
		CallVoidMethod("setEndAfter", refNode);
	}

	public void Collapse()
	{
		CallVoidMethod("collapse");
	}

	public void Collapse(bool toStart)
	{
		CallVoidMethod("collapse", toStart);
	}

	public void SelectNode(nsIDOMNode refNode)
	{
		CallVoidMethod("selectNode", refNode);
	}

	public void SelectNodeContents(nsIDOMNode refNode)
	{
		CallVoidMethod("selectNodeContents", refNode);
	}

	public short CompareBoundaryPoints(ushort how, nsISupports sourceRange)
	{
		return CallMethod<short>("compareBoundaryPoints", new object[2] { how, sourceRange });
	}

	public void DeleteContents()
	{
		CallVoidMethod("deleteContents");
	}

	public nsISupports ExtractContents()
	{
		return CallMethod<nsISupports>("extractContents", new object[0]);
	}

	public nsISupports CloneContents()
	{
		return CallMethod<nsISupports>("cloneContents", new object[0]);
	}

	public void InsertNode(nsIDOMNode node)
	{
		CallVoidMethod("insertNode", node);
	}

	public void SurroundContents(nsIDOMNode newParent)
	{
		CallVoidMethod("surroundContents", newParent);
	}

	public nsISupports CloneRange()
	{
		return CallMethod<nsISupports>("cloneRange", new object[0]);
	}

	public void Detach()
	{
		CallVoidMethod("detach");
	}

	public bool IsPointInRange(nsIDOMNode node, uint offset)
	{
		return CallMethod<bool>("isPointInRange", new object[2] { node, offset });
	}

	public short ComparePoint(nsIDOMNode node, uint offset)
	{
		return CallMethod<short>("comparePoint", new object[2] { node, offset });
	}

	public bool IntersectsNode(nsIDOMNode node)
	{
		return CallMethod<bool>("intersectsNode", new object[1] { node });
	}

	public nsISupports CreateContextualFragment(string fragment)
	{
		return CallMethod<nsISupports>("createContextualFragment", new object[1] { fragment });
	}

	public nsISupports GetClientRects()
	{
		return CallMethod<nsISupports>("getClientRects", new object[0]);
	}

	public nsISupports GetBoundingClientRect()
	{
		return CallMethod<nsISupports>("getBoundingClientRect", new object[0]);
	}
}
