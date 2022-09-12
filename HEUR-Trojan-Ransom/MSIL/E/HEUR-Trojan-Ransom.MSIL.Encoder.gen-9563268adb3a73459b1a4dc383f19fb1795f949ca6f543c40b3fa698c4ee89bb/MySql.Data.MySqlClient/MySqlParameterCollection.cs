using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Drawing.Design;

namespace MySql.Data.MySqlClient;

[ListBindable(true)]
[Editor("MySql.Data.MySqlClient.Design.DBParametersEditor,MySql.Design", typeof(UITypeEditor))]
public sealed class MySqlParameterCollection : DbParameterCollection
{
	private readonly List<MySqlParameter> _items = new List<MySqlParameter>();

	private readonly Dictionary<string, int> _indexHashCs;

	private readonly Dictionary<string, int> _indexHashCi;

	internal bool containsUnnamedParameters;

	public override bool IsFixedSize => ((IList)_items).IsFixedSize;

	public override bool IsReadOnly => ((IList)_items).IsReadOnly;

	public override bool IsSynchronized => ((ICollection)_items).IsSynchronized;

	public override int Count => _items.Count;

	public new MySqlParameter this[int index]
	{
		get
		{
			return InternalGetParameter(index);
		}
		set
		{
			InternalSetParameter(index, value);
		}
	}

	public new MySqlParameter this[string name]
	{
		get
		{
			return InternalGetParameter(name);
		}
		set
		{
			InternalSetParameter(name, value);
		}
	}

	public override object SyncRoot => ((ICollection)_items).SyncRoot;

	internal MySqlParameterCollection(MySqlCommand cmd)
	{
		_indexHashCs = new Dictionary<string, int>();
		_indexHashCi = new Dictionary<string, int>(StringComparer.CurrentCultureIgnoreCase);
		containsUnnamedParameters = false;
		Clear();
	}

	public MySqlParameter Add(string parameterName, MySqlDbType dbType, int size, string sourceColumn)
	{
		return Add(new MySqlParameter(parameterName, dbType, size, sourceColumn));
	}

	public MySqlParameter Add(MySqlParameter value)
	{
		return InternalAdd(value, -1);
	}

	public MySqlParameter AddWithValue(string parameterName, object value)
	{
		return Add(new MySqlParameter(parameterName, value));
	}

	public MySqlParameter Add(string parameterName, MySqlDbType dbType)
	{
		return Add(new MySqlParameter(parameterName, dbType));
	}

	public MySqlParameter Add(string parameterName, MySqlDbType dbType, int size)
	{
		return Add(new MySqlParameter(parameterName, dbType, size));
	}

	public override void Clear()
	{
		foreach (MySqlParameter item in _items)
		{
			item.Collection = null;
		}
		_items.Clear();
		_indexHashCs.Clear();
		_indexHashCi.Clear();
	}

	private void CheckIndex(int index)
	{
		if (index < 0 || index >= Count)
		{
			throw new IndexOutOfRangeException("Parameter index is out of range.");
		}
	}

	private MySqlParameter InternalGetParameter(int index)
	{
		CheckIndex(index);
		return _items[index];
	}

	private MySqlParameter InternalGetParameter(string parameterName)
	{
		int num = IndexOf(parameterName);
		if (num < 0)
		{
			if (parameterName.StartsWith("@", StringComparison.Ordinal) || parameterName.StartsWith("?", StringComparison.Ordinal))
			{
				string parameterName2 = parameterName.Substring(1);
				num = IndexOf(parameterName2);
				if (num != -1)
				{
					return _items[num];
				}
			}
			throw new ArgumentException("Parameter '" + parameterName + "' not found in the collection.");
		}
		return _items[num];
	}

	private void InternalSetParameter(string parameterName, MySqlParameter value)
	{
		int num = IndexOf(parameterName);
		if (num < 0)
		{
			throw new ArgumentException("Parameter '" + parameterName + "' not found in the collection.");
		}
		InternalSetParameter(num, value);
	}

	private void InternalSetParameter(int index, MySqlParameter value)
	{
		if (value == null)
		{
			throw new ArgumentException(Resources.NewValueShouldBeMySqlParameter);
		}
		CheckIndex(index);
		MySqlParameter mySqlParameter = _items[index];
		_indexHashCs.Remove(mySqlParameter.ParameterName);
		_indexHashCi.Remove(mySqlParameter.ParameterName);
		_items[index] = value;
		_indexHashCs.Add(value.ParameterName, index);
		_indexHashCi.Add(value.ParameterName, index);
	}

	public override int IndexOf(string parameterName)
	{
		int value = -1;
		if (!_indexHashCs.TryGetValue(parameterName, out value) && !_indexHashCi.TryGetValue(parameterName, out value))
		{
			return -1;
		}
		return value;
	}

	public override int IndexOf(object value)
	{
		if (!(value is MySqlParameter item))
		{
			throw new ArgumentException("Argument must be of type DbParameter", "value");
		}
		return _items.IndexOf(item);
	}

	internal void ParameterNameChanged(MySqlParameter p, string oldName, string newName)
	{
		int value = IndexOf(oldName);
		_indexHashCs.Remove(oldName);
		_indexHashCi.Remove(oldName);
		_indexHashCs.Add(newName, value);
		_indexHashCi.Add(newName, value);
	}

	private MySqlParameter InternalAdd(MySqlParameter value, int index)
	{
		if (value == null)
		{
			throw new ArgumentException("The MySqlParameterCollection only accepts non-null MySqlParameter type objects.", "value");
		}
		if (string.IsNullOrEmpty(value.ParameterName))
		{
			value.ParameterName = $"Parameter{GetNextIndex()}";
		}
		if (IndexOf(value.ParameterName) >= 0)
		{
			throw new MySqlException(string.Format(Resources.ParameterAlreadyDefined, value.ParameterName));
		}
		string text = value.ParameterName;
		if (text[0] == '@' || text[0] == '?')
		{
			text = text.Substring(1, text.Length - 1);
		}
		if (IndexOf(text) >= 0)
		{
			throw new MySqlException(string.Format(Resources.ParameterAlreadyDefined, value.ParameterName));
		}
		if (index == -1)
		{
			_items.Add(value);
			index = _items.Count - 1;
		}
		else
		{
			_items.Insert(index, value);
			AdjustHashes(index, addEntry: true);
		}
		_indexHashCs.Add(value.ParameterName, index);
		_indexHashCi.Add(value.ParameterName, index);
		value.Collection = this;
		return value;
	}

	private int GetNextIndex()
	{
		int num = Count + 1;
		while (true)
		{
			string key = "Parameter" + num;
			if (!_indexHashCi.ContainsKey(key))
			{
				break;
			}
			num++;
		}
		return num;
	}

	private static void AdjustHash(Dictionary<string, int> hash, string parameterName, int keyIndex, bool addEntry)
	{
		if (hash.ContainsKey(parameterName))
		{
			int num = hash[parameterName];
			if (num >= keyIndex)
			{
				hash[parameterName] = ((!addEntry) ? (--num) : (++num));
			}
		}
	}

	private void AdjustHashes(int keyIndex, bool addEntry)
	{
		for (int i = 0; i < Count; i++)
		{
			string parameterName = _items[i].ParameterName;
			AdjustHash(_indexHashCi, parameterName, keyIndex, addEntry);
			AdjustHash(_indexHashCs, parameterName, keyIndex, addEntry);
		}
	}

	private MySqlParameter GetParameterFlexibleInternal(string baseName)
	{
		int num = IndexOf(baseName);
		if (-1 == num)
		{
			num = IndexOf("?" + baseName);
		}
		if (-1 == num)
		{
			num = IndexOf("@" + baseName);
		}
		if (-1 != num)
		{
			return this[num];
		}
		return null;
	}

	internal MySqlParameter GetParameterFlexible(string parameterName, bool throwOnNotFound)
	{
		string baseName = parameterName;
		MySqlParameter parameterFlexibleInternal = GetParameterFlexibleInternal(baseName);
		if (parameterFlexibleInternal != null)
		{
			return parameterFlexibleInternal;
		}
		if (parameterName.StartsWith("@", StringComparison.Ordinal) || parameterName.StartsWith("?", StringComparison.Ordinal))
		{
			baseName = parameterName.Substring(1);
		}
		parameterFlexibleInternal = GetParameterFlexibleInternal(baseName);
		if (parameterFlexibleInternal != null)
		{
			return parameterFlexibleInternal;
		}
		if (throwOnNotFound)
		{
			throw new ArgumentException("Parameter '" + parameterName + "' not found in the collection.");
		}
		return null;
	}

	public override void AddRange(Array values)
	{
		foreach (DbParameter value in values)
		{
			Add(value);
		}
	}

	protected override DbParameter GetParameter(string parameterName)
	{
		return InternalGetParameter(parameterName);
	}

	protected override DbParameter GetParameter(int index)
	{
		return InternalGetParameter(index);
	}

	protected override void SetParameter(string parameterName, DbParameter value)
	{
		InternalSetParameter(parameterName, value as MySqlParameter);
	}

	protected override void SetParameter(int index, DbParameter value)
	{
		InternalSetParameter(index, value as MySqlParameter);
	}

	public override int Add(object value)
	{
		if (!(value is MySqlParameter value2))
		{
			throw new MySqlException("Only MySqlParameter objects may be stored");
		}
		MySqlParameter value3 = Add(value2);
		return IndexOf(value3);
	}

	public override bool Contains(string parameterName)
	{
		return IndexOf(parameterName) != -1;
	}

	public override bool Contains(object value)
	{
		if (!(value is MySqlParameter item))
		{
			throw new ArgumentException("Argument must be of type DbParameter", "value");
		}
		return _items.Contains(item);
	}

	public override void CopyTo(Array array, int index)
	{
		_items.ToArray().CopyTo(array, index);
	}

	public override IEnumerator GetEnumerator()
	{
		return _items.GetEnumerator();
	}

	public override void Insert(int index, object value)
	{
		if (!(value is MySqlParameter value2))
		{
			throw new MySqlException("Only MySqlParameter objects may be stored");
		}
		InternalAdd(value2, index);
	}

	public override void Remove(object value)
	{
		MySqlParameter mySqlParameter = value as MySqlParameter;
		mySqlParameter.Collection = null;
		int keyIndex = IndexOf(mySqlParameter);
		_items.Remove(mySqlParameter);
		_indexHashCs.Remove(mySqlParameter.ParameterName);
		_indexHashCi.Remove(mySqlParameter.ParameterName);
		AdjustHashes(keyIndex, addEntry: false);
	}

	public override void RemoveAt(string parameterName)
	{
		DbParameter parameter = GetParameter(parameterName);
		Remove(parameter);
	}

	public override void RemoveAt(int index)
	{
		object value = _items[index];
		Remove(value);
	}
}
