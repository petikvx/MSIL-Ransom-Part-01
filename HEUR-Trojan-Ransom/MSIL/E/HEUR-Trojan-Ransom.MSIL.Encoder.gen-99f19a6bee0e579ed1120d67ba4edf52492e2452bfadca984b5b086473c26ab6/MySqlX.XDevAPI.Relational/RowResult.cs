using MySqlX.Sessions;

namespace MySqlX.XDevAPI.Relational;

public sealed class RowResult : InternalRowResult
{
	internal RowResult(InternalSession session)
		: base(session)
	{
	}
}
