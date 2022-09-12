using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace MySqlX.XDevAPI.Common;

public abstract class BaseStatement<TResult> where TResult : BaseResult
{
	internal bool _hasChanged;

	internal bool _isPrepared;

	protected int _stmtId;

	public BaseSession Session { get; private set; }

	public BaseStatement(BaseSession session)
	{
		Session = session;
		_hasChanged = true;
	}

	public abstract TResult Execute();

	public async Task<TResult> ExecuteAsync()
	{
		return await Task.Factory.StartNew(delegate
		{
			TResult val = Execute();
			if (val is BufferingResult<DbDoc>)
			{
				(val as BufferingResult<DbDoc>).FetchAll();
			}
			else if (val is BufferingResult<Row>)
			{
				(val as BufferingResult<Row>).FetchAll();
			}
			return val;
		}, CancellationToken.None, TaskCreationOptions.None, Session._scheduler);
	}

	protected void ValidateOpenSession()
	{
		if (Session.XSession.SessionState != SessionState.Open)
		{
			throw new MySqlException(ResourcesX.InvalidSession);
		}
	}

	protected void SetChanged()
	{
		_hasChanged = true;
	}

	protected virtual TResult ConvertToPreparedStatement<T>(Func<T, TResult> executeFunc, T t, IEnumerable args)
	{
		if (!Session.SupportsPreparedStatements)
		{
			return executeFunc(t);
		}
		if (_hasChanged)
		{
			if (_isPrepared)
			{
				Session.XSession.DeallocatePreparedStatement(_stmtId);
				_isPrepared = false;
			}
			return executeFunc(t);
		}
		if (!_isPrepared)
		{
			try
			{
				_stmtId = Session.XSession.PrepareStatement(this);
				_isPrepared = true;
			}
			catch (MySqlException ex) when (ex.Code == 1461 || ex.Code == 1047)
			{
				Session.SupportsPreparedStatements = false;
				_isPrepared = false;
				return executeFunc(t);
			}
		}
		return Session.XSession.ExecutePreparedStatement<TResult>(_stmtId, args);
	}
}
