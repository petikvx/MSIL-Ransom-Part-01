namespace Gecko.WebIDL;

public class TreeBoxObject : WebIDLBase
{
	public nsISupports Columns => GetProperty<nsISupports>("columns");

	public nsISupports View
	{
		get
		{
			return GetProperty<nsISupports>("view");
		}
		set
		{
			SetProperty("view", value);
		}
	}

	public bool Focused
	{
		get
		{
			return GetProperty<bool>("focused");
		}
		set
		{
			SetProperty("focused", value);
		}
	}

	public nsIDOMElement TreeBody => GetProperty<nsIDOMElement>("treeBody");

	public int RowHeight => GetProperty<int>("rowHeight");

	public int RowWidth => GetProperty<int>("rowWidth");

	public int HorizontalPosition => GetProperty<int>("horizontalPosition");

	public nsISupports SelectionRegion => GetProperty<nsISupports>("selectionRegion");

	public TreeBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public int GetFirstVisibleRow()
	{
		return CallMethod<int>("getFirstVisibleRow", new object[0]);
	}

	public int GetLastVisibleRow()
	{
		return CallMethod<int>("getLastVisibleRow", new object[0]);
	}

	public int GetPageLength()
	{
		return CallMethod<int>("getPageLength", new object[0]);
	}

	public void EnsureRowIsVisible(int index)
	{
		CallVoidMethod("ensureRowIsVisible", index);
	}

	public void EnsureCellIsVisible(int row, nsISupports col)
	{
		CallVoidMethod("ensureCellIsVisible", row, col);
	}

	public void ScrollToRow(int index)
	{
		CallVoidMethod("scrollToRow", index);
	}

	public void ScrollByLines(int numLines)
	{
		CallVoidMethod("scrollByLines", numLines);
	}

	public void ScrollByPages(int numPages)
	{
		CallVoidMethod("scrollByPages", numPages);
	}

	public void ScrollToCell(int row, nsISupports col)
	{
		CallVoidMethod("scrollToCell", row, col);
	}

	public void ScrollToColumn(nsISupports col)
	{
		CallVoidMethod("scrollToColumn", col);
	}

	public void ScrollToHorizontalPosition(int horizontalPosition)
	{
		CallVoidMethod("scrollToHorizontalPosition", horizontalPosition);
	}

	public void Invalidate()
	{
		CallVoidMethod("invalidate");
	}

	public void InvalidateColumn(nsISupports col)
	{
		CallVoidMethod("invalidateColumn", col);
	}

	public void InvalidateRow(int index)
	{
		CallVoidMethod("invalidateRow", index);
	}

	public void InvalidateCell(int row, nsISupports col)
	{
		CallVoidMethod("invalidateCell", row, col);
	}

	public void InvalidateRange(int startIndex, int endIndex)
	{
		CallVoidMethod("invalidateRange", startIndex, endIndex);
	}

	public void InvalidateColumnRange(int startIndex, int endIndex, nsISupports col)
	{
		CallVoidMethod("invalidateColumnRange", startIndex, endIndex, col);
	}

	public int GetRowAt(int x, int y)
	{
		return CallMethod<int>("getRowAt", new object[2] { x, y });
	}

	public object GetCellAt(int x, int y)
	{
		return CallMethod<object>("getCellAt", new object[2] { x, y });
	}

	public void GetCellAt(int x, int y, object row, object column, object childElt)
	{
		CallVoidMethod("getCellAt", x, y, row, column, childElt);
	}

	public nsISupports GetCoordsForCellItem(int row, nsISupports col, string element)
	{
		return CallMethod<nsISupports>("getCoordsForCellItem", new object[3] { row, col, element });
	}

	public void GetCoordsForCellItem(int row, nsISupports col, string element, object x, object y, object width, object height)
	{
		CallVoidMethod("getCoordsForCellItem", row, col, element, x, y, width, height);
	}

	public bool IsCellCropped(int row, nsISupports col)
	{
		return CallMethod<bool>("isCellCropped", new object[2] { row, col });
	}

	public void RowCountChanged(int index, int count)
	{
		CallVoidMethod("rowCountChanged", index, count);
	}

	public void BeginUpdateBatch()
	{
		CallVoidMethod("beginUpdateBatch");
	}

	public void EndUpdateBatch()
	{
		CallVoidMethod("endUpdateBatch");
	}

	public void ClearStyleAndImageCaches()
	{
		CallVoidMethod("clearStyleAndImageCaches");
	}
}
