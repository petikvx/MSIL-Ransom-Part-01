using System.Collections.Generic;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.Relational;

public class SqlStatement : BaseStatement<SqlResult>
{
	protected internal List<object> parameters = new List<object>();

	public string SQL { get; private set; }

	public SqlStatement(Session session, string sql)
		: base((BaseSession)session)
	{
		SQL = sql;
	}

	public override SqlResult Execute()
	{
		ValidateOpenSession();
		return GetSQLResult(this);
	}

	private SqlResult GetSQLResult(SqlStatement statement)
	{
		return base.Session.XSession.GetSQLResult(statement.SQL, parameters.ToArray());
	}

	public SqlStatement Bind(params object[] values)
	{
		if (values == null)
		{
			parameters.Add(null);
		}
		else
		{
			parameters.AddRange(values);
		}
		return this;
	}
}
