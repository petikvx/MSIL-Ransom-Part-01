using System;

namespace Gecko.WebIDL;

public class MediaKeyStatusMap : WebIDLBase
{
	public uint Size => GetProperty<uint>("size");

	public MediaKeyStatusMap(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool Has(IntPtr keyId)
	{
		return CallMethod<bool>("has", new object[1] { keyId });
	}

	public MediaKeyStatus Get(IntPtr keyId)
	{
		return CallMethod<MediaKeyStatus>("get", new object[1] { keyId });
	}
}
