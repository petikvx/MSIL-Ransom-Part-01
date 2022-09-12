namespace Gecko.WebIDL;

public class TelephonyCallGroup : WebIDLBase
{
	public nsISupports Calls => GetProperty<nsISupports>("calls");

	public TelephonyCallGroupState State => GetProperty<TelephonyCallGroupState>("state");

	public TelephonyCallGroup(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Add(nsISupports call)
	{
		return CallMethod<Promise>("add", new object[1] { call });
	}

	public Promise Add(nsISupports call, nsISupports secondCall)
	{
		return CallMethod<Promise>("add", new object[2] { call, secondCall });
	}

	public Promise Remove(nsISupports call)
	{
		return CallMethod<Promise>("remove", new object[1] { call });
	}

	public Promise HangUp()
	{
		return CallMethod<Promise>("hangUp", new object[0]);
	}

	public Promise Hold()
	{
		return CallMethod<Promise>("hold", new object[0]);
	}

	public Promise Resume()
	{
		return CallMethod<Promise>("resume", new object[0]);
	}
}
