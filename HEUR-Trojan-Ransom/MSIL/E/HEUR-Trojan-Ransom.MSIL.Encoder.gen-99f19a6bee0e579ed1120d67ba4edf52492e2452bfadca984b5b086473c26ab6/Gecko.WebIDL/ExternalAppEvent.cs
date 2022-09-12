namespace Gecko.WebIDL;

public class ExternalAppEvent : WebIDLBase
{
	public string Data => GetProperty<string>("data");

	public ExternalAppEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
