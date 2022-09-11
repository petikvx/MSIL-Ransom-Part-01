using System.Collections.Generic;
using MySql.Data.MySqlClient;
using MySqlX.Failover;
using ns10;
using ns21;

namespace ns14;

internal sealed class Class106 : Class105
{
	private int int_0;

	public Class106(List<XServer> list_1)
		: base(list_1)
	{
		int_0 = 0;
	}

	protected internal override void vmethod_0()
	{
		if (base.Hosts == null || base.Hosts.Count == 0)
		{
			throw new MySqlException(Class121.Replication_NoAvailableServer);
		}
		base.Hosts[0].IsActive = true;
		xserver_0 = base.Hosts[0];
	}

	protected internal override XServer vmethod_1()
	{
		if (base.Hosts == null)
		{
			throw new MySqlException(Class121.Replication_NoAvailableServer);
		}
		base.Hosts[int_0].IsActive = false;
		xserver_0 = ((int_0 == base.Hosts.Count - 1) ? base.Hosts[0] : base.Hosts[int_0 + 1]);
		xserver_0.IsActive = true;
		int_0++;
		return xserver_0;
	}
}
