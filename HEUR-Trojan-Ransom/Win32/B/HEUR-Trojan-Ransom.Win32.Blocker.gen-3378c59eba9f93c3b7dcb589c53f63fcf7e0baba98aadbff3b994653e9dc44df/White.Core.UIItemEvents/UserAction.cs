using System.Collections.Generic;

namespace White.Core.UIItemEvents;

public class UserAction
{
	private UserEvent lastEvent;

	private readonly List<UserEvent> allEvents = new List<UserEvent>();

	private bool repeatEvent;

	public virtual UserEvent CurrentUserEvent => lastEvent;

	public virtual UserEvent LastEvent => lastEvent;

	public virtual bool RepeatEvent => repeatEvent;

	public virtual void Register(UserEvent userEvent)
	{
		repeatEvent = userEvent.IsRepeatEvent(lastEvent);
		if (repeatEvent)
		{
			allEvents.Remove(lastEvent);
		}
		allEvents.Add(userEvent);
		lastEvent = userEvent;
	}
}
