using System;
using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.Custom;

public class CustomUIItem : UIItem
{
	private UIItemContainer container;

	protected virtual UIItemContainer Container => container;

	protected CustomUIItem(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	protected CustomUIItem()
	{
	}

	internal virtual void SetContainer(UIItemContainer uiItemContainer)
	{
		container = uiItemContainer;
	}

	public override void ActionPerforming(UIItem uiItem)
	{
		throw new NotImplementedException();
	}
}
