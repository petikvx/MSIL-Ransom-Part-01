#define DEBUG
using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using LivePortfolio.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using SVCSharedCode;

namespace LivePortfolio;

public class DatabasePrimitives : ClassBase
{
	private SQLiteConnectionStringBuilder ConnectionStringBuilder;

	private string ConnectionString;

	public DatabasePrimitives()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		ConnectionStringBuilder = new SQLiteConnectionStringBuilder();
		SQLiteConnectionStringBuilder connectionStringBuilder = ConnectionStringBuilder;
		connectionStringBuilder.set_DataSource(MyWpfExtension.Application.Info.get_DirectoryPath() + "\\Data\\Bartleby.s3db");
		connectionStringBuilder.set_Pooling(true);
		connectionStringBuilder.set_Version(3);
		connectionStringBuilder = null;
		ConnectionString = ((DbConnectionStringBuilder)(object)ConnectionStringBuilder).ConnectionString;
	}

	public DataTable ExecuteQuery(string SQL)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		DataTable dataTable = new DataTable();
		SQLiteConnection val = new SQLiteConnection(ConnectionString);
		try
		{
			val.Open();
			SQLiteCommand val2 = new SQLiteCommand(SQL, val);
			SQLiteDataReader val3 = default(SQLiteDataReader);
			try
			{
				val3 = val2.ExecuteReader();
				dataTable.Load((IDataReader)val3);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				base.ExceptionHandler.HandleError(ex2, "DatabasePrimitives.ExecuteQuery", "Modal", 999);
				Interaction.MsgBox((object)SQL, (MsgBoxStyle)0, (object)null);
				Clipboard.SetText(SQL);
				ProjectData.ClearProjectError();
			}
			finally
			{
				val3.Close();
				val.Close();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		WriteLogMessage(SQL, Conversions.ToInteger("1"), 0);
		return dataTable;
	}

	public int ExecuteNonQuery(string SQL, bool Logging = true)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		SQL = "BEGIN TRANSACTION;" + SQL + "; COMMIT;";
		SQLiteConnection val = new SQLiteConnection(ConnectionString);
		int result = default(int);
		try
		{
			val.Open();
			SQLiteCommand val2 = new SQLiteCommand(SQL, val);
			try
			{
				result = val2.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				base.ExceptionHandler.HandleError(ex2, "DatabasePrimitives.ExecuteNonQuery", "Modal", 999);
				Interaction.MsgBox((object)SQL, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			finally
			{
				val.Close();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		if (Logging)
		{
			WriteLogMessage(SQL, Conversions.ToInteger("1"), 0);
		}
		return result;
	}

	public object ExecuteScalar(string SQL, bool Logging = true)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (Logging)
		{
			WriteLogMessage("SQL " + SQL);
			Debug.Print("SQL " + SQL);
		}
		SQLiteConnection val = new SQLiteConnection(ConnectionString);
		object objectValue = default(object);
		try
		{
			val.Open();
			SQLiteCommand val2 = new SQLiteCommand(SQL, val);
			try
			{
				objectValue = RuntimeHelpers.GetObjectValue(val2.ExecuteScalar());
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				base.ExceptionHandler.HandleError(ex2, "DatabasePrimitives.ExecuteScalar", "Modal", 999);
				Interaction.MsgBox((object)SQL, (MsgBoxStyle)0, (object)null);
				Clipboard.SetText(SQL);
				ProjectData.ClearProjectError();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		WriteLogMessage(SQL, Conversions.ToInteger("1"), 0);
		return objectValue;
	}

	public void WriteLogMessage(string Message, int Code = 0, int severity = 1)
	{
		Message = Message.Replace("'", " ");
		ExecuteNonQuery("INSERT INTO Log(Message,Code,Severity) VALUES ('" + Message + "', " + Conversions.ToString(Code) + "," + Conversions.ToString(severity) + ")", Logging: false);
	}
}
