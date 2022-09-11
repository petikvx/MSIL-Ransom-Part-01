using System.Windows;
using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class SelectionItem : UIItem
{
	public virtual bool IsSelected
	{
		get
		{
			return (bool)Property(SelectionItemPattern.IsSelectedProperty);
		}
		set
		{
			if (IsSelected != value && value && !IsSelected)
			{
				Select();
			}
		}
	}

	protected SelectionItem()
	{
	}

	public SelectionItem(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual void Select()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		Rect bounds = Bounds;
		if (!((Rect)(ref bounds)).get_IsEmpty())
		{
			Click();
		}
		SelectionItemPattern val = (SelectionItemPattern)Pattern(SelectionItemPattern.Pattern);
		if (val == null)
		{
			throw new UIActionException($"{ToString()} cannot be selected as its position is unknown and doesn't support SelectionItemPattern");
		}
		val.Select();
	}
}
