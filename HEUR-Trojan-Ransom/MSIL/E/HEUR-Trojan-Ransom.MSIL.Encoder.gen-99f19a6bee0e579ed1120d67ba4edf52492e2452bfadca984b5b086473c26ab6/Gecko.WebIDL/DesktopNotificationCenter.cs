namespace Gecko.WebIDL;

public class DesktopNotificationCenter : WebIDLBase
{
	public DesktopNotificationCenter(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports CreateNotification(string title, string description)
	{
		return CallMethod<nsISupports>("createNotification", new object[2] { title, description });
	}

	public nsISupports CreateNotification(string title, string description, string iconURL)
	{
		return CallMethod<nsISupports>("createNotification", new object[3] { title, description, iconURL });
	}
}
