using System;

namespace MySql.Data.MySqlClient;

public class MySqlScriptEventArgs : EventArgs
{
	internal ScriptStatement Statement { get; set; }

	public string StatementText => Statement.text;

	public int Line => Statement.line;

	public int Position => Statement.position;
}
