using System;

namespace Gecko.WebIDL;

public class Body : WebIDLBase
{
	public bool BodyUsed => GetProperty<bool>("bodyUsed");

	public Body(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<IntPtr> ArrayBuffer()
	{
		return CallMethod<Promise<IntPtr>>("arrayBuffer", new object[0]);
	}

	public Promise<nsIDOMBlob> Blob()
	{
		return CallMethod<Promise<nsIDOMBlob>>("blob", new object[0]);
	}

	public Promise<nsIDOMFormData> FormData()
	{
		return CallMethod<Promise<nsIDOMFormData>>("formData", new object[0]);
	}

	public Promise<object> Json()
	{
		return CallMethod<Promise<object>>("json", new object[0]);
	}

	public Promise<USVString> Text()
	{
		return CallMethod<Promise<USVString>>("text", new object[0]);
	}
}
