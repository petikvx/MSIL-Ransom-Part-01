using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using MySql.Data.Common;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

internal class SchemaProvider
{
	protected MySqlConnection connection;

	public static string MetaCollection = "MetaDataCollections";

	public SchemaProvider(MySqlConnection connectionToUse)
	{
		connection = connectionToUse;
	}

	public virtual MySqlSchemaCollection GetSchema(string collection, string[] restrictions)
	{
		if (connection.State != ConnectionState.Open)
		{
			throw new MySqlException("GetSchema can only be called on an open connection.");
		}
		collection = StringUtility.ToUpperInvariant(collection);
		return GetSchemaInternal(collection, restrictions) ?? throw new ArgumentException("Invalid collection name");
	}

	public virtual MySqlSchemaCollection GetDatabases(string[] restrictions)
	{
		Regex regex = null;
		int num = int.Parse(connection.driver.Property("lower_case_table_names"));
		string text = "SHOW DATABASES";
		if (num == 0 && restrictions != null && restrictions.Length >= 1)
		{
			text = text + " LIKE '" + restrictions[0] + "'";
		}
		MySqlSchemaCollection mySqlSchemaCollection = QueryCollection("Databases", text);
		if (num != 0 && restrictions != null && restrictions.Length >= 1 && restrictions[0] != null)
		{
			regex = new Regex(restrictions[0], RegexOptions.IgnoreCase);
		}
		MySqlSchemaCollection mySqlSchemaCollection2 = new MySqlSchemaCollection("Databases");
		mySqlSchemaCollection2.AddColumn("CATALOG_NAME", typeof(string));
		mySqlSchemaCollection2.AddColumn("SCHEMA_NAME", typeof(string));
		foreach (MySqlSchemaRow row in mySqlSchemaCollection.Rows)
		{
			if (regex == null || regex.Match(row[0].ToString()).Success)
			{
				mySqlSchemaCollection2.AddRow()[1] = row[0];
			}
		}
		return mySqlSchemaCollection2;
	}

	public virtual MySqlSchemaCollection GetTables(string[] restrictions)
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("Tables");
		mySqlSchemaCollection.AddColumn("TABLE_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_TYPE", typeof(string));
		mySqlSchemaCollection.AddColumn("ENGINE", typeof(string));
		mySqlSchemaCollection.AddColumn("VERSION", typeof(ulong));
		mySqlSchemaCollection.AddColumn("ROW_FORMAT", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_ROWS", typeof(ulong));
		mySqlSchemaCollection.AddColumn("AVG_ROW_LENGTH", typeof(ulong));
		mySqlSchemaCollection.AddColumn("DATA_LENGTH", typeof(ulong));
		mySqlSchemaCollection.AddColumn("MAX_DATA_LENGTH", typeof(ulong));
		mySqlSchemaCollection.AddColumn("INDEX_LENGTH", typeof(ulong));
		mySqlSchemaCollection.AddColumn("DATA_FREE", typeof(ulong));
		mySqlSchemaCollection.AddColumn("AUTO_INCREMENT", typeof(ulong));
		mySqlSchemaCollection.AddColumn("CREATE_TIME", typeof(DateTime));
		mySqlSchemaCollection.AddColumn("UPDATE_TIME", typeof(DateTime));
		mySqlSchemaCollection.AddColumn("CHECK_TIME", typeof(DateTime));
		mySqlSchemaCollection.AddColumn("TABLE_COLLATION", typeof(string));
		mySqlSchemaCollection.AddColumn("CHECKSUM", typeof(ulong));
		mySqlSchemaCollection.AddColumn("CREATE_OPTIONS", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_COMMENT", typeof(string));
		string[] array = new string[4];
		if (restrictions != null && restrictions.Length >= 2)
		{
			array[0] = restrictions[1];
		}
		MySqlSchemaCollection databases = GetDatabases(array);
		if (restrictions != null)
		{
			Array.Copy(restrictions, array, Math.Min(array.Length, restrictions.Length));
		}
		foreach (MySqlSchemaRow row in databases.Rows)
		{
			array[1] = row["SCHEMA_NAME"].ToString();
			FindTables(mySqlSchemaCollection, array);
		}
		return mySqlSchemaCollection;
	}

	protected void QuoteDefaultValues(MySqlSchemaCollection schemaCollection)
	{
		if (schemaCollection == null || !schemaCollection.ContainsColumn("COLUMN_DEFAULT"))
		{
			return;
		}
		foreach (MySqlSchemaRow row in schemaCollection.Rows)
		{
			object arg = row["COLUMN_DEFAULT"];
			if (MetaData.IsTextType(row["DATA_TYPE"].ToString()))
			{
				row["COLUMN_DEFAULT"] = $"{arg}";
			}
		}
	}

	public virtual MySqlSchemaCollection GetColumns(string[] restrictions)
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("Columns");
		mySqlSchemaCollection.AddColumn("TABLE_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("COLUMN_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("ORDINAL_POSITION", typeof(ulong));
		mySqlSchemaCollection.AddColumn("COLUMN_DEFAULT", typeof(string));
		mySqlSchemaCollection.AddColumn("IS_NULLABLE", typeof(string));
		mySqlSchemaCollection.AddColumn("DATA_TYPE", typeof(string));
		mySqlSchemaCollection.AddColumn("CHARACTER_MAXIMUM_LENGTH", typeof(ulong));
		mySqlSchemaCollection.AddColumn("CHARACTER_OCTET_LENGTH", typeof(ulong));
		mySqlSchemaCollection.AddColumn("NUMERIC_PRECISION", typeof(ulong));
		mySqlSchemaCollection.AddColumn("NUMERIC_SCALE", typeof(ulong));
		mySqlSchemaCollection.AddColumn("CHARACTER_SET_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("COLLATION_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("COLUMN_TYPE", typeof(string));
		mySqlSchemaCollection.AddColumn("COLUMN_KEY", typeof(string));
		mySqlSchemaCollection.AddColumn("EXTRA", typeof(string));
		mySqlSchemaCollection.AddColumn("PRIVILEGES", typeof(string));
		mySqlSchemaCollection.AddColumn("COLUMN_COMMENT", typeof(string));
		mySqlSchemaCollection.AddColumn("GENERATION_EXPRESSION", typeof(string));
		string columnRestriction = null;
		if (restrictions != null && restrictions.Length == 4)
		{
			columnRestriction = restrictions[3];
			restrictions[3] = null;
		}
		foreach (MySqlSchemaRow row in GetTables(restrictions).Rows)
		{
			LoadTableColumns(mySqlSchemaCollection, row["TABLE_SCHEMA"].ToString(), row["TABLE_NAME"].ToString(), columnRestriction);
		}
		QuoteDefaultValues(mySqlSchemaCollection);
		return mySqlSchemaCollection;
	}

	private void LoadTableColumns(MySqlSchemaCollection schemaCollection, string schema, string tableName, string columnRestriction)
	{
		MySqlCommand mySqlCommand = new MySqlCommand($"SHOW FULL COLUMNS FROM `{schema}`.`{tableName}`", connection);
		int num = 1;
		using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
		while (mySqlDataReader.Read())
		{
			string @string = mySqlDataReader.GetString(0);
			if (columnRestriction == null || !(@string != columnRestriction))
			{
				MySqlSchemaRow mySqlSchemaRow = schemaCollection.AddRow();
				mySqlSchemaRow["TABLE_CATALOG"] = DBNull.Value;
				mySqlSchemaRow["TABLE_SCHEMA"] = schema;
				mySqlSchemaRow["TABLE_NAME"] = tableName;
				mySqlSchemaRow["COLUMN_NAME"] = @string;
				mySqlSchemaRow["ORDINAL_POSITION"] = num++;
				mySqlSchemaRow["COLUMN_DEFAULT"] = mySqlDataReader.GetValue(5);
				mySqlSchemaRow["IS_NULLABLE"] = mySqlDataReader.GetString(3);
				mySqlSchemaRow["DATA_TYPE"] = mySqlDataReader.GetString(1);
				mySqlSchemaRow["CHARACTER_MAXIMUM_LENGTH"] = DBNull.Value;
				mySqlSchemaRow["CHARACTER_OCTET_LENGTH"] = DBNull.Value;
				mySqlSchemaRow["NUMERIC_PRECISION"] = DBNull.Value;
				mySqlSchemaRow["NUMERIC_SCALE"] = DBNull.Value;
				mySqlSchemaRow["CHARACTER_SET_NAME"] = mySqlDataReader.GetValue(2);
				mySqlSchemaRow["COLLATION_NAME"] = mySqlSchemaRow["CHARACTER_SET_NAME"];
				mySqlSchemaRow["COLUMN_TYPE"] = mySqlDataReader.GetString(1);
				mySqlSchemaRow["COLUMN_KEY"] = mySqlDataReader.GetString(4);
				mySqlSchemaRow["EXTRA"] = mySqlDataReader.GetString(6);
				mySqlSchemaRow["PRIVILEGES"] = mySqlDataReader.GetString(7);
				mySqlSchemaRow["COLUMN_COMMENT"] = mySqlDataReader.GetString(8);
				mySqlSchemaRow["GENERATION_EXPRESSION"] = (mySqlDataReader.GetString(6).Contains("VIRTUAL") ? mySqlDataReader.GetString(9) : string.Empty);
				ParseColumnRow(mySqlSchemaRow);
			}
		}
	}

	private static void ParseColumnRow(MySqlSchemaRow row)
	{
		string text = row["CHARACTER_SET_NAME"].ToString();
		int num = text.IndexOf('_');
		if (num != -1)
		{
			row["CHARACTER_SET_NAME"] = text.Substring(0, num);
		}
		string text2 = row["DATA_TYPE"].ToString();
		num = text2.IndexOf('(');
		if (num == -1)
		{
			return;
		}
		row["DATA_TYPE"] = text2.Substring(0, num);
		int num2 = text2.IndexOf(')', num);
		string text3 = text2.Substring(num + 1, num2 - (num + 1));
		switch (row["DATA_TYPE"].ToString()!.ToLower())
		{
		case "real":
		case "decimal":
		{
			string[] array = text3.Split(new char[1] { ',' });
			row["NUMERIC_PRECISION"] = array[0];
			if (array.Length == 2)
			{
				row["NUMERIC_SCALE"] = array[1];
			}
			break;
		}
		case "char":
		case "varchar":
			row["CHARACTER_MAXIMUM_LENGTH"] = text3;
			break;
		}
	}

	public virtual MySqlSchemaCollection GetIndexes(string[] restrictions)
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("Indexes");
		mySqlSchemaCollection.AddColumn("INDEX_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("INDEX_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("INDEX_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("UNIQUE", typeof(bool));
		mySqlSchemaCollection.AddColumn("PRIMARY", typeof(bool));
		mySqlSchemaCollection.AddColumn("TYPE", typeof(string));
		mySqlSchemaCollection.AddColumn("COMMENT", typeof(string));
		string[] array = new string[Math.Max((restrictions != null) ? restrictions.Length : 4, 4)];
		restrictions?.CopyTo(array, 0);
		array[3] = "BASE TABLE";
		foreach (MySqlSchemaRow row in GetTables(array).Rows)
		{
			string sql = string.Format("SHOW INDEX FROM `{0}`.`{1}`", MySqlHelper.DoubleQuoteString((string)row["TABLE_SCHEMA"]), MySqlHelper.DoubleQuoteString((string)row["TABLE_NAME"]));
			foreach (MySqlSchemaRow row2 in QueryCollection("indexes", sql).Rows)
			{
				if (1L == (connection.driver.Version.isAtLeast(8, 0, 1) ? ((uint)row2["SEQ_IN_INDEX"]) : ((long)row2["SEQ_IN_INDEX"])) && (restrictions == null || restrictions.Length != 4 || restrictions[3] == null || row2["KEY_NAME"].Equals(restrictions[3])))
				{
					MySqlSchemaRow mySqlSchemaRow = mySqlSchemaCollection.AddRow();
					mySqlSchemaRow["INDEX_CATALOG"] = null;
					mySqlSchemaRow["INDEX_SCHEMA"] = row["TABLE_SCHEMA"];
					mySqlSchemaRow["INDEX_NAME"] = row2["KEY_NAME"];
					mySqlSchemaRow["TABLE_NAME"] = row2["TABLE"];
					mySqlSchemaRow["UNIQUE"] = (connection.driver.Version.isAtLeast(8, 0, 1) ? (Convert.ToInt64(row2["NON_UNIQUE"]) == 0L) : ((long)row2["NON_UNIQUE"] == 0L));
					mySqlSchemaRow["PRIMARY"] = row2["KEY_NAME"].Equals("PRIMARY");
					mySqlSchemaRow["TYPE"] = row2["INDEX_TYPE"];
					mySqlSchemaRow["COMMENT"] = row2["COMMENT"];
				}
			}
		}
		return mySqlSchemaCollection;
	}

	public virtual MySqlSchemaCollection GetIndexColumns(string[] restrictions)
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("IndexColumns");
		mySqlSchemaCollection.AddColumn("INDEX_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("INDEX_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("INDEX_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("COLUMN_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("ORDINAL_POSITION", typeof(int));
		mySqlSchemaCollection.AddColumn("SORT_ORDER", typeof(string));
		string[] array = new string[Math.Max((restrictions == null) ? 4 : restrictions.Length, 4)];
		restrictions?.CopyTo(array, 0);
		array[3] = "BASE TABLE";
		foreach (MySqlSchemaRow row in GetTables(array).Rows)
		{
			using MySqlDataReader mySqlDataReader = new MySqlCommand(string.Format("SHOW INDEX FROM `{0}`.`{1}`", row["TABLE_SCHEMA"], row["TABLE_NAME"]), connection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				string @string = GetString(mySqlDataReader, mySqlDataReader.GetOrdinal("KEY_NAME"));
				string string2 = GetString(mySqlDataReader, mySqlDataReader.GetOrdinal("COLUMN_NAME"));
				if (restrictions == null || ((restrictions.Length < 4 || restrictions[3] == null || !(@string != restrictions[3])) && (restrictions.Length < 5 || restrictions[4] == null || !(string2 != restrictions[4]))))
				{
					MySqlSchemaRow mySqlSchemaRow = mySqlSchemaCollection.AddRow();
					mySqlSchemaRow["INDEX_CATALOG"] = null;
					mySqlSchemaRow["INDEX_SCHEMA"] = row["TABLE_SCHEMA"];
					mySqlSchemaRow["INDEX_NAME"] = @string;
					mySqlSchemaRow["TABLE_NAME"] = GetString(mySqlDataReader, mySqlDataReader.GetOrdinal("TABLE"));
					mySqlSchemaRow["COLUMN_NAME"] = string2;
					mySqlSchemaRow["ORDINAL_POSITION"] = mySqlDataReader.GetValue(mySqlDataReader.GetOrdinal("SEQ_IN_INDEX"));
					mySqlSchemaRow["SORT_ORDER"] = mySqlDataReader.GetString("COLLATION");
				}
			}
		}
		return mySqlSchemaCollection;
	}

	public virtual MySqlSchemaCollection GetForeignKeys(string[] restrictions)
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("Foreign Keys");
		mySqlSchemaCollection.AddColumn("CONSTRAINT_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("CONSTRAINT_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("CONSTRAINT_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("MATCH_OPTION", typeof(string));
		mySqlSchemaCollection.AddColumn("UPDATE_RULE", typeof(string));
		mySqlSchemaCollection.AddColumn("DELETE_RULE", typeof(string));
		mySqlSchemaCollection.AddColumn("REFERENCED_TABLE_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("REFERENCED_TABLE_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("REFERENCED_TABLE_NAME", typeof(string));
		string filterName = null;
		if (restrictions != null && restrictions.Length >= 4)
		{
			filterName = restrictions[3];
			restrictions[3] = null;
		}
		foreach (MySqlSchemaRow row in GetTables(restrictions).Rows)
		{
			GetForeignKeysOnTable(mySqlSchemaCollection, row, filterName, includeColumns: false);
		}
		return mySqlSchemaCollection;
	}

	public virtual MySqlSchemaCollection GetForeignKeyColumns(string[] restrictions)
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("Foreign Keys");
		mySqlSchemaCollection.AddColumn("CONSTRAINT_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("CONSTRAINT_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("CONSTRAINT_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("TABLE_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("COLUMN_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("ORDINAL_POSITION", typeof(int));
		mySqlSchemaCollection.AddColumn("REFERENCED_TABLE_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("REFERENCED_TABLE_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("REFERENCED_TABLE_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("REFERENCED_COLUMN_NAME", typeof(string));
		string filterName = null;
		if (restrictions != null && restrictions.Length >= 4)
		{
			filterName = restrictions[3];
			restrictions[3] = null;
		}
		foreach (MySqlSchemaRow row in GetTables(restrictions).Rows)
		{
			GetForeignKeysOnTable(mySqlSchemaCollection, row, filterName, includeColumns: true);
		}
		return mySqlSchemaCollection;
	}

	private string GetSqlMode()
	{
		return new MySqlCommand("SELECT @@SQL_MODE", connection).ExecuteScalar().ToString();
	}

	private void GetForeignKeysOnTable(MySqlSchemaCollection fkTable, MySqlSchemaRow tableToParse, string filterName, bool includeColumns)
	{
		string sqlMode = GetSqlMode();
		if (filterName != null)
		{
			filterName = StringUtility.ToLowerInvariant(filterName);
		}
		string cmdText = string.Format("SHOW CREATE TABLE `{0}`.`{1}`", tableToParse["TABLE_SCHEMA"], tableToParse["TABLE_NAME"]);
		string input = null;
		using (MySqlDataReader mySqlDataReader = new MySqlCommand(cmdText, connection).ExecuteReader())
		{
			mySqlDataReader.Read();
			input = StringUtility.ToLowerInvariant(mySqlDataReader.GetString(1));
		}
		MySqlTokenizer mySqlTokenizer = new MySqlTokenizer(input);
		mySqlTokenizer.AnsiQuotes = sqlMode.IndexOf("ANSI_QUOTES") != -1;
		mySqlTokenizer.BackslashEscapes = sqlMode.IndexOf("NO_BACKSLASH_ESCAPES") != -1;
		while (true)
		{
			string text = mySqlTokenizer.NextToken();
			while (text != null && (text != "constraint" || mySqlTokenizer.Quoted))
			{
				text = mySqlTokenizer.NextToken();
			}
			if (text != null)
			{
				ParseConstraint(fkTable, tableToParse, mySqlTokenizer, includeColumns);
				continue;
			}
			break;
		}
	}

	private static void ParseConstraint(MySqlSchemaCollection fkTable, MySqlSchemaRow table, MySqlTokenizer tokenizer, bool includeColumns)
	{
		string text = tokenizer.NextToken();
		MySqlSchemaRow mySqlSchemaRow = fkTable.AddRow();
		string text2 = tokenizer.NextToken();
		if (!(text2 != "foreign") && !tokenizer.Quoted)
		{
			tokenizer.NextToken();
			tokenizer.NextToken();
			mySqlSchemaRow["CONSTRAINT_CATALOG"] = table["TABLE_CATALOG"];
			mySqlSchemaRow["CONSTRAINT_SCHEMA"] = table["TABLE_SCHEMA"];
			mySqlSchemaRow["TABLE_CATALOG"] = table["TABLE_CATALOG"];
			mySqlSchemaRow["TABLE_SCHEMA"] = table["TABLE_SCHEMA"];
			mySqlSchemaRow["TABLE_NAME"] = table["TABLE_NAME"];
			mySqlSchemaRow["REFERENCED_TABLE_CATALOG"] = null;
			mySqlSchemaRow["CONSTRAINT_NAME"] = text.Trim('\'', '`');
			List<string> srcColumns = (includeColumns ? ParseColumns(tokenizer) : null);
			while (text2 != "references" || tokenizer.Quoted)
			{
				text2 = tokenizer.NextToken();
			}
			string text3 = tokenizer.NextToken();
			string text4 = tokenizer.NextToken();
			if (text4.StartsWith(".", StringComparison.Ordinal))
			{
				mySqlSchemaRow["REFERENCED_TABLE_SCHEMA"] = text3;
				mySqlSchemaRow["REFERENCED_TABLE_NAME"] = text4.Substring(1).Trim('\'', '`');
				tokenizer.NextToken();
			}
			else
			{
				mySqlSchemaRow["REFERENCED_TABLE_SCHEMA"] = table["TABLE_SCHEMA"];
				mySqlSchemaRow["REFERENCED_TABLE_NAME"] = text3.Substring(1).Trim('\'', '`');
			}
			List<string> targetColumns = (includeColumns ? ParseColumns(tokenizer) : null);
			if (includeColumns)
			{
				ProcessColumns(fkTable, mySqlSchemaRow, srcColumns, targetColumns);
			}
			else
			{
				fkTable.Rows.Add(mySqlSchemaRow);
			}
		}
	}

	private static List<string> ParseColumns(MySqlTokenizer tokenizer)
	{
		List<string> list = new List<string>();
		string text = tokenizer.NextToken();
		while (text != ")")
		{
			if (text != ",")
			{
				list.Add(text);
			}
			text = tokenizer.NextToken();
		}
		return list;
	}

	private static void ProcessColumns(MySqlSchemaCollection fkTable, MySqlSchemaRow row, List<string> srcColumns, List<string> targetColumns)
	{
		for (int i = 0; i < srcColumns.Count; i++)
		{
			MySqlSchemaRow mySqlSchemaRow = fkTable.AddRow();
			row.CopyRow(mySqlSchemaRow);
			mySqlSchemaRow["COLUMN_NAME"] = srcColumns[i];
			mySqlSchemaRow["ORDINAL_POSITION"] = i;
			mySqlSchemaRow["REFERENCED_COLUMN_NAME"] = targetColumns[i];
			fkTable.Rows.Add(mySqlSchemaRow);
		}
	}

	public virtual MySqlSchemaCollection GetUsers(string[] restrictions)
	{
		StringBuilder stringBuilder = new StringBuilder("SELECT Host, User FROM mysql.user");
		if (restrictions != null && restrictions.Length != 0)
		{
			stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " WHERE User LIKE '{0}'", new object[1] { restrictions[0] });
		}
		MySqlSchemaCollection mySqlSchemaCollection = QueryCollection("Users", stringBuilder.ToString());
		mySqlSchemaCollection.Columns[0].Name = "HOST";
		mySqlSchemaCollection.Columns[1].Name = "USERNAME";
		return mySqlSchemaCollection;
	}

	public virtual MySqlSchemaCollection GetProcedures(string[] restrictions)
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("Procedures");
		mySqlSchemaCollection.AddColumn("SPECIFIC_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("ROUTINE_CATALOG", typeof(string));
		mySqlSchemaCollection.AddColumn("ROUTINE_SCHEMA", typeof(string));
		mySqlSchemaCollection.AddColumn("ROUTINE_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("ROUTINE_TYPE", typeof(string));
		mySqlSchemaCollection.AddColumn("DTD_IDENTIFIER", typeof(string));
		mySqlSchemaCollection.AddColumn("ROUTINE_BODY", typeof(string));
		mySqlSchemaCollection.AddColumn("ROUTINE_DEFINITION", typeof(string));
		mySqlSchemaCollection.AddColumn("EXTERNAL_NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("EXTERNAL_LANGUAGE", typeof(string));
		mySqlSchemaCollection.AddColumn("PARAMETER_STYLE", typeof(string));
		mySqlSchemaCollection.AddColumn("IS_DETERMINISTIC", typeof(string));
		mySqlSchemaCollection.AddColumn("SQL_DATA_ACCESS", typeof(string));
		mySqlSchemaCollection.AddColumn("SQL_PATH", typeof(string));
		mySqlSchemaCollection.AddColumn("SECURITY_TYPE", typeof(string));
		mySqlSchemaCollection.AddColumn("CREATED", typeof(DateTime));
		mySqlSchemaCollection.AddColumn("LAST_ALTERED", typeof(DateTime));
		mySqlSchemaCollection.AddColumn("SQL_MODE", typeof(string));
		mySqlSchemaCollection.AddColumn("ROUTINE_COMMENT", typeof(string));
		mySqlSchemaCollection.AddColumn("DEFINER", typeof(string));
		StringBuilder stringBuilder = null;
		if (connection.driver.Version.isAtLeast(8, 0, 1))
		{
			stringBuilder = new StringBuilder("SELECT * FROM information_schema.routines WHERE 1=1");
			if (restrictions != null)
			{
				if (restrictions.Length >= 2 && restrictions[1] != null)
				{
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " AND routine_schema LIKE '{0}'", new object[1] { restrictions[1] });
				}
				if (restrictions.Length >= 3 && restrictions[2] != null)
				{
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " AND routine_name LIKE '{0}'", new object[1] { restrictions[2] });
				}
				if (restrictions.Length >= 4 && restrictions[3] != null)
				{
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " AND routine_type LIKE '{0}'", new object[1] { restrictions[3] });
				}
			}
			using MySqlDataReader mySqlDataReader = new MySqlCommand(stringBuilder.ToString(), connection).ExecuteReader();
			while (mySqlDataReader.Read())
			{
				MySqlSchemaRow mySqlSchemaRow = mySqlSchemaCollection.AddRow();
				mySqlSchemaRow["SPECIFIC_NAME"] = mySqlDataReader.GetString("specific_name");
				mySqlSchemaRow["ROUTINE_CATALOG"] = DBNull.Value;
				mySqlSchemaRow["ROUTINE_SCHEMA"] = mySqlDataReader.GetString("routine_schema");
				mySqlSchemaRow["ROUTINE_NAME"] = mySqlDataReader.GetString("routine_name");
				string s = (string)(mySqlSchemaRow["ROUTINE_TYPE"] = mySqlDataReader.GetString("routine_type"));
				mySqlSchemaRow["DTD_IDENTIFIER"] = ((StringUtility.ToLowerInvariant(s) == "function") ? ((IConvertible)mySqlDataReader.GetString("DTD_IDENTIFIER")) : ((IConvertible)DBNull.Value));
				mySqlSchemaRow["ROUTINE_BODY"] = "SQL";
				mySqlSchemaRow["ROUTINE_DEFINITION"] = mySqlDataReader.GetString("routine_definition");
				mySqlSchemaRow["EXTERNAL_NAME"] = DBNull.Value;
				mySqlSchemaRow["EXTERNAL_LANGUAGE"] = DBNull.Value;
				mySqlSchemaRow["PARAMETER_STYLE"] = "SQL";
				mySqlSchemaRow["IS_DETERMINISTIC"] = mySqlDataReader.GetString("is_deterministic");
				mySqlSchemaRow["SQL_DATA_ACCESS"] = mySqlDataReader.GetString("sql_data_access");
				mySqlSchemaRow["SQL_PATH"] = DBNull.Value;
				mySqlSchemaRow["SECURITY_TYPE"] = mySqlDataReader.GetString("security_type");
				mySqlSchemaRow["CREATED"] = mySqlDataReader.GetDateTime("created");
				mySqlSchemaRow["LAST_ALTERED"] = mySqlDataReader.GetDateTime("last_altered");
				mySqlSchemaRow["SQL_MODE"] = mySqlDataReader.GetString("sql_mode");
				mySqlSchemaRow["ROUTINE_COMMENT"] = mySqlDataReader.GetString("routine_comment");
				mySqlSchemaRow["DEFINER"] = mySqlDataReader.GetString("definer");
			}
			return mySqlSchemaCollection;
		}
		stringBuilder = new StringBuilder("SELECT * FROM mysql.proc WHERE 1=1");
		if (restrictions != null)
		{
			if (restrictions.Length >= 2 && restrictions[1] != null)
			{
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " AND db LIKE '{0}'", new object[1] { restrictions[1] });
			}
			if (restrictions.Length >= 3 && restrictions[2] != null)
			{
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " AND name LIKE '{0}'", new object[1] { restrictions[2] });
			}
			if (restrictions.Length >= 4 && restrictions[3] != null)
			{
				stringBuilder.AppendFormat(CultureInfo.InvariantCulture, " AND type LIKE '{0}'", new object[1] { restrictions[3] });
			}
		}
		using MySqlDataReader mySqlDataReader2 = new MySqlCommand(stringBuilder.ToString(), connection).ExecuteReader();
		while (mySqlDataReader2.Read())
		{
			MySqlSchemaRow mySqlSchemaRow2 = mySqlSchemaCollection.AddRow();
			mySqlSchemaRow2["SPECIFIC_NAME"] = mySqlDataReader2.GetString("specific_name");
			mySqlSchemaRow2["ROUTINE_CATALOG"] = DBNull.Value;
			mySqlSchemaRow2["ROUTINE_SCHEMA"] = mySqlDataReader2.GetString("db");
			mySqlSchemaRow2["ROUTINE_NAME"] = mySqlDataReader2.GetString("name");
			string s2 = (string)(mySqlSchemaRow2["ROUTINE_TYPE"] = mySqlDataReader2.GetString("type"));
			mySqlSchemaRow2["DTD_IDENTIFIER"] = ((StringUtility.ToLowerInvariant(s2) == "function") ? ((IConvertible)mySqlDataReader2.GetString("returns")) : ((IConvertible)DBNull.Value));
			mySqlSchemaRow2["ROUTINE_BODY"] = "SQL";
			mySqlSchemaRow2["ROUTINE_DEFINITION"] = mySqlDataReader2.GetString("body");
			mySqlSchemaRow2["EXTERNAL_NAME"] = DBNull.Value;
			mySqlSchemaRow2["EXTERNAL_LANGUAGE"] = DBNull.Value;
			mySqlSchemaRow2["PARAMETER_STYLE"] = "SQL";
			mySqlSchemaRow2["IS_DETERMINISTIC"] = mySqlDataReader2.GetString("is_deterministic");
			mySqlSchemaRow2["SQL_DATA_ACCESS"] = mySqlDataReader2.GetString("sql_data_access");
			mySqlSchemaRow2["SQL_PATH"] = DBNull.Value;
			mySqlSchemaRow2["SECURITY_TYPE"] = mySqlDataReader2.GetString("security_type");
			mySqlSchemaRow2["CREATED"] = mySqlDataReader2.GetDateTime("created");
			mySqlSchemaRow2["LAST_ALTERED"] = mySqlDataReader2.GetDateTime("modified");
			mySqlSchemaRow2["SQL_MODE"] = mySqlDataReader2.GetString("sql_mode");
			mySqlSchemaRow2["ROUTINE_COMMENT"] = mySqlDataReader2.GetString("comment");
			mySqlSchemaRow2["DEFINER"] = mySqlDataReader2.GetString("definer");
		}
		return mySqlSchemaCollection;
	}

	protected virtual MySqlSchemaCollection GetCollections()
	{
		object[][] data = new object[14][]
		{
			new object[3] { "MetaDataCollections", 0, 0 },
			new object[3] { "DataSourceInformation", 0, 0 },
			new object[3] { "DataTypes", 0, 0 },
			new object[3] { "Restrictions", 0, 0 },
			new object[3] { "ReservedWords", 0, 0 },
			new object[3] { "Databases", 1, 1 },
			new object[3] { "Tables", 4, 2 },
			new object[3] { "Columns", 4, 4 },
			new object[3] { "Users", 1, 1 },
			new object[3] { "Foreign Keys", 4, 3 },
			new object[3] { "IndexColumns", 5, 4 },
			new object[3] { "Indexes", 4, 3 },
			new object[3] { "Foreign Key Columns", 4, 3 },
			new object[3] { "UDF", 1, 1 }
		};
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("MetaDataCollections");
		mySqlSchemaCollection.AddColumn("CollectionName", typeof(string));
		mySqlSchemaCollection.AddColumn("NumberOfRestrictions", typeof(int));
		mySqlSchemaCollection.AddColumn("NumberOfIdentifierParts", typeof(int));
		FillTable(mySqlSchemaCollection, data);
		return mySqlSchemaCollection;
	}

	private MySqlSchemaCollection GetDataSourceInformation()
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("DataSourceInformation");
		mySqlSchemaCollection.AddColumn("CompositeIdentifierSeparatorPattern", typeof(string));
		mySqlSchemaCollection.AddColumn("DataSourceProductName", typeof(string));
		mySqlSchemaCollection.AddColumn("DataSourceProductVersion", typeof(string));
		mySqlSchemaCollection.AddColumn("DataSourceProductVersionNormalized", typeof(string));
		mySqlSchemaCollection.AddColumn("GroupByBehavior", typeof(GroupByBehavior));
		mySqlSchemaCollection.AddColumn("IdentifierPattern", typeof(string));
		mySqlSchemaCollection.AddColumn("IdentifierCase", typeof(IdentifierCase));
		mySqlSchemaCollection.AddColumn("OrderByColumnsInSelect", typeof(bool));
		mySqlSchemaCollection.AddColumn("ParameterMarkerFormat", typeof(string));
		mySqlSchemaCollection.AddColumn("ParameterMarkerPattern", typeof(string));
		mySqlSchemaCollection.AddColumn("ParameterNameMaxLength", typeof(int));
		mySqlSchemaCollection.AddColumn("ParameterNamePattern", typeof(string));
		mySqlSchemaCollection.AddColumn("QuotedIdentifierPattern", typeof(string));
		mySqlSchemaCollection.AddColumn("QuotedIdentifierCase", typeof(IdentifierCase));
		mySqlSchemaCollection.AddColumn("StatementSeparatorPattern", typeof(string));
		mySqlSchemaCollection.AddColumn("StringLiteralPattern", typeof(string));
		mySqlSchemaCollection.AddColumn("SupportedJoinOperators", typeof(SupportedJoinOperators));
		DBVersion version = connection.driver.Version;
		string value = $"{version.Major:0}.{version.Minor:0}.{version.Build:0}";
		MySqlSchemaRow mySqlSchemaRow = mySqlSchemaCollection.AddRow();
		mySqlSchemaRow["CompositeIdentifierSeparatorPattern"] = "\\.";
		mySqlSchemaRow["DataSourceProductName"] = "MySQL";
		mySqlSchemaRow["DataSourceProductVersion"] = connection.ServerVersion;
		mySqlSchemaRow["DataSourceProductVersionNormalized"] = value;
		mySqlSchemaRow["GroupByBehavior"] = GroupByBehavior.Unrelated;
		mySqlSchemaRow["IdentifierPattern"] = "(^\\`\\p{Lo}\\p{Lu}\\p{Ll}_@#][\\p{Lo}\\p{Lu}\\p{Ll}\\p{Nd}@$#_]*$)|(^\\`[^\\`\\0]|\\`\\`+\\`$)|(^\\\" + [^\\\"\\0]|\\\"\\\"+\\\"$)";
		mySqlSchemaRow["IdentifierCase"] = IdentifierCase.Insensitive;
		mySqlSchemaRow["OrderByColumnsInSelect"] = false;
		mySqlSchemaRow["ParameterMarkerFormat"] = "{0}";
		mySqlSchemaRow["ParameterMarkerPattern"] = "(@[A-Za-z0-9_$#]*)";
		mySqlSchemaRow["ParameterNameMaxLength"] = 128;
		mySqlSchemaRow["ParameterNamePattern"] = "^[\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}_@#][\\p{Lo}\\p{Lu}\\p{Ll}\\p{Lm}\\p{Nd}\\uff3f_@#\\$]*(?=\\s+|$)";
		mySqlSchemaRow["QuotedIdentifierPattern"] = "(([^\\`]|\\`\\`)*)";
		mySqlSchemaRow["QuotedIdentifierCase"] = IdentifierCase.Sensitive;
		mySqlSchemaRow["StatementSeparatorPattern"] = ";";
		mySqlSchemaRow["StringLiteralPattern"] = "'(([^']|'')*)'";
		mySqlSchemaRow["SupportedJoinOperators"] = 15;
		mySqlSchemaCollection.Rows.Add(mySqlSchemaRow);
		return mySqlSchemaCollection;
	}

	private static MySqlSchemaCollection GetDataTypes()
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("DataTypes");
		mySqlSchemaCollection.AddColumn("TypeName", typeof(string));
		mySqlSchemaCollection.AddColumn("ProviderDbType", typeof(int));
		mySqlSchemaCollection.AddColumn("ColumnSize", typeof(long));
		mySqlSchemaCollection.AddColumn("CreateFormat", typeof(string));
		mySqlSchemaCollection.AddColumn("CreateParameters", typeof(string));
		mySqlSchemaCollection.AddColumn("DataType", typeof(string));
		mySqlSchemaCollection.AddColumn("IsAutoincrementable", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsBestMatch", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsCaseSensitive", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsFixedLength", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsFixedPrecisionScale", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsLong", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsNullable", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsSearchable", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsSearchableWithLike", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsUnsigned", typeof(bool));
		mySqlSchemaCollection.AddColumn("MaximumScale", typeof(short));
		mySqlSchemaCollection.AddColumn("MinimumScale", typeof(short));
		mySqlSchemaCollection.AddColumn("IsConcurrencyType", typeof(bool));
		mySqlSchemaCollection.AddColumn("IsLiteralSupported", typeof(bool));
		mySqlSchemaCollection.AddColumn("LiteralPrefix", typeof(string));
		mySqlSchemaCollection.AddColumn("LiteralSuffix", typeof(string));
		mySqlSchemaCollection.AddColumn("NativeDataType", typeof(string));
		MySqlBit.SetDSInfo(mySqlSchemaCollection);
		MySqlBinary.SetDSInfo(mySqlSchemaCollection);
		MySqlDateTime.SetDSInfo(mySqlSchemaCollection);
		MySqlTimeSpan.SetDSInfo(mySqlSchemaCollection);
		MySqlString.SetDSInfo(mySqlSchemaCollection);
		MySqlDouble.SetDSInfo(mySqlSchemaCollection);
		MySqlSingle.SetDSInfo(mySqlSchemaCollection);
		MySqlByte.SetDSInfo(mySqlSchemaCollection);
		MySqlInt16.SetDSInfo(mySqlSchemaCollection);
		MySqlInt32.SetDSInfo(mySqlSchemaCollection);
		MySqlInt64.SetDSInfo(mySqlSchemaCollection);
		MySqlDecimal.SetDSInfo(mySqlSchemaCollection);
		MySqlUByte.SetDSInfo(mySqlSchemaCollection);
		MySqlUInt16.SetDSInfo(mySqlSchemaCollection);
		MySqlUInt32.SetDSInfo(mySqlSchemaCollection);
		MySqlUInt64.SetDSInfo(mySqlSchemaCollection);
		return mySqlSchemaCollection;
	}

	protected virtual MySqlSchemaCollection GetRestrictions()
	{
		object[][] data = new object[28][]
		{
			new object[4] { "Users", "Name", "", 0 },
			new object[4] { "Databases", "Name", "", 0 },
			new object[4] { "Tables", "Database", "", 0 },
			new object[4] { "Tables", "Schema", "", 1 },
			new object[4] { "Tables", "Table", "", 2 },
			new object[4] { "Tables", "TableType", "", 3 },
			new object[4] { "Columns", "Database", "", 0 },
			new object[4] { "Columns", "Schema", "", 1 },
			new object[4] { "Columns", "Table", "", 2 },
			new object[4] { "Columns", "Column", "", 3 },
			new object[4] { "Indexes", "Database", "", 0 },
			new object[4] { "Indexes", "Schema", "", 1 },
			new object[4] { "Indexes", "Table", "", 2 },
			new object[4] { "Indexes", "Name", "", 3 },
			new object[4] { "IndexColumns", "Database", "", 0 },
			new object[4] { "IndexColumns", "Schema", "", 1 },
			new object[4] { "IndexColumns", "Table", "", 2 },
			new object[4] { "IndexColumns", "ConstraintName", "", 3 },
			new object[4] { "IndexColumns", "Column", "", 4 },
			new object[4] { "Foreign Keys", "Database", "", 0 },
			new object[4] { "Foreign Keys", "Schema", "", 1 },
			new object[4] { "Foreign Keys", "Table", "", 2 },
			new object[4] { "Foreign Keys", "Constraint Name", "", 3 },
			new object[4] { "Foreign Key Columns", "Catalog", "", 0 },
			new object[4] { "Foreign Key Columns", "Schema", "", 1 },
			new object[4] { "Foreign Key Columns", "Table", "", 2 },
			new object[4] { "Foreign Key Columns", "Constraint Name", "", 3 },
			new object[4] { "UDF", "Name", "", 0 }
		};
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("Restrictions");
		mySqlSchemaCollection.AddColumn("CollectionName", typeof(string));
		mySqlSchemaCollection.AddColumn("RestrictionName", typeof(string));
		mySqlSchemaCollection.AddColumn("RestrictionDefault", typeof(string));
		mySqlSchemaCollection.AddColumn("RestrictionNumber", typeof(int));
		FillTable(mySqlSchemaCollection, data);
		return mySqlSchemaCollection;
	}

	private static MySqlSchemaCollection GetReservedWords()
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("ReservedWords");
		mySqlSchemaCollection.AddColumn(DbMetaDataColumnNames.ReservedWord, typeof(string));
		StreamReader streamReader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream("MySql.Data.Properties.ReservedWords.txt"));
		for (string text = streamReader.ReadLine(); text != null; text = streamReader.ReadLine())
		{
			mySqlSchemaCollection.AddRow()[0] = text;
		}
		streamReader.Dispose();
		return mySqlSchemaCollection;
	}

	protected static void FillTable(MySqlSchemaCollection dt, object[][] data)
	{
		foreach (object[] array in data)
		{
			MySqlSchemaRow mySqlSchemaRow = dt.AddRow();
			for (int j = 0; j < array.Length; j++)
			{
				mySqlSchemaRow[j] = array[j];
			}
		}
	}

	private void FindTables(MySqlSchemaCollection schema, string[] restrictions)
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "SHOW TABLE STATUS FROM `{0}`", new object[1] { restrictions[1] });
		if (restrictions != null && restrictions.Length >= 3 && restrictions[2] != null)
		{
			stringBuilder2.AppendFormat(CultureInfo.InvariantCulture, " LIKE '{0}'", new object[1] { restrictions[2] });
		}
		stringBuilder.Append(stringBuilder2.ToString());
		string value = ((restrictions[1].ToLower() == "information_schema") ? "SYSTEM VIEW" : "BASE TABLE");
		using MySqlDataReader mySqlDataReader = new MySqlCommand(stringBuilder.ToString(), connection).ExecuteReader();
		while (mySqlDataReader.Read())
		{
			MySqlSchemaRow mySqlSchemaRow = schema.AddRow();
			mySqlSchemaRow["TABLE_CATALOG"] = null;
			mySqlSchemaRow["TABLE_SCHEMA"] = restrictions[1];
			mySqlSchemaRow["TABLE_NAME"] = mySqlDataReader.GetString(0);
			mySqlSchemaRow["TABLE_TYPE"] = value;
			mySqlSchemaRow["ENGINE"] = GetString(mySqlDataReader, 1);
			mySqlSchemaRow["VERSION"] = mySqlDataReader.GetValue(2);
			mySqlSchemaRow["ROW_FORMAT"] = GetString(mySqlDataReader, 3);
			mySqlSchemaRow["TABLE_ROWS"] = mySqlDataReader.GetValue(4);
			mySqlSchemaRow["AVG_ROW_LENGTH"] = mySqlDataReader.GetValue(5);
			mySqlSchemaRow["DATA_LENGTH"] = mySqlDataReader.GetValue(6);
			mySqlSchemaRow["MAX_DATA_LENGTH"] = mySqlDataReader.GetValue(7);
			mySqlSchemaRow["INDEX_LENGTH"] = mySqlDataReader.GetValue(8);
			mySqlSchemaRow["DATA_FREE"] = mySqlDataReader.GetValue(9);
			mySqlSchemaRow["AUTO_INCREMENT"] = mySqlDataReader.GetValue(10);
			mySqlSchemaRow["CREATE_TIME"] = mySqlDataReader.GetValue(11);
			mySqlSchemaRow["UPDATE_TIME"] = mySqlDataReader.GetValue(12);
			mySqlSchemaRow["CHECK_TIME"] = mySqlDataReader.GetValue(13);
			mySqlSchemaRow["TABLE_COLLATION"] = GetString(mySqlDataReader, 14);
			mySqlSchemaRow["CHECKSUM"] = mySqlDataReader.GetValue(15);
			mySqlSchemaRow["CREATE_OPTIONS"] = GetString(mySqlDataReader, 16);
			mySqlSchemaRow["TABLE_COMMENT"] = GetString(mySqlDataReader, 17);
		}
	}

	private static string GetString(MySqlDataReader reader, int index)
	{
		if (reader.IsDBNull(index))
		{
			return null;
		}
		return reader.GetString(index);
	}

	public virtual MySqlSchemaCollection GetUDF(string[] restrictions)
	{
		string text = "SELECT name,ret,dl FROM mysql.func";
		if (restrictions != null && restrictions.Length >= 1 && !string.IsNullOrEmpty(restrictions[0]))
		{
			text = text + " WHERE name LIKE '" + restrictions[0] + "'";
		}
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection("User-defined Functions");
		mySqlSchemaCollection.AddColumn("NAME", typeof(string));
		mySqlSchemaCollection.AddColumn("RETURN_TYPE", typeof(int));
		mySqlSchemaCollection.AddColumn("LIBRARY_NAME", typeof(string));
		MySqlCommand mySqlCommand = new MySqlCommand(text, connection);
		try
		{
			using MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
			while (mySqlDataReader.Read())
			{
				MySqlSchemaRow mySqlSchemaRow = mySqlSchemaCollection.AddRow();
				mySqlSchemaRow[0] = mySqlDataReader.GetString(0);
				mySqlSchemaRow[1] = mySqlDataReader.GetInt32(1);
				mySqlSchemaRow[2] = mySqlDataReader.GetString(2);
			}
			return mySqlSchemaCollection;
		}
		catch (MySqlException ex)
		{
			if (ex.Number != 1142)
			{
				throw;
			}
			throw new MySqlException(Resources.UnableToEnumerateUDF, ex);
		}
	}

	protected virtual MySqlSchemaCollection GetSchemaInternal(string collection, string[] restrictions)
	{
		switch (collection)
		{
		case "DATABASES":
			return GetDatabases(restrictions);
		case "USERS":
			return GetUsers(restrictions);
		case "UDF":
			return GetUDF(restrictions);
		case "METADATACOLLECTIONS":
			return GetCollections();
		case "RESERVEDWORDS":
			return GetReservedWords();
		case "RESTRICTIONS":
			return GetRestrictions();
		case "DATATYPES":
			return GetDataTypes();
		default:
			if (restrictions == null)
			{
				restrictions = new string[2];
			}
			if (connection != null && connection.Database != null && connection.Database.Length > 0 && restrictions.Length > 1 && restrictions[1] == null)
			{
				restrictions[1] = connection.Database;
			}
			return collection switch
			{
				"FOREIGN KEY COLUMNS" => GetForeignKeyColumns(restrictions), 
				"FOREIGN KEYS" => GetForeignKeys(restrictions), 
				"INDEXCOLUMNS" => GetIndexColumns(restrictions), 
				"INDEXES" => GetIndexes(restrictions), 
				"COLUMNS" => GetColumns(restrictions), 
				"TABLES" => GetTables(restrictions), 
				_ => null, 
			};
		case "DATASOURCEINFORMATION":
			return GetDataSourceInformation();
		}
	}

	internal string[] CleanRestrictions(string[] restrictionValues)
	{
		string[] array = null;
		if (restrictionValues != null)
		{
			array = (string[])restrictionValues.Clone();
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (text != null)
				{
					array[i] = text.Trim(new char[1] { '`' });
				}
			}
		}
		return array;
	}

	protected MySqlSchemaCollection QueryCollection(string name, string sql)
	{
		MySqlSchemaCollection mySqlSchemaCollection = new MySqlSchemaCollection(name);
		MySqlDataReader mySqlDataReader = new MySqlCommand(sql, connection).ExecuteReader();
		for (int i = 0; i < mySqlDataReader.FieldCount; i++)
		{
			mySqlSchemaCollection.AddColumn(mySqlDataReader.GetName(i), mySqlDataReader.GetFieldType(i));
		}
		using (mySqlDataReader)
		{
			while (mySqlDataReader.Read())
			{
				MySqlSchemaRow mySqlSchemaRow = mySqlSchemaCollection.AddRow();
				for (int j = 0; j < mySqlDataReader.FieldCount; j++)
				{
					mySqlSchemaRow[j] = mySqlDataReader.GetValue(j);
				}
			}
			return mySqlSchemaCollection;
		}
	}
}
