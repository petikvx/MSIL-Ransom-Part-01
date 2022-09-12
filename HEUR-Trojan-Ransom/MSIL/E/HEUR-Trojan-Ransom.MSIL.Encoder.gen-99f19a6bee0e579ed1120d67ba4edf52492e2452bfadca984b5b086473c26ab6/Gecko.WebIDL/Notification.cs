namespace Gecko.WebIDL;

public class Notification : WebIDLBase
{
	public NotificationPermission Permission
	{
		get
		{
			return GetProperty<NotificationPermission>("permission");
		}
		set
		{
			SetProperty("permission", value);
		}
	}

	public string Title => GetProperty<string>("title");

	public NotificationDirection Dir => GetProperty<NotificationDirection>("dir");

	public string Lang => GetProperty<string>("lang");

	public string Body => GetProperty<string>("body");

	public string Tag => GetProperty<string>("tag");

	public string Icon => GetProperty<string>("icon");

	public object Data => GetProperty<object>("data");

	public Notification(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Close()
	{
		CallVoidMethod("close");
	}
}
