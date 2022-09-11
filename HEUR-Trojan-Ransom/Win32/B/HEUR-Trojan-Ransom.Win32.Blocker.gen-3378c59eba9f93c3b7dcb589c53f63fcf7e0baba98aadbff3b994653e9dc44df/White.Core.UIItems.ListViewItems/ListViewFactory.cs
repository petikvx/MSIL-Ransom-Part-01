using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.ListViewItems;

public class ListViewFactory
{
	private readonly AutomationElementFinder automationElementFinder;

	private readonly ActionListener actionListener;

	public virtual ListViewRows Rows => new ListViewRows(automationElementFinder, actionListener, Header);

	public virtual ListViewHeader Header
	{
		get
		{
			AutomationElement val = automationElementFinder.Child(AutomationSearchCondition.ByControlType(ControlType.Header));
			if (val == (AutomationElement)null)
			{
				return null;
			}
			return new ListViewHeader(val, actionListener);
		}
	}

	public ListViewFactory(AutomationElementFinder automationElementFinder, ActionListener actionListener)
	{
		this.automationElementFinder = automationElementFinder;
		this.actionListener = actionListener;
	}
}
