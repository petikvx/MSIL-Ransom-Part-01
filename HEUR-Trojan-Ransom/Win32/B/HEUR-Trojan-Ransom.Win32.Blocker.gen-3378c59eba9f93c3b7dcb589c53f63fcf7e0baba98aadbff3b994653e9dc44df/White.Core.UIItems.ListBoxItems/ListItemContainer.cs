namespace White.Core.UIItems.ListBoxItems;

public interface ListItemContainer
{
	string SelectedItemText { get; }

	ListItem SelectedItem { get; }

	ListItem Item(string itemText);

	ListItem Item(int index);

	void Select(string itemText);

	void Select(int index);
}
