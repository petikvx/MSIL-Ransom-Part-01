using System;

namespace Gecko.WebIDL;

public class TextEncoder : WebIDLBase
{
	public string Encoding => GetProperty<string>("encoding");

	public TextEncoder(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public IntPtr Encode()
	{
		return CallMethod<IntPtr>("encode", new object[0]);
	}

	public IntPtr Encode(USVString input)
	{
		return CallMethod<IntPtr>("encode", new object[1] { input });
	}
}
