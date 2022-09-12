namespace Gecko.WebIDL;

public class DesktopNotification : WebIDLBase
{
	public DesktopNotification(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Show()
	{
		CallVoidMethod("show");
	}
}
