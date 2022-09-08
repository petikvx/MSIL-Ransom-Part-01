using System.Net;
using Orcus.Shared.Commands.ReverseProxy;

namespace Orcus.Commands.ReverseProxy.Args;

public class ReverseProxyStatusUpdatedEventArgs : ReverseProxyEventArgs
{
	public bool IsConnected { get; }

	public IPAddress LocalAddress { get; }

	public int LocalPort { get; }

	public string TargetServer { get; }

	public string HostName { get; set; }

	public ReverseProxyStatusUpdate ToStatusUpdate()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		ReverseProxyStatusUpdate val = new ReverseProxyStatusUpdate();
		val.set_ConnectionId(base.ConnectionId);
		val.set_HostName(HostName);
		val.set_IsConnected(IsConnected);
		val.set_LocalPort(LocalPort);
		val.set_LocalAddress(LocalAddress);
		return val;
	}

	public ReverseProxyStatusUpdatedEventArgs(int connectionId, bool isConnected, IPAddress localAddress, int localPort, string targetServer)
		: base(connectionId)
	{
		IsConnected = isConnected;
		LocalAddress = localAddress;
		LocalPort = localPort;
		TargetServer = targetServer;
		if (!isConnected)
		{
			return;
		}
		try
		{
			IPHostEntry hostEntry = Dns.GetHostEntry(targetServer);
			if (!string.IsNullOrEmpty(hostEntry.HostName))
			{
				HostName = hostEntry.HostName;
			}
		}
		catch
		{
			HostName = null;
		}
	}
}
