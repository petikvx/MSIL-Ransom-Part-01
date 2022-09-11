using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;
using White.Core.UIItems.ListViewItems;
using White.Core.WindowsAPI;

namespace White.Core.UIItems;

public class ListViewRow : UIItem
{
	private readonly ListViewHeader header;

	private readonly AutomationElementFinder finder;

	public virtual bool IsSelected
	{
		get
		{
			actionListener.ActionPerforming(this);
			return IsSelectedValue;
		}
	}

	internal virtual bool IsSelectedValue => (bool)Property(SelectionItemPattern.IsSelectedProperty);

	public virtual ListViewCells Cells
	{
		get
		{
			actionListener.ActionPerforming(this);
			List<AutomationElement> collection = finder.Children(AutomationSearchCondition.ByControlType(ControlType.Text));
			return new ListViewCells(collection, actionListener, header);
		}
	}

	protected ListViewRow()
	{
	}

	public ListViewRow(AutomationElement automationElement, ActionListener actionListener, ListViewHeader header)
		: base(automationElement, actionListener)
	{
		this.header = header;
		finder = new AutomationElementFinder(automationElement);
	}

	public virtual void Select()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		actionListener.ActionPerforming(this);
		UIItem.mouse.Click(ClickablePoint, actionListener);
	}

	public virtual void MultiSelect()
	{
		actionListener.ActionPerforming(this);
		keyboard.HoldKey(KeyboardInput.SpecialKeys.CONTROL, actionListener);
		Select();
		keyboard.LeaveKey(KeyboardInput.SpecialKeys.CONTROL, actionListener);
	}
}
