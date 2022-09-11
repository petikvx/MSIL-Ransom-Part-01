using System.Collections;
using System.Windows.Automation;
using White.Core.Factory;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TableItems;

public class TableRows : UIItemList<TableRow>
{
	protected TableRows()
	{
	}

	public TableRows(ICollection tees)
		: base(tees)
	{
	}

	public TableRows(ICollection rowElements, ActionListener actionListener, TableHeader tableHeader, TableCellFactory tableCellFactory)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		foreach (AutomationElement rowElement in rowElements)
		{
			AutomationElement automationElement = rowElement;
			Add(new TableRow(automationElement, actionListener, tableHeader, tableCellFactory));
		}
	}

	public virtual TableRow Get(string column, string value)
	{
		return Find((TableRow obj) => obj.Cells[column].Value.Equals(value));
	}

	public virtual TableRows GetMultipleRows(string column, string value)
	{
		return new TableRows(FindAll((TableRow obj) => obj.Cells[column].Value.Equals(value)));
	}
}
