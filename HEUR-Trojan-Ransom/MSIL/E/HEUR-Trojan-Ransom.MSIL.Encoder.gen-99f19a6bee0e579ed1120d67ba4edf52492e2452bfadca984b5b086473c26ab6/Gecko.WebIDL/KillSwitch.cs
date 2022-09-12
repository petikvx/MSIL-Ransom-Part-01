namespace Gecko.WebIDL;

public class KillSwitch : WebIDLBase
{
	public KillSwitch(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object> Enable()
	{
		return CallMethod<Promise<object>>("enable", new object[0]);
	}

	public Promise<object> Disable()
	{
		return CallMethod<Promise<object>>("disable", new object[0]);
	}
}
