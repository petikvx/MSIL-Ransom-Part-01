using System;

namespace Gecko.WebIDL;

public class SEChannel : WebIDLBase
{
	public nsISupports Session => GetProperty<nsISupports>("session");

	public IntPtr OpenResponse => GetProperty<IntPtr>("openResponse");

	public bool IsClosed => GetProperty<bool>("isClosed");

	public SEChannelType Type => GetProperty<SEChannelType>("type");

	public SEChannel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> Transmit()
	{
		return CallMethod<Promise<nsISupports>>("transmit", new object[0]);
	}

	public Promise<nsISupports> Transmit(object command)
	{
		return CallMethod<Promise<nsISupports>>("transmit", new object[1] { command });
	}

	public Promise Close()
	{
		return CallMethod<Promise>("close", new object[0]);
	}
}
