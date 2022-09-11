using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace ns5;

internal sealed class EventArgs2 : RowUpdatedEventArgs
{
	public new MySqlCommand Command => (MySqlCommand)base.Command;

	public EventArgs2(DataRow dataRow_0, IDbCommand idbCommand_0, StatementType statementType_0, DataTableMapping dataTableMapping_0)
		: base(dataRow_0, idbCommand_0, statementType_0, dataTableMapping_0)
	{
	}
}
