using White.Core.UIItems;
using White.Core.Utility;

namespace White.Core.UIItemEvents;

public class CheckBoxEvent : UserEvent
{
	private readonly bool checkState;

	private static readonly string CachedActionName = PropertyResolver.NameFor((CheckBox c) => c.Checked);

	public override object[] ActionParameters => new object[1] { checkState };

	public CheckBoxEvent(CheckBox checkBox)
		: base(checkBox)
	{
		checkState = checkBox.Checked;
	}

	protected override string ActionName(EventOption eventOption)
	{
		return CachedActionName;
	}
}
