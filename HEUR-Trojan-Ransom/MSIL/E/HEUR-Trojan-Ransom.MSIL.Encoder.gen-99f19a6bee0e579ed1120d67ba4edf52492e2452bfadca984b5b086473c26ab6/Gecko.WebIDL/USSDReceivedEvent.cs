namespace Gecko.WebIDL;

public class USSDReceivedEvent : WebIDLBase
{
	public uint ServiceId => GetProperty<uint>("serviceId");

	public string Message => GetProperty<string>("message");

	public nsISupports Session => GetProperty<nsISupports>("session");

	public USSDReceivedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
