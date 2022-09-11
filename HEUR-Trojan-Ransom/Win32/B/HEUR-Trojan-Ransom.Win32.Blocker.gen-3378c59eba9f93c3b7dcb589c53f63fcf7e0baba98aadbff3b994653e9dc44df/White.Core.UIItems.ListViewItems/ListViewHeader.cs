using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.ListViewItems;

public class ListViewHeader : UIItem
{
	private readonly AutomationElementFinder automationElementFinder;

	public virtual ListViewColumns Columns
	{
		get
		{
			List<AutomationElement> automationElementCollection = automationElementFinder.Children(AutomationSearchCondition.ByControlType(ControlType.HeaderItem));
			return new ListViewColumns(automationElementCollection, actionListener);
		}
	}

	protected ListViewHeader()
	{
	}

	public ListViewHeader(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		automationElementFinder = new AutomationElementFinder(automationElement);
	}

	public virtual ListViewColumn Column(string text)
	{
		return Columns.Find((ListViewColumn column) => column.Text.Equals(text));
	}
}
