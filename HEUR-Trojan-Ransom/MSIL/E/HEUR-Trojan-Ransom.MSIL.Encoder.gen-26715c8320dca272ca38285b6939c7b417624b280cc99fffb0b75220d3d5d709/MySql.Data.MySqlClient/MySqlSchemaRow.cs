using System;
using System.Collections.Generic;

namespace MySql.Data.MySqlClient;

public class MySqlSchemaRow
{
	private Dictionary<int, object> _data;

	internal MySqlSchemaCollection Collection { get; }

	internal object this[string s]
	{
		get
		{
			return GetValueForName(s);
		}
		set
		{
			SetValueForName(s, value);
		}
	}

	internal object this[int i]
	{
		get
		{
			int key = Collection.LogicalMappings[i];
			if (!_data.ContainsKey(key))
			{
				_data[key] = null;
			}
			return _data[key];
		}
		set
		{
			_data[Collection.LogicalMappings[i]] = value;
		}
	}

	public MySqlSchemaRow(MySqlSchemaCollection c)
	{
		Collection = c;
		InitMetadata();
	}

	internal void InitMetadata()
	{
		_data = new Dictionary<int, object>();
	}

	private void SetValueForName(string colName, object value)
	{
		int i = Collection.Mapping[colName];
		this[i] = value;
	}

	private object GetValueForName(string colName)
	{
		int num = Collection.Mapping[colName];
		if (!_data.ContainsKey(num))
		{
			_data[num] = null;
		}
		return this[num];
	}

	internal void CopyRow(MySqlSchemaRow row)
	{
		if (Collection.Columns.Count != row.Collection.Columns.Count)
		{
			throw new InvalidOperationException("column count doesn't match");
		}
		for (int i = 0; i < Collection.Columns.Count; i++)
		{
			row[i] = this[i];
		}
	}
}
