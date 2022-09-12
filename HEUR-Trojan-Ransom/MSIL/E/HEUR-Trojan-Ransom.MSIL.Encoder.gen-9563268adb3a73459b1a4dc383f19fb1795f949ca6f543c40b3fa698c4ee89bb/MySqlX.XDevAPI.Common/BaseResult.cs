using System.Collections.Generic;
using System.Collections.ObjectModel;
using MySqlX.Protocol;
using MySqlX.Sessions;

namespace MySqlX.XDevAPI.Common;

public abstract class BaseResult
{
	private List<WarningInfo> _warnings = new List<WarningInfo>();

	internal ulong _recordsAffected;

	internal ulong _affectedItemsCount;

	internal ulong _autoIncrementValue;

	internal InternalSession _session;

	internal bool _hasData;

	internal bool _hasMoreResults;

	internal List<string> _documentIds = new List<string>();

	public ulong AffectedItemsCount => _affectedItemsCount;

	protected ProtocolBase Protocol => _session?.GetProtocol();

	public ReadOnlyCollection<WarningInfo> Warnings => _warnings.AsReadOnly();

	public int WarningsCount => _warnings.Count;

	internal BaseResult(InternalSession session)
	{
		if (session != null)
		{
			_session = session;
			if (session.ActiveResult != null)
			{
				session.ActiveResult.Buffer();
				session.ActiveResult = null;
			}
			_hasData = Protocol.HasData(this);
			if (_hasData)
			{
				session.ActiveResult = this;
			}
		}
	}

	internal void AddWarning(WarningInfo w)
	{
		_warnings.Add(w);
	}

	protected virtual void Buffer()
	{
	}
}
