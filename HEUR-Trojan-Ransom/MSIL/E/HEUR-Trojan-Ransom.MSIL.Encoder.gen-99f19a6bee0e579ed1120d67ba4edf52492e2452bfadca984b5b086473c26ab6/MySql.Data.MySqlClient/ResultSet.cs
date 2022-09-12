using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

internal class ResultSet
{
	private Driver _driver;

	private bool[] _uaFieldsUsed;

	private Dictionary<string, int> _fieldHashCi;

	private int _rowIndex;

	private bool _readDone;

	private bool _isSequential;

	private int _seqIndex;

	private readonly int _statementId;

	private bool _cached;

	private List<IMySqlValue[]> _cachedValues;

	public bool HasRows { get; }

	public int Size
	{
		get
		{
			MySqlField[] fields = Fields;
			if (fields == null)
			{
				return 0;
			}
			return fields.Length;
		}
	}

	public MySqlField[] Fields { get; private set; }

	public IMySqlValue[] Values { get; private set; }

	public bool IsOutputParameters { get; set; }

	public int AffectedRows { get; private set; }

	public long InsertedId { get; private set; }

	public int TotalRows { get; private set; }

	public int SkippedRows { get; private set; }

	public bool Cached
	{
		get
		{
			return _cached;
		}
		set
		{
			_cached = value;
			if (_cached && _cachedValues == null)
			{
				_cachedValues = new List<IMySqlValue[]>();
			}
		}
	}

	public IMySqlValue this[int index]
	{
		get
		{
			if (_rowIndex < 0)
			{
				throw new MySqlException(Resources.AttemptToAccessBeforeRead);
			}
			_uaFieldsUsed[index] = true;
			if (_isSequential && index != _seqIndex)
			{
				if (index < _seqIndex)
				{
					throw new MySqlException(Resources.ReadingPriorColumnUsingSeqAccess);
				}
				while (_seqIndex < index - 1)
				{
					_driver.SkipColumnValue(Values[++_seqIndex]);
				}
				Values[index] = _driver.ReadColumnValue(index, Fields[index], Values[index]);
				_seqIndex = index;
			}
			return Values[index];
		}
	}

	public ResultSet(int affectedRows, long insertedId)
	{
		AffectedRows = affectedRows;
		InsertedId = insertedId;
		_readDone = true;
	}

	public ResultSet(Driver d, int statementId, int numCols)
	{
		AffectedRows = -1;
		InsertedId = -1L;
		_driver = d;
		_statementId = statementId;
		_rowIndex = -1;
		LoadColumns(numCols);
		IsOutputParameters = IsOutputParameterResultSet();
		HasRows = GetNextRow();
		_readDone = !HasRows;
	}

	public int GetOrdinal(string name)
	{
		if (!_fieldHashCi.TryGetValue(name, out var value))
		{
			throw new IndexOutOfRangeException(string.Format(Resources.CouldNotFindColumnName, name));
		}
		return value;
	}

	private bool GetNextRow()
	{
		bool num = _driver.FetchDataRow(_statementId, Size);
		if (num)
		{
			TotalRows++;
		}
		return num;
	}

	public bool NextRow(CommandBehavior behavior)
	{
		if (_readDone)
		{
			if (Cached)
			{
				return CachedNextRow(behavior);
			}
			return false;
		}
		if ((behavior & CommandBehavior.SingleRow) != 0 && _rowIndex == 0)
		{
			return false;
		}
		_isSequential = (behavior & CommandBehavior.SequentialAccess) != 0;
		_seqIndex = -1;
		if (_rowIndex >= 0)
		{
			bool flag = false;
			try
			{
				flag = GetNextRow();
			}
			catch (MySqlException ex)
			{
				if (ex.IsQueryAborted)
				{
					_readDone = true;
				}
				throw;
			}
			if (!flag)
			{
				_readDone = true;
				return false;
			}
		}
		if (!_isSequential)
		{
			ReadColumnData(outputParms: false);
		}
		_rowIndex++;
		return true;
	}

	private bool CachedNextRow(CommandBehavior behavior)
	{
		if ((behavior & CommandBehavior.SingleRow) != 0 && _rowIndex == 0)
		{
			return false;
		}
		if (_rowIndex == TotalRows - 1)
		{
			return false;
		}
		_rowIndex++;
		Values = _cachedValues[_rowIndex];
		return true;
	}

	public void Close()
	{
		if (!_readDone)
		{
			if (HasRows && _rowIndex == -1)
			{
				SkippedRows++;
			}
			try
			{
				while (_driver.IsOpen && _driver.SkipDataRow())
				{
					TotalRows++;
					SkippedRows++;
				}
			}
			catch (IOException)
			{
			}
			_readDone = true;
		}
		else if (_driver == null)
		{
			CacheClose();
		}
		_driver = null;
		if (Cached)
		{
			CacheReset();
		}
	}

	private void CacheClose()
	{
		SkippedRows = TotalRows - _rowIndex - 1;
	}

	private void CacheReset()
	{
		if (Cached)
		{
			_rowIndex = -1;
			AffectedRows = -1;
			InsertedId = -1L;
			SkippedRows = 0;
		}
	}

	public bool FieldRead(int index)
	{
		return _uaFieldsUsed[index];
	}

	public void SetValueObject(int i, IMySqlValue valueObject)
	{
		Values[i] = valueObject;
	}

	private bool IsOutputParameterResultSet()
	{
		if (_driver.HasStatus(ServerStatusFlags.OutputParameters))
		{
			return true;
		}
		if (Fields.Length == 0)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < Fields.Length)
			{
				if (!Fields[num].ColumnName.StartsWith("@_cnet_param_", StringComparison.OrdinalIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private void LoadColumns(int numCols)
	{
		Fields = _driver.GetColumns(numCols);
		Values = new IMySqlValue[numCols];
		_uaFieldsUsed = new bool[numCols];
		_fieldHashCi = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
		for (int i = 0; i < Fields.Length; i++)
		{
			string columnName = Fields[i].ColumnName;
			if (!_fieldHashCi.ContainsKey(columnName))
			{
				_fieldHashCi.Add(columnName, i);
			}
			Values[i] = Fields[i].GetValueObject();
		}
	}

	private void ReadColumnData(bool outputParms)
	{
		for (int i = 0; i < Size; i++)
		{
			Values[i] = _driver.ReadColumnValue(i, Fields[i], Values[i]);
		}
		if (Cached)
		{
			_cachedValues.Add((IMySqlValue[])Values.Clone());
		}
		if (outputParms)
		{
			bool num = _driver.FetchDataRow(_statementId, Fields.Length);
			_rowIndex = 0;
			if (num)
			{
				throw new MySqlException(Resources.MoreThanOneOPRow);
			}
		}
	}
}
