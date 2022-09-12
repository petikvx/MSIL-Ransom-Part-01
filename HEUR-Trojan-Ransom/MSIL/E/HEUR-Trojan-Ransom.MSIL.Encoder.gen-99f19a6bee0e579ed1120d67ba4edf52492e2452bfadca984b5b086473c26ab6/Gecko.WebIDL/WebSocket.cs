using System;

namespace Gecko.WebIDL;

public class WebSocket : WebIDLBase
{
	public string Url => GetProperty<string>("url");

	public ushort ReadyState => GetProperty<ushort>("readyState");

	public uint BufferedAmount => GetProperty<uint>("bufferedAmount");

	public string Extensions => GetProperty<string>("extensions");

	public string Protocol => GetProperty<string>("protocol");

	public BinaryType BinaryType
	{
		get
		{
			return GetProperty<BinaryType>("binaryType");
		}
		set
		{
			SetProperty("binaryType", value);
		}
	}

	public WebSocket(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Close()
	{
		CallVoidMethod("close");
	}

	public void Close(ushort code)
	{
		CallVoidMethod("close", code);
	}

	public void Close(ushort code, string reason)
	{
		CallVoidMethod("close", code, reason);
	}

	public void Send(string data)
	{
		CallVoidMethod("send", data);
	}

	public void Send(nsIDOMBlob data)
	{
		CallVoidMethod("send", data);
	}

	public void Send(IntPtr data)
	{
		CallVoidMethod("send", data);
	}
}
