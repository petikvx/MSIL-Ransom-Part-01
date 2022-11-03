using System;
using System.Net;
using xClient.Core.Networking;
using xClient.Core.Packets;

namespace xClient.Core.ReverseProxy.Packets;

[Serializable]
public class ReverseProxyConnectResponse : IPacket
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

	public void Execute(Client client)
	{
		client.Send(this);
	}
}
