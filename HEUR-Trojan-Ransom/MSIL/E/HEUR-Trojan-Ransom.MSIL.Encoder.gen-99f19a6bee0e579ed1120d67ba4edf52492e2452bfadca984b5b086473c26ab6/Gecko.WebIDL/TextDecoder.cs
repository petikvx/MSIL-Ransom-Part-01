using System;

namespace Gecko.WebIDL;

public class TextDecoder : WebIDLBase
{
	public string Encoding => GetProperty<string>("encoding");

	public bool Fatal => GetProperty<bool>("fatal");

	public TextDecoder(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public USVString Decode()
	{
		return CallMethod<USVString>("decode", new object[0]);
	}

	public USVString Decode(IntPtr input)
	{
		return CallMethod<USVString>("decode", new object[1] { input });
	}

	public USVString Decode(IntPtr input, object options)
	{
		return CallMethod<USVString>("decode", new object[2] { input, options });
	}
}
