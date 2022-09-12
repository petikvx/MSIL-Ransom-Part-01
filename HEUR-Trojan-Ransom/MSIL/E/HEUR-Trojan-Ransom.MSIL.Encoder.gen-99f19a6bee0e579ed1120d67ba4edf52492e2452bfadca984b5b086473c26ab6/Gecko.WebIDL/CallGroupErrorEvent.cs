namespace Gecko.WebIDL;

public class CallGroupErrorEvent : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string Message => GetProperty<string>("message");

	public CallGroupErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
