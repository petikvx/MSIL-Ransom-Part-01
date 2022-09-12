using System.Collections.ObjectModel;
using MySqlX.Sessions;

namespace MySqlX.XDevAPI.Common;

public class Result : BaseResult
{
	public ulong AutoIncrementValue => _autoIncrementValue;

	public ReadOnlyCollection<string> GeneratedIds { get; }

	internal Result(InternalSession session)
		: base(session)
	{
		if (session != null)
		{
			GeneratedIds = new ReadOnlyCollection<string>(_documentIds);
			session.GetProtocol().CloseResult(this);
		}
	}
}
