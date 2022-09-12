namespace Gecko.WebIDL;

public class DataErrorEvent : WebIDLBase
{
	public string Message => GetProperty<string>("message");

	public DataErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
