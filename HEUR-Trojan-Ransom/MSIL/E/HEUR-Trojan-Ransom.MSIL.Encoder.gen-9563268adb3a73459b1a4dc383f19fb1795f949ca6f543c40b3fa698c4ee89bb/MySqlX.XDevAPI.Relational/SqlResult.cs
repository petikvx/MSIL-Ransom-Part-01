using MySqlX.Sessions;

namespace MySqlX.XDevAPI.Relational;

public class SqlResult : InternalRowResult
{
	public bool HasData => _hasData;

	internal SqlResult(InternalSession session)
		: base(session)
	{
	}

	public bool NextResult()
	{
		if (!_hasMoreResults)
		{
			return false;
		}
		_hasData = base.Protocol.HasData(this);
		LoadColumnData();
		_isComplete = !_hasData;
		_position = -1;
		_items.Clear();
		return _hasData;
	}
}
