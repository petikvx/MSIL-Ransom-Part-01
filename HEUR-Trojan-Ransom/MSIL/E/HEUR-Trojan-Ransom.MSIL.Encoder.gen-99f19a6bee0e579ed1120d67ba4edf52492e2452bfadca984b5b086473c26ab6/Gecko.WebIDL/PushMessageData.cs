using System;

namespace Gecko.WebIDL;

public class PushMessageData : WebIDLBase
{
	public PushMessageData(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public IntPtr ArrayBuffer()
	{
		return CallMethod<IntPtr>("arrayBuffer", new object[0]);
	}

	public nsIDOMBlob Blob()
	{
		return CallMethod<nsIDOMBlob>("blob", new object[0]);
	}

	public object Json()
	{
		return CallMethod<object>("json", new object[0]);
	}

	public USVString Text()
	{
		return CallMethod<USVString>("text", new object[0]);
	}
}
