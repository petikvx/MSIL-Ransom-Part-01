using System.Collections.Generic;

namespace MySql.Data.Failover;

internal abstract class FailoverGroup
{
	protected internal FailoverServer _activeHost;

	protected internal List<FailoverServer> Hosts { get; set; }

	protected internal FailoverServer ActiveHost
	{
		get
		{
			if (Hosts == null)
			{
				return null;
			}
			if (_activeHost != null)
			{
				return _activeHost;
			}
			foreach (FailoverServer host in Hosts)
			{
				if (host.IsActive)
				{
					return host;
				}
			}
			return null;
		}
	}

	internal FailoverGroup(List<FailoverServer> hosts)
	{
		Hosts = hosts;
		SetInitialActiveServer();
	}

	protected internal abstract void SetInitialActiveServer();

	protected internal abstract FailoverServer GetNextHost();
}
