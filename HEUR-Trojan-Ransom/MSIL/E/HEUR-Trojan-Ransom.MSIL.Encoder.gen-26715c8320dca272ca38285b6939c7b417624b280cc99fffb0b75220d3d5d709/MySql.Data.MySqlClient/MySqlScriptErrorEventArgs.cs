using System;

namespace MySql.Data.MySqlClient;

public class MySqlScriptErrorEventArgs : MySqlScriptEventArgs
{
	public Exception Exception { get; }

	public bool Ignore { get; set; }

	public MySqlScriptErrorEventArgs(Exception exception)
	{
		Exception = exception;
	}
}
