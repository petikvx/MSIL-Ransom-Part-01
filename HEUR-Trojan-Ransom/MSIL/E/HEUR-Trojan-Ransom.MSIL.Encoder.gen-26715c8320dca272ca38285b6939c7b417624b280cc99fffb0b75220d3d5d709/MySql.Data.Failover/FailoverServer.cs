using System;

namespace MySql.Data.Failover;

internal class FailoverServer : IEquatable<FailoverServer>
{
	internal string Host { get; private set; }

	internal int Port { get; private set; }

	internal int Priority { get; private set; }

	internal bool IsActive { get; set; }

	internal bool Attempted { get; set; }

	internal DateTime DemotedTime { get; set; }

	internal FailoverServer(string host, int port, int? priority)
	{
		Host = host;
		Port = port;
		Priority = priority ?? (-1);
	}

	public bool Equals(FailoverServer other)
	{
		if (other == null)
		{
			return false;
		}
		if (Host == other.Host)
		{
			return Port == other.Port;
		}
		return false;
	}
}
