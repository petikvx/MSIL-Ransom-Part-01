using System;

namespace Gecko.WebIDL;

public class SESession : WebIDLBase
{
	public nsISupports Reader => GetProperty<nsISupports>("reader");

	public bool IsClosed => GetProperty<bool>("isClosed");

	public SESession(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> OpenLogicalChannel(IntPtr aid)
	{
		return CallMethod<Promise<nsISupports>>("openLogicalChannel", new object[1] { aid });
	}

	public Promise CloseAll()
	{
		return CallMethod<Promise>("closeAll", new object[0]);
	}
}
