using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.Sessions;
using MySqlX.XDevAPI.Relational;

namespace MySqlX.XDevAPI;

public class Session : BaseSession
{
	internal Session(string connectionString, Client client = null)
		: base(connectionString, client)
	{
	}

	internal Session(object connectionData, Client client = null)
		: base(connectionData, client)
	{
	}

	internal Session(InternalSession internalSession, Client client)
		: base(internalSession, client)
	{
	}

	public SqlStatement SQL(string sql)
	{
		if (base.InternalSession.SessionState != SessionState.Open)
		{
			throw new MySqlException(ResourcesX.InvalidSession);
		}
		return new SqlStatement(this, sql);
	}

	public void SetCurrentSchema(string schema)
	{
		base.InternalSession.ExecuteSqlNonQuery("USE `" + schema + "`");
		GetSchema(schema);
	}

	public Schema GetCurrentSchema()
	{
		string text = (string)base.InternalSession.ExecuteQueryAsScalar("SELECT DATABASE()");
		if (text != null)
		{
			return GetSchema(text);
		}
		return null;
	}
}
