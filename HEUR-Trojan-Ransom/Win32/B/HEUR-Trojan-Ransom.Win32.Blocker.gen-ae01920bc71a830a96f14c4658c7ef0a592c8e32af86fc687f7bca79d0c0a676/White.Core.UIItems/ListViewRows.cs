using System.Collections;
using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Factory;
using White.Core.UIItems.Actions;
using White.Core.UIItems.ListViewItems;

namespace White.Core.UIItems;

public class ListViewRows : UIItemList<ListViewRow>
{
	public virtual ListViewRows SelectedRows => new ListViewRows(FindAll((ListViewRow obj) => obj.IsSelectedValue));

	private ListViewRows(ICollection tees)
		: base(tees)
	{
	}

	public ListViewRows(AutomationElementFinder finder, ActionListener actionListener, ListViewHeader header)
	{
		List<AutomationElement> list = finder.Descendants(AutomationSearchCondition.ByControlType(ControlType.DataItem));
		foreach (AutomationElement item in list)
		{
			Add(new ListViewRow(item, actionListener, header));
		}
	}

	public virtual ListViewRow Get(int zeroBasedIndex)
	{
		if (base.Count <= zeroBasedIndex)
		{
			throw new UIItemSearchException("No row found with index " + zeroBasedIndex);
		}
		return base[zeroBasedIndex];
	}

	public virtual ListViewRow Get(string column, string value)
	{
		return Find((ListViewRow obj) => obj.Cells[column].Text.Equals(value));
	}
}
