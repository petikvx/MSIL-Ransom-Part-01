using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MySql.Data.Failover;

internal class SequentialFailoverGroup : FailoverGroup
{
	private FailoverServer _initialHost;

	private int _hostIndex;

	private FailoverServer _currentHost;

	public SequentialFailoverGroup(List<FailoverServer> hosts)
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
		_initialHost = base.Hosts[0];
		base.Hosts[0].IsActive = true;
		_activeHost = base.Hosts[0];
		_currentHost = _activeHost;
	}

	protected internal override FailoverServer GetNextHost()
	{
		if (base.Hosts != null)
		{
			List<FailoverServer> hosts = base.Hosts;
			if (hosts == null || hosts.Count != 0)
			{
				FailoverServer failoverServer = base.Hosts.Find((FailoverServer h) => h.Host == _currentHost.Host && h.Port == _currentHost.Port);
				failoverServer.IsActive = false;
				_hostIndex = base.Hosts.IndexOf(failoverServer);
				if (base.Hosts.Count > 1)
				{
					_activeHost = ((_hostIndex == base.Hosts.Count - 1) ? base.Hosts[0] : base.Hosts[_hostIndex + 1]);
					_activeHost.IsActive = true;
					_currentHost = _activeHost;
					_hostIndex++;
				}
				else
				{
					_activeHost = _initialHost;
				}
				return _activeHost;
			}
		}
		throw new MySqlException(Resources.Replication_NoAvailableServer);
	}
}
