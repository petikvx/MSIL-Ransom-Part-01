using White.Core.Finder;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.Container;

internal class CachedContainerItemFactory : ContainerItemFactory
{
	private readonly CachedUIItems children;

	public CachedContainerItemFactory(CachedUIItems cachedUIItems, ActionListener actionListener)
	{
		children = cachedUIItems;
		base.actionListener = actionListener;
	}

	protected override IUIItem Find(SearchCriteria searchCriteria)
	{
		return children.Get(searchCriteria, actionListener);
	}

	public override void Visit(WindowControlVisitor windowControlVisitor)
	{
		UIItemCollection uIItemCollection = children.UIItems(actionListener);
		foreach (UIItem item in uIItemCollection)
		{
			item.Visit(windowControlVisitor);
		}
	}

	public override UIItemCollection GetAll(SearchCriteria searchCriteria)
	{
		return children.GetAll(searchCriteria, actionListener);
	}
}
