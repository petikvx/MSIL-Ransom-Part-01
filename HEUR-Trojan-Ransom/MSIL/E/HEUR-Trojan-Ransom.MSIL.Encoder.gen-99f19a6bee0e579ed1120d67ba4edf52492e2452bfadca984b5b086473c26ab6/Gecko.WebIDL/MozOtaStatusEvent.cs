namespace Gecko.WebIDL;

public class MozOtaStatusEvent : WebIDLBase
{
	public string Status => GetProperty<string>("status");

	public MozOtaStatusEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
