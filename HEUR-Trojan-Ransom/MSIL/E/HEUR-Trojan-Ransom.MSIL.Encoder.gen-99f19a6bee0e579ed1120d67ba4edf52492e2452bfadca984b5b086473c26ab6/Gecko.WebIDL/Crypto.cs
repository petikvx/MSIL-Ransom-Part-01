using System;

namespace Gecko.WebIDL;

public class Crypto : WebIDLBase
{
	public nsISupports Subtle => GetProperty<nsISupports>("subtle");

	public Crypto(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public IntPtr GetRandomValues(IntPtr array)
	{
		return CallMethod<IntPtr>("getRandomValues", new object[1] { array });
	}
}
