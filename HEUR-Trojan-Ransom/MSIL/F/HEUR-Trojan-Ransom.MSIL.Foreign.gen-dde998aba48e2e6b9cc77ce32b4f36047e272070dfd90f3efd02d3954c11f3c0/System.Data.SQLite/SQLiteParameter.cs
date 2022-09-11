using System.ComponentModel;
using System.Data.Common;

namespace System.Data.SQLite;

public sealed class SQLiteParameter : DbParameter, ICloneable
{
	private const DbType UnknownDbType = (DbType)(-1);

	private IDbCommand _command;

	internal DbType _dbType;

	private DataRowVersion _rowVersion;

	private object _objValue;

	private string _sourceColumn;

	private string _parameterName;

	private int _dataSize;

	private bool _nullable;

	private bool _nullMapping;

	private string _typeName;

	public IDbCommand Command
	{
		get
		{
			return _command;
		}
		set
		{
			_command = value;
		}
	}

	public override bool IsNullable
	{
		get
		{
			return _nullable;
		}
		set
		{
			_nullable = value;
		}
	}

	[RefreshProperties(RefreshProperties.All)]
	[DbProviderSpecificTypeProperty(true)]
	public override DbType DbType
	{
		get
		{
			if (_dbType == (DbType)(-1))
			{
				if (_objValue != null && _objValue != DBNull.Value)
				{
					return SQLiteConvert.TypeToDbType(_objValue.GetType());
				}
				return DbType.String;
			}
			return _dbType;
		}
		set
		{
			_dbType = value;
		}
	}

	public override ParameterDirection Direction
	{
		get
		{
			return ParameterDirection.Input;
		}
		set
		{
			if (value != ParameterDirection.Input)
			{
				throw new NotSupportedException();
			}
		}
	}

	public override string ParameterName
	{
		get
		{
			return _parameterName;
		}
		set
		{
			_parameterName = value;
		}
	}

	[DefaultValue(0)]
	public override int Size
	{
		get
		{
			return _dataSize;
		}
		set
		{
			_dataSize = value;
		}
	}

	public override string SourceColumn
	{
		get
		{
			return _sourceColumn;
		}
		set
		{
			_sourceColumn = value;
		}
	}

	public override bool SourceColumnNullMapping
	{
		get
		{
			return _nullMapping;
		}
		set
		{
			_nullMapping = value;
		}
	}

	public override DataRowVersion SourceVersion
	{
		get
		{
			return _rowVersion;
		}
		set
		{
			_rowVersion = value;
		}
	}

	[TypeConverter(typeof(StringConverter))]
	[RefreshProperties(RefreshProperties.All)]
	public override object Value
	{
		get
		{
			return _objValue;
		}
		set
		{
			_objValue = value;
			if (_dbType == (DbType)(-1) && _objValue != null && _objValue != DBNull.Value)
			{
				_dbType = SQLiteConvert.TypeToDbType(_objValue.GetType());
			}
		}
	}

	public string TypeName
	{
		get
		{
			return _typeName;
		}
		set
		{
			_typeName = value;
		}
	}

	internal SQLiteParameter(IDbCommand command)
		: this()
	{
		_command = command;
	}

	public SQLiteParameter()
		: this(null, (DbType)(-1), 0, null, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(string parameterName)
		: this(parameterName, (DbType)(-1), 0, null, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(string parameterName, object value)
		: this(parameterName, (DbType)(-1), 0, null, DataRowVersion.Current)
	{
		Value = value;
	}

	public SQLiteParameter(string parameterName, DbType dbType)
		: this(parameterName, dbType, 0, null, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(string parameterName, DbType dbType, string sourceColumn)
		: this(parameterName, dbType, 0, sourceColumn, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(string parameterName, DbType dbType, string sourceColumn, DataRowVersion rowVersion)
		: this(parameterName, dbType, 0, sourceColumn, rowVersion)
	{
	}

	public SQLiteParameter(DbType dbType)
		: this(null, dbType, 0, null, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(DbType dbType, object value)
		: this(null, dbType, 0, null, DataRowVersion.Current)
	{
		Value = value;
	}

	public SQLiteParameter(DbType dbType, string sourceColumn)
		: this(null, dbType, 0, sourceColumn, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(DbType dbType, string sourceColumn, DataRowVersion rowVersion)
		: this(null, dbType, 0, sourceColumn, rowVersion)
	{
	}

	public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize)
		: this(parameterName, parameterType, parameterSize, null, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize, string sourceColumn)
		: this(parameterName, parameterType, parameterSize, sourceColumn, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion)
	{
		_parameterName = parameterName;
		_dbType = parameterType;
		_sourceColumn = sourceColumn;
		_rowVersion = rowVersion;
		_dataSize = parameterSize;
		_nullable = true;
	}

	private SQLiteParameter(SQLiteParameter source)
		: this(source.ParameterName, source._dbType, 0, source.Direction, source.IsNullable, 0, 0, source.SourceColumn, source.SourceVersion, source.Value)
	{
		_nullMapping = source._nullMapping;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, object value)
		: this(parameterName, parameterType, parameterSize, sourceColumn, rowVersion)
	{
		Direction = direction;
		IsNullable = isNullable;
		Value = value;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public SQLiteParameter(string parameterName, DbType parameterType, int parameterSize, ParameterDirection direction, byte precision, byte scale, string sourceColumn, DataRowVersion rowVersion, bool sourceColumnNullMapping, object value)
		: this(parameterName, parameterType, parameterSize, sourceColumn, rowVersion)
	{
		Direction = direction;
		SourceColumnNullMapping = sourceColumnNullMapping;
		Value = value;
	}

	public SQLiteParameter(DbType parameterType, int parameterSize)
		: this(null, parameterType, parameterSize, null, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(DbType parameterType, int parameterSize, string sourceColumn)
		: this(null, parameterType, parameterSize, sourceColumn, DataRowVersion.Current)
	{
	}

	public SQLiteParameter(DbType parameterType, int parameterSize, string sourceColumn, DataRowVersion rowVersion)
		: this(null, parameterType, parameterSize, sourceColumn, rowVersion)
	{
	}

	public override void ResetDbType()
	{
		_dbType = (DbType)(-1);
	}

	public object Clone()
	{
		return new SQLiteParameter(this);
	}
}
