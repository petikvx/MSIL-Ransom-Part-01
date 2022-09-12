namespace Gecko;

public class TreeView
{
	private nsITreeView _treeView;

	public int RowCount => _treeView.GetRowCountAttribute();

	public TreeSelection Selection
	{
		get
		{
			return new TreeSelection(_treeView.GetSelectionAttribute());
		}
		set
		{
			_treeView.SetSelectionAttribute(value._treeSelection);
		}
	}

	public bool IsSorted => _treeView.IsSorted();

	internal TreeView(nsITreeView treeView)
	{
		_treeView = treeView;
	}

	public bool IsContainer(int index)
	{
		return _treeView.IsContainer(index);
	}

	public bool IsContainerOpen(int index)
	{
		return _treeView.IsContainerOpen(index);
	}

	public bool IsContainerEmpty(int index)
	{
		return _treeView.IsContainerEmpty(index);
	}

	public bool IsSeparator(int index)
	{
		return _treeView.IsSeparator(index);
	}

	public int GetParentIndex(int rowIndex)
	{
		return _treeView.GetParentIndex(rowIndex);
	}

	public bool HasNextSibling(int rowIndex, int afterIndex)
	{
		return _treeView.HasNextSibling(rowIndex, afterIndex);
	}

	public int GetLevel(int index)
	{
		return _treeView.GetLevel(index);
	}

	public string GetImageSrc(int row, TreeColumn col)
	{
		return nsString.Get(_treeView.GetImageSrc, row, col._treeColumn);
	}

	public int GetProgressMode(int row, TreeColumn col)
	{
		return _treeView.GetProgressMode(row, col._treeColumn);
	}

	public string GetCellValue(int row, TreeColumn col)
	{
		return nsString.Get(_treeView.GetCellValue, row, col._treeColumn);
	}

	public string GetCellText(int row, TreeColumn col)
	{
		return nsString.Get(_treeView.GetCellText, row, col._treeColumn);
	}

	public void SetTree(TreeBoxObject tree)
	{
		_treeView.SetTree(tree._treeBoxObject);
	}

	public void ToggleOpenState(int index)
	{
		_treeView.ToggleOpenState(index);
	}

	public void CycleHeader(TreeColumn col)
	{
		_treeView.CycleHeader(col._treeColumn);
	}

	public void SelectionChanged()
	{
		_treeView.SelectionChanged();
	}

	public void CycleCell(int row, TreeColumn col)
	{
		_treeView.CycleCell(row, col._treeColumn);
	}

	public bool IsEditable(int row, TreeColumn col)
	{
		return _treeView.IsEditable(row, col._treeColumn);
	}

	public bool IsSelectable(int row, TreeColumn col)
	{
		return _treeView.IsSelectable(row, col._treeColumn);
	}

	public void SetCellValue(int row, TreeColumn col, string value)
	{
		nsString.Set(_treeView.SetCellValue, row, col._treeColumn, value);
	}

	public void SetCellText(int row, TreeColumn col, string value)
	{
		nsString.Set(_treeView.SetCellText, row, col._treeColumn, value);
	}

	public void PerformAction(string action)
	{
		_treeView.PerformAction(action);
	}

	public void PerformActionOnRow(string action, int row)
	{
		_treeView.PerformActionOnRow(action, row);
	}

	public void PerformActionOnCell(string action, int row, TreeColumn col)
	{
		_treeView.PerformActionOnCell(action, row, col._treeColumn);
	}
}
