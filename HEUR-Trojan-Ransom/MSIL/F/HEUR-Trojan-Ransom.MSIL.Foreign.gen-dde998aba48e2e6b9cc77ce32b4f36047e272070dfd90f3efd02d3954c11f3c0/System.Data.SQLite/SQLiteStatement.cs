using System.Globalization;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

internal sealed class SQLiteStatement : IDisposable
{
	internal SQLiteBase _sql;

	internal string _sqlStatement;

	internal SQLiteStatementHandle _sqlite_stmt;

	internal int _unnamedParameters;

	internal string[] _paramNames;

	internal SQLiteParameter[] _paramValues;

	internal SQLiteCommand _command;

	private SQLiteConnectionFlags _flags;

	private string[] _types;

	private bool disposed;

	[NonSerialized]
	internal static GetString _009E;

	internal string[] TypeDefinitions => _types;

	internal SQLiteStatement(SQLiteBase sqlbase, SQLiteConnectionFlags flags, SQLiteStatementHandle stmt, string strCommand, SQLiteStatement previous)
	{
		_sql = sqlbase;
		_sqlite_stmt = stmt;
		_sqlStatement = strCommand;
		_flags = flags;
		int num = 0;
		int num2 = _sql.Bind_ParamCount(this, _flags);
		if (num2 <= 0)
		{
			return;
		}
		if (previous != null)
		{
			num = previous._unnamedParameters;
		}
		_paramNames = new string[num2];
		_paramValues = new SQLiteParameter[num2];
		for (int i = 0; i < num2; i++)
		{
			string text = _sql.Bind_ParamName(this, _flags, i + 1);
			if (string.IsNullOrEmpty(text))
			{
				text = HelperMethods.StringFormat(CultureInfo.InvariantCulture, _009E(107382573), num);
				num++;
				_unnamedParameters++;
			}
			_paramNames[i] = text;
			_paramValues[i] = null;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteStatement).Name);
		}
	}

	private void Dispose(bool disposing)
	{
		if (disposed)
		{
			return;
		}
		if (disposing)
		{
			if (_sqlite_stmt != null)
			{
				_sqlite_stmt.Dispose();
				_sqlite_stmt = null;
			}
			_paramNames = null;
			_paramValues = null;
			_sql = null;
			_sqlStatement = null;
		}
		disposed = true;
	}

	~SQLiteStatement()
	{
		Dispose(disposing: false);
	}

	internal bool TryGetChanges(ref int changes, ref bool readOnly)
	{
		if (_sql != null && _sql.IsOpen())
		{
			changes = _sql.Changes;
			readOnly = _sql.IsReadOnly(this);
			return true;
		}
		return false;
	}

	internal bool MapParameter(string s, SQLiteParameter p)
	{
		if (_paramNames == null)
		{
			return false;
		}
		int num = 0;
		if (s.Length > 0 && _009E(107382532).IndexOf(s[0]) == -1)
		{
			num = 1;
		}
		int num2 = _paramNames.Length;
		for (int i = 0; i < num2; i++)
		{
			if (string.Compare(_paramNames[i], num, s, 0, Math.Max(_paramNames[i].Length - num, s.Length), StringComparison.OrdinalIgnoreCase) == 0)
			{
				_paramValues[i] = p;
				return true;
			}
		}
		return false;
	}

	internal void BindParameters()
	{
		if (_paramNames != null)
		{
			int num = _paramNames.Length;
			for (int i = 0; i < num; i++)
			{
				BindParameter(i + 1, _paramValues[i]);
			}
		}
	}

	private static SQLiteConnection GetConnection(SQLiteStatement statement)
	{
		try
		{
			if (statement != null)
			{
				SQLiteCommand command = statement._command;
				if (command != null)
				{
					SQLiteConnection connection = command.Connection;
					if (connection != null)
					{
						return connection;
					}
				}
			}
		}
		catch (ObjectDisposedException)
		{
		}
		return null;
	}

	private void InvokeBindValueCallback(int index, SQLiteParameter parameter, out bool complete)
	{
		complete = false;
		SQLiteConnectionFlags flags = _flags;
		_flags &= ~SQLiteConnectionFlags.UseConnectionBindValueCallbacks;
		try
		{
			if (parameter == null)
			{
				return;
			}
			SQLiteConnection connection = GetConnection(this);
			if (connection == null)
			{
				return;
			}
			string text = parameter.TypeName;
			if (text == null && (_flags & SQLiteConnectionFlags.UseParameterNameForTypeName) == SQLiteConnectionFlags.UseParameterNameForTypeName)
			{
				text = parameter.ParameterName;
			}
			if (text == null && (_flags & SQLiteConnectionFlags.UseParameterDbTypeForTypeName) == SQLiteConnectionFlags.UseParameterDbTypeForTypeName)
			{
				text = SQLiteConvert.DbTypeToTypeName(connection, parameter.DbType, _flags);
			}
			if (text != null && connection.TryGetTypeCallbacks(text, out var callbacks) && callbacks != null)
			{
				SQLiteBindValueCallback bindValueCallback = callbacks.BindValueCallback;
				if (bindValueCallback != null)
				{
					object bindValueUserData = callbacks.BindValueUserData;
					bindValueCallback(_sql, _command, flags, parameter, text, index, bindValueUserData, out complete);
				}
			}
		}
		finally
		{
			_flags |= SQLiteConnectionFlags.UseConnectionBindValueCallbacks;
		}
	}

	private void BindParameter(int index, SQLiteParameter param)
	{
		if (param == null)
		{
			throw new SQLiteException(_009E(107382555));
		}
		if ((_flags & SQLiteConnectionFlags.UseConnectionBindValueCallbacks) == SQLiteConnectionFlags.UseConnectionBindValueCallbacks)
		{
			InvokeBindValueCallback(index, param, out var complete);
			if (complete)
			{
				return;
			}
		}
		object value = param.Value;
		DbType dbType = param.DbType;
		if (value != null && dbType == DbType.Object)
		{
			dbType = SQLiteConvert.TypeToDbType(value.GetType());
		}
		if ((_flags & SQLiteConnectionFlags.LogPreBind) == SQLiteConnectionFlags.LogPreBind)
		{
			IntPtr intPtr = _sqlite_stmt;
			SQLiteLog.LogMessage(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _009E(107382490), intPtr, index, dbType, value));
		}
		if (value == null || Convert.IsDBNull(value))
		{
			_sql.Bind_Null(this, _flags, index);
			return;
		}
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		bool flag = (_flags & SQLiteConnectionFlags.BindInvariantText) == SQLiteConnectionFlags.BindInvariantText;
		if ((_flags & SQLiteConnectionFlags.BindAllAsText) == SQLiteConnectionFlags.BindAllAsText)
		{
			if (value is DateTime)
			{
				_sql.Bind_DateTime(this, _flags, index, (DateTime)value);
			}
			else
			{
				_sql.Bind_Text(this, _flags, index, flag ? SQLiteConvert.ToStringWithProvider(value, invariantCulture) : value.ToString());
			}
			return;
		}
		CultureInfo provider = CultureInfo.CurrentCulture;
		if ((_flags & SQLiteConnectionFlags.ConvertInvariantText) == SQLiteConnectionFlags.ConvertInvariantText)
		{
			provider = invariantCulture;
		}
		switch (dbType)
		{
		case DbType.Date:
		case DbType.DateTime:
		case DbType.Time:
			_sql.Bind_DateTime(this, _flags, index, (value is string) ? _sql.ToDateTime((string)value) : Convert.ToDateTime(value, provider));
			break;
		case DbType.Boolean:
			_sql.Bind_Boolean(this, _flags, index, SQLiteConvert.ToBoolean(value, provider, viaFramework: true));
			break;
		case DbType.SByte:
			_sql.Bind_Int32(this, _flags, index, Convert.ToSByte(value, provider));
			break;
		case DbType.Int16:
			_sql.Bind_Int32(this, _flags, index, Convert.ToInt16(value, provider));
			break;
		case DbType.Int32:
			_sql.Bind_Int32(this, _flags, index, Convert.ToInt32(value, provider));
			break;
		case DbType.Int64:
			_sql.Bind_Int64(this, _flags, index, Convert.ToInt64(value, provider));
			break;
		case DbType.Byte:
			_sql.Bind_UInt32(this, _flags, index, Convert.ToByte(value, provider));
			break;
		case DbType.UInt16:
			_sql.Bind_UInt32(this, _flags, index, Convert.ToUInt16(value, provider));
			break;
		case DbType.UInt32:
			_sql.Bind_UInt32(this, _flags, index, Convert.ToUInt32(value, provider));
			break;
		case DbType.UInt64:
			_sql.Bind_UInt64(this, _flags, index, Convert.ToUInt64(value, provider));
			break;
		case DbType.Currency:
		case DbType.Double:
		case DbType.Single:
			_sql.Bind_Double(this, _flags, index, Convert.ToDouble(value, provider));
			break;
		case DbType.Binary:
			_sql.Bind_Blob(this, _flags, index, (byte[])value);
			break;
		case DbType.Guid:
			if (_command.Connection._binaryGuid)
			{
				_sql.Bind_Blob(this, _flags, index, ((Guid)value).ToByteArray());
			}
			else
			{
				_sql.Bind_Text(this, _flags, index, flag ? SQLiteConvert.ToStringWithProvider(value, invariantCulture) : value.ToString());
			}
			break;
		case DbType.Decimal:
			_sql.Bind_Text(this, _flags, index, Convert.ToDecimal(value, provider).ToString(invariantCulture));
			break;
		default:
			_sql.Bind_Text(this, _flags, index, flag ? SQLiteConvert.ToStringWithProvider(value, invariantCulture) : value.ToString());
			break;
		}
	}

	internal void SetTypes(string typedefs)
	{
		int num = typedefs.IndexOf(_009E(107381833), 0, StringComparison.OrdinalIgnoreCase);
		if (num == -1)
		{
			throw new ArgumentOutOfRangeException();
		}
		string[] array = typedefs.Substring(num + 6).Replace(_009E(107410998), string.Empty).Replace(_009E(107356926), string.Empty)
			.Replace(_009E(107381824), string.Empty)
			.Replace(_009E(107363080), string.Empty)
			.Replace(_009E(107363075), string.Empty)
			.Replace(_009E(107381851), string.Empty)
			.Split(',', '\r', '\n', '\t');
		for (int i = 0; i < array.Length; i++)
		{
			if (string.IsNullOrEmpty(array[i]))
			{
				array[i] = null;
			}
		}
		_types = array;
	}

	static SQLiteStatement()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteStatement));
	}
}
