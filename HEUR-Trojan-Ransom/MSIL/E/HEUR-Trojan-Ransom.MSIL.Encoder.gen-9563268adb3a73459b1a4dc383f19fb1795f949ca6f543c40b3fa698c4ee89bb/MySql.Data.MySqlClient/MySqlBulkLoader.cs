using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySql.Data.MySqlClient;

public class MySqlBulkLoader
{
	private const string defaultFieldTerminator = "\t";

	private const string defaultLineTerminator = "\n";

	private const char defaultEscapeCharacter = '\\';

	public MySqlConnection Connection { get; set; }

	public string FieldTerminator { get; set; }

	public string LineTerminator { get; set; }

	public string TableName { get; set; }

	public string CharacterSet { get; set; }

	public string FileName { get; set; }

	public int Timeout { get; set; }

	public bool Local { get; set; }

	public int NumberOfLinesToSkip { get; set; }

	public string LinePrefix { get; set; }

	public char FieldQuotationCharacter { get; set; }

	public bool FieldQuotationOptional { get; set; }

	public char EscapeCharacter { get; set; }

	public MySqlBulkLoaderConflictOption ConflictOption { get; set; }

	public MySqlBulkLoaderPriority Priority { get; set; }

	public List<string> Columns { get; }

	public List<string> Expressions { get; }

	public MySqlBulkLoader(MySqlConnection connection)
	{
		Connection = connection;
		Local = false;
		FieldTerminator = "\t";
		LineTerminator = "\n";
		FieldQuotationCharacter = '\0';
		ConflictOption = MySqlBulkLoaderConflictOption.None;
		Columns = new List<string>();
		Expressions = new List<string>();
	}

	public int Load()
	{
		bool flag = false;
		if (Connection == null)
		{
			throw new InvalidOperationException(Resources.ConnectionNotSet);
		}
		if (Connection.State != ConnectionState.Open)
		{
			flag = true;
			Connection.Open();
		}
		try
		{
			return new MySqlCommand(BuildSqlCommand(), Connection)
			{
				CommandTimeout = Timeout
			}.ExecuteNonQuery();
		}
		finally
		{
			if (flag)
			{
				Connection.Close();
			}
		}
	}

	public Task<int> LoadAsync()
	{
		return LoadAsync(CancellationToken.None);
	}

	public Task<int> LoadAsync(CancellationToken cancellationToken)
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
				int result = Load();
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	private string BuildSqlCommand()
	{
		StringBuilder stringBuilder = new StringBuilder("LOAD DATA ");
		if (Priority == MySqlBulkLoaderPriority.Low)
		{
			stringBuilder.Append("LOW_PRIORITY ");
		}
		else if (Priority == MySqlBulkLoaderPriority.Concurrent)
		{
			stringBuilder.Append("CONCURRENT ");
		}
		if (Local)
		{
			stringBuilder.Append("LOCAL ");
		}
		stringBuilder.Append("INFILE ");
		if (Path.DirectorySeparatorChar == '\\')
		{
			stringBuilder.AppendFormat("'{0}' ", FileName.Replace("\\", "\\\\"));
		}
		else
		{
			stringBuilder.AppendFormat("'{0}' ", FileName);
		}
		if (ConflictOption == MySqlBulkLoaderConflictOption.Ignore)
		{
			stringBuilder.Append("IGNORE ");
		}
		else if (ConflictOption == MySqlBulkLoaderConflictOption.Replace)
		{
			stringBuilder.Append("REPLACE ");
		}
		stringBuilder.AppendFormat("INTO TABLE {0} ", TableName);
		if (CharacterSet != null)
		{
			stringBuilder.AppendFormat("CHARACTER SET {0} ", CharacterSet);
		}
		StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
		if (FieldTerminator != "\t")
		{
			stringBuilder2.AppendFormat("TERMINATED BY '{0}' ", FieldTerminator);
		}
		if (FieldQuotationCharacter != 0)
		{
			stringBuilder2.AppendFormat("{0} ENCLOSED BY '{1}' ", FieldQuotationOptional ? "OPTIONALLY" : "", FieldQuotationCharacter);
		}
		if (EscapeCharacter != '\\' && EscapeCharacter != 0)
		{
			stringBuilder2.AppendFormat("ESCAPED BY '{0}' ", EscapeCharacter);
		}
		if (stringBuilder2.Length > 0)
		{
			stringBuilder.AppendFormat("FIELDS {0}", stringBuilder2.ToString());
		}
		stringBuilder2 = new StringBuilder(string.Empty);
		if (!string.IsNullOrEmpty(LinePrefix))
		{
			stringBuilder2.AppendFormat("STARTING BY '{0}' ", LinePrefix);
		}
		if (LineTerminator != "\n")
		{
			stringBuilder2.AppendFormat("TERMINATED BY '{0}' ", LineTerminator);
		}
		if (stringBuilder2.Length > 0)
		{
			stringBuilder.AppendFormat("LINES {0}", stringBuilder2.ToString());
		}
		if (NumberOfLinesToSkip > 0)
		{
			stringBuilder.AppendFormat("IGNORE {0} LINES ", NumberOfLinesToSkip);
		}
		if (Columns.Count > 0)
		{
			stringBuilder.Append("(");
			stringBuilder.Append(Columns[0]);
			for (int i = 1; i < Columns.Count; i++)
			{
				stringBuilder.AppendFormat(",{0}", Columns[i]);
			}
			stringBuilder.Append(") ");
		}
		if (Expressions.Count > 0)
		{
			stringBuilder.Append("SET ");
			stringBuilder.Append(Expressions[0]);
			for (int j = 1; j < Expressions.Count; j++)
			{
				stringBuilder.AppendFormat(",{0}", Expressions[j]);
			}
		}
		return stringBuilder.ToString();
	}
}
