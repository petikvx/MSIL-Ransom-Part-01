using System;

namespace Gecko.WebIDL;

public class XMLHttpRequest : WebIDLBase
{
	public ushort ReadyState => GetProperty<ushort>("readyState");

	public uint Timeout
	{
		get
		{
			return GetProperty<uint>("timeout");
		}
		set
		{
			SetProperty("timeout", value);
		}
	}

	public bool WithCredentials
	{
		get
		{
			return GetProperty<bool>("withCredentials");
		}
		set
		{
			SetProperty("withCredentials", value);
		}
	}

	public nsISupports Upload => GetProperty<nsISupports>("upload");

	public string ResponseURL => GetProperty<string>("responseURL");

	public ushort Status => GetProperty<ushort>("status");

	public ByteString StatusText => GetProperty<ByteString>("statusText");

	public XMLHttpRequestResponseType ResponseType
	{
		get
		{
			return GetProperty<XMLHttpRequestResponseType>("responseType");
		}
		set
		{
			SetProperty("responseType", value);
		}
	}

	public object Response => GetProperty<object>("response");

	public string ResponseText => GetProperty<string>("responseText");

	public nsIDOMDocument ResponseXML => GetProperty<nsIDOMDocument>("responseXML");

	public bool MozBackgroundRequest
	{
		get
		{
			return GetProperty<bool>("mozBackgroundRequest");
		}
		set
		{
			SetProperty("mozBackgroundRequest", value);
		}
	}

	public nsISupports Channel => GetProperty<nsISupports>("channel");

	public ByteString NetworkInterfaceId
	{
		get
		{
			return GetProperty<ByteString>("networkInterfaceId");
		}
		set
		{
			SetProperty("networkInterfaceId", value);
		}
	}

	public bool MozAnon => GetProperty<bool>("mozAnon");

	public bool MozSystem => GetProperty<bool>("mozSystem");

	public XMLHttpRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Open(ByteString method, string url)
	{
		CallVoidMethod("open", method, url);
	}

	public void Open(ByteString method, string url, bool async)
	{
		CallVoidMethod("open", method, url, async);
	}

	public void Open(ByteString method, string url, bool async, string user)
	{
		CallVoidMethod("open", method, url, async, user);
	}

	public void Open(ByteString method, string url, bool async, string user, string password)
	{
		CallVoidMethod("open", method, url, async, user, password);
	}

	public void SetRequestHeader(ByteString header, ByteString value)
	{
		CallVoidMethod("setRequestHeader", header, value);
	}

	public void Send()
	{
		CallVoidMethod("send");
	}

	public void Send(IntPtr data)
	{
		CallVoidMethod("send", data);
	}

	public void Send(nsIDOMBlob data)
	{
		CallVoidMethod("send", data);
	}

	public void Send(nsIDOMDocument data)
	{
		CallVoidMethod("send", data);
	}

	public void Send(string data)
	{
		CallVoidMethod("send", data);
	}

	public void Send(nsIDOMFormData data)
	{
		CallVoidMethod("send", data);
	}

	public void Send(nsISupports data)
	{
		CallVoidMethod("send", data);
	}

	public void Abort()
	{
		CallVoidMethod("abort");
	}

	public ByteString GetResponseHeader(ByteString header)
	{
		return CallMethod<ByteString>("getResponseHeader", new object[1] { header });
	}

	public ByteString GetAllResponseHeaders()
	{
		return CallMethod<ByteString>("getAllResponseHeaders", new object[0]);
	}

	public void OverrideMimeType(string mime)
	{
		CallVoidMethod("overrideMimeType", mime);
	}

	public object GetInterface(nsISupports iid)
	{
		return CallMethod<object>("getInterface", new object[1] { iid });
	}
}
