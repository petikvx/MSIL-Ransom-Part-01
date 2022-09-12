namespace Gecko.WebIDL;

public class NotificationEvent : WebIDLBase
{
	public nsISupports Notification => GetProperty<nsISupports>("notification");

	public NotificationEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
