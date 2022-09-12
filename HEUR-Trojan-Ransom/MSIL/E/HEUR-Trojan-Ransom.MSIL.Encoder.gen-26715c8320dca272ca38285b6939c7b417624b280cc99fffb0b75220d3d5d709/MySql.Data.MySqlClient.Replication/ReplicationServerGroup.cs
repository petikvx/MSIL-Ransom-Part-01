using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Timers;

namespace MySql.Data.MySqlClient.Replication;

public abstract class ReplicationServerGroup
{
	protected List<ReplicationServer> servers = new List<ReplicationServer>();

	public string Name { get; protected set; }

	public int RetryTime { get; protected set; }

	protected IList<ReplicationServer> Servers { get; private set; }

	public ReplicationServerGroup(string name, int retryTime)
	{
		Servers = servers;
		Name = name;
		RetryTime = retryTime;
	}

	protected internal ReplicationServer AddServer(string name, bool isMaster, string connectionString)
	{
		ReplicationServer replicationServer = new ReplicationServer(name, isMaster, connectionString);
		servers.Add(replicationServer);
		return replicationServer;
	}

	protected internal void RemoveServer(string name)
	{
		ReplicationServer server = GetServer(name);
		if (server == null)
		{
			throw new MySqlException(string.Format(Resources.ReplicationServerNotFound, name));
		}
		servers.Remove(server);
	}

	protected internal ReplicationServer GetServer(string name)
	{
		foreach (ReplicationServer server in servers)
		{
			if (string.Compare(name, server.Name, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return server;
			}
		}
		return null;
	}

	protected internal abstract ReplicationServer GetServer(bool isMaster);

	protected internal virtual ReplicationServer GetServer(bool isMaster, MySqlConnectionStringBuilder settings)
	{
		return GetServer(isMaster);
	}

	protected internal virtual void HandleFailover(ReplicationServer server)
	{
		BackgroundWorker backgroundWorker = new BackgroundWorker();
		backgroundWorker.DoWork += delegate(object sender, DoWorkEventArgs e)
		{
			bool isRunning = false;
			ReplicationServer server2 = e.Argument as ReplicationServer;
			Timer timer = new Timer((double)RetryTime * 1000.0);
			ElapsedEventHandler elapsedEventHandler = delegate
			{
				if (isRunning)
				{
					return;
				}
				try
				{
					isRunning = true;
					using MySqlConnection mySqlConnection = new MySqlConnection(server.ConnectionString);
					mySqlConnection.Open();
					server2.IsAvailable = true;
					timer.Stop();
				}
				catch
				{
					MySqlTrace.LogWarning(0, string.Format(Resources.Replication_ConnectionAttemptFailed, server2.Name));
				}
				finally
				{
					isRunning = false;
				}
			};
			timer.Elapsed += elapsedEventHandler;
			timer.Start();
			elapsedEventHandler(sender, null);
		};
		backgroundWorker.RunWorkerAsync(server);
	}

	protected internal virtual void HandleFailover(ReplicationServer server, Exception exception)
	{
		HandleFailover(server);
	}
}
