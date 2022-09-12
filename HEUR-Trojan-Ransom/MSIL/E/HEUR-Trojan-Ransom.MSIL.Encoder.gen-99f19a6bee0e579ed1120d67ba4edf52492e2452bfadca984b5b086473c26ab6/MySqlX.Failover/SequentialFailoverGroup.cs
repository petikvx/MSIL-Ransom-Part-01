using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlX.Failover;

internal class SequentialFailoverGroup : FailoverGroup
{
	private int _hostIndex;

	public SequentialFailoverGroup(List<XServer> hosts)
		: base(hosts)
	{
		_hostIndex = 0;
	}

	protected internal override void SetInitialActiveServer()
	{
		if (base.Hosts == null || base.Hosts.Count == 0)
		{
			throw new MySqlException(Resources.Replication_NoAvailableServer);
		}
		base.Hosts[0].IsActive = true;
		_activeHost = base.Hosts[0];
	}

	protected internal override XServer GetNextHost()
	{
		if (base.Hosts == null)
		{
			throw new MySqlException(Resources.Replication_NoAvailableServer);
		}
		base.Hosts[_hostIndex].IsActive = false;
		_activeHost = ((_hostIndex == base.Hosts.Count - 1) ? base.Hosts[0] : base.Hosts[_hostIndex + 1]);
		_activeHost.IsActive = true;
		_hostIndex++;
		return _activeHost;
	}
}
