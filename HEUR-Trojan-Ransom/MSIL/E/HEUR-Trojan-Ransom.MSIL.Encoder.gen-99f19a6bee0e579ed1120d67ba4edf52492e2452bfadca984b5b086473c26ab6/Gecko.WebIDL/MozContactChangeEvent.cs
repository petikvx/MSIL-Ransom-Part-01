namespace Gecko.WebIDL;

public class MozContactChangeEvent : WebIDLBase
{
	public string ContactID => GetProperty<string>("contactID");

	public string Reason => GetProperty<string>("reason");

	public MozContactChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
