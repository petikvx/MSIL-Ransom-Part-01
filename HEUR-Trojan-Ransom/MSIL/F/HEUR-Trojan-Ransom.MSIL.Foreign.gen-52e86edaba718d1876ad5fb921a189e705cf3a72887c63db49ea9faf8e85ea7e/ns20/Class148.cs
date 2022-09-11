using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns11;
using ns21;
using ns6;

namespace ns20;

[DesignerCategory("Code")]
[ToolboxItem(false)]
internal sealed class Class148 : DbCommandBuilder
{
	[NonSerialized]
	internal static GetString getString_0;

	public new Class149 DataAdapter
	{
		get
		{
			return (Class149)base.DataAdapter;
		}
		set
		{
			base.DataAdapter = value;
		}
	}

	public Class148()
	{
		QuotePrefix = (QuoteSuffix = getString_0(107410313));
	}

	public Class148(Class149 class149_0)
		: this()
	{
		DataAdapter = class149_0;
	}

	public static void smethod_0(MySqlCommand mySqlCommand_0)
	{
		if (mySqlCommand_0.CommandType != CommandType.StoredProcedure)
		{
			throw new InvalidOperationException(Class121.CanNotDeriveParametersForTextCommands);
		}
		string text = mySqlCommand_0.CommandText;
		if (text.IndexOf(getString_0(107397975)) == -1)
		{
			text = mySqlCommand_0.Connection.Database + getString_0(107397975) + text;
		}
		try
		{
			Class173 @class = mySqlCommand_0.Connection.ProcedureCache.method_0(mySqlCommand_0.Connection, text, null);
			mySqlCommand_0.Parameters.Clear();
			foreach (Class177 row in @class.class176_1.Rows)
			{
				MySqlParameter mySqlParameter = new MySqlParameter();
				mySqlParameter.ParameterName = string.Format(getString_0(107351991), row[getString_0(107352014)]);
				if (row[getString_0(107351961)].Equals(0) && mySqlParameter.ParameterName == getString_0(107409936))
				{
					mySqlParameter.ParameterName = getString_0(107351936);
				}
				mySqlParameter.Direction = smethod_2(row);
				bool bool_ = StoredProcedure.smethod_0(row[getString_0(107351947)].ToString()).IndexOf(getString_0(107351894)) != -1;
				bool bool_2 = @class.class176_0.Rows[0][getString_0(107351913)].ToString()!.IndexOf(getString_0(107351868)) != -1;
				mySqlParameter.MySqlDbType = Class123.smethod_3(row[getString_0(107351879)].ToString(), bool_, bool_2, mySqlCommand_0.Connection);
				if (row[getString_0(107351322)] != null)
				{
					mySqlParameter.Size = (int)row[getString_0(107351322)];
				}
				if (row[getString_0(107351289)] != null)
				{
					mySqlParameter.Precision = Convert.ToByte(row[getString_0(107351289)]);
				}
				if (row[getString_0(107351264)] != null)
				{
					mySqlParameter.Scale = Convert.ToByte(row[getString_0(107351264)]);
				}
				if (mySqlParameter.MySqlDbType == MySqlDbType.Set || mySqlParameter.MySqlDbType == MySqlDbType.Enum)
				{
					mySqlParameter.PossibleValues = smethod_1(row);
				}
				mySqlCommand_0.Parameters.Add(mySqlParameter);
			}
		}
		catch (InvalidOperationException ex)
		{
			throw new MySqlException(Class121.UnableToDeriveParameters, ex);
		}
	}

	private static List<string> smethod_1(Class177 class177_0)
	{
		string[] array = new string[2]
		{
			getString_0(107359523),
			getString_0(107360072)
		};
		string text = class177_0[getString_0(107351947)].ToString()!.Trim();
		int i;
		for (i = 0; i < 2 && !text.StartsWith(array[i], StringComparison.OrdinalIgnoreCase); i++)
		{
		}
		if (i == 2)
		{
			return null;
		}
		text = text.Substring(array[i].Length).Trim();
		text = text.Trim('(', ')').Trim();
		List<string> list = new List<string>();
		Class127 @class = new Class127(text);
		string text2 = @class.method_1();
		int num = @class.StartIndex;
		while (true)
		{
			if (text2 == null || text2 == getString_0(107405178))
			{
				int num2 = text.Length - 1;
				if (text2 == getString_0(107405178))
				{
					num2 = @class.StartIndex;
				}
				string item = text.Substring(num, num2 - num).Trim('\'', '"').Trim();
				list.Add(item);
				num = @class.StopIndex;
			}
			if (text2 == null)
			{
				break;
			}
			text2 = @class.method_1();
		}
		return list;
	}

	private static ParameterDirection smethod_2(Class177 class177_0)
	{
		string text = class177_0[getString_0(107351275)].ToString();
		if (Convert.ToInt32(class177_0[getString_0(107351961)]) == 0)
		{
			return ParameterDirection.ReturnValue;
		}
		if (text == getString_0(107357220))
		{
			return ParameterDirection.Input;
		}
		if (text == getString_0(107351222))
		{
			return ParameterDirection.Output;
		}
		return ParameterDirection.InputOutput;
	}

	public MySqlCommand method_0()
	{
		return (MySqlCommand)GetDeleteCommand();
	}

	public MySqlCommand method_1()
	{
		return (MySqlCommand)GetUpdateCommand();
	}

	public MySqlCommand method_2()
	{
		return (MySqlCommand)GetInsertCommand(useColumnsForParameterNames: false);
	}

	string DbCommandBuilder.QuoteIdentifier(string unquotedIdentifier)
	{
		if (unquotedIdentifier == null)
		{
			throw new ArgumentNullException(getString_0(107351249));
		}
		if (unquotedIdentifier.StartsWith(QuotePrefix) && unquotedIdentifier.EndsWith(QuoteSuffix))
		{
			return unquotedIdentifier;
		}
		unquotedIdentifier = unquotedIdentifier.Replace(QuotePrefix, QuotePrefix + QuotePrefix);
		return string.Format(getString_0(107351192), QuotePrefix, unquotedIdentifier, QuoteSuffix);
	}

	string DbCommandBuilder.UnquoteIdentifier(string quotedIdentifier)
	{
		if (quotedIdentifier == null)
		{
			throw new ArgumentNullException(getString_0(107351211));
		}
		if (quotedIdentifier.StartsWith(QuotePrefix) && quotedIdentifier.EndsWith(QuoteSuffix))
		{
			if (quotedIdentifier.StartsWith(QuotePrefix))
			{
				quotedIdentifier = quotedIdentifier.Substring(1);
			}
			if (quotedIdentifier.EndsWith(QuoteSuffix))
			{
				quotedIdentifier = quotedIdentifier.Substring(0, quotedIdentifier.Length - 1);
			}
			quotedIdentifier = quotedIdentifier.Replace(QuotePrefix + QuotePrefix, QuotePrefix);
			return quotedIdentifier;
		}
		return quotedIdentifier;
	}

	DataTable DbCommandBuilder.GetSchemaTable(DbCommand sourceCommand)
	{
		DataTable schemaTable = base.GetSchemaTable(sourceCommand);
		foreach (DataRow row in schemaTable.Rows)
		{
			if (row[getString_0(107353442)].Equals(sourceCommand.Connection!.Database))
			{
				row[getString_0(107353442)] = null;
			}
		}
		return schemaTable;
	}

	string DbCommandBuilder.GetParameterName(string parameterName)
	{
		StringBuilder stringBuilder = new StringBuilder(parameterName);
		stringBuilder.Replace(getString_0(107396478), getString_0(107398200));
		stringBuilder.Replace(getString_0(107409941), getString_0(107351186));
		stringBuilder.Replace(getString_0(107409646), getString_0(107409641));
		stringBuilder.Replace(getString_0(107409750), getString_0(107351177));
		stringBuilder.Replace(getString_0(107409755), getString_0(107351136));
		stringBuilder.Replace(getString_0(107398378), getString_0(107351127));
		stringBuilder.Replace(getString_0(107351150), getString_0(107351145));
		stringBuilder.Replace(getString_0(107398137), getString_0(107351104));
		stringBuilder.Replace(getString_0(107397975), getString_0(107351095));
		return string.Format(getString_0(107351991), stringBuilder.ToString());
	}

	void DbCommandBuilder.ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause)
	{
		((MySqlParameter)parameter).MySqlDbType = (MySqlDbType)row[getString_0(107353415)];
	}

	string DbCommandBuilder.GetParameterName(int parameterOrdinal)
	{
		return string.Format(getString_0(107351118), parameterOrdinal.ToString(CultureInfo.InvariantCulture));
	}

	string DbCommandBuilder.GetParameterPlaceholder(int parameterOrdinal)
	{
		return string.Format(getString_0(107351118), parameterOrdinal.ToString(CultureInfo.InvariantCulture));
	}

	void DbCommandBuilder.SetRowUpdatingHandler(DbDataAdapter adapter)
	{
		Class149 @class = adapter as Class149;
		if (adapter != base.DataAdapter)
		{
			@class.RowUpdating += method_3;
		}
		else
		{
			@class.RowUpdating -= method_3;
		}
	}

	private void method_3(object sender, EventArgs1 e)
	{
		RowUpdatingHandler(e);
	}

	static Class148()
	{
		Strings.CreateGetStringDelegate(typeof(Class148));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398378), getString_0(107398373)).Replace(getString_0(107398336), getString_0(107398331)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398326)))
		{
			throw new SecurityException(getString_0(107398301));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
