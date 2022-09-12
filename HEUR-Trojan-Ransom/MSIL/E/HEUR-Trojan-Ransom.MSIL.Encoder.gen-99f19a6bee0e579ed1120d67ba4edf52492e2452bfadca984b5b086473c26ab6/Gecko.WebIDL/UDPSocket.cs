using System;

namespace Gecko.WebIDL;

public class UDPSocket : WebIDLBase
{
	public string LocalAddress => GetProperty<string>("localAddress");

	public ushort? LocalPort => GetProperty<ushort?>("localPort");

	public string RemoteAddress => GetProperty<string>("remoteAddress");

	public ushort? RemotePort => GetProperty<ushort?>("remotePort");

	public bool AddressReuse => GetProperty<bool>("addressReuse");

	public bool Loopback => GetProperty<bool>("loopback");

	public SocketReadyState ReadyState => GetProperty<SocketReadyState>("readyState");

	public Promise Opened => GetProperty<Promise>("opened");

	public Promise Closed => GetProperty<Promise>("closed");

	public UDPSocket(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise Close()
	{
		return CallMethod<Promise>("close", new object[0]);
	}

	public void JoinMulticastGroup(string multicastGroupAddress)
	{
		CallVoidMethod("joinMulticastGroup", multicastGroupAddress);
	}

	public void LeaveMulticastGroup(string multicastGroupAddress)
	{
		CallVoidMethod("leaveMulticastGroup", multicastGroupAddress);
	}

	public bool Send(WebIDLUnion<string, nsIDOMBlob, IntPtr, IntPtr> data)
	{
		return CallMethod<bool>("send", new object[1] { data });
	}

	public bool Send(WebIDLUnion<string, nsIDOMBlob, IntPtr, IntPtr> data, string remoteAddress)
	{
		return CallMethod<bool>("send", new object[2] { data, remoteAddress });
	}

	public bool Send(WebIDLUnion<string, nsIDOMBlob, IntPtr, IntPtr> data, string remoteAddress, ushort? remotePort)
	{
		return CallMethod<bool>("send", new object[3] { data, remoteAddress, remotePort });
	}
}
