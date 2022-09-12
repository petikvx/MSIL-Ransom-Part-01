namespace Gecko.WebIDL;

public class TelephonyCall : WebIDLBase
{
	public uint ServiceId => GetProperty<uint>("serviceId");

	public nsISupports Id => GetProperty<nsISupports>("id");

	public nsISupports SecondId => GetProperty<nsISupports>("secondId");

	public TelephonyCallState State => GetProperty<TelephonyCallState>("state");

	public bool Emergency => GetProperty<bool>("emergency");

	public bool Switchable => GetProperty<bool>("switchable");

	public bool Mergeable => GetProperty<bool>("mergeable");

	public nsISupports Error => GetProperty<nsISupports>("error");

	public TelephonyCallDisconnectedReason DisconnectedReason => GetProperty<TelephonyCallDisconnectedReason>("disconnectedReason");

	public nsISupports Group => GetProperty<nsISupports>("group");

	public TelephonyCall(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Answer()
	{
		return CallMethod<Promise>("answer", new object[0]);
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
