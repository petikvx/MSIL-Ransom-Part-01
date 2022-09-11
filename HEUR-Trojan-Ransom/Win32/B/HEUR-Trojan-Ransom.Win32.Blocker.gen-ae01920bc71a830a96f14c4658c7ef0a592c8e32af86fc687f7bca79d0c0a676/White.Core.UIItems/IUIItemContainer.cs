using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems;

public interface IUIItemContainer : ActionListener, IUIItem
{
	T Get<T>() where T : UIItem;

	T Get<T>(string primaryIdentification) where T : UIItem;

	T Get<T>(SearchCriteria searchCriteria) where T : UIItem;
}
