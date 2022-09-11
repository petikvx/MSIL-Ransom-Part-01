using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.ListBoxItems;

public class ListControl : UIItem, VerticalSpanProvider, ListItemContainer
{
	protected AutomationElementFinder finder;

	public virtual ListItems Items => new ListItems(finder.Descendants(AutomationSearchCondition.ByControlType(ControlType.ListItem)), this);

	public virtual string SelectedItemText => Items.SelectedItemText;

	public virtual ListItem SelectedItem => Items.SelectedItem;

	public virtual VerticalSpan VerticalSpan => new VerticalSpan(Bounds);

	protected ListControl()
	{
	}

	public ListControl(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		finder = new AutomationElementFinder(automationElement);
	}

	public virtual ListItem Item(string itemText)
	{
		return Items.Item(itemText);
	}

	public virtual ListItem Item(int index)
	{
		return Items[index];
	}

	public virtual void Select(string itemText)
	{
		Item(itemText).Select();
	}

	public virtual void Select(int index)
	{
		Item(index).Select();
	}

	public override void SetValue(object value)
	{
		Select(value.ToString());
	}

	public override void ActionPerforming(UIItem uiItem)
	{
		ScreenItem screenItem = new ScreenItem(uiItem, ScrollBars);
		screenItem.MakeVisible(this);
	}
}
