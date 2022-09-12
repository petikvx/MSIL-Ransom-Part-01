using System;
using System.Collections.Generic;

namespace MySql.Data.MySqlClient.Replication;

internal static class ReplicationManager
{
	private static List<ReplicationServerGroup> groups;

	private static object thisLock;

	internal static IList<ReplicationServerGroup> Groups { get; private set; }

	static ReplicationManager()
	{
		groups = new List<ReplicationServerGroup>();
		thisLock = new object();
		Groups = groups;
		if (MySqlConfiguration.Settings == null)
		{
			return;
		}
		foreach (ReplicationServerGroupConfigurationElement serverGroup in MySqlConfiguration.Settings.Replication.ServerGroups)
		{
			ReplicationServerGroup replicationServerGroup = AddGroup(serverGroup.Name, serverGroup.GroupType, serverGroup.RetryTime);
			foreach (ReplicationServerConfigurationElement server in serverGroup.Servers)
			{
				replicationServerGroup.AddServer(server.Name, server.IsMaster, server.ConnectionString);
			}
		}
	}

	internal static ReplicationServerGroup AddGroup(string name, int retryTime)
	{
		return AddGroup(name, null, retryTime);
	}

	internal static ReplicationServerGroup AddGroup(string name, string groupType, int retryTime)
	{
		if (string.IsNullOrEmpty(groupType))
		{
			groupType = "MySql.Data.MySqlClient.Replication.ReplicationRoundRobinServerGroup";
		}
		ReplicationServerGroup replicationServerGroup = (ReplicationServerGroup)Activator.CreateInstance(Type.GetType(groupType), name, retryTime);
		groups.Add(replicationServerGroup);
		return replicationServerGroup;
	}

	internal static ReplicationServer GetServer(string groupName, bool isMaster)
	{
		return GetGroup(groupName).GetServer(isMaster);
	}

	internal static ReplicationServerGroup GetGroup(string groupName)
	{
		ReplicationServerGroup replicationServerGroup = null;
		foreach (ReplicationServerGroup group in groups)
		{
			if (string.Compare(group.Name, groupName, StringComparison.OrdinalIgnoreCase) == 0)
			{
				replicationServerGroup = group;
				break;
			}
		}
		if (replicationServerGroup == null)
		{
			throw new MySqlException(string.Format(Resources.ReplicationGroupNotFound, groupName));
		}
		return replicationServerGroup;
	}

	internal static bool IsReplicationGroup(string groupName)
	{
		foreach (ReplicationServerGroup group in groups)
		{
			if (string.Compare(group.Name, groupName, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return true;
			}
		}
		return false;
	}

	internal static void GetNewConnection(string groupName, bool master, MySqlConnection connection)
	{
		while (true)
		{
			lock (thisLock)
			{
				if (!IsReplicationGroup(groupName))
				{
					break;
				}
				ReplicationServerGroup group = GetGroup(groupName);
				ReplicationServer server = group.GetServer(master, connection.Settings);
				if (server == null)
				{
					throw new MySqlException(Resources.Replication_NoAvailableServer);
				}
				try
				{
					bool flag = false;
					if (connection.driver != null && connection.driver.IsOpen)
					{
						if (!new MySqlConnectionStringBuilder(server.ConnectionString).Equals(connection.driver.Settings))
						{
							flag = true;
						}
					}
					else
					{
						flag = true;
					}
					if (flag)
					{
						Driver driver = (connection.driver = Driver.Create(new MySqlConnectionStringBuilder(server.ConnectionString)));
					}
					break;
				}
				catch (MySqlException ex)
				{
					connection.driver = null;
					server.IsAvailable = false;
					MySqlTrace.LogError(ex.Number, ex.ToString());
					if (ex.Number != 1042)
					{
						throw;
					}
					group.HandleFailover(server, ex);
				}
				continue;
			}
		}
	}
}
