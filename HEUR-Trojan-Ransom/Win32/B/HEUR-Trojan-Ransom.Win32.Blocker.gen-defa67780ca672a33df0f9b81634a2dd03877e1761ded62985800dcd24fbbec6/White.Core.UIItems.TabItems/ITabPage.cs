using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TabItems;

public interface ITabPage : ActionListener, IUIItem
{
	bool IsSelected { get; }

	void Select();
}
