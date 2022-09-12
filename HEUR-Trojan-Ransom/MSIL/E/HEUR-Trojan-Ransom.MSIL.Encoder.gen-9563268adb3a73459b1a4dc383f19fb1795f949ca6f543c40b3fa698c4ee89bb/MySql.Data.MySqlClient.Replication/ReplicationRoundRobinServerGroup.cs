namespace MySql.Data.MySqlClient.Replication;

public class ReplicationRoundRobinServerGroup : ReplicationServerGroup
{
	private int nextServer;

	public ReplicationRoundRobinServerGroup(string name, int retryTime)
		: base(name, retryTime)
	{
		nextServer = -1;
	}

	protected internal override ReplicationServer GetServer(bool isMaster)
	{
		int num = 0;
		ReplicationServer replicationServer;
		while (true)
		{
			if (num < base.Servers.Count)
			{
				nextServer++;
				if (nextServer == base.Servers.Count)
				{
					nextServer = 0;
				}
				replicationServer = base.Servers[nextServer];
				if (replicationServer.IsAvailable && (!isMaster || replicationServer.IsMaster))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return replicationServer;
	}
}
