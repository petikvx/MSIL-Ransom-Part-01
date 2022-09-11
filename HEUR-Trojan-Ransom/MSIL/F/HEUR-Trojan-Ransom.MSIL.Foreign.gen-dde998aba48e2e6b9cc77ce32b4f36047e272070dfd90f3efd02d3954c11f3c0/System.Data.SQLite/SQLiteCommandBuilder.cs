using System.ComponentModel;
using System.Data.Common;
using System.Globalization;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteCommandBuilder : DbCommandBuilder
{
	private bool disposed;

	[NonSerialized]
	internal static GetString _0010;

	public new SQLiteDataAdapter DataAdapter
	{
		get
		{
			CheckDisposed();
			return (SQLiteDataAdapter)base.DataAdapter;
		}
		set
		{
			CheckDisposed();
			base.DataAdapter = value;
		}
	}

	[Browsable(false)]
	public override CatalogLocation CatalogLocation
	{
		get
		{
			CheckDisposed();
			return base.CatalogLocation;
		}
		set
		{
			CheckDisposed();
			base.CatalogLocation = value;
		}
	}

	[Browsable(false)]
	public override string CatalogSeparator
	{
		get
		{
			CheckDisposed();
			return base.CatalogSeparator;
		}
		set
		{
			CheckDisposed();
			base.CatalogSeparator = value;
		}
	}

	[DefaultValue("[")]
	[Browsable(false)]
	public override string QuotePrefix
	{
		get
		{
			CheckDisposed();
			return base.QuotePrefix;
		}
		set
		{
			CheckDisposed();
			base.QuotePrefix = value;
		}
	}

	[Browsable(false)]
	public override string QuoteSuffix
	{
		get
		{
			CheckDisposed();
			return base.QuoteSuffix;
		}
		set
		{
			CheckDisposed();
			base.QuoteSuffix = value;
		}
	}

	[Browsable(false)]
	public override string SchemaSeparator
	{
		get
		{
			CheckDisposed();
			return base.SchemaSeparator;
		}
		set
		{
			CheckDisposed();
			base.SchemaSeparator = value;
		}
	}

	public SQLiteCommandBuilder()
		: this(null)
	{
	}

	public SQLiteCommandBuilder(SQLiteDataAdapter adp)
	{
		QuotePrefix = _0010(107362564);
		QuoteSuffix = _0010(107362559);
		DataAdapter = adp;
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteCommandBuilder).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			_ = disposed;
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	protected override void ApplyParameterInfo(DbParameter parameter, DataRow row, StatementType statementType, bool whereClause)
	{
		SQLiteParameter sQLiteParameter = (SQLiteParameter)parameter;
		sQLiteParameter.DbType = (DbType)row[SchemaTableColumn.ProviderType];
	}

	protected override string GetParameterName(string parameterName)
	{
		return HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0010(107362554), parameterName);
	}

	protected override string GetParameterName(int parameterOrdinal)
	{
		return HelperMethods.StringFormat(CultureInfo.InvariantCulture, _0010(107362577), parameterOrdinal);
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
		CheckDisposed();
		return (SQLiteCommand)base.GetDeleteCommand();
	}

	public new SQLiteCommand GetDeleteCommand(bool useColumnsForParameterNames)
	{
		CheckDisposed();
		return (SQLiteCommand)base.GetDeleteCommand(useColumnsForParameterNames);
	}

	public new SQLiteCommand GetUpdateCommand()
	{
		CheckDisposed();
		return (SQLiteCommand)base.GetUpdateCommand();
	}

	public new SQLiteCommand GetUpdateCommand(bool useColumnsForParameterNames)
	{
		CheckDisposed();
		return (SQLiteCommand)base.GetUpdateCommand(useColumnsForParameterNames);
	}

	public new SQLiteCommand GetInsertCommand()
	{
		CheckDisposed();
		return (SQLiteCommand)base.GetInsertCommand();
	}

	public new SQLiteCommand GetInsertCommand(bool useColumnsForParameterNames)
	{
		CheckDisposed();
		return (SQLiteCommand)base.GetInsertCommand(useColumnsForParameterNames);
	}

	public override string QuoteIdentifier(string unquotedIdentifier)
	{
		CheckDisposed();
		if (string.IsNullOrEmpty(QuotePrefix) || string.IsNullOrEmpty(QuoteSuffix) || string.IsNullOrEmpty(unquotedIdentifier))
		{
			return unquotedIdentifier;
		}
		return QuotePrefix + unquotedIdentifier.Replace(QuoteSuffix, QuoteSuffix + QuoteSuffix) + QuoteSuffix;
	}

	public override string UnquoteIdentifier(string quotedIdentifier)
	{
		CheckDisposed();
		if (string.IsNullOrEmpty(QuotePrefix) || string.IsNullOrEmpty(QuoteSuffix) || string.IsNullOrEmpty(quotedIdentifier))
		{
			return quotedIdentifier;
		}
		if (!quotedIdentifier.StartsWith(QuotePrefix, StringComparison.OrdinalIgnoreCase) || !quotedIdentifier.EndsWith(QuoteSuffix, StringComparison.OrdinalIgnoreCase))
		{
			return quotedIdentifier;
		}
		return quotedIdentifier.Substring(QuotePrefix.Length, quotedIdentifier.Length - (QuotePrefix.Length + QuoteSuffix.Length)).Replace(QuoteSuffix + QuoteSuffix, QuoteSuffix);
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

	static SQLiteCommandBuilder()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteCommandBuilder));
	}
}
