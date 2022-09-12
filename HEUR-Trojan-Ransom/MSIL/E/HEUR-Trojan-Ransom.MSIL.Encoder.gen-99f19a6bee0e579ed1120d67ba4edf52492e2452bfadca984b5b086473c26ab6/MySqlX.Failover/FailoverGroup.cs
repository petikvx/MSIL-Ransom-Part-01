using System.Collections.Generic;

namespace MySqlX.Failover;

internal abstract class FailoverGroup
{
	protected internal XServer _activeHost;

	protected internal List<XServer> Hosts { get; set; }

	protected internal XServer ActiveHost
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
			foreach (XServer host in Hosts)
			{
				if (host.IsActive)
				{
					return host;
				}
			}
			return null;
		}
	}

	internal FailoverGroup(List<XServer> hosts)
	{
		Hosts = hosts;
		SetInitialActiveServer();
	}

	protected internal abstract void SetInitialActiveServer();

	protected internal abstract XServer GetNextHost();
}
