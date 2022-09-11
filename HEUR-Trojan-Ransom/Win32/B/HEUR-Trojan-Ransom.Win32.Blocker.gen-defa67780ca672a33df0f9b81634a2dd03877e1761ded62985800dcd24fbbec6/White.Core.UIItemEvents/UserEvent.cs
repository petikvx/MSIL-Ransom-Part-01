using System;
using White.Core.UIItems;

namespace White.Core.UIItemEvents;

public abstract class UserEvent
{
	protected readonly IUIItem uiItem;

	private readonly DateTime timestamp;

	public virtual DateTime Timestamp => timestamp;

	public virtual Type UIItemType => uiItem.GetType();

	public virtual object[] ActionParameters => new object[0];

	public UserEvent(IUIItem uiItem)
	{
		this.uiItem = uiItem;
		timestamp = DateTime.Now;
	}

	protected abstract string ActionName(EventOption eventOption);

	public virtual void WriteTo(EventWriter eventWriter, EventOption eventOption)
	{
		eventWriter.Write(UIItemType, ActionName(eventOption), uiItem.PrimaryIdentification, ActionParameters);
	}

	public virtual bool IsRepeatEvent(UserEvent otherEvent)
	{
		return false;
	}

	public virtual bool IsIdenfiedAs(string identification)
	{
		return uiItem.PrimaryIdentification.Equals(identification);
	}
}
