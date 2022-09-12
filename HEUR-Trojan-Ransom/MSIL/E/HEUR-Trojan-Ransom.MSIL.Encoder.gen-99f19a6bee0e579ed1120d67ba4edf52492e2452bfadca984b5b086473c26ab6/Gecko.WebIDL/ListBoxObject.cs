namespace Gecko.WebIDL;

public class ListBoxObject : WebIDLBase
{
	public ListBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public int GetRowCount()
	{
		return CallMethod<int>("getRowCount", new object[0]);
	}

	public int GetNumberOfVisibleRows()
	{
		return CallMethod<int>("getNumberOfVisibleRows", new object[0]);
	}

	public int GetIndexOfFirstVisibleRow()
	{
		return CallMethod<int>("getIndexOfFirstVisibleRow", new object[0]);
	}

	public void EnsureIndexIsVisible(int rowIndex)
	{
		CallVoidMethod("ensureIndexIsVisible", rowIndex);
	}

	public void ScrollToIndex(int rowIndex)
	{
		CallVoidMethod("scrollToIndex", rowIndex);
	}

	public void ScrollByLines(int numLines)
	{
		CallVoidMethod("scrollByLines", numLines);
	}

	public nsIDOMElement GetItemAtIndex(int index)
	{
		return CallMethod<nsIDOMElement>("getItemAtIndex", new object[1] { index });
	}

	public int GetIndexOfItem(nsIDOMElement item)
	{
		return CallMethod<int>("getIndexOfItem", new object[1] { item });
	}
}
