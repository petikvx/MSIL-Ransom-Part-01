namespace MySqlX.XDevAPI;

public class MySQLX
{
	public static Session GetSession(string connectionString)
	{
		return new Session(connectionString);
	}

	public static Session GetSession(object connectionData)
	{
		return new Session(connectionData);
	}

	public static Client GetClient(string connectionString, string connectionOptions)
	{
		return new Client(connectionString, connectionOptions);
	}

	public static Client GetClient(string connectionString, object connectionOptions)
	{
		return new Client(connectionString, connectionOptions);
	}

	public static Client GetClient(object connectionData, string connectionOptions)
	{
		return new Client(connectionData, connectionOptions);
	}

	public static Client GetClient(object connectionData, object connectionOptions)
	{
		return new Client(connectionData, connectionOptions);
	}
}
