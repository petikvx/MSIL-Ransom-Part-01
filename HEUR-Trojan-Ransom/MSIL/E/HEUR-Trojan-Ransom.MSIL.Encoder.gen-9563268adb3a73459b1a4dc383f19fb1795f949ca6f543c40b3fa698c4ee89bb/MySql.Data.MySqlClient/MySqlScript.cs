using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

public class MySqlScript
{
	public MySqlConnection Connection { get; set; }

	public string Query { get; set; }

	public string Delimiter { get; set; }

	public event MySqlStatementExecutedEventHandler StatementExecuted;

	public event MySqlScriptErrorEventHandler Error;

	public event EventHandler ScriptCompleted;

	public MySqlScript()
	{
		Delimiter = ";";
	}

	public MySqlScript(MySqlConnection connection)
		: this()
	{
		Connection = connection;
	}

	public MySqlScript(string query)
		: this()
	{
		Query = query;
	}

	public MySqlScript(MySqlConnection connection, string query)
		: this()
	{
		Connection = connection;
		Query = query;
	}

	public int Execute()
	{
		bool flag = false;
		if (Connection == null)
		{
			throw new InvalidOperationException(Resources.ConnectionNotSet);
		}
		if (string.IsNullOrEmpty(Query))
		{
			return 0;
		}
		if (Connection.State != ConnectionState.Open)
		{
			flag = true;
			Connection.Open();
		}
		bool allowUserVariables = Connection.Settings.AllowUserVariables;
		Connection.Settings.AllowUserVariables = true;
		try
		{
			string text = StringUtility.ToUpperInvariant(Connection.driver.Property("sql_mode"));
			bool ansiQuotes = text.IndexOf("ANSI_QUOTES") != -1;
			bool noBackslashEscapes = text.IndexOf("NO_BACKSLASH_ESCAPES") != -1;
			List<ScriptStatement> source = BreakIntoStatements(ansiQuotes, noBackslashEscapes);
			int num = 0;
			MySqlCommand mySqlCommand = new MySqlCommand(null, Connection);
			foreach (ScriptStatement item in source.Where((ScriptStatement statement) => !string.IsNullOrEmpty(statement.text)))
			{
				mySqlCommand.CommandText = item.text;
				try
				{
					mySqlCommand.ExecuteNonQuery();
					num++;
					OnQueryExecuted(item);
				}
				catch (Exception ex)
				{
					if (this.Error == null)
					{
						throw;
					}
					if (!OnScriptError(ex))
					{
						break;
					}
				}
			}
			OnScriptCompleted();
			return num;
		}
		finally
		{
			Connection.Settings.AllowUserVariables = allowUserVariables;
			if (flag)
			{
				Connection.Close();
			}
		}
	}

	private void OnQueryExecuted(ScriptStatement statement)
	{
		if (this.StatementExecuted != null)
		{
			MySqlScriptEventArgs e = new MySqlScriptEventArgs
			{
				Statement = statement
			};
			this.StatementExecuted(this, e);
		}
	}

	private void OnScriptCompleted()
	{
		this.ScriptCompleted?.Invoke(this, EventArgs.Empty);
	}

	private bool OnScriptError(Exception ex)
	{
		if (this.Error == null)
		{
			return false;
		}
		MySqlScriptErrorEventArgs mySqlScriptErrorEventArgs = new MySqlScriptErrorEventArgs(ex);
		this.Error(this, mySqlScriptErrorEventArgs);
		return mySqlScriptErrorEventArgs.Ignore;
	}

	private List<int> BreakScriptIntoLines()
	{
		List<int> list = new List<int>();
		StringReader stringReader = new StringReader(Query);
		string text = stringReader.ReadLine();
		int num = 0;
		while (text != null)
		{
			list.Add(num);
			num += text.Length;
			text = stringReader.ReadLine();
		}
		return list;
	}

	private static int FindLineNumber(int position, List<int> lineNumbers)
	{
		int i;
		for (i = 0; i < lineNumbers.Count && position < lineNumbers[i]; i++)
		{
		}
		return i;
	}

	private List<ScriptStatement> BreakIntoStatements(bool ansiQuotes, bool noBackslashEscapes)
	{
		string text = Delimiter;
		int num = 0;
		List<ScriptStatement> list = new List<ScriptStatement>();
		List<int> list2 = BreakScriptIntoLines();
		MySqlTokenizer mySqlTokenizer = new MySqlTokenizer(Query);
		mySqlTokenizer.AnsiQuotes = ansiQuotes;
		mySqlTokenizer.BackslashEscapes = !noBackslashEscapes;
		for (string text2 = mySqlTokenizer.NextToken(); text2 != null; text2 = mySqlTokenizer.NextToken())
		{
			if (!mySqlTokenizer.Quoted)
			{
				if (text2.ToLower(CultureInfo.InvariantCulture) == "delimiter")
				{
					mySqlTokenizer.NextToken();
					AdjustDelimiterEnd(mySqlTokenizer);
					text = Query.Substring(mySqlTokenizer.StartIndex, mySqlTokenizer.StopIndex - mySqlTokenizer.StartIndex).Trim();
					num = mySqlTokenizer.StopIndex;
				}
				else
				{
					if (text.StartsWith(text2, StringComparison.OrdinalIgnoreCase) && mySqlTokenizer.StartIndex + text.Length <= Query.Length && Query.Substring(mySqlTokenizer.StartIndex, text.Length) == text)
					{
						text2 = text;
						mySqlTokenizer.Position = mySqlTokenizer.StartIndex + text.Length;
						mySqlTokenizer.StopIndex = mySqlTokenizer.Position;
					}
					int num2 = text2.IndexOf(text, StringComparison.OrdinalIgnoreCase);
					if (num2 != -1)
					{
						int num3 = mySqlTokenizer.StopIndex - text2.Length + num2;
						if (mySqlTokenizer.StopIndex == Query.Length - 1)
						{
							num3++;
						}
						string text3 = Query.Substring(num, num3 - num);
						ScriptStatement item = default(ScriptStatement);
						item.text = text3.Trim();
						item.line = FindLineNumber(num, list2);
						item.position = num - list2[item.line];
						list.Add(item);
						num = num3 + text.Length;
					}
				}
			}
		}
		if (num < Query.Length - 1)
		{
			string text4 = Query.Substring(num).Trim();
			if (string.IsNullOrEmpty(text4))
			{
				return list;
			}
			ScriptStatement scriptStatement = default(ScriptStatement);
			scriptStatement.text = text4;
			scriptStatement.line = FindLineNumber(num, list2);
			ScriptStatement item2 = scriptStatement;
			item2.position = num - list2[item2.line];
			list.Add(item2);
		}
		return list;
	}

	private void AdjustDelimiterEnd(MySqlTokenizer tokenizer)
	{
		if (tokenizer.StopIndex < Query.Length)
		{
			int num = tokenizer.StopIndex;
			char c = Query[num];
			while (!char.IsWhiteSpace(c) && num < Query.Length - 1)
			{
				c = Query[++num];
			}
			tokenizer.StopIndex = num;
			tokenizer.Position = num;
		}
	}

	public Task<int> ExecuteAsync()
	{
		return ExecuteAsync(CancellationToken.None);
	}

	public Task<int> ExecuteAsync(CancellationToken cancellationToken)
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
				int result = Execute();
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
