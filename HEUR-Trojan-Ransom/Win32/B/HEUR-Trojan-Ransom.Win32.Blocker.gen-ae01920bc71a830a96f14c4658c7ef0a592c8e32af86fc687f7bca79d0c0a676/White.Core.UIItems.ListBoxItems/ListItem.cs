using System.Windows;
using System.Windows.Automation;
using White.Core.UIA;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.ListBoxItems;

public abstract class ListItem : UIItem
{
	public virtual bool IsSelected => (bool)Property(SelectionItemPattern.IsSelectedProperty);

	public virtual string Text => Name;

	public abstract bool Checked { get; }

	protected ListItem()
	{
	}

	protected ListItem(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual void Select()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (!IsSelected)
		{
			actionListener.ActionPerforming(this);
			Rect bounds = Bounds;
			if (((Rect)(ref bounds)).get_IsEmpty())
			{
				SelectionItemPattern val = (SelectionItemPattern)automationElement.GetCurrentPattern(SelectionItemPattern.Pattern);
				val.Select();
			}
			else
			{
				UIItem.mouse.Click(Bounds.ImmediateInteriorEast(), actionListener);
			}
			actionListener.ActionPerformed(Action.WindowMessage);
		}
	}

	public abstract void Check();

	public abstract void UnCheck();
}
