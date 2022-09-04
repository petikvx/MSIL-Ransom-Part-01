using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Globalization;

namespace System.Data.SQLite;

[Editor("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[ListBindable(false)]
public sealed class SQLiteParameterCollection : DbParameterCollection
{
	private SQLiteCommand _command;

	private List<SQLiteParameter> _parameterList;

	private bool _unboundFlag;

	public override bool IsSynchronized => true;

	public override bool IsFixedSize => false;

	public override bool IsReadOnly => false;

	public override object SyncRoot => null;

	public override int Count => _parameterList.Count;

	public new SQLiteParameter this[string parameterName]
	{
		get
		{
			return (SQLiteParameter)GetParameter(parameterName);
		}
		set
		{
			SetParameter(parameterName, value);
		}
	}

	public new SQLiteParameter this[int index]
	{
		get
		{
			return (SQLiteParameter)GetParameter(index);
		}
		set
		{
			SetParameter(index, value);
		}
	}

	internal SQLiteParameterCollection(SQLiteCommand cmd)
	{
		_command = cmd;
		_parameterList = new List<SQLiteParameter>();
		_unboundFlag = true;
	}

	public override IEnumerator GetEnumerator()
	{
		return _parameterList.GetEnumerator();
	}

	public SQLiteParameter Add(string parameterName, DbType parameterType, int parameterSize, string sourceColumn)
	{
		SQLiteParameter sQLiteParameter = new SQLiteParameter(parameterName, parameterType, parameterSize, sourceColumn);
		Add(sQLiteParameter);
		return sQLiteParameter;
	}

	public SQLiteParameter Add(string parameterName, DbType parameterType, int parameterSize)
	{
		SQLiteParameter sQLiteParameter = new SQLiteParameter(parameterName, parameterType, parameterSize);
		Add(sQLiteParameter);
		return sQLiteParameter;
	}

	public SQLiteParameter Add(string parameterName, DbType parameterType)
	{
		SQLiteParameter sQLiteParameter = new SQLiteParameter(parameterName, parameterType);
		Add(sQLiteParameter);
		return sQLiteParameter;
	}

	public int Add(SQLiteParameter parameter)
	{
		int num = -1;
		if (!string.IsNullOrEmpty(parameter.ParameterName))
		{
			num = IndexOf(parameter.ParameterName);
		}
		if (num == -1)
		{
			num = _parameterList.Count;
			_parameterList.Add(parameter);
		}
		SetParameter(num, parameter);
		return num;
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public override int Add(object value)
	{
		return Add((SQLiteParameter)value);
	}

	public SQLiteParameter AddWithValue(string parameterName, object value)
	{
		SQLiteParameter sQLiteParameter = new SQLiteParameter(parameterName, value);
		Add(sQLiteParameter);
		return sQLiteParameter;
	}

	public void AddRange(SQLiteParameter[] values)
	{
		int num = values.Length;
		for (int i = 0; i < num; i++)
		{
			Add(values[i]);
		}
	}

	public override void AddRange(Array values)
	{
		int length = values.Length;
		for (int i = 0; i < length; i++)
		{
			Add((SQLiteParameter)values.GetValue(i));
		}
	}

	public override void Clear()
	{
		_unboundFlag = true;
		_parameterList.Clear();
	}

	public override bool Contains(string parameterName)
	{
		return IndexOf(parameterName) != -1;
	}

	public override bool Contains(object value)
	{
		return _parameterList.Contains((SQLiteParameter)value);
	}

	public override void CopyTo(Array array, int index)
	{
		throw new NotImplementedException();
	}

	protected override DbParameter GetParameter(string parameterName)
	{
		return GetParameter(IndexOf(parameterName));
	}

	protected override DbParameter GetParameter(int index)
	{
		return _parameterList[index];
	}

	public override int IndexOf(string parameterName)
	{
		int count = _parameterList.Count;
		int num = 0;
		while (true)
		{
			if (num < count)
			{
				if (string.Compare(parameterName, _parameterList[num].ParameterName, StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public override int IndexOf(object value)
	{
		return _parameterList.IndexOf((SQLiteParameter)value);
	}

	public override void Insert(int index, object value)
	{
		_unboundFlag = true;
		_parameterList.Insert(index, (SQLiteParameter)value);
	}

	public override void Remove(object value)
	{
		_unboundFlag = true;
		_parameterList.Remove((SQLiteParameter)value);
	}

	public override void RemoveAt(string parameterName)
	{
		RemoveAt(IndexOf(parameterName));
	}

	public override void RemoveAt(int index)
	{
		_unboundFlag = true;
		_parameterList.RemoveAt(index);
	}

	protected override void SetParameter(string parameterName, DbParameter value)
	{
		SetParameter(IndexOf(parameterName), value);
	}

	protected override void SetParameter(int index, DbParameter value)
	{
		_unboundFlag = true;
		_parameterList[index] = (SQLiteParameter)value;
	}

	internal void Unbind()
	{
		_unboundFlag = true;
	}

	internal void MapParameters(SQLiteStatement activeStatement)
	{
		if (!_unboundFlag || _parameterList.Count == 0 || _command._statementList == null)
		{
			return;
		}
		int num = 0;
		int num2 = -1;
		foreach (SQLiteParameter parameter in _parameterList)
		{
			num2++;
			string text = parameter.ParameterName;
			if (text == null)
			{
				text = string.Format(CultureInfo.InvariantCulture, ";{0}", new object[1] { num });
				num++;
			}
			bool flag = false;
			int num3 = ((activeStatement != null) ? 1 : _command._statementList.Count);
			SQLiteStatement sQLiteStatement = activeStatement;
			for (int i = 0; i < num3; i++)
			{
				flag = false;
				if (sQLiteStatement == null)
				{
					sQLiteStatement = _command._statementList[i];
				}
				if (sQLiteStatement._paramNames != null && sQLiteStatement.MapParameter(text, parameter))
				{
					flag = true;
				}
				sQLiteStatement = null;
			}
			if (flag)
			{
				continue;
			}
			text = string.Format(CultureInfo.InvariantCulture, ";{0}", new object[1] { num2 });
			sQLiteStatement = activeStatement;
			for (int i = 0; i < num3; i++)
			{
				if (sQLiteStatement == null)
				{
					sQLiteStatement = _command._statementList[i];
				}
				if (sQLiteStatement._paramNames != null && sQLiteStatement.MapParameter(text, parameter))
				{
					flag = true;
				}
				sQLiteStatement = null;
			}
		}
		if (activeStatement == null)
		{
			_unboundFlag = false;
		}
	}
}
