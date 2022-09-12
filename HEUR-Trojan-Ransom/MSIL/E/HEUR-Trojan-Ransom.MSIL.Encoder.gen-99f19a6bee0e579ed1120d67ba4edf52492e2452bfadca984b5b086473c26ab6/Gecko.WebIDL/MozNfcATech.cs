using System;

namespace Gecko.WebIDL;

public class MozNfcATech : WebIDLBase
{
	public MozNfcATech(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<IntPtr> Transceive(IntPtr command)
	{
		return CallMethod<Promise<IntPtr>>("transceive", new object[1] { command });
	}
}
