using System;
using System.Collections.Generic;
using MySql.Data;

namespace MySqlX.XDevAPI.Relational;

public class Row
{
	private object[] _values;

	private Dictionary<string, int> _nameMap;

	public object this[int index] => GetValue(index);

	public object this[string name] => GetValue(name);

	internal Row(Dictionary<string, int> nameMap, object[] values)
	{
		_values = values;
		_nameMap = nameMap;
	}

	public string GetString(string name)
	{
		return GetValue(name).ToString();
	}

	private object GetValue(int index)
	{
		if (index < 0 || index >= _values.Length)
		{
			throw new IndexOutOfRangeException(string.Format(ResourcesX.InvalidRowIndex, index));
		}
		return _values[index];
	}

	private object GetValue(string name)
	{
		if (!_nameMap.ContainsKey(name))
		{
			throw new InvalidOperationException(string.Format(ResourcesX.InvalidNameIndex, name));
		}
		return GetValue(_nameMap[name]);
	}
}
