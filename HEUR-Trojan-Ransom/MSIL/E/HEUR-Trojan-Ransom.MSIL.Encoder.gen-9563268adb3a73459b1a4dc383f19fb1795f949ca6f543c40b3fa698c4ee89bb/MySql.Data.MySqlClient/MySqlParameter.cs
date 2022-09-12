using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Text;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

[TypeConverter(typeof(MySqlParameterConverter))]
public sealed class MySqlParameter : DbParameter, ICloneable, IDataParameter, IDbDataParameter
{
	private const int UNSIGNED_MASK = 32768;

	private object _paramValue;

	private string _paramName;

	private MySqlDbType _mySqlDbType;

	private bool _inferType = true;

	private const int GEOMETRY_LENGTH = 25;

	private DbType _dbType;

	[Category("Data")]
	public override DataRowVersion SourceVersion { get; set; }

	[Category("Misc")]
	public override string ParameterName
	{
		get
		{
			return _paramName;
		}
		set
		{
			SetParameterName(value);
		}
	}

	internal MySqlParameterCollection Collection { get; set; }

	internal Encoding Encoding { get; set; }

	internal bool TypeHasBeenSet => !_inferType;

	internal string BaseName
	{
		get
		{
			if (!ParameterName.StartsWith("@", StringComparison.Ordinal) && !ParameterName.StartsWith("?", StringComparison.Ordinal))
			{
				return ParameterName;
			}
			return ParameterName.Substring(1);
		}
	}

	[Category("Data")]
	public override ParameterDirection Direction { get; set; }

	[Browsable(false)]
	public override bool IsNullable { get; set; }

	[DbProviderSpecificTypeProperty(true)]
	[Category("Data")]
	public MySqlDbType MySqlDbType
	{
		get
		{
			return _mySqlDbType;
		}
		set
		{
			SetMySqlDbType(value);
			_inferType = false;
		}
	}

	[Category("Data")]
	public override byte Precision { get; set; }

	[Category("Data")]
	public override byte Scale { get; set; }

	[Category("Data")]
	public override int Size { get; set; }

	[TypeConverter(typeof(StringConverter))]
	[Category("Data")]
	public override object Value
	{
		get
		{
			return _paramValue;
		}
		set
		{
			_paramValue = value;
			byte[] array = value as byte[];
			string text = value as string;
			if (array != null)
			{
				Size = array.Length;
			}
			else if (text != null)
			{
				Size = text.Length;
			}
			if (_inferType)
			{
				SetTypeFromValue();
			}
		}
	}

	internal IMySqlValue ValueObject { get; private set; }

	public IList PossibleValues { get; internal set; }

	[Category("Data")]
	public override string SourceColumn { get; set; }

	public override bool SourceColumnNullMapping { get; set; }

	public override DbType DbType
	{
		get
		{
			return _dbType;
		}
		set
		{
			SetDbType(value);
			_inferType = false;
		}
	}

	public MySqlParameter Clone()
	{
		return new MySqlParameter(_paramName, _mySqlDbType, Direction, SourceColumn, SourceVersion, _paramValue)
		{
			_inferType = _inferType
		};
	}

	object ICloneable.Clone()
	{
		return Clone();
	}

	public MySqlParameter(string parameterName, MySqlDbType dbType, int size, string sourceColumn)
		: this(parameterName, dbType)
	{
		Size = size;
		Direction = ParameterDirection.Input;
		SourceColumn = sourceColumn;
		SourceVersion = DataRowVersion.Default;
	}

	public MySqlParameter()
	{
		SourceVersion = DataRowVersion.Default;
		Direction = ParameterDirection.Input;
	}

	public MySqlParameter(string parameterName, object value)
		: this()
	{
		ParameterName = parameterName;
		Value = value;
	}

	public MySqlParameter(string parameterName, MySqlDbType dbType)
		: this(parameterName, null)
	{
		MySqlDbType = dbType;
	}

	public MySqlParameter(string parameterName, MySqlDbType dbType, int size)
		: this(parameterName, dbType)
	{
		Size = size;
	}

	public MySqlParameter(string parameterName, MySqlDbType dbType, int size, ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, DataRowVersion sourceVersion, object value)
		: this(parameterName, dbType, size, sourceColumn)
	{
		Direction = direction;
		IsNullable = isNullable;
		Precision = precision;
		Scale = scale;
		Value = value;
		SourceVersion = sourceVersion;
	}

	internal MySqlParameter(string name, MySqlDbType type, ParameterDirection dir, string col, DataRowVersion sourceVersion, object val)
		: this(name, type)
	{
		Direction = dir;
		SourceColumn = col;
		Value = val;
		SourceVersion = sourceVersion;
	}

	private void SetParameterName(string name)
	{
		Collection?.ParameterNameChanged(this, _paramName, name);
		_paramName = name;
	}

	public override string ToString()
	{
		return _paramName;
	}

	internal int GetPSType()
	{
		switch (_mySqlDbType)
		{
		case MySqlDbType.Guid:
			return 254;
		case MySqlDbType.UByte:
			return 32769;
		case MySqlDbType.UInt16:
			return 32770;
		case MySqlDbType.UInt32:
			return 32771;
		default:
		{
			int mySqlDbType = (int)_mySqlDbType;
			return (mySqlDbType > 255) ? (mySqlDbType - 500) : mySqlDbType;
		}
		case MySqlDbType.UInt64:
			return 32776;
		case MySqlDbType.UInt24:
			return 32771;
		case MySqlDbType.Bit:
			return 32776;
		}
	}

	internal void Serialize(MySqlPacket packet, bool binary, MySqlConnectionStringBuilder settings)
	{
		if (!binary && (_paramValue == null || _paramValue == DBNull.Value))
		{
			packet.WriteStringNoNull("NULL");
			return;
		}
		if (ValueObject.MySqlDbType == MySqlDbType.Guid)
		{
			MySqlGuid mySqlGuid = (MySqlGuid)(object)ValueObject;
			mySqlGuid.OldGuids = settings.OldGuids;
			ValueObject = mySqlGuid;
		}
		if (ValueObject.MySqlDbType == MySqlDbType.Geometry)
		{
			MySqlGeometry mySqlGeometryValue = (MySqlGeometry)(object)ValueObject;
			if (mySqlGeometryValue.IsNull && Value != null)
			{
				MySqlGeometry.TryParse(Value.ToString(), out mySqlGeometryValue);
			}
			ValueObject = mySqlGeometryValue;
		}
		ValueObject.WriteValue(packet, binary, _paramValue, Size);
	}

	private void SetMySqlDbType(MySqlDbType mysqlDbtype)
	{
		_mySqlDbType = ((mysqlDbtype == MySqlDbType.JSON) ? MySqlDbType.VarChar : mysqlDbtype);
		ValueObject = MySqlField.GetIMySqlValue(_mySqlDbType);
		SetDbTypeFromMySqlDbType();
	}

	private void SetTypeFromValue()
	{
		if (_paramValue == null || _paramValue == DBNull.Value)
		{
			return;
		}
		if (_paramValue is Guid)
		{
			MySqlDbType = MySqlDbType.Guid;
			return;
		}
		if (_paramValue is TimeSpan)
		{
			MySqlDbType = MySqlDbType.Time;
			return;
		}
		if (_paramValue is bool)
		{
			MySqlDbType = MySqlDbType.Byte;
			return;
		}
		Type type = _paramValue.GetType();
		switch (type.Name)
		{
		case "Int64":
			MySqlDbType = MySqlDbType.Int64;
			return;
		case "SByte":
			MySqlDbType = MySqlDbType.Byte;
			return;
		case "MySqlGeometry":
			MySqlDbType = MySqlDbType.Geometry;
			return;
		case "UInt16":
			MySqlDbType = MySqlDbType.UInt16;
			return;
		case "Int16":
			MySqlDbType = MySqlDbType.Int16;
			return;
		case "String":
			MySqlDbType = MySqlDbType.VarChar;
			return;
		case "UInt64":
			MySqlDbType = MySqlDbType.UInt64;
			return;
		case "DateTime":
			MySqlDbType = MySqlDbType.DateTime;
			return;
		case "Double":
			MySqlDbType = MySqlDbType.Double;
			return;
		case "Decimal":
			MySqlDbType = MySqlDbType.Decimal;
			return;
		case "Int32":
			MySqlDbType = MySqlDbType.Int32;
			return;
		case "UInt32":
			MySqlDbType = MySqlDbType.UInt32;
			return;
		case "Byte":
			MySqlDbType = MySqlDbType.UByte;
			return;
		case "Single":
			MySqlDbType = MySqlDbType.Float;
			return;
		}
		if (type.GetTypeInfo().BaseType == typeof(Enum))
		{
			MySqlDbType = MySqlDbType.Int32;
		}
		else
		{
			MySqlDbType = MySqlDbType.Blob;
		}
	}

	internal long EstimatedSize()
	{
		if (Value != null && Value != DBNull.Value)
		{
			if (Value is byte[])
			{
				return ((byte[])Value).Length;
			}
			if (Value is string)
			{
				return ((string)Value).Length * 4;
			}
			if (!(Value is decimal) && !(Value is float))
			{
				return 32L;
			}
			return 64L;
		}
		return 4L;
	}

	public override void ResetDbType()
	{
		_inferType = true;
	}

	private void SetDbTypeFromMySqlDbType()
	{
		switch (_mySqlDbType)
		{
		case MySqlDbType.TinyBlob:
		case MySqlDbType.MediumBlob:
		case MySqlDbType.LongBlob:
		case MySqlDbType.Blob:
			_dbType = DbType.Object;
			break;
		case MySqlDbType.Enum:
		case MySqlDbType.Set:
		case MySqlDbType.VarChar:
			_dbType = DbType.String;
			break;
		case MySqlDbType.String:
			_dbType = DbType.StringFixedLength;
			break;
		case MySqlDbType.Decimal:
		case MySqlDbType.NewDecimal:
			_dbType = DbType.Decimal;
			break;
		case MySqlDbType.Byte:
			_dbType = DbType.SByte;
			break;
		case MySqlDbType.Int16:
			_dbType = DbType.Int16;
			break;
		case MySqlDbType.Float:
			_dbType = DbType.Single;
			break;
		case MySqlDbType.Double:
			_dbType = DbType.Double;
			break;
		case MySqlDbType.Int64:
			_dbType = DbType.Int64;
			break;
		case MySqlDbType.Int32:
		case MySqlDbType.Int24:
			_dbType = DbType.Int32;
			break;
		case MySqlDbType.Time:
			_dbType = DbType.Time;
			break;
		case MySqlDbType.Timestamp:
		case MySqlDbType.DateTime:
			_dbType = DbType.DateTime;
			break;
		case MySqlDbType.Date:
		case MySqlDbType.Year:
		case MySqlDbType.Newdate:
			_dbType = DbType.Date;
			break;
		case MySqlDbType.Bit:
			_dbType = DbType.UInt64;
			break;
		case MySqlDbType.Guid:
			_dbType = DbType.Guid;
			break;
		case MySqlDbType.UByte:
			_dbType = DbType.Byte;
			break;
		case MySqlDbType.UInt16:
			_dbType = DbType.UInt16;
			break;
		case MySqlDbType.UInt64:
			_dbType = DbType.UInt64;
			break;
		case MySqlDbType.UInt32:
		case MySqlDbType.UInt24:
			_dbType = DbType.UInt32;
			break;
		}
	}

	private void SetDbType(DbType dbType)
	{
		_dbType = dbType;
		switch (_dbType)
		{
		case DbType.Byte:
		case DbType.Boolean:
			_mySqlDbType = MySqlDbType.UByte;
			break;
		case DbType.Date:
			_mySqlDbType = MySqlDbType.Date;
			break;
		case DbType.DateTime:
			_mySqlDbType = MySqlDbType.DateTime;
			break;
		case DbType.Currency:
		case DbType.Decimal:
			_mySqlDbType = MySqlDbType.Decimal;
			break;
		case DbType.Double:
			_mySqlDbType = MySqlDbType.Double;
			break;
		case DbType.Guid:
			_mySqlDbType = MySqlDbType.Guid;
			break;
		case DbType.Int16:
			_mySqlDbType = MySqlDbType.Int16;
			break;
		case DbType.Int32:
			_mySqlDbType = MySqlDbType.Int32;
			break;
		case DbType.Int64:
			_mySqlDbType = MySqlDbType.Int64;
			break;
		case DbType.SByte:
			_mySqlDbType = MySqlDbType.Byte;
			break;
		case DbType.Single:
			_mySqlDbType = MySqlDbType.Float;
			break;
		case DbType.AnsiString:
		case DbType.String:
			_mySqlDbType = MySqlDbType.VarChar;
			break;
		case DbType.Time:
			_mySqlDbType = MySqlDbType.Time;
			break;
		case DbType.UInt16:
			_mySqlDbType = MySqlDbType.UInt16;
			break;
		case DbType.UInt32:
			_mySqlDbType = MySqlDbType.UInt32;
			break;
		case DbType.UInt64:
			_mySqlDbType = MySqlDbType.UInt64;
			break;
		default:
			_mySqlDbType = MySqlDbType.Blob;
			break;
		case DbType.AnsiStringFixedLength:
		case DbType.StringFixedLength:
			_mySqlDbType = MySqlDbType.String;
			break;
		}
		if (_dbType == DbType.Object && _paramValue is byte[] array && array.Length == 25)
		{
			_mySqlDbType = MySqlDbType.Geometry;
		}
		ValueObject = MySqlField.GetIMySqlValue(_mySqlDbType);
	}
}
