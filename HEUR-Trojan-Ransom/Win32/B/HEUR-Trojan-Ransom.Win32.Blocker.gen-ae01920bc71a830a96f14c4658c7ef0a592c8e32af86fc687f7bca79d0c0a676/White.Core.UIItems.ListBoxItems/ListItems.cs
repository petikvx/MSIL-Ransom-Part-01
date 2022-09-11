using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.UIA;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.ListBoxItems;

public class ListItems : UIItemList<ListItem>, ListItemContainer
{
	private readonly ActionListener actionListener;

	public virtual ListItem SelectedItem => Find((ListItem obj) => obj.IsSelected);

	public virtual string SelectedItemText
	{
		get
		{
			ListItem selectedItem = SelectedItem;
			if (selectedItem != null)
			{
				return selectedItem.Text;
			}
			return string.Empty;
		}
	}

	public ListItems(List<AutomationElement> collection, ActionListener actionListener)
		: base(collection, actionListener)
	{
		this.actionListener = actionListener;
	}

	public virtual ListItem Item(string text)
	{
		ListItem listItem = ItemWithText(text);
		if (listItem != null)
		{
			return listItem;
		}
		MakeLastItemReadyForPerformingAction();
		listItem = ItemWithText(text);
		if (listItem == null)
		{
			throw new UIActionException($"Item of text {text} not found.");
		}
		return listItem;
	}

	private void MakeLastItemReadyForPerformingAction()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (base.Count != 0)
		{
			ListItem listItem = Item(base.Count - 1);
			if (listItem.Bounds.IsZeroSize() || string.IsNullOrEmpty(listItem.Text))
			{
				actionListener.ActionPerforming(listItem);
			}
		}
	}

	private ListItem ItemWithText(string text)
	{
		return Find((ListItem obj) => obj.Text.Equals(text));
	}

	public virtual ListItem Item(int index)
	{
		return base[index];
	}

	public virtual void Select(string text)
	{
		Item(text).Select();
	}

	public virtual void Select(int index)
	{
		Item(index).Select();
	}
}
