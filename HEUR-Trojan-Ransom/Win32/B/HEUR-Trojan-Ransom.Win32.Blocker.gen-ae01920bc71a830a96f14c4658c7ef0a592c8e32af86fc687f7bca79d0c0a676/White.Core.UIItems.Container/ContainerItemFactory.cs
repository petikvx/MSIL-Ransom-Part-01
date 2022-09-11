using White.Core.Factory;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.Container;

public abstract class ContainerItemFactory
{
	protected ActionListener actionListener;

	public virtual IUIItem Get(SearchCriteria searchCriteria, ActionListener uiItemActionListener)
	{
		IUIItem iUIItem = Find(searchCriteria);
		if (iUIItem != null && !(iUIItem is UIItemContainer))
		{
			return UIItemProxyFactory.Create(iUIItem, uiItemActionListener);
		}
		return iUIItem;
	}

	protected abstract IUIItem Find(SearchCriteria searchCriteria);

	public abstract void Visit(WindowControlVisitor windowControlVisitor);

	public abstract UIItemCollection GetAll(SearchCriteria searchCriteria);
}
