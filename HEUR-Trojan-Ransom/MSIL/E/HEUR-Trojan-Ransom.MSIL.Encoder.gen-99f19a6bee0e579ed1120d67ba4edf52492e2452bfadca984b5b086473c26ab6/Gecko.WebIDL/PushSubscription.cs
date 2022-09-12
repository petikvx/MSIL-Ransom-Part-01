using System;

namespace Gecko.WebIDL;

public class PushSubscription : WebIDLBase
{
	public USVString Endpoint => GetProperty<USVString>("endpoint");

	public PushSubscription(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public IntPtr GetKey(PushEncryptionKeyName name)
	{
		return CallMethod<IntPtr>("getKey", new object[1] { name });
	}

	public Promise<bool> Unsubscribe()
	{
		return CallMethod<Promise<bool>>("unsubscribe", new object[0]);
	}

	public void SetPrincipal(nsISupports principal)
	{
		CallVoidMethod("setPrincipal", principal);
	}
}
