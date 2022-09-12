using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MySql.Data;
using MySqlX.Sessions;
using MySqlX.XDevAPI.Relational;

namespace MySqlX.XDevAPI.Common;

public abstract class BufferingResult<T> : BaseResult, IEnumerable<T>, IEnumerator<T>, IDisposable, IEnumerable, IEnumerator
{
	protected int _position;

	protected List<T> _items = new List<T>();

	protected bool _isComplete;

	private Dictionary<string, int> _nameMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

	internal List<Column> _columns;

	protected Dictionary<string, int> NameMap => _nameMap;

	public int PageSize { get; private set; }

	public T Current
	{
		get
		{
			if (_position == _items.Count)
			{
				throw new InvalidOperationException(string.Format(ResourcesX.NoDataAtIndex, _position));
			}
			return _items[_position];
		}
	}

	object IEnumerator.Current => Current;

	internal BufferingResult(InternalSession session)
		: base(session)
	{
		LoadColumnData();
		PageSize = 20;
		_position = -1;
	}

	protected void LoadColumnData()
	{
		_columns = new List<Column>();
		if (_hasData)
		{
			_columns = base.Protocol.LoadColumnMetadata();
			if (_columns.Count == 0)
			{
				_hasData = false;
			}
			for (int i = 0; i < _columns.Count; i++)
			{
				_nameMap.Add(_columns[i].ColumnLabel ?? _columns[i].ColumnName, i);
			}
		}
		else
		{
			base.Protocol.CloseResult(this);
		}
	}

	public ReadOnlyCollection<T> FetchAll()
	{
		while (PageInItems())
		{
		}
		return _items.AsReadOnly();
	}

	internal void Dump()
	{
		if (!_isComplete)
		{
			while (ReadItem(dumping: true) != null)
			{
			}
			_isComplete = true;
		}
	}

	public T FetchOne()
	{
		if (!Next())
		{
			return default(T);
		}
		return Current;
	}

	public bool Next()
	{
		_position++;
		if (_position >= _items.Count)
		{
			if (_isComplete)
			{
				return false;
			}
			if (!PageInItems())
			{
				_isComplete = true;
				return false;
			}
		}
		return true;
	}

	protected abstract T ReadItem(bool dumping);

	private bool PageInItems()
	{
		if (_isComplete)
		{
			return false;
		}
		int num = 0;
		for (int i = 0; i < PageSize; i++)
		{
			T val = ReadItem(dumping: false);
			if (val != null)
			{
				_items.Add(val);
				num++;
				continue;
			}
			_isComplete = !_hasData;
			_session.ActiveResult = null;
			break;
		}
		return num > 0;
	}

	public bool MoveNext()
	{
		return Next();
	}

	public void Reset()
	{
		_position = 0;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return this;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return this;
	}

	protected override void Buffer()
	{
		FetchAll();
	}

	public void Dispose()
	{
	}
}
