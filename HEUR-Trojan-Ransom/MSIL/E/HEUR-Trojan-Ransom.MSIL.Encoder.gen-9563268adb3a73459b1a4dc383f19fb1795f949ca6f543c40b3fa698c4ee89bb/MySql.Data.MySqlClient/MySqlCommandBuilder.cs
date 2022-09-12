using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Text;
using MySql.Data.Common;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

[ToolboxItem(false)]
[DesignerCategory("Code")]
public sealed class MySqlCommandBuilder : DbCommandBuilder
{
	public new MySqlDataAdapter DataAdapter
	{
		get
		{
			return (MySqlDataAdapter)base.DataAdapter;
		}
		set
		{
			base.DataAdapter = value;
		}
	}

	public MySqlCommandBuilder()
	{
		QuotePrefix = (QuoteSuffix = "`");
	}

	public MySqlCommandBuilder(MySqlDataAdapter adapter)
		: this()
	{
		DataAdapter = adapter;
	}

	public static void DeriveParameters(MySqlCommand command)
	{
		if (command.CommandType != CommandType.StoredProcedure)
		{
			throw new InvalidOperationException(Resources.CanNotDeriveParametersForTextCommands);
		}
		string text = command.CommandText;
		if (text.IndexOf(".") == -1)
		{
			text = command.Connection.Database + "." + text;
		}
		try
		{
			ProcedureCacheEntry procedure = command.Connection.ProcedureCache.GetProcedure(command.Connection, text, null);
			command.Parameters.Clear();
			foreach (MySqlSchemaRow row in procedure.parameters.Rows)
			{
				MySqlParameter mySqlParameter = new MySqlParameter();
				mySqlParameter.ParameterName = string.Format("@{0}", row["PARAMETER_NAME"]);
				if (row["ORDINAL_POSITION"].Equals(0) && mySqlParameter.ParameterName == "@")
				{
					mySqlParameter.ParameterName = "@RETURN_VALUE";
				}
				mySqlParameter.Direction = GetDirection(row);
				bool unsigned = StoredProcedure.GetFlags(row["DTD_IDENTIFIER"].ToString()).IndexOf("UNSIGNED") != -1;
				bool realAsFloat = procedure.procedure.Rows[0]["SQL_MODE"].ToString()!.IndexOf("REAL_AS_FLOAT") != -1;
				mySqlParameter.MySqlDbType = MetaData.NameToType(row["DATA_TYPE"].ToString(), unsigned, realAsFloat, command.Connection);
				if (row["CHARACTER_MAXIMUM_LENGTH"] != null)
				{
					mySqlParameter.Size = (int)row["CHARACTER_MAXIMUM_LENGTH"];
				}
				if (row["NUMERIC_PRECISION"] != null)
				{
					mySqlParameter.Precision = Convert.ToByte(row["NUMERIC_PRECISION"]);
				}
				if (row["NUMERIC_SCALE"] != null)
				{
					mySqlParameter.Scale = Convert.ToByte(row["NUMERIC_SCALE"]);
				}
				if (mySqlParameter.MySqlDbType == MySqlDbType.Set || mySqlParameter.MySqlDbType == MySqlDbType.Enum)
				{
					mySqlParameter.PossibleValues = GetPossibleValues(row);
				}
				command.Parameters.Add(mySqlParameter);
			}
		}
		catch (InvalidOperationException ex)
		{
			throw new MySqlException(Resources.UnableToDeriveParameters, ex);
		}
	}

	private static List<string> GetPossibleValues(MySqlSchemaRow row)
	{
		string[] array = new string[2] { "ENUM", "SET" };
		string text = row["DTD_IDENTIFIER"].ToString()!.Trim();
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
		MySqlTokenizer mySqlTokenizer = new MySqlTokenizer(text);
		string text2 = mySqlTokenizer.NextToken();
		int num = mySqlTokenizer.StartIndex;
		while (true)
		{
			if (text2 == null || text2 == ",")
			{
				int num2 = text.Length - 1;
				if (text2 == ",")
				{
					num2 = mySqlTokenizer.StartIndex;
				}
				string item = text.Substring(num, num2 - num).Trim('\'', '"').Trim();
				list.Add(item);
				num = mySqlTokenizer.StopIndex;
			}
			if (text2 == null)
			{
				break;
			}
			text2 = mySqlTokenizer.NextToken();
		}
		return list;
	}

	private static ParameterDirection GetDirection(MySqlSchemaRow row)
	{
		string text = row["PARAMETER_MODE"].ToString();
		if (Convert.ToInt32(row["ORDINAL_POSITION"]) == 0)
		{
			return ParameterDirection.ReturnValue;
		}
		if (text == "IN")
		{
			return ParameterDirection.Input;
		}
		if (text == "OUT")
		{
			return ParameterDirection.Output;
		}
		return ParameterDirection.InputOutput;
	}

	public new MySqlCommand GetDeleteCommand()
	{
		return (MySqlCommand)base.GetDeleteCommand();
	}

	public new MySqlCommand GetUpdateCommand()
	{
		return (MySqlCommand)base.GetUpdateCommand();
	}

	public new MySqlCommand GetInsertCommand()
	{
		return (MySqlCommand)GetInsertCommand(useColumnsForParameterNames: false);
	}

	public override string QuoteIdentifier(string unquotedIdentifier)
	{
		if (unquotedIdentifier == null)
		{
			throw new ArgumentNullException("unquotedIdentifier");
		}
		if (unquotedIdentifier.StartsWith(QuotePrefix) && unquotedIdentifier.EndsWith(QuoteSuffix))
		{
			return unquotedIdentifier;
		}
		unquotedIdentifier = unquotedIdentifier.Replace(QuotePrefix, QuotePrefix + QuotePrefix);
		return $"{QuotePrefix}{unquotedIdentifier}{QuoteSuffix}";
	}

	public override string UnquoteIdentifier(string quotedIdentifier)
	{
		if (quotedIdentifier == null)
		{
			throw new ArgumentNullException("quotedIdentifier");
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

	protected override DataTable GetSchemaTable(DbCommand sourceCommand)
	{
		DataTable schemaTable = base.GetSchemaTable(sourceCommand);
		foreach (DataRow row in schemaTable.Rows)
		{
			if (row["BaseSchemaName"].Equals(sourceCommand.Connection!.Database))
			{
				row["BaseSchemaName"] = null;
			}
		}
		return schemaTable;
	}

	protected override string GetParameterName(string parameterName)
	{
		StringBuilder stringBuilder = new StringBuilder(parameterName);
		stringBuilder.Replace(" ", "");
		stringBuilder.Replace("/", "_per_");
		stringBuilder.Replace("-", "_");
		stringBuilder.Replace(")", "_cb_");
		stringBuilder.Replace("(", "_ob_");
		stringBuilder.Replace("%", "_pct_");
		stringBuilder.Replace("<", "_lt_");
		stringBuilder.Replace(">", "_gt_");
		stringBuilder.Replace(".", "_pt_");
		return $"@{stringBuilder.ToString()}";
	}

	protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause)
	{
		((MySqlParameter)parameter).MySqlDbType = (MySqlDbType)row["ProviderType"];
	}

	protected override string GetParameterName(int parameterOrdinal)
	{
		return $"@p{parameterOrdinal.ToString(CultureInfo.InvariantCulture)}";
	}

	protected override string GetParameterPlaceholder(int parameterOrdinal)
	{
		return $"@p{parameterOrdinal.ToString(CultureInfo.InvariantCulture)}";
	}

	protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
	{
		MySqlDataAdapter mySqlDataAdapter = adapter as MySqlDataAdapter;
		if (adapter != base.DataAdapter)
		{
			mySqlDataAdapter.RowUpdating += RowUpdating;
		}
		else
		{
			mySqlDataAdapter.RowUpdating -= RowUpdating;
		}
	}

	private void RowUpdating(object sender, MySqlRowUpdatingEventArgs e)
	{
		RowUpdatingHandler(e);
	}
}
