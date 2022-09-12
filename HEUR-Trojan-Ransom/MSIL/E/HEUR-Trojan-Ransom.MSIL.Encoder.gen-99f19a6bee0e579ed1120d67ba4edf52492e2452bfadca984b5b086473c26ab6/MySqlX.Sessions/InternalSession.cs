using System;
using System.Collections.ObjectModel;
using System.IO;
using MySql.Data;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using MySqlX.Protocol;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;

namespace MySqlX.Sessions;

internal abstract class InternalSession : IDisposable
{
	protected Stream _stream;

	internal BaseResult ActiveResult;

	private bool disposed;

	protected internal MySqlXConnectionStringBuilder Settings;

	public SessionState SessionState { get; protected set; }

	public InternalSession(MySqlXConnectionStringBuilder settings)
	{
		Settings = settings;
	}

	protected abstract void Open();

	public abstract void Close();

	internal abstract ProtocolBase GetProtocol();

	public static InternalSession GetSession(MySqlXConnectionStringBuilder settings)
	{
		InternalSession internalSession = new XInternalSession(settings);
		int num = 0;
		while (true)
		{
			try
			{
				internalSession.Open();
				SetDefaultCollation(internalSession, settings.CharacterSet);
				return internalSession;
			}
			catch (IOException ex)
			{
				if (num++ >= 5)
				{
					throw new MySqlException(ResourcesX.UnableToOpenSession, ex);
				}
			}
		}
	}

	public Result ExecuteSqlNonQuery(string sql, params object[] args)
	{
		GetProtocol().SendSQL(sql, args);
		return new Result(this);
	}

	public RowResult GetSqlRowResult(string sql)
	{
		GetProtocol().SendSQL(sql);
		return new RowResult(this);
	}

	public SqlResult GetSQLResult(string sql, object[] args)
	{
		GetProtocol().SendSQL(sql, args);
		return new SqlResult(this);
	}

	public object ExecuteQueryAsScalar(string sql)
	{
		ReadOnlyCollection<Row> readOnlyCollection = GetSqlRowResult(sql).FetchAll();
		if (readOnlyCollection.Count == 0)
		{
			throw new MySqlException("No data found");
		}
		return readOnlyCollection[0][0];
	}

	private static void SetDefaultCollation(InternalSession session, string charset)
	{
		if (session.GetServerVersion().isAtLeast(8, 0, 1))
		{
			session.GetSqlRowResult("SHOW CHARSET WHERE Charset='" + charset + "'");
			Row row = session.GetSqlRowResult("SHOW CHARSET WHERE Charset='" + charset + "'").FetchOne();
			if (row != null)
			{
				string @string = row.GetString("Default collation");
				session.ExecuteSqlNonQuery("SET collation_connection = '" + @string + "'");
			}
			else
			{
				session.ExecuteSqlNonQuery("SET collation_connection = 'utf8mb4_0900_ai_ci'");
			}
		}
	}

	internal DBVersion GetServerVersion()
	{
		return DBVersion.Parse(GetSqlRowResult("SHOW VARIABLES LIKE 'version'").FetchOne().GetString("Value"));
	}

	internal int GetThreadId()
	{
		return int.Parse(GetSqlRowResult("SELECT CONNECTION_ID()").FetchOne().GetString("connection_id()"));
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!disposed)
		{
			disposed = true;
		}
	}
}
