namespace Gecko;

public class TreeSelection
{
	internal nsITreeSelection _treeSelection;

	public TreeBoxObject Tree
	{
		get
		{
			return new TreeBoxObject(_treeSelection.GetTreeAttribute());
		}
		set
		{
			_treeSelection.SetTreeAttribute(value._treeBoxObject);
		}
	}

	public bool Single => _treeSelection.GetSingleAttribute();

	public int Count => _treeSelection.GetCountAttribute();

	public int RangeCount => _treeSelection.GetRangeCount();

	public bool SelectEventsSuppressed
	{
		get
		{
			return _treeSelection.GetSelectEventsSuppressedAttribute();
		}
		set
		{
			_treeSelection.SetSelectEventsSuppressedAttribute(value);
		}
	}

	public int CurrentIndex
	{
		get
		{
			return _treeSelection.GetCurrentIndexAttribute();
		}
		set
		{
			_treeSelection.SetCurrentIndexAttribute(value);
		}
	}

	public TreeColumn CureentColumn
	{
		get
		{
			return new TreeColumn(_treeSelection.GetCurrentColumnAttribute());
		}
		set
		{
			_treeSelection.SetCurrentColumnAttribute(value._treeColumn);
		}
	}

	public int ShiftSelectPivot => _treeSelection.GetShiftSelectPivotAttribute();

	internal TreeSelection(nsITreeSelection treeSelection)
	{
		_treeSelection = treeSelection;
	}

	public bool IsSelected(int index)
	{
		return _treeSelection.IsSelected(index);
	}

	public void Select(int index)
	{
		_treeSelection.Select(index);
	}

	public void TimedSelect(int index, int delay)
	{
		_treeSelection.TimedSelect(index, delay);
	}

	public void ToggleSelect(int index)
	{
		_treeSelection.ToggleSelect(index);
	}

	public void RangedSelect(int startIndex, int endIndex, bool augment)
	{
		_treeSelection.RangedSelect(startIndex, endIndex, augment);
	}

	public void ClearRange(int startIndex, int endIndex)
	{
		_treeSelection.ClearRange(startIndex, endIndex);
	}

	public void ClearSelection()
	{
		_treeSelection.ClearSelection();
	}

	public void InvertSelection()
	{
		_treeSelection.InvertSelection();
	}

	public void SelectAll()
	{
		_treeSelection.SelectAll();
	}

	public void GetRangeAt(int i, ref int min, ref int max)
	{
		_treeSelection.GetRangeAt(i, ref min, ref max);
	}

	public void InvalidateSelection()
	{
		_treeSelection.InvalidateSelection();
	}

	public void AdjustSelection(int index, int count)
	{
		_treeSelection.AdjustSelection(index, count);
	}
}
