using System;

namespace Orcus.Commands.ReverseProxy.Args;

public class ReverseProxyEventArgs : EventArgs
{
	public int ConnectionId { get; }

	public ReverseProxyEventArgs(int connectionId)
	{
		ConnectionId = connectionId;
	}
}
