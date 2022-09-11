using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TabItems;

public class TabPage : UIItem, ActionListener, IUIItem, ITabPage
{
	private readonly SelectionItem selectionItem;

	public virtual bool IsSelected => selectionItem.IsSelected;

	protected TabPage()
	{
	}

	public TabPage(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		selectionItem = new SelectionItem(automationElement, actionListener);
	}

	public virtual void Select()
	{
		selectionItem.Select();
	}

	public override string ToString()
	{
		return Name;
	}
}
