namespace Gecko.WebIDL;

public class EventTarget : WebIDLBase
{
	public nsIDOMWindow OwnerGlobal => GetProperty<nsIDOMWindow>("ownerGlobal");

	public EventTarget(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void AddEventListener(string type, nsISupports listener)
	{
		CallVoidMethod("addEventListener", type, listener);
	}

	public void AddEventListener(string type, nsISupports listener, bool capture)
	{
		CallVoidMethod("addEventListener", type, listener, capture);
	}

	public void AddEventListener(string type, nsISupports listener, bool capture, bool? wantsUntrusted)
	{
		CallVoidMethod("addEventListener", type, listener, capture, wantsUntrusted);
	}

	public void RemoveEventListener(string type, nsISupports listener)
	{
		CallVoidMethod("removeEventListener", type, listener);
	}

	public void RemoveEventListener(string type, nsISupports listener, bool capture)
	{
		CallVoidMethod("removeEventListener", type, listener, capture);
	}

	public bool DispatchEvent(nsIDOMEvent @event)
	{
		return CallMethod<bool>("dispatchEvent", new object[1] { @event });
	}
}
