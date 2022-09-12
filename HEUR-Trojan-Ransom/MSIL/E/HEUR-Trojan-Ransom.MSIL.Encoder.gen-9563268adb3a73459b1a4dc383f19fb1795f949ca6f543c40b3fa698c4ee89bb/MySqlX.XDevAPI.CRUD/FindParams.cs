using MySql.Data.MySqlClient;
using MySqlX.Protocol.X;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.CRUD;

internal class FindParams : FilterParams
{
	public string[] GroupBy;

	public string GroupByCritieria;

	public string[] Projection;

	public RowLock Locking;

	public LockContention LockingOption;
}
