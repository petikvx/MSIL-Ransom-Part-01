using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace MySql.Data.Failover;

internal class RandomFailoverGroup : FailoverGroup
{
	private FailoverServer _initialHost;

	private FailoverServer _currentHost;

	private readonly Random rnd = new Random();

	public RandomFailoverGroup(List<FailoverServer> hosts)
		: base(hosts)
	{
	}

	protected internal override void SetInitialActiveServer()
	{
		if (base.Hosts == null || base.Hosts.Count == 0)
		{
			throw new MySqlException(Resources.Replication_NoAvailableServer);
		}
		int index = rnd.Next(base.Hosts.Count);
		_initialHost = base.Hosts[index];
		_initialHost.IsActive = true;
		_initialHost.Attempted = true;
		_activeHost = _initialHost;
		_currentHost = _activeHost;
	}

	protected internal override FailoverServer GetNextHost()
	{
		if (base.Hosts != null)
		{
			List<FailoverServer> hosts = base.Hosts;
			if (hosts == null || hosts.Count != 0)
			{
				base.Hosts.Find((FailoverServer h) => h.Host == _currentHost.Host && h.Port == _currentHost.Port)!.IsActive = false;
				List<FailoverServer> list = base.Hosts.FindAll((FailoverServer h) => !h.Attempted);
				if (list.Count > 0)
				{
					_activeHost = list[rnd.Next(list.Count)];
					_activeHost.IsActive = true;
					_activeHost.Attempted = true;
					_currentHost = _activeHost;
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
