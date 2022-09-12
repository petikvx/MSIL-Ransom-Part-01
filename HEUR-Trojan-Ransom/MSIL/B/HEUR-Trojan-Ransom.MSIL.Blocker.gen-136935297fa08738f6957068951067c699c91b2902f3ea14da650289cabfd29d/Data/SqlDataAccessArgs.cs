using System.Collections.Generic;

namespace Data;

public class SqlDataAccessArgs
{
	private IDictionary<string, object> args = new Dictionary<string, object>();

	public IDictionary<string, object> Arguments => args;

	public static SqlDataAccessArgs CreateWith(string name, object value)
	{
		return new SqlDataAccessArgs(name, value);
	}

	public SqlDataAccessArgs And(string name, object value)
	{
		args[name] = value;
		return this;
	}

	private SqlDataAccessArgs(string name, object value)
	{
		args[name] = value;
	}
}
