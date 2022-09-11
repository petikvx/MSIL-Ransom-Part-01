using White.Core.UIItems.Finders;
using log4net;

namespace White.Core.UIItems.WPFUIItems;

public static class WPFUIItem
{
	private static readonly ILog Logger = LogManager.GetLogger(typeof(WPFUIItem));

	public static T Get<T>(this UIItem uiItem, SearchCriteria searchCriteria) where T : UIItem
	{
		UIItemContainer uiItemContainer = GetUiItemContainer(uiItem);
		return (T)uiItemContainer.Get(searchCriteria.AndControlType(typeof(T)));
	}

	private static UIItemContainer GetUiItemContainer(UIItem uiItem)
	{
		if (!uiItem.Framework.WPF)
		{
			Logger.Warn((object)"Only WPF items should be treated as container items");
		}
		return uiItem.AsContainer();
	}

	public static IUIItem[] GetMultiple(this UIItem uiItem, SearchCriteria criteria)
	{
		UIItemContainer uiItemContainer = GetUiItemContainer(uiItem);
		return uiItemContainer.GetMultiple(criteria);
	}

	public static IUIItem Get(this UIItem uiItem, SearchCriteria searchCriteria)
	{
		UIItemContainer uiItemContainer = GetUiItemContainer(uiItem);
		return uiItemContainer.Get(searchCriteria);
	}
}
