using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.Factory;
using White.Core.UIItems.Actions;
using White.Core.UIItems.ListViewItems;

namespace White.Core.UIItems;

public class ListViewCells : UIItemList<ListViewCell>
{
	private readonly ListViewHeader header;

	public virtual ListViewCell this[string columnName]
	{
		get
		{
			if (header == null && string.IsNullOrEmpty(columnName))
			{
				return base[0];
			}
			if (header == null)
			{
				throw new UIActionException("Cannot get cell for " + columnName);
			}
			return this[header.Column(columnName)];
		}
	}

	internal virtual ListViewCell this[ListViewColumn column]
	{
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			HorizontalSpan span = new HorizontalSpan(column.Bounds);
			return Find((ListViewCell cell) => !span.IsOutside(cell.Bounds));
		}
	}

	public ListViewCells(List<AutomationElement> collection, ActionListener actionListener, ListViewHeader header)
		: base(collection, (UIItemFactory)new ListViewCellFactory(), actionListener)
	{
		this.header = header;
	}
}
