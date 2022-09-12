using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MySql.Data.MySqlClient;
using MySqlX.Sessions;
using MySqlX.XDevAPI.Common;

namespace MySqlX.XDevAPI.Relational;

public class InternalRowResult : BufferingResult<Row>
{
	public ReadOnlyCollection<Column> Columns => _columns.AsReadOnly();

	public int ColumnCount => _columns.Count;

	public List<string> ColumnNames => _columns.Select((Column o) => o.ColumnLabel).ToList();

	public ReadOnlyCollection<Row> Rows => _items.AsReadOnly();

	public object this[int index] => GetValue(index);

	internal InternalRowResult(InternalSession session)
		: base(session)
	{
	}

	private object GetValue(int index)
	{
		if (_position == _items.Count)
		{
			throw new InvalidOperationException("No data at position");
		}
		return _items[_position][index];
	}

	public int IndexOf(string name)
	{
		if (!base.NameMap.ContainsKey(name))
		{
			throw new MySqlException("Column not found '" + name + "'");
		}
		return base.NameMap[name];
	}

	protected override Row ReadItem(bool dumping)
	{
		List<byte[]> list = base.Protocol.ReadRow(this);
		if (list == null)
		{
			return null;
		}
		if (dumping)
		{
			return new Row(base.NameMap, null);
		}
		object[] array = new object[list.Count];
		for (int i = 0; i < list.Count; i++)
		{
			array[i] = Columns[i]._decoder.ClrValueDecoder(list[i]);
		}
		return new Row(base.NameMap, array);
	}
}
