using System.Collections;
using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TableItems;

public class TableCells : UIItemList<TableCell>
{
	private readonly TableHeader tableHeader;

	public virtual TableCell this[string column]
	{
		get
		{
			if (tableHeader == null && string.IsNullOrEmpty(column))
			{
				return base[0];
			}
			if (tableHeader == null)
			{
				throw new UIActionException($"Cannot get cell for {column}");
			}
			return base[tableHeader.Columns[column].Index];
		}
	}

	public TableCells(ICollection tableCellElements, TableHeader tableHeader, ActionListener actionListener)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		this.tableHeader = tableHeader;
		foreach (AutomationElement tableCellElement in tableCellElements)
		{
			AutomationElement automationElement = tableCellElement;
			Add(new TableCell(automationElement, actionListener));
		}
	}
}
