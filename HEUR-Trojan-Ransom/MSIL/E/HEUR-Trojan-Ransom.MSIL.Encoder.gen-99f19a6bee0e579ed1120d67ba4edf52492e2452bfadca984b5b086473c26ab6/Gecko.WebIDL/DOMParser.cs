using System;

namespace Gecko.WebIDL;

public class DOMParser : WebIDLBase
{
	public DOMParser(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsIDOMDocument ParseFromString(string str, SupportedType type)
	{
		return CallMethod<nsIDOMDocument>("parseFromString", new object[2] { str, type });
	}

	public nsIDOMDocument ParseFromBuffer(byte[] buf, uint bufLen, SupportedType type)
	{
		return CallMethod<nsIDOMDocument>("parseFromBuffer", new object[3] { buf, bufLen, type });
	}

	public nsIDOMDocument ParseFromBuffer(IntPtr buf, uint bufLen, SupportedType type)
	{
		return CallMethod<nsIDOMDocument>("parseFromBuffer", new object[3] { buf, bufLen, type });
	}

	public nsIDOMDocument ParseFromStream(nsISupports stream, string charset, int contentLength, SupportedType type)
	{
		return CallMethod<nsIDOMDocument>("parseFromStream", new object[4] { stream, charset, contentLength, type });
	}

	public void Init()
	{
		CallVoidMethod("init");
	}

	public void Init(nsISupports principal)
	{
		CallVoidMethod("init", principal);
	}

	public void Init(nsISupports principal, nsISupports documentURI)
	{
		CallVoidMethod("init", principal, documentURI);
	}

	public void Init(nsISupports principal, nsISupports documentURI, nsISupports baseURI)
	{
		CallVoidMethod("init", principal, documentURI, baseURI);
	}
}
