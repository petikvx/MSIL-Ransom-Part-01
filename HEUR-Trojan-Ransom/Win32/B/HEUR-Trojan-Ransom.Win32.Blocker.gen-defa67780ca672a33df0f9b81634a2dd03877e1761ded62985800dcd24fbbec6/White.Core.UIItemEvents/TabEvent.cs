using White.Core.UIItems.TabItems;
using White.Core.Utility;

namespace White.Core.UIItemEvents;

public class TabEvent : UserEvent
{
	private static readonly string Action;

	private readonly object[] parameters;

	public override object[] ActionParameters => parameters;

	static TabEvent()
	{
		Action = MethodNameResolver.NameFor((Tab t) => t.SelectTabPage(null));
	}

	public TabEvent(Tab tab)
		: base(tab)
	{
		parameters = new object[1] { tab.SelectedTab.Name };
	}

	protected override string ActionName(EventOption eventOption)
	{
		return Action;
	}
}
