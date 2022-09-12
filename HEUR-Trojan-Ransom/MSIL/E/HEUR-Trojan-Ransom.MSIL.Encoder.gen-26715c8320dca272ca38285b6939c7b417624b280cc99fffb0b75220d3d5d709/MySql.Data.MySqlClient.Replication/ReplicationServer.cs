namespace MySql.Data.MySqlClient.Replication;

public class ReplicationServer
{
	public string Name { get; private set; }

	public bool IsMaster { get; private set; }

	public string ConnectionString { get; internal set; }

	public bool IsAvailable { get; set; }

	public ReplicationServer(string name, bool isMaster, string connectionString)
	{
		Name = name;
		IsMaster = isMaster;
		ConnectionString = connectionString;
		IsAvailable = true;
	}
}
