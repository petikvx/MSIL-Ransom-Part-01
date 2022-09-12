using System;
using System.Collections.Generic;
using System.Data;

namespace MySql.Data.MySqlClient;

public class MySqlSchemaCollection
{
	private readonly List<SchemaColumn> _columns = new List<SchemaColumn>();

	private readonly List<MySqlSchemaRow> _rows = new List<MySqlSchemaRow>();

	private readonly DataTable _table;

	internal Dictionary<string, int> Mapping;

	internal Dictionary<int, int> LogicalMappings;

	public string Name { get; set; }

	public IList<SchemaColumn> Columns => _columns;

	public IList<MySqlSchemaRow> Rows => _rows;

	public MySqlSchemaCollection()
	{
		Mapping = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		LogicalMappings = new Dictionary<int, int>();
	}

	public MySqlSchemaCollection(string name)
		: this()
	{
		Name = name;
	}

	public MySqlSchemaCollection(DataTable dt)
		: this()
	{
		_table = dt;
		int num = 0;
		foreach (DataColumn column in dt.Columns)
		{
			Columns.Add(new SchemaColumn
			{
				Name = column.ColumnName,
				Type = column.DataType
			});
			Mapping.Add(column.ColumnName, num++);
			LogicalMappings[Columns.Count - 1] = Columns.Count - 1;
		}
		foreach (DataRow row in dt.Rows)
		{
			MySqlSchemaRow mySqlSchemaRow = new MySqlSchemaRow(this);
			for (num = 0; num < Columns.Count; num++)
			{
				mySqlSchemaRow[num] = row[num];
			}
			Rows.Add(mySqlSchemaRow);
		}
	}

	internal SchemaColumn AddColumn(string name, Type t)
	{
		SchemaColumn schemaColumn = new SchemaColumn
		{
			Name = name,
			Type = t
		};
		_columns.Add(schemaColumn);
		Mapping.Add(name, _columns.Count - 1);
		LogicalMappings[_columns.Count - 1] = _columns.Count - 1;
		return schemaColumn;
	}

	internal int ColumnIndex(string name)
	{
		int result = -1;
		for (int i = 0; i < _columns.Count; i++)
		{
			if (string.Compare(_columns[i].Name, name, StringComparison.OrdinalIgnoreCase) == 0)
			{
				result = i;
				break;
			}
		}
		return result;
	}

	internal void RemoveColumn(string name)
	{
		int num = ColumnIndex(name);
		if (num == -1)
		{
			throw new InvalidOperationException();
		}
		_columns.RemoveAt(num);
		for (int i = num; i < Columns.Count; i++)
		{
			LogicalMappings[i] += 1;
		}
	}

	internal bool ContainsColumn(string name)
	{
		return ColumnIndex(name) >= 0;
	}

	internal MySqlSchemaRow AddRow()
	{
		MySqlSchemaRow mySqlSchemaRow = new MySqlSchemaRow(this);
		_rows.Add(mySqlSchemaRow);
		return mySqlSchemaRow;
	}

	internal MySqlSchemaRow NewRow()
	{
		return new MySqlSchemaRow(this);
	}

	internal DataTable AsDataTable()
	{
		if (_table != null)
		{
			return _table;
		}
		DataTable dataTable = new DataTable(Name);
		foreach (SchemaColumn column in Columns)
		{
			dataTable.Columns.Add(column.Name, column.Type);
		}
		foreach (MySqlSchemaRow row in Rows)
		{
			DataRow dataRow = dataTable.NewRow();
			for (int i = 0; i < dataTable.Columns.Count; i++)
			{
				dataRow[i] = ((row[i] == null) ? DBNull.Value : row[i]);
			}
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}
}
