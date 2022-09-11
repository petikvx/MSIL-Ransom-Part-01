using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns21;
using ns7;

namespace ns18;

internal sealed class Class136
{
	[CompilerGenerated]
	private Class139 class139_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private string string_5;

	[CompilerGenerated]
	private char char_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private char char_1;

	[CompilerGenerated]
	private Enum34 enum34_0;

	[CompilerGenerated]
	private Enum33 enum33_0;

	[CompilerGenerated]
	private readonly List<string> list_0;

	[CompilerGenerated]
	private readonly List<string> list_1;

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

	public string FieldTerminator
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

	public string LineTerminator
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

	public string TableName
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public string CharacterSet
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string FileName
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	public int Timeout
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public bool Local
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public int NumberOfLinesToSkip
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public string LinePrefix
	{
		[CompilerGenerated]
		get
		{
			return string_5;
		}
		[CompilerGenerated]
		set
		{
			string_5 = value;
		}
	}

	public char FieldQuotationCharacter
	{
		[CompilerGenerated]
		get
		{
			return char_0;
		}
		[CompilerGenerated]
		set
		{
			char_0 = value;
		}
	}

	public bool FieldQuotationOptional
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public char EscapeCharacter
	{
		[CompilerGenerated]
		get
		{
			return char_1;
		}
		[CompilerGenerated]
		set
		{
			char_1 = value;
		}
	}

	public Enum34 ConflictOption
	{
		[CompilerGenerated]
		get
		{
			return enum34_0;
		}
		[CompilerGenerated]
		set
		{
			enum34_0 = value;
		}
	}

	public Enum33 Priority
	{
		[CompilerGenerated]
		get
		{
			return enum33_0;
		}
		[CompilerGenerated]
		set
		{
			enum33_0 = value;
		}
	}

	public List<string> Columns
	{
		[CompilerGenerated]
		get
		{
			return list_0;
		}
	}

	public List<string> Expressions
	{
		[CompilerGenerated]
		get
		{
			return list_1;
		}
	}

	public Class136(Class139 class139_1)
	{
		Connection = class139_1;
		Local = true;
		FieldTerminator = getString_0(107356291);
		LineTerminator = getString_0(107357340);
		FieldQuotationCharacter = '\0';
		ConflictOption = Enum34.const_0;
		list_0 = new List<string>();
		list_1 = new List<string>();
	}

	public int method_0()
	{
		bool flag = false;
		if (Connection == null)
		{
			throw new InvalidOperationException(Class121.ConnectionNotSet);
		}
		if (Connection.State != ConnectionState.Open)
		{
			flag = true;
			Connection.Open();
		}
		try
		{
			return new MySqlCommand(method_3(), Connection)
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

	public Task<int> method_1()
	{
		return method_2(CancellationToken.None);
	}

	public Task<int> method_2(CancellationToken cancellationToken_0)
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

	private string method_3()
	{
		StringBuilder stringBuilder = new StringBuilder(getString_0(107356318));
		if (Priority == Enum33.const_1)
		{
			stringBuilder.Append(getString_0(107356269));
		}
		else if (Priority == Enum33.const_2)
		{
			stringBuilder.Append(getString_0(107356280));
		}
		if (Local)
		{
			stringBuilder.Append(getString_0(107356231));
		}
		stringBuilder.Append(getString_0(107356254));
		if (Path.DirectorySeparatorChar == '\\')
		{
			stringBuilder.AppendFormat(getString_0(107356241), FileName.Replace(getString_0(107396376), getString_0(107356200)));
		}
		else
		{
			stringBuilder.AppendFormat(getString_0(107356241), FileName);
		}
		if (ConflictOption == Enum34.const_2)
		{
			stringBuilder.Append(getString_0(107356195));
		}
		else if (ConflictOption == Enum34.const_1)
		{
			stringBuilder.Append(getString_0(107356214));
		}
		stringBuilder.AppendFormat(getString_0(107356169), TableName);
		if (CharacterSet != null)
		{
			stringBuilder.AppendFormat(getString_0(107356180), CharacterSet);
		}
		StringBuilder stringBuilder2 = new StringBuilder(string.Empty);
		if (FieldTerminator != getString_0(107356291))
		{
			stringBuilder2.AppendFormat(getString_0(107356155), FieldTerminator);
		}
		if (FieldQuotationCharacter != 0)
		{
			stringBuilder2.AppendFormat(getString_0(107356126), FieldQuotationOptional ? getString_0(107356093) : getString_0(107398052), FieldQuotationCharacter);
		}
		if (EscapeCharacter != '\\' && EscapeCharacter != 0)
		{
			stringBuilder2.AppendFormat(getString_0(107356556), EscapeCharacter);
		}
		if (stringBuilder2.Length > 0)
		{
			stringBuilder.AppendFormat(getString_0(107356563), stringBuilder2.ToString());
		}
		stringBuilder2 = new StringBuilder(string.Empty);
		if (!string.IsNullOrEmpty(LinePrefix))
		{
			stringBuilder2.AppendFormat(getString_0(107356514), LinePrefix);
		}
		if (LineTerminator != getString_0(107357340))
		{
			stringBuilder2.AppendFormat(getString_0(107356155), LineTerminator);
		}
		if (stringBuilder2.Length > 0)
		{
			stringBuilder.AppendFormat(getString_0(107356489), stringBuilder2.ToString());
		}
		if (NumberOfLinesToSkip > 0)
		{
			stringBuilder.AppendFormat(getString_0(107356508), NumberOfLinesToSkip);
		}
		if (Columns.Count > 0)
		{
			stringBuilder.Append(getString_0(107409607));
			stringBuilder.Append(Columns[0]);
			for (int i = 1; i < Columns.Count; i++)
			{
				stringBuilder.AppendFormat(getString_0(107356451), Columns[i]);
			}
			stringBuilder.Append(getString_0(107356474));
		}
		if (Expressions.Count > 0)
		{
			stringBuilder.Append(getString_0(107356469));
			stringBuilder.Append(Expressions[0]);
			for (int j = 1; j < Expressions.Count; j++)
			{
				stringBuilder.AppendFormat(getString_0(107356451), Expressions[j]);
			}
		}
		return stringBuilder.ToString();
	}

	static Class136()
	{
		Strings.CreateGetStringDelegate(typeof(Class136));
	}
}
