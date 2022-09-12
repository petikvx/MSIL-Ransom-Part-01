using System;

namespace Gecko.WebIDL;

public class DataChannel : WebIDLBase
{
	public string Label => GetProperty<string>("label");

	public bool Reliable => GetProperty<bool>("reliable");

	public RTCDataChannelState ReadyState => GetProperty<RTCDataChannelState>("readyState");

	public uint BufferedAmount => GetProperty<uint>("bufferedAmount");

	public uint BufferedAmountLowThreshold
	{
		get
		{
			return GetProperty<uint>("bufferedAmountLowThreshold");
		}
		set
		{
			SetProperty("bufferedAmountLowThreshold", value);
		}
	}

	public RTCDataChannelType BinaryType
	{
		get
		{
			return GetProperty<RTCDataChannelType>("binaryType");
		}
		set
		{
			SetProperty("binaryType", value);
		}
	}

	public string Protocol => GetProperty<string>("protocol");

	public bool Ordered => GetProperty<bool>("ordered");

	public ushort Id => GetProperty<ushort>("id");

	public ushort Stream => GetProperty<ushort>("stream");

	public DataChannel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Close()
	{
		CallVoidMethod("close");
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
