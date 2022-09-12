using System;

namespace Gecko.WebIDL;

public class TCPSocket : WebIDLBase
{
	public USVString Host => GetProperty<USVString>("host");

	public ushort Port => GetProperty<ushort>("port");

	public bool Ssl => GetProperty<bool>("ssl");

	public ulong BufferedAmount => GetProperty<ulong>("bufferedAmount");

	public TCPReadyState ReadyState => GetProperty<TCPReadyState>("readyState");

	public TCPSocketBinaryType BinaryType => GetProperty<TCPSocketBinaryType>("binaryType");

	public TCPSocket(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void UpgradeToSecure()
	{
		CallVoidMethod("upgradeToSecure");
	}

	public void Suspend()
	{
		CallVoidMethod("suspend");
	}

	public void Resume()
	{
		CallVoidMethod("resume");
	}

	public void Close()
	{
		CallVoidMethod("close");
	}

	public bool Send(ByteString data)
	{
		return CallMethod<bool>("send", new object[1] { data });
	}

	public bool Send(IntPtr data)
	{
		return CallMethod<bool>("send", new object[1] { data });
	}

	public bool Send(IntPtr data, uint byteOffset)
	{
		return CallMethod<bool>("send", new object[2] { data, byteOffset });
	}

	public bool Send(IntPtr data, uint byteOffset, uint byteLength)
	{
		return CallMethod<bool>("send", new object[3] { data, byteOffset, byteLength });
	}
}
