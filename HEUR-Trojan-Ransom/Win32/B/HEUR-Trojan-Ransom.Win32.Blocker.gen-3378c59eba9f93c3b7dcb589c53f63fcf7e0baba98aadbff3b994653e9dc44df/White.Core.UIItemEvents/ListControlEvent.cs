using White.Core.UIItems;
using White.Core.UIItems.ListBoxItems;
using White.Core.Utility;

namespace White.Core.UIItemEvents;

public class ListControlEvent : UserEvent
{
	private readonly string selectedItem;

	private static readonly string CachedMethodName;

	public override object[] ActionParameters => new object[1] { selectedItem };

	static ListControlEvent()
	{
		CachedMethodName = MethodNameResolver.NameFor((ComboBox c) => c.Select(null));
	}

	public ListControlEvent(IUIItem uiItem, string selectedItem)
		: base(uiItem)
	{
		this.selectedItem = selectedItem;
	}

	protected override string ActionName(EventOption eventOption)
	{
		return CachedMethodName;
	}
}
