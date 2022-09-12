using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Xml;

namespace Data;

public sealed class SqlDataAccess
{
	private static SqlConnection _connection;

	public static SqlTransaction OpenTransaction(string connectionString)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		_connection = new SqlConnection(connectionString);
		((DbConnection)(object)_connection).Open();
		return _connection.BeginTransaction();
	}

	public static void Commit(SqlTransaction transaction)
	{
		((DbTransaction)(object)transaction).Commit();
		((DbConnection)(object)_connection).Close();
		((Component)(object)_connection).Dispose();
		_connection = null;
	}

	public static void Rollback(SqlTransaction transaction)
	{
		((DbTransaction)(object)transaction).Rollback();
		((DbConnection)(object)_connection).Close();
		((Component)(object)_connection).Dispose();
		_connection = null;
	}

	public static int ExecuteNonQuery(string connectionString, string text)
	{
		return ExecuteNonQuery(connectionString, text, null);
	}

	public static int ExecuteNonQuery(string connectionString, string text, IDictionary<string, object> args)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		int num = -1;
		SqlConnection val = new SqlConnection(connectionString);
		try
		{
			SqlCommand val2 = new SqlCommand(text, val);
			try
			{
				((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
				if (args != null && args.Count > 0)
				{
					foreach (string key in args.Keys)
					{
						val2.get_Parameters().AddWithValue(key, (args[key] == null) ? DBNull.Value : args[key]);
					}
				}
				((DbConnection)(object)val).Open();
				try
				{
					return ((DbCommand)(object)val2).ExecuteNonQuery();
				}
				finally
				{
					try
					{
						((DbConnection)(object)val).Close();
						((Component)(object)val).Dispose();
						((Component)(object)val2).Dispose();
					}
					catch
					{
					}
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static int ExecuteNonQuery(string text, IDictionary<string, object> args, SqlTransaction transaction)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		int num = -1;
		SqlCommand val = new SqlCommand(text, _connection, transaction);
		try
		{
			((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
			if (args != null && args.Count > 0)
			{
				foreach (string key in args.Keys)
				{
					val.get_Parameters().AddWithValue(key, (args[key] == null) ? DBNull.Value : args[key]);
				}
			}
			try
			{
				return ((DbCommand)(object)val).ExecuteNonQuery();
			}
			finally
			{
				try
				{
					((Component)(object)val).Dispose();
				}
				catch
				{
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static T ExecuteScalarQuery<T>(string connectionString, string text)
	{
		return (T)Convert.ChangeType(ExecuteScalarQuery(connectionString, text, null, null), typeof(T));
	}

	public static T ExecuteScalarQuery<T>(string connectionString, string text, IDictionary<string, object> args)
	{
		return (T)Convert.ChangeType(ExecuteScalarQuery(connectionString, text, args, null), typeof(T));
	}

	public static T ExecuteScalarQuery<T>(string connectionString, string text, IDictionary<string, object> args, string field)
	{
		return (T)Convert.ChangeType(ExecuteScalarQuery(connectionString, text, args, field), typeof(T));
	}

	private static object ExecuteScalarQuery(string connectionString, string text, IDictionary<string, object> args, string field)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		if (field != null)
		{
			return executeDataRowAsScalar(connectionString, text, args, field);
		}
		object obj = null;
		SqlConnection val = new SqlConnection(connectionString);
		try
		{
			SqlCommand val2 = new SqlCommand(text, val);
			try
			{
				((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
				if (args != null && args.Count > 0)
				{
					foreach (string key in args.Keys)
					{
						val2.get_Parameters().AddWithValue(key, (args[key] == null) ? DBNull.Value : args[key]);
					}
				}
				((DbConnection)(object)val).Open();
				try
				{
					return ((DbCommand)(object)val2).ExecuteScalar();
				}
				finally
				{
					try
					{
						((DbConnection)(object)val).Close();
						((Component)(object)val).Dispose();
						((Component)(object)val2).Dispose();
					}
					catch
					{
					}
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static T ExecuteScalarQuery<T>(string text, IDictionary<string, object> args, SqlTransaction transaction)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object value = null;
		SqlCommand val = new SqlCommand(text, _connection, transaction);
		try
		{
			((DbCommand)(object)val).CommandType = CommandType.StoredProcedure;
			if (args != null && args.Count > 0)
			{
				foreach (string key in args.Keys)
				{
					val.get_Parameters().AddWithValue(key, (args[key] == null) ? DBNull.Value : args[key]);
				}
			}
			try
			{
				value = ((DbCommand)(object)val).ExecuteScalar();
			}
			finally
			{
				try
				{
					((Component)(object)val).Dispose();
				}
				catch
				{
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return (T)Convert.ChangeType(value, typeof(T));
	}

	public static DataTable ExecuteDataTableQuery(string connectionString, string text)
	{
		return ExecuteDataTableQuery(connectionString, text, null);
	}

	public static DataTable ExecuteDataTableQuery(string connectionString, string text, IDictionary<string, object> args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		DataTable dataTable = null;
		int num = 0;
		SqlConnection val = new SqlConnection(connectionString);
		try
		{
			SqlCommand val2 = new SqlCommand(text, val);
			try
			{
				((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
				if (args != null && args.Count > 0)
				{
					foreach (string key in args.Keys)
					{
						val2.get_Parameters().AddWithValue(key, (args[key] == null) ? DBNull.Value : args[key]);
					}
				}
				((DbConnection)(object)val).Open();
				try
				{
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						dataTable = new DataTable();
						while (((DbDataReader)(object)val3).Read())
						{
							DataRow dataRow = dataTable.NewRow();
							for (int i = 0; i < ((DbDataReader)(object)val3).FieldCount; i++)
							{
								if (num == 0)
								{
									dataTable.Columns.Add(((DbDataReader)(object)val3).GetName(i));
								}
								dataRow[i] = ((DbDataReader)(object)val3)[i];
							}
							dataTable.Rows.Add(dataRow);
							num++;
						}
					}
					((DbDataReader)(object)val3).Close();
					return dataTable;
				}
				finally
				{
					try
					{
						((DbConnection)(object)val).Close();
						((Component)(object)val).Dispose();
						((Component)(object)val2).Dispose();
					}
					catch
					{
					}
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static DataRow ExecuteDataRowQuery(string connectionString, string text)
	{
		return ExecuteDataRowQuery(connectionString, text, null);
	}

	public static DataRow ExecuteDataRowQuery(string connectionString, string text, IDictionary<string, object> args)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		DataRow dataRow = null;
		SqlConnection val = new SqlConnection(connectionString);
		try
		{
			SqlCommand val2 = new SqlCommand(text, val);
			try
			{
				((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
				if (args != null && args.Count > 0)
				{
					foreach (string key in args.Keys)
					{
						val2.get_Parameters().AddWithValue(key, (args[key] == null) ? DBNull.Value : args[key]);
					}
				}
				((DbConnection)(object)val).Open();
				try
				{
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						((DbDataReader)(object)val3).Read();
						dataRow = new DataTable().NewRow();
						for (int i = 0; i < ((DbDataReader)(object)val3).FieldCount; i++)
						{
							dataRow.Table.Columns.Add(((DbDataReader)(object)val3).GetName(i));
							dataRow[i] = ((DbDataReader)(object)val3)[i];
						}
					}
					((DbDataReader)(object)val3).Close();
					return dataRow;
				}
				finally
				{
					try
					{
						((DbConnection)(object)val).Close();
						((Component)(object)val).Dispose();
						((Component)(object)val2).Dispose();
					}
					catch
					{
					}
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static DataRow ExecuteDataRowText(string connectionString, string text, IDictionary<string, object> args)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		DataRow dataRow = null;
		SqlConnection val = new SqlConnection(connectionString);
		try
		{
			SqlCommand val2 = new SqlCommand(text, val);
			try
			{
				((DbCommand)(object)val2).CommandType = CommandType.Text;
				if (args != null && args.Count > 0)
				{
					foreach (string key in args.Keys)
					{
						val2.get_Parameters().AddWithValue(key, args[key]);
					}
				}
				((DbConnection)(object)val).Open();
				try
				{
					SqlDataReader val3 = val2.ExecuteReader();
					if (((DbDataReader)(object)val3).HasRows)
					{
						((DbDataReader)(object)val3).Read();
						dataRow = new DataTable().NewRow();
						for (int i = 0; i < ((DbDataReader)(object)val3).FieldCount; i++)
						{
							dataRow.Table.Columns.Add(((DbDataReader)(object)val3).GetName(i));
							dataRow[i] = ((DbDataReader)(object)val3)[i];
						}
					}
					((DbDataReader)(object)val3).Close();
					return dataRow;
				}
				finally
				{
					try
					{
						((DbConnection)(object)val).Close();
						((Component)(object)val).Dispose();
						((Component)(object)val2).Dispose();
					}
					catch
					{
					}
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	public static XmlDocument ExecuteXmlQuery(string connectionString, string text)
	{
		return ExecuteXmlQuery(connectionString, text, null);
	}

	public static XmlDocument ExecuteXmlQuery(string connectionString, string text, IDictionary<string, object> args)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		XmlDocument xmlDocument = null;
		SqlConnection val = new SqlConnection(connectionString);
		try
		{
			SqlCommand val2 = new SqlCommand(text, val);
			try
			{
				((DbCommand)(object)val2).CommandType = CommandType.StoredProcedure;
				if (args != null && args.Count > 0)
				{
					foreach (string key in args.Keys)
					{
						val2.get_Parameters().AddWithValue(key, (args[key] == null) ? DBNull.Value : args[key]);
					}
				}
				((DbConnection)(object)val).Open();
				try
				{
					XmlReader xmlReader = val2.ExecuteXmlReader();
					xmlDocument = new XmlDocument();
					xmlDocument.Load(xmlReader);
					xmlReader.Close();
					return xmlDocument;
				}
				catch (Exception ex)
				{
					if (ex.InnerException!.GetType().Equals(typeof(SqlNullValueException)))
					{
						return null;
					}
					return xmlDocument;
				}
				finally
				{
					try
					{
						((DbConnection)(object)val).Close();
						((Component)(object)val).Dispose();
						((Component)(object)val2).Dispose();
					}
					catch
					{
					}
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private static object executeDataRowAsScalar(string connectionString, string text, IDictionary<string, object> args, string field)
	{
		DataRow dataRow = ExecuteDataRowQuery(connectionString, text, args);
		if (dataRow == null)
		{
			return null;
		}
		if (!dataRow.Table.Columns.Contains(field))
		{
			return null;
		}
		return dataRow[field];
	}

	private SqlDataAccess()
	{
	}
}
