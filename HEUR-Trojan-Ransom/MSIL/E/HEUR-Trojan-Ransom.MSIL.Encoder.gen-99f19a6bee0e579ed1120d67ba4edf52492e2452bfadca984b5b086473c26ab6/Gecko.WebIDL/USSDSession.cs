namespace Gecko.WebIDL;

public class USSDSession : WebIDLBase
{
	public USSDSession(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Send(string ussd)
	{
		return CallMethod<Promise>("send", new object[1] { ussd });
	}

	public Promise Cancel()
	{
		return CallMethod<Promise>("cancel", new object[0]);
	}
}
