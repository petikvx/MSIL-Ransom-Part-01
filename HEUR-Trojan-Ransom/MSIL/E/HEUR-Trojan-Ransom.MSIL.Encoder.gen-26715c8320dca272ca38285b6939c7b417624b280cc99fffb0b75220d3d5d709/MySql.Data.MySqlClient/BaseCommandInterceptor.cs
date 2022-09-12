using System.Data;

namespace MySql.Data.MySqlClient;

public abstract class BaseCommandInterceptor
{
	protected MySqlConnection ActiveConnection { get; private set; }

	public virtual bool ExecuteScalar(string sql, ref object returnValue)
	{
		return false;
	}

	public virtual bool ExecuteNonQuery(string sql, ref int returnValue)
	{
		return false;
	}

	public virtual bool ExecuteReader(string sql, CommandBehavior behavior, ref MySqlDataReader returnValue)
	{
		return false;
	}

	public virtual void Init(MySqlConnection connection)
	{
		ActiveConnection = connection;
	}
}
