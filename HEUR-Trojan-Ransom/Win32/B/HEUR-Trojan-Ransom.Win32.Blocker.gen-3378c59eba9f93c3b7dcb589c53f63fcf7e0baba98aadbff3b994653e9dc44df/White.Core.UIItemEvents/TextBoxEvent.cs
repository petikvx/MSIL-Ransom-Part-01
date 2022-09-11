using White.Core.UIItems;
using White.Core.Utility;

namespace White.Core.UIItemEvents;

public class TextBoxEvent : UserEvent
{
	private static readonly string TextAction;

	private static readonly string BulkTextAction;

	public override object[] ActionParameters => new object[1] { ((TextBox)uiItem).Text.TrimEnd(new char[0]) };

	static TextBoxEvent()
	{
		TextAction = PropertyResolver.NameFor((TextBox t) => t.Text);
		BulkTextAction = PropertyResolver.NameFor((TextBox t) => t.BulkText);
	}

	public TextBoxEvent(IUIItem textBox)
		: base(textBox)
	{
	}

	protected override string ActionName(EventOption eventOption)
	{
		if (!eventOption.BulkText)
		{
			return TextAction;
		}
		return BulkTextAction;
	}

	public override bool IsRepeatEvent(UserEvent otherEvent)
	{
		if (otherEvent is TextBoxEvent)
		{
			return otherEvent.IsIdenfiedAs(uiItem.PrimaryIdentification);
		}
		return false;
	}
}
