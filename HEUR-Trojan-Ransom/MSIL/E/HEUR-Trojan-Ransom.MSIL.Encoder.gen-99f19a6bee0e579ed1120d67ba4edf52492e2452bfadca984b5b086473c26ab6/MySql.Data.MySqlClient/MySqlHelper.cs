using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySql.Data.MySqlClient;

public sealed class MySqlHelper
{
	private enum CharClass : byte
	{
		None,
		Quote,
		Backslash
	}

	private static string stringOfBackslashChars = "\\¥Š₩∖﹨＼";

	private static string stringOfQuoteChars = "\"'`\u00b4ʹʺʻʼˈˊˋ\u02d9\u0300\u0301‘’‚′‵❛❜＇";

	private static CharClass[] charClassArray = MakeCharClassArray();

	public static Task<DataRow> ExecuteDataRowAsync(string connectionString, string commandText, params MySqlParameter[] parms)
	{
		return ExecuteDataRowAsync(connectionString, commandText, CancellationToken.None, parms);
	}

	public static Task<DataRow> ExecuteDataRowAsync(string connectionString, string commandText, CancellationToken cancellationToken, params MySqlParameter[] parms)
	{
		TaskCompletionSource<DataRow> taskCompletionSource = new TaskCompletionSource<DataRow>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataRow result = ExecuteDataRow(connectionString, commandText, parms);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static DataRow ExecuteDataRow(string connectionString, string commandText, params MySqlParameter[] parms)
	{
		DataSet dataSet = ExecuteDataset(connectionString, commandText, parms);
		if (dataSet == null)
		{
			return null;
		}
		if (dataSet.Tables.Count == 0)
		{
			return null;
		}
		if (dataSet.Tables[0].Rows.Count == 0)
		{
			return null;
		}
		return dataSet.Tables[0].Rows[0];
	}

	public static DataSet ExecuteDataset(string connectionString, string commandText)
	{
		return ExecuteDataset(connectionString, commandText, (MySqlParameter[])null);
	}

	public static DataSet ExecuteDataset(string connectionString, string commandText, params MySqlParameter[] commandParameters)
	{
		using MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
		mySqlConnection.Open();
		return ExecuteDataset(mySqlConnection, commandText, commandParameters);
	}

	public static DataSet ExecuteDataset(MySqlConnection connection, string commandText)
	{
		return ExecuteDataset(connection, commandText, (MySqlParameter[])null);
	}

	public static DataSet ExecuteDataset(MySqlConnection connection, string commandText, params MySqlParameter[] commandParameters)
	{
		MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = connection;
		mySqlCommand.CommandText = commandText;
		mySqlCommand.CommandType = CommandType.Text;
		if (commandParameters != null)
		{
			foreach (MySqlParameter value in commandParameters)
			{
				mySqlCommand.Parameters.Add(value);
			}
		}
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);
		DataSet dataSet = new DataSet();
		mySqlDataAdapter.Fill(dataSet);
		mySqlCommand.Parameters.Clear();
		return dataSet;
	}

	public static void UpdateDataSet(string connectionString, string commandText, DataSet ds, string tablename)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
		mySqlConnection.Open();
		MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(commandText, mySqlConnection);
		new MySqlCommandBuilder(mySqlDataAdapter).ToString();
		mySqlDataAdapter.Update(ds, tablename);
		mySqlConnection.Close();
	}

	public static Task<DataSet> ExecuteDatasetAsync(string connectionString, string commandText)
	{
		return ExecuteDatasetAsync(connectionString, commandText, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<DataSet> ExecuteDatasetAsync(string connectionString, string commandText, CancellationToken cancellationToken)
	{
		return ExecuteDatasetAsync(connectionString, commandText, cancellationToken, (MySqlParameter[])null);
	}

	public static Task<DataSet> ExecuteDatasetAsync(string connectionString, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteDatasetAsync(connectionString, commandText, CancellationToken.None, commandParameters);
	}

	public static Task<DataSet> ExecuteDatasetAsync(string connectionString, string commandText, CancellationToken cancellationToken, params MySqlParameter[] commandParameters)
	{
		TaskCompletionSource<DataSet> taskCompletionSource = new TaskCompletionSource<DataSet>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataSet result = ExecuteDataset(connectionString, commandText, commandParameters);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<DataSet> ExecuteDatasetAsync(MySqlConnection connection, string commandText)
	{
		return ExecuteDatasetAsync(connection, commandText, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<DataSet> ExecuteDatasetAsync(MySqlConnection connection, string commandText, CancellationToken cancellationToken)
	{
		return ExecuteDatasetAsync(connection, commandText, cancellationToken, (MySqlParameter[])null);
	}

	public static Task<DataSet> ExecuteDatasetAsync(MySqlConnection connection, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteDatasetAsync(connection, commandText, CancellationToken.None, commandParameters);
	}

	public static Task<DataSet> ExecuteDatasetAsync(MySqlConnection connection, string commandText, CancellationToken cancellationToken, params MySqlParameter[] commandParameters)
	{
		TaskCompletionSource<DataSet> taskCompletionSource = new TaskCompletionSource<DataSet>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				DataSet result = ExecuteDataset(connection, commandText, commandParameters);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task UpdateDataSetAsync(string connectionString, string commandText, DataSet ds, string tablename)
	{
		return UpdateDataSetAsync(connectionString, commandText, ds, tablename, CancellationToken.None);
	}

	public static Task UpdateDataSetAsync(string connectionString, string commandText, DataSet ds, string tablename, CancellationToken cancellationToken)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				UpdateDataSet(connectionString, commandText, ds, tablename);
				taskCompletionSource.SetResult(result: true);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	private MySqlHelper()
	{
	}

	public static int ExecuteNonQuery(MySqlConnection connection, string commandText, params MySqlParameter[] commandParameters)
	{
		MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = connection;
		mySqlCommand.CommandText = commandText;
		mySqlCommand.CommandType = CommandType.Text;
		if (commandParameters != null)
		{
			foreach (MySqlParameter value in commandParameters)
			{
				mySqlCommand.Parameters.Add(value);
			}
		}
		int result = mySqlCommand.ExecuteNonQuery();
		mySqlCommand.Parameters.Clear();
		return result;
	}

	public static int ExecuteNonQuery(string connectionString, string commandText, params MySqlParameter[] parms)
	{
		using MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
		mySqlConnection.Open();
		return ExecuteNonQuery(mySqlConnection, commandText, parms);
	}

	private static MySqlDataReader ExecuteReader(MySqlConnection connection, MySqlTransaction transaction, string commandText, MySqlParameter[] commandParameters, bool externalConn)
	{
		MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = connection;
		mySqlCommand.Transaction = transaction;
		mySqlCommand.CommandText = commandText;
		mySqlCommand.CommandType = CommandType.Text;
		if (commandParameters != null)
		{
			foreach (MySqlParameter value in commandParameters)
			{
				mySqlCommand.Parameters.Add(value);
			}
		}
		MySqlDataReader result = ((!externalConn) ? mySqlCommand.ExecuteReader(CommandBehavior.CloseConnection) : mySqlCommand.ExecuteReader());
		mySqlCommand.Parameters.Clear();
		return result;
	}

	public static MySqlDataReader ExecuteReader(string connectionString, string commandText)
	{
		return ExecuteReader(connectionString, commandText, (MySqlParameter[])null);
	}

	public static MySqlDataReader ExecuteReader(MySqlConnection connection, string commandText)
	{
		return ExecuteReader(connection, null, commandText, null, externalConn: true);
	}

	public static MySqlDataReader ExecuteReader(string connectionString, string commandText, params MySqlParameter[] commandParameters)
	{
		MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
		mySqlConnection.Open();
		return ExecuteReader(mySqlConnection, null, commandText, commandParameters, externalConn: false);
	}

	public static MySqlDataReader ExecuteReader(MySqlConnection connection, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteReader(connection, null, commandText, commandParameters, externalConn: true);
	}

	public static object ExecuteScalar(string connectionString, string commandText)
	{
		return ExecuteScalar(connectionString, commandText, (MySqlParameter[])null);
	}

	public static object ExecuteScalar(string connectionString, string commandText, params MySqlParameter[] commandParameters)
	{
		using MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
		mySqlConnection.Open();
		return ExecuteScalar(mySqlConnection, commandText, commandParameters);
	}

	public static object ExecuteScalar(MySqlConnection connection, string commandText)
	{
		return ExecuteScalar(connection, commandText, (MySqlParameter[])null);
	}

	public static object ExecuteScalar(MySqlConnection connection, string commandText, params MySqlParameter[] commandParameters)
	{
		MySqlCommand mySqlCommand = new MySqlCommand();
		mySqlCommand.Connection = connection;
		mySqlCommand.CommandText = commandText;
		mySqlCommand.CommandType = CommandType.Text;
		if (commandParameters != null)
		{
			foreach (MySqlParameter value in commandParameters)
			{
				mySqlCommand.Parameters.Add(value);
			}
		}
		object result = mySqlCommand.ExecuteScalar();
		mySqlCommand.Parameters.Clear();
		return result;
	}

	private static CharClass[] MakeCharClassArray()
	{
		CharClass[] array = new CharClass[65536];
		string text = stringOfBackslashChars;
		foreach (char c in text)
		{
			array[(uint)c] = CharClass.Backslash;
		}
		text = stringOfQuoteChars;
		foreach (char c2 in text)
		{
			array[(uint)c2] = CharClass.Quote;
		}
		return array;
	}

	private static bool NeedsQuoting(string s)
	{
		return s.Any((char c) => charClassArray[(uint)c] != CharClass.None);
	}

	public static string EscapeString(string value)
	{
		if (!NeedsQuoting(value))
		{
			return value;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in value)
		{
			if (charClassArray[(uint)c] != 0)
			{
				stringBuilder.Append("\\");
			}
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}

	public static string DoubleQuoteString(string value)
	{
		if (!NeedsQuoting(value))
		{
			return value;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in value)
		{
			switch (charClassArray[(uint)c])
			{
			case CharClass.Quote:
				stringBuilder.Append(c);
				break;
			case CharClass.Backslash:
				stringBuilder.Append("\\");
				break;
			}
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}

	public static Task<int> ExecuteNonQueryAsync(MySqlConnection connection, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteNonQueryAsync(connection, commandText, CancellationToken.None, commandParameters);
	}

	public static Task<int> ExecuteNonQueryAsync(MySqlConnection connection, string commandText, CancellationToken cancellationToken, params MySqlParameter[] commandParameters)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = ExecuteNonQuery(connection, commandText, commandParameters);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<int> ExecuteNonQueryAsync(string connectionString, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteNonQueryAsync(connectionString, commandText, CancellationToken.None, commandParameters);
	}

	public static Task<int> ExecuteNonQueryAsync(string connectionString, string commandText, CancellationToken cancellationToken, params MySqlParameter[] commandParameters)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = ExecuteNonQuery(connectionString, commandText, commandParameters);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	private static Task<MySqlDataReader> ExecuteReaderAsync(MySqlConnection connection, MySqlTransaction transaction, string commandText, MySqlParameter[] commandParameters, bool ExternalConn)
	{
		return ExecuteReaderAsync(connection, transaction, commandText, commandParameters, ExternalConn, CancellationToken.None);
	}

	private static Task<MySqlDataReader> ExecuteReaderAsync(MySqlConnection connection, MySqlTransaction transaction, string commandText, MySqlParameter[] commandParameters, bool ExternalConn, CancellationToken cancellationToken)
	{
		TaskCompletionSource<MySqlDataReader> taskCompletionSource = new TaskCompletionSource<MySqlDataReader>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				MySqlDataReader result = ExecuteReader(connection, transaction, commandText, commandParameters, ExternalConn);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<MySqlDataReader> ExecuteReaderAsync(string connectionString, string commandText)
	{
		return ExecuteReaderAsync(connectionString, commandText, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<MySqlDataReader> ExecuteReaderAsync(string connectionString, string commandText, CancellationToken cancellationToken)
	{
		return ExecuteReaderAsync(connectionString, commandText, cancellationToken, (MySqlParameter[])null);
	}

	public static Task<MySqlDataReader> ExecuteReaderAsync(MySqlConnection connection, string commandText)
	{
		return ExecuteReaderAsync(connection, null, commandText, null, ExternalConn: true, CancellationToken.None);
	}

	public static Task<MySqlDataReader> ExecuteReaderAsync(MySqlConnection connection, string commandText, CancellationToken cancellationToken)
	{
		return ExecuteReaderAsync(connection, null, commandText, null, ExternalConn: true, cancellationToken);
	}

	public static Task<MySqlDataReader> ExecuteReaderAsync(string connectionString, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteReaderAsync(connectionString, commandText, CancellationToken.None, commandParameters);
	}

	public static Task<MySqlDataReader> ExecuteReaderAsync(string connectionString, string commandText, CancellationToken cancellationToken, params MySqlParameter[] commandParameters)
	{
		TaskCompletionSource<MySqlDataReader> taskCompletionSource = new TaskCompletionSource<MySqlDataReader>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				MySqlDataReader result = ExecuteReader(connectionString, commandText, commandParameters);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<MySqlDataReader> ExecuteReaderAsync(MySqlConnection connection, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteReaderAsync(connection, null, commandText, commandParameters, ExternalConn: true, CancellationToken.None);
	}

	public static Task<MySqlDataReader> ExecuteReaderAsync(MySqlConnection connection, string commandText, CancellationToken cancellationToken, params MySqlParameter[] commandParameters)
	{
		return ExecuteReaderAsync(connection, null, commandText, commandParameters, ExternalConn: true, cancellationToken);
	}

	public static Task<object> ExecuteScalarAsync(string connectionString, string commandText)
	{
		return ExecuteScalarAsync(connectionString, commandText, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<object> ExecuteScalarAsync(string connectionString, string commandText, CancellationToken cancellationToken)
	{
		return ExecuteScalarAsync(connectionString, commandText, cancellationToken, (MySqlParameter[])null);
	}

	public static Task<object> ExecuteScalarAsync(string connectionString, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteScalarAsync(connectionString, commandText, CancellationToken.None, commandParameters);
	}

	public static Task<object> ExecuteScalarAsync(string connectionString, string commandText, CancellationToken cancellationToken, params MySqlParameter[] commandParameters)
	{
		TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				object result = ExecuteScalar(connectionString, commandText, commandParameters);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	public static Task<object> ExecuteScalarAsync(MySqlConnection connection, string commandText)
	{
		return ExecuteScalarAsync(connection, commandText, CancellationToken.None, (MySqlParameter[])null);
	}

	public static Task<object> ExecuteScalarAsync(MySqlConnection connection, string commandText, CancellationToken cancellationToken)
	{
		return ExecuteScalarAsync(connection, commandText, cancellationToken, (MySqlParameter[])null);
	}

	public static Task<object> ExecuteScalarAsync(MySqlConnection connection, string commandText, params MySqlParameter[] commandParameters)
	{
		return ExecuteScalarAsync(connection, commandText, CancellationToken.None, commandParameters);
	}

	public static Task<object> ExecuteScalarAsync(MySqlConnection connection, string commandText, CancellationToken cancellationToken, params MySqlParameter[] commandParameters)
	{
		TaskCompletionSource<object> taskCompletionSource = new TaskCompletionSource<object>();
		if (!(cancellationToken == CancellationToken.None) && cancellationToken.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				object result = ExecuteScalar(connection, commandText, commandParameters);
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}
}
