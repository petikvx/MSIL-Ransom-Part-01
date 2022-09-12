using System.Data;
using System.Data.Common;

namespace MySql.Data.MySqlClient;

public sealed class MySqlRowUpdatingEventArgs : RowUpdatingEventArgs
{
	public new MySqlCommand Command
	{
		get
		{
			return (MySqlCommand)base.Command;
		}
		set
		{
			base.Command = value;
		}
	}

	public MySqlRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		: base(row, command, statementType, tableMapping)
	{
	}
}
