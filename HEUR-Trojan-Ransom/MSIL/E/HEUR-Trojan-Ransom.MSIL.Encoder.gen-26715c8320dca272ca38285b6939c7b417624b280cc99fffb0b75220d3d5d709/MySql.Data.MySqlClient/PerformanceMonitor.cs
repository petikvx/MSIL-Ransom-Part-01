namespace MySql.Data.MySqlClient;

internal class PerformanceMonitor
{
	public MySqlConnection Connection { get; private set; }

	public PerformanceMonitor(MySqlConnection connection)
	{
		Connection = connection;
	}

	public virtual void AddHardProcedureQuery()
	{
	}

	public virtual void AddSoftProcedureQuery()
	{
	}
}
