namespace Gecko;

public class GeckoSelection
{
	private nsISelection Selection;

	public object DomSelection => Selection;

	public GeckoNode AnchorNode => GeckoNode.Create(Selection.GetAnchorNodeAttribute());

	public int AnchorOffset => Selection.GetAnchorOffsetAttribute();

	public GeckoNode FocusNode => GeckoNode.Create(Selection.GetFocusNodeAttribute());

	public int FocusOffset => Selection.GetFocusOffsetAttribute();

	public bool IsCollapsed => Selection.GetIsCollapsedAttribute();

	public int RangeCount => Selection.GetRangeCountAttribute();

	private GeckoSelection(nsISelection selection)
	{
		Selection = selection;
	}

	internal static GeckoSelection Create(nsISelection selection)
	{
		return (selection == null) ? null : new GeckoSelection(selection);
	}

	public GeckoRange GetRangeAt(int index)
	{
		return new GeckoRange(Selection.GetRangeAt(index));
	}

	public void Collapse(GeckoNode parentNode, int offset)
	{
		Selection.Collapse(parentNode.DomObject, offset);
	}

	public void Extend(GeckoNode parentNode, int offset)
	{
		Selection.Extend(parentNode.DomObject, offset);
	}

	public void CollapseToStart()
	{
		Selection.CollapseToStart();
	}

	public void CollapseToEnd()
	{
		Selection.CollapseToEnd();
	}

	public bool ContainsNode(GeckoNode node, bool partlyContained)
	{
		return Selection.ContainsNode(node.DomObject, partlyContained);
	}

	public void SelectAllChildren(GeckoNode parentNode)
	{
		Selection.SelectAllChildren(parentNode.DomObject);
	}

	public void AddRange(GeckoRange range)
	{
		Selection.AddRange(range.DomRange);
	}

	public void RemoveRange(GeckoRange range)
	{
		Selection.RemoveRange(range.DomRange);
	}

	public void RemoveAllRanges()
	{
		Selection.RemoveAllRanges();
	}

	public void DeleteFromDocument()
	{
		Selection.DeleteFromDocument();
	}

	public void StartBatchChanges()
	{
		((nsISelectionPrivate)Selection).StartBatchChanges();
	}

	public void EndBatchChanges()
	{
		((nsISelectionPrivate)Selection).EndBatchChanges();
	}

	public void ScrollIntoView(short aRegion, bool aIsSynchronous, short aVPercent, short aHPercent)
	{
		((nsISelectionPrivate)Selection).ScrollIntoView(aRegion, aIsSynchronous, aVPercent, aHPercent);
	}

	public override string ToString()
	{
		return Selection.ToString();
	}
}
