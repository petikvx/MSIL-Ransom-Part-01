namespace MySqlX.Failover;

internal class XServer
{
	internal string Host { get; private set; }

	internal int Port { get; private set; }

	internal int Priority { get; private set; }

	internal bool IsActive { get; set; }

	internal XServer(string host, int port, int priority)
	{
		Host = host;
		Port = port;
		Priority = priority;
	}
}
