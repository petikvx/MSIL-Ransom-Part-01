using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns11;
using ns13;
using ns20;
using ns21;
using ns26;
using ns4;
using ns5;

namespace MySql.Data.MySqlClient;

public sealed class MySqlScript
{
	[CompilerGenerated]
	private Delegate6 delegate6_0;

	[CompilerGenerated]
	private Delegate7 delegate7_0;

	[CompilerGenerated]
	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private Class139 class139_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[NonSerialized]
	internal static GetString getString_0;

	public Class139 Connection
	{
		[CompilerGenerated]
		get
		{
			return class139_0;
		}
		[CompilerGenerated]
		set
		{
			class139_0 = value;
		}
	}

	public string Query
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public string Delimiter
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public event Delegate6 StatementExecuted
	{
		[CompilerGenerated]
		add
		{
			Delegate6 @delegate = delegate6_0;
			Delegate6 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate6 value2 = (Delegate6)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate6_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate6 @delegate = delegate6_0;
			Delegate6 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate6 value2 = (Delegate6)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate6_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event Delegate7 Error
	{
		[CompilerGenerated]
		add
		{
			Delegate7 @delegate = delegate7_0;
			Delegate7 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate7 value2 = (Delegate7)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate7_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		[CompilerGenerated]
		remove
		{
			Delegate7 @delegate = delegate7_0;
			Delegate7 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate7 value2 = (Delegate7)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate7_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}

	public event EventHandler ScriptCompleted
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = eventHandler_0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public MySqlScript()
	{
		Delimiter = getString_0(107410085);
	}

	public MySqlScript(Class139 connection)
		: this()
	{
		Connection = connection;
	}

	public MySqlScript(string query)
		: this()
	{
		Query = query;
	}

	public MySqlScript(Class139 connection, string query)
		: this()
	{
		Connection = connection;
		Query = query;
	}

	public int method_0()
	{
		bool flag = false;
		if (Connection == null)
		{
			throw new InvalidOperationException(Class121.ConnectionNotSet);
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
			string text = Class135.smethod_0(Connection.class143_0.method_0(getString_0(107376411)));
			bool bool_ = text.IndexOf(getString_0(107355282)) != -1;
			bool bool_2 = text.IndexOf(getString_0(107355233)) != -1;
			List<ScriptStatement> source = method_5(bool_, bool_2);
			int num = 0;
			MySqlCommand mySqlCommand = new MySqlCommand(null, Connection);
			foreach (ScriptStatement item in source.Where((ScriptStatement scriptStatement_0) => !string.IsNullOrEmpty(scriptStatement_0.string_0)))
			{
				mySqlCommand.CommandText = item.string_0;
				try
				{
					mySqlCommand.ExecuteNonQuery();
					num++;
					method_1(item);
				}
				catch (Exception exception_)
				{
					if (delegate7_0 == null)
					{
						throw;
					}
					if (!method_3(exception_))
					{
						break;
					}
				}
			}
			method_2();
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

	private void method_1(ScriptStatement scriptStatement_0)
	{
		if (delegate6_0 != null)
		{
			EventArgs3 e = new EventArgs3
			{
				Statement = scriptStatement_0
			};
			delegate6_0(this, e);
		}
	}

	private void method_2()
	{
		eventHandler_0?.Invoke(this, EventArgs.Empty);
	}

	private bool method_3(Exception exception_0)
	{
		if (delegate7_0 == null)
		{
			return false;
		}
		EventArgs4 eventArgs = new EventArgs4(exception_0);
		delegate7_0(this, eventArgs);
		return eventArgs.Ignore;
	}

	private List<int> method_4()
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

	private static int smethod_0(int int_0, List<int> list_0)
	{
		int i;
		for (i = 0; i < list_0.Count && int_0 < list_0[i]; i++)
		{
		}
		return i;
	}

	private List<ScriptStatement> method_5(bool bool_0, bool bool_1)
	{
		string text = Delimiter;
		int num = 0;
		List<ScriptStatement> list = new List<ScriptStatement>();
		List<int> list2 = method_4();
		Class127 @class = new Class127(Query);
		@class.AnsiQuotes = bool_0;
		@class.BackslashEscapes = !bool_1;
		for (string text2 = @class.method_1(); text2 != null; text2 = @class.method_1())
		{
			if (!@class.Quoted)
			{
				if (text2.ToLower(CultureInfo.InvariantCulture) == getString_0(107376430))
				{
					@class.method_1();
					method_6(@class);
					text = Query.Substring(@class.StartIndex, @class.StopIndex - @class.StartIndex).Trim();
					num = @class.StopIndex;
				}
				else
				{
					if (text.StartsWith(text2, StringComparison.OrdinalIgnoreCase) && @class.StartIndex + text.Length <= Query.Length && Query.Substring(@class.StartIndex, text.Length) == text)
					{
						text2 = text;
						@class.Position = @class.StartIndex + text.Length;
						@class.StopIndex = @class.Position;
					}
					int num2 = text2.IndexOf(text, StringComparison.OrdinalIgnoreCase);
					if (num2 != -1)
					{
						int num3 = @class.StopIndex - text2.Length + num2;
						if (@class.StopIndex == Query.Length - 1)
						{
							num3++;
						}
						string text3 = Query.Substring(num, num3 - num);
						ScriptStatement item = default(ScriptStatement);
						item.string_0 = text3.Trim();
						item.int_0 = smethod_0(num, list2);
						item.int_1 = num - list2[item.int_0];
						list.Add(item);
						num = num3 + text.Length;
					}
				}
			}
		}
		if (num < Query.Length - 1)
		{
			string value = Query.Substring(num).Trim();
			if (string.IsNullOrEmpty(value))
			{
				return list;
			}
			ScriptStatement scriptStatement = default(ScriptStatement);
			scriptStatement.string_0 = value;
			scriptStatement.int_0 = smethod_0(num, list2);
			ScriptStatement item2 = scriptStatement;
			item2.int_1 = num - list2[item2.int_0];
			list.Add(item2);
		}
		return list;
	}

	private void method_6(Class127 class127_0)
	{
		if (class127_0.StopIndex < Query.Length)
		{
			int num = class127_0.StopIndex;
			char c = Query[num];
			while (!char.IsWhiteSpace(c) && num < Query.Length - 1)
			{
				c = Query[++num];
			}
			class127_0.StopIndex = num;
			class127_0.Position = num;
		}
	}

	public Task<int> method_7()
	{
		return method_8(CancellationToken.None);
	}

	public Task<int> method_8(CancellationToken cancellationToken_0)
	{
		TaskCompletionSource<int> taskCompletionSource = new TaskCompletionSource<int>();
		if (!(cancellationToken_0 == CancellationToken.None) && cancellationToken_0.IsCancellationRequested)
		{
			taskCompletionSource.SetCanceled();
		}
		else
		{
			try
			{
				int result = method_0();
				taskCompletionSource.SetResult(result);
			}
			catch (Exception exception)
			{
				taskCompletionSource.SetException(exception);
			}
		}
		return taskCompletionSource.Task;
	}

	static MySqlScript()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlScript));
	}
}
