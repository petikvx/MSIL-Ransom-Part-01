using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite;

public sealed class SQLiteCommandBuilder : DbCommandBuilder
{
	public new SQLiteDataAdapter DataAdapter
	{
		get
		{
			return (SQLiteDataAdapter)base.DataAdapter;
		}
		set
		{
			base.DataAdapter = value;
		}
	}

	[Browsable(false)]
	public override CatalogLocation CatalogLocation
	{
		get
		{
			return base.CatalogLocation;
		}
		set
		{
			base.CatalogLocation = value;
		}
	}

	[Browsable(false)]
	public override string CatalogSeparator
	{
		get
		{
			return base.CatalogSeparator;
		}
		set
		{
			base.CatalogSeparator = value;
		}
	}

	[DefaultValue("[")]
	[Browsable(false)]
	public override string QuotePrefix
	{
		get
		{
			return base.QuotePrefix;
		}
		set
		{
			base.QuotePrefix = value;
		}
	}

	[Browsable(false)]
	public override string QuoteSuffix
	{
		get
		{
			return base.QuoteSuffix;
		}
		set
		{
			base.QuoteSuffix = value;
		}
	}

	[Browsable(false)]
	public override string SchemaSeparator
	{
		get
		{
			return base.SchemaSeparator;
		}
		set
		{
			base.SchemaSeparator = value;
		}
	}

	public SQLiteCommandBuilder()
		: this(null)
	{
	}

	public SQLiteCommandBuilder(SQLiteDataAdapter adp)
	{
		QuotePrefix = "[";
		QuoteSuffix = "]";
		DataAdapter = adp;
	}

	protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause)
	{
		SQLiteParameter sQLiteParameter = (SQLiteParameter)parameter;
		sQLiteParameter.DbType = (DbType)row[SchemaTableColumn.ProviderType];
	}

	protected override string GetParameterName(string parameterName)
	{
		return string.Format(CultureInfo.InvariantCulture, "@{0}", new object[1] { parameterName });
	}

	protected override string GetParameterName(int parameterOrdinal)
	{
		return string.Format(CultureInfo.InvariantCulture, "@param{0}", new object[1] { parameterOrdinal });
	}

	protected override string GetParameterPlaceholder(int parameterOrdinal)
	{
		return GetParameterName(parameterOrdinal);
	}

	protected override void SetRowUpdatingHandler(DbDataAdapter adapter)
	{
		if (adapter == base.DataAdapter)
		{
			((SQLiteDataAdapter)adapter).RowUpdating -= RowUpdatingEventHandler;
		}
		else
		{
			((SQLiteDataAdapter)adapter).RowUpdating += RowUpdatingEventHandler;
		}
	}

	private void RowUpdatingEventHandler(object sender, RowUpdatingEventArgs e)
	{
		RowUpdatingHandler(e);
	}

	public new SQLiteCommand GetDeleteCommand()
	{
		return (SQLiteCommand)base.GetDeleteCommand();
	}

	public new SQLiteCommand GetDeleteCommand(bool useColumnsForParameterNames)
	{
		return (SQLiteCommand)base.GetDeleteCommand(useColumnsForParameterNames);
	}

	public new SQLiteCommand GetUpdateCommand()
	{
		return (SQLiteCommand)base.GetUpdateCommand();
	}

	public new SQLiteCommand GetUpdateCommand(bool useColumnsForParameterNames)
	{
		return (SQLiteCommand)base.GetUpdateCommand(useColumnsForParameterNames);
	}

	public new SQLiteCommand GetInsertCommand()
	{
		return (SQLiteCommand)base.GetInsertCommand();
	}

	public new SQLiteCommand GetInsertCommand(bool useColumnsForParameterNames)
	{
		return (SQLiteCommand)base.GetInsertCommand(useColumnsForParameterNames);
	}

	public override string QuoteIdentifier(string unquotedIdentifier)
	{
		if (!string.IsNullOrEmpty(QuotePrefix) && !string.IsNullOrEmpty(QuoteSuffix) && !string.IsNullOrEmpty(unquotedIdentifier))
		{
			return QuotePrefix + unquotedIdentifier.Replace(QuoteSuffix, QuoteSuffix + QuoteSuffix) + QuoteSuffix;
		}
		return unquotedIdentifier;
	}

	public override string UnquoteIdentifier(string quotedIdentifier)
	{
		if (!string.IsNullOrEmpty(QuotePrefix) && !string.IsNullOrEmpty(QuoteSuffix) && !string.IsNullOrEmpty(quotedIdentifier))
		{
			if (quotedIdentifier.StartsWith(QuotePrefix, StringComparison.OrdinalIgnoreCase) && quotedIdentifier.EndsWith(QuoteSuffix, StringComparison.OrdinalIgnoreCase))
			{
				return quotedIdentifier.Substring(QuotePrefix.Length, quotedIdentifier.Length - (QuotePrefix.Length + QuoteSuffix.Length)).Replace(QuoteSuffix + QuoteSuffix, QuoteSuffix);
			}
			return quotedIdentifier;
		}
		return quotedIdentifier;
	}

	protected override DataTable GetSchemaTable(DbCommand sourceCommand)
	{
		using IDataReader dataReader = sourceCommand.ExecuteReader(CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo);
		DataTable schemaTable = dataReader.GetSchemaTable();
		if (HasSchemaPrimaryKey(schemaTable))
		{
			ResetIsUniqueSchemaColumn(schemaTable);
		}
		return schemaTable;
	}

	private bool HasSchemaPrimaryKey(DataTable schema)
	{
		DataColumn column = schema.Columns[SchemaTableColumn.IsKey];
		foreach (DataRow row in schema.Rows)
		{
			if ((bool)row[column])
			{
				return true;
			}
		}
		return false;
	}

	private void ResetIsUniqueSchemaColumn(DataTable schema)
	{
		DataColumn column = schema.Columns[SchemaTableColumn.IsUnique];
		DataColumn column2 = schema.Columns[SchemaTableColumn.IsKey];
		foreach (DataRow row in schema.Rows)
		{
			if (!(bool)row[column2])
			{
				row[column] = false;
			}
		}
		schema.AcceptChanges();
	}
}
