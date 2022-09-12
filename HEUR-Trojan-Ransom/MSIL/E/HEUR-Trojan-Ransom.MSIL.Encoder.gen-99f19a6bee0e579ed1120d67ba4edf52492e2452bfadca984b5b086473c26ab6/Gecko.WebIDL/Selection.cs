namespace Gecko.WebIDL;

public class Selection : WebIDLBase
{
	public nsIDOMNode AnchorNode => GetProperty<nsIDOMNode>("anchorNode");

	public uint AnchorOffset => GetProperty<uint>("anchorOffset");

	public nsIDOMNode FocusNode => GetProperty<nsIDOMNode>("focusNode");

	public uint FocusOffset => GetProperty<uint>("focusOffset");

	public bool IsCollapsed => GetProperty<bool>("isCollapsed");

	public uint RangeCount => GetProperty<uint>("rangeCount");

	public bool InterlinePosition
	{
		get
		{
			return GetProperty<bool>("interlinePosition");
		}
		set
		{
			SetProperty("interlinePosition", value);
		}
	}

	public short? CaretBidiLevel
	{
		get
		{
			return GetProperty<short?>("caretBidiLevel");
		}
		set
		{
			SetProperty("caretBidiLevel", value);
		}
	}

	public short Type => GetProperty<short>("type");

	public Selection(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Collapse(nsIDOMNode node, uint offset)
	{
		CallVoidMethod("collapse", node, offset);
	}

	public void CollapseToStart()
	{
		CallVoidMethod("collapseToStart");
	}

	public void CollapseToEnd()
	{
		CallVoidMethod("collapseToEnd");
	}

	public void Extend(nsIDOMNode node, uint offset)
	{
		CallVoidMethod("extend", node, offset);
	}

	public void SelectAllChildren(nsIDOMNode node)
	{
		CallVoidMethod("selectAllChildren", node);
	}

	public void DeleteFromDocument()
	{
		CallVoidMethod("deleteFromDocument");
	}

	public nsISupports GetRangeAt(uint index)
	{
		return CallMethod<nsISupports>("getRangeAt", new object[1] { index });
	}

	public void AddRange(nsISupports range)
	{
		CallVoidMethod("addRange", range);
	}

	public void RemoveRange(nsISupports range)
	{
		CallVoidMethod("removeRange", range);
	}

	public void RemoveAllRanges()
	{
		CallVoidMethod("removeAllRanges");
	}

	public bool ContainsNode(nsIDOMNode node, bool allowPartialContainment)
	{
		return CallMethod<bool>("containsNode", new object[2] { node, allowPartialContainment });
	}

	public void Modify(string alter, string direction, string granularity)
	{
		CallVoidMethod("modify", alter, direction, granularity);
	}

	public string ToStringWithFormat(string formatType, uint flags, int wrapColumn)
	{
		return CallMethod<string>("toStringWithFormat", new object[3] { formatType, flags, wrapColumn });
	}

	public void AddSelectionListener(nsISupports newListener)
	{
		CallVoidMethod("addSelectionListener", newListener);
	}

	public void RemoveSelectionListener(nsISupports listenerToRemove)
	{
		CallVoidMethod("removeSelectionListener", listenerToRemove);
	}

	public nsISupports[] GetRangesForInterval(nsIDOMNode beginNode, int beginOffset, nsIDOMNode endNode, int endOffset, bool allowAdjacent)
	{
		return CallMethod<nsISupports[]>("GetRangesForInterval", new object[5] { beginNode, beginOffset, endNode, endOffset, allowAdjacent });
	}

	public void ScrollIntoView(short aRegion, bool aIsSynchronous, short aVPercent, short aHPercent)
	{
		CallVoidMethod("scrollIntoView", aRegion, aIsSynchronous, aVPercent, aHPercent);
	}
}
