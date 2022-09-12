using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

internal class TracingDriver : Driver
{
	private static long driverCounter;

	private long driverId;

	private ResultSet activeResult;

	private int rowSizeInBytes;

	public TracingDriver(MySqlConnectionStringBuilder settings)
		: base(settings)
	{
		driverId = Interlocked.Increment(ref driverCounter);
	}

	public override void Open()
	{
		base.Open();
		MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.ConnectionOpened, Resources.TraceOpenConnection, driverId, base.Settings.ConnectionString, base.ThreadID);
	}

	public override void Close()
	{
		base.Close();
		MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.ConnectionClosed, Resources.TraceCloseConnection, driverId);
	}

	public override void SendQuery(MySqlPacket p)
	{
		rowSizeInBytes = 0;
		string text = base.Encoding.GetString(p.Buffer, 5, p.Length - 5);
		string text2 = null;
		if (text.Length > 300)
		{
			text2 = new QueryNormalizer().Normalize(text);
			text = text.Substring(0, 300);
		}
		base.SendQuery(p);
		MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.QueryOpened, Resources.TraceQueryOpened, driverId, base.ThreadID, text);
		if (text2 != null)
		{
			MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.QueryNormalized, Resources.TraceQueryNormalized, driverId, base.ThreadID, text2);
		}
	}

	protected override int GetResult(int statementId, ref int affectedRows, ref long insertedId)
	{
		try
		{
			int result = base.GetResult(statementId, ref affectedRows, ref insertedId);
			MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.ResultOpened, Resources.TraceResult, driverId, result, affectedRows, insertedId);
			return result;
		}
		catch (MySqlException ex)
		{
			MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.Error, Resources.TraceOpenResultError, driverId, ex.Number, ex.Message);
			throw ex;
		}
	}

	public override ResultSet NextResult(int statementId, bool force)
	{
		if (activeResult != null)
		{
			if (base.Settings.UseUsageAdvisor)
			{
				ReportUsageAdvisorWarnings(statementId, activeResult);
			}
			MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.ResultClosed, Resources.TraceResultClosed, driverId, activeResult.TotalRows, activeResult.SkippedRows, rowSizeInBytes);
			rowSizeInBytes = 0;
			activeResult = null;
		}
		activeResult = base.NextResult(statementId, force);
		return activeResult;
	}

	public override int PrepareStatement(string sql, ref MySqlField[] parameters)
	{
		int num = base.PrepareStatement(sql, ref parameters);
		MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.StatementPrepared, Resources.TraceStatementPrepared, driverId, sql, num);
		return num;
	}

	public override void CloseStatement(int id)
	{
		base.CloseStatement(id);
		MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.StatementClosed, Resources.TraceStatementClosed, driverId, id);
	}

	public override void SetDatabase(string dbName)
	{
		base.SetDatabase(dbName);
		MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.NonQuery, Resources.TraceSetDatabase, driverId, dbName);
	}

	public override void ExecuteStatement(MySqlPacket packetToExecute)
	{
		base.ExecuteStatement(packetToExecute);
		int position = packetToExecute.Position;
		packetToExecute.Position = 1;
		int num = packetToExecute.ReadInteger(4);
		packetToExecute.Position = position;
		MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.StatementExecuted, Resources.TraceStatementExecuted, driverId, num, base.ThreadID);
	}

	public override bool FetchDataRow(int statementId, int columns)
	{
		try
		{
			bool num = base.FetchDataRow(statementId, columns);
			if (num)
			{
				rowSizeInBytes += (handler as NativeDriver).Packet.Length;
			}
			return num;
		}
		catch (MySqlException ex)
		{
			MySqlTrace.TraceEvent(TraceEventType.Error, MySqlTraceEventType.Error, Resources.TraceFetchError, driverId, ex.Number, ex.Message);
			throw ex;
		}
	}

	public override void CloseQuery(MySqlConnection connection, int statementId)
	{
		base.CloseQuery(connection, statementId);
		MySqlTrace.TraceEvent(TraceEventType.Information, MySqlTraceEventType.QueryClosed, Resources.TraceQueryDone, driverId);
	}

	public override List<MySqlError> ReportWarnings(MySqlConnection connection)
	{
		List<MySqlError> list = base.ReportWarnings(connection);
		foreach (MySqlError item in list)
		{
			MySqlTrace.TraceEvent(TraceEventType.Warning, MySqlTraceEventType.Warning, Resources.TraceWarning, driverId, item.Level, item.Code, item.Message);
		}
		return list;
	}

	private bool AllFieldsAccessed(ResultSet rs)
	{
		if (rs.Fields != null && rs.Fields.Length != 0)
		{
			int num = 0;
			while (true)
			{
				if (num < rs.Fields.Length)
				{
					if (!rs.FieldRead(num))
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	private void ReportUsageAdvisorWarnings(int statementId, ResultSet rs)
	{
		if (!base.Settings.UseUsageAdvisor)
		{
			return;
		}
		if (HasStatus(ServerStatusFlags.NoIndex))
		{
			MySqlTrace.TraceEvent(TraceEventType.Warning, MySqlTraceEventType.UsageAdvisorWarning, Resources.TraceUAWarningNoIndex, driverId, UsageAdvisorWarningFlags.NoIndex);
		}
		else if (HasStatus(ServerStatusFlags.BadIndex))
		{
			MySqlTrace.TraceEvent(TraceEventType.Warning, MySqlTraceEventType.UsageAdvisorWarning, Resources.TraceUAWarningBadIndex, driverId, UsageAdvisorWarningFlags.BadIndex);
		}
		if (rs.SkippedRows > 0)
		{
			MySqlTrace.TraceEvent(TraceEventType.Warning, MySqlTraceEventType.UsageAdvisorWarning, Resources.TraceUAWarningSkippedRows, driverId, UsageAdvisorWarningFlags.SkippedRows, rs.SkippedRows);
		}
		if (!AllFieldsAccessed(rs))
		{
			StringBuilder stringBuilder = new StringBuilder("");
			string arg = "";
			for (int i = 0; i < rs.Size; i++)
			{
				if (!rs.FieldRead(i))
				{
					stringBuilder.AppendFormat("{0}{1}", arg, rs.Fields[i].ColumnName);
					arg = ",";
				}
			}
			MySqlTrace.TraceEvent(TraceEventType.Warning, MySqlTraceEventType.UsageAdvisorWarning, Resources.TraceUAWarningSkippedColumns, driverId, UsageAdvisorWarningFlags.SkippedColumns, stringBuilder.ToString());
		}
		if (rs.Fields == null)
		{
			return;
		}
		MySqlField[] fields = rs.Fields;
		foreach (MySqlField mySqlField in fields)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			string arg2 = "";
			foreach (Type typeConversion in mySqlField.TypeConversions)
			{
				stringBuilder2.AppendFormat("{0}{1}", arg2, typeConversion.Name);
				arg2 = ",";
			}
			if (stringBuilder2.Length > 0)
			{
				MySqlTrace.TraceEvent(TraceEventType.Warning, MySqlTraceEventType.UsageAdvisorWarning, Resources.TraceUAWarningFieldConversion, driverId, UsageAdvisorWarningFlags.FieldConversion, mySqlField.ColumnName, stringBuilder2.ToString());
			}
		}
	}
}
