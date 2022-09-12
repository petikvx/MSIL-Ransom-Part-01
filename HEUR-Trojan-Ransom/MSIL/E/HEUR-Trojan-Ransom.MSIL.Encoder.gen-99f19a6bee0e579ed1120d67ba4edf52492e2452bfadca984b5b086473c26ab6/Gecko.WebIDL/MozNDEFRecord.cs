using System;

namespace Gecko.WebIDL;

public class MozNDEFRecord : WebIDLBase
{
	public TNF Tnf => GetProperty<TNF>("tnf");

	public IntPtr Type => GetProperty<IntPtr>("type");

	public IntPtr Id => GetProperty<IntPtr>("id");

	public IntPtr Payload => GetProperty<IntPtr>("payload");

	public uint Size => GetProperty<uint>("size");

	public MozNDEFRecord(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string GetAsURI()
	{
		return CallMethod<string>("getAsURI", new object[0]);
	}
}
