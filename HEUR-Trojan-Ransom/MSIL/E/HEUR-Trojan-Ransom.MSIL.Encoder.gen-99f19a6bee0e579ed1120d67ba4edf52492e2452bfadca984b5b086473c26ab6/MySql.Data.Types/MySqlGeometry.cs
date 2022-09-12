using System;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

public struct MySqlGeometry : IMySqlValue
{
	private readonly MySqlDbType _type;

	private readonly double _xValue;

	private readonly double _yValue;

	private readonly int _srid;

	private const int GEOMETRY_LENGTH = 25;

	public double? XCoordinate => _xValue;

	public double? YCoordinate => _yValue;

	public int? SRID => _srid;

	MySqlDbType IMySqlValue.MySqlDbType => _type;

	public bool IsNull { get; }

	object IMySqlValue.Value => Value;

	public byte[] Value { get; }

	Type IMySqlValue.SystemType => typeof(byte[]);

	string IMySqlValue.MySqlTypeName => "GEOMETRY";

	public MySqlGeometry(bool isNull)
		: this(MySqlDbType.Geometry, isNull)
	{
	}

	public MySqlGeometry(double xValue, double yValue)
		: this(MySqlDbType.Geometry, xValue, yValue, 0)
	{
	}

	public MySqlGeometry(double xValue, double yValue, int srid)
		: this(MySqlDbType.Geometry, xValue, yValue, srid)
	{
	}

	internal MySqlGeometry(MySqlDbType type, bool isNull)
	{
		_type = type;
		isNull = true;
		_xValue = 0.0;
		_yValue = 0.0;
		_srid = 0;
		Value = null;
		IsNull = true;
	}

	internal MySqlGeometry(MySqlDbType type, double xValue, double yValue, int srid)
	{
		_type = type;
		_xValue = xValue;
		_yValue = yValue;
		IsNull = false;
		_srid = srid;
		Value = new byte[25];
		byte[] bytes = BitConverter.GetBytes(srid);
		for (int i = 0; i < bytes.Length; i++)
		{
			Value[i] = bytes[i];
		}
		long num = BitConverter.DoubleToInt64Bits(xValue);
		long num2 = BitConverter.DoubleToInt64Bits(yValue);
		Value[4] = 1;
		Value[5] = 1;
		for (int j = 0; j < 8; j++)
		{
			Value[j + 9] = (byte)((ulong)num & 0xFFuL);
			num >>= 8;
		}
		for (int k = 0; k < 8; k++)
		{
			Value[k + 17] = (byte)((ulong)num2 & 0xFFuL);
			num2 >>= 8;
		}
	}

	public MySqlGeometry(MySqlDbType type, byte[] val)
	{
		if (val == null)
		{
			throw new ArgumentNullException("val");
		}
		byte[] array = new byte[val.Length];
		for (int i = 0; i < val.Length; i++)
		{
			array[i] = val[i];
		}
		int num = ((val.Length == 25) ? 9 : 5);
		int num2 = ((val.Length == 25) ? 17 : 13);
		Value = array;
		_xValue = ((val.Length >= num + 8) ? BitConverter.ToDouble(val, num) : 0.0);
		_yValue = ((val.Length >= num2 + 8) ? BitConverter.ToDouble(val, num2) : 0.0);
		_srid = ((val.Length == 25) ? BitConverter.ToInt32(val, 0) : 0);
		IsNull = false;
		_type = type;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		byte[] array = null;
		try
		{
			array = ((MySqlGeometry)val).Value;
		}
		catch
		{
			array = val as byte[];
		}
		if (array == null)
		{
			MySqlGeometry mySqlGeometryValue = new MySqlGeometry(0.0, 0.0);
			TryParse(val.ToString(), out mySqlGeometryValue);
			array = mySqlGeometryValue.Value;
		}
		byte[] array2 = new byte[25];
		for (int i = 0; i < array.Length; i++)
		{
			if (array.Length < 25)
			{
				array2[i + 4] = array[i];
			}
			else
			{
				array2[i] = array[i];
			}
		}
		packet.WriteStringNoNull("_binary ");
		packet.WriteByte(39);
		EscapeByteArray(array2, 25, packet);
		packet.WriteByte(39);
	}

	private static void EscapeByteArray(byte[] bytes, int length, MySqlPacket packet)
	{
		for (int i = 0; i < length; i++)
		{
			byte b = bytes[i];
			switch (b)
			{
			case 0:
				packet.WriteByte(92);
				packet.WriteByte(48);
				break;
			default:
				packet.WriteByte(b);
				break;
			case 34:
			case 39:
			case 92:
				packet.WriteByte(92);
				packet.WriteByte(b);
				break;
			}
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		MySqlGeometry mySqlGeometry;
		if (nullVal)
		{
			mySqlGeometry = new MySqlGeometry(_type, isNull: true);
		}
		else
		{
			if (length == -1L)
			{
				length = packet.ReadFieldLength();
			}
			byte[] array = new byte[length];
			packet.Read(array, 0, (int)length);
			mySqlGeometry = new MySqlGeometry(_type, array);
		}
		return mySqlGeometry;
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		int num = (int)packet.ReadFieldLength();
		packet.Position += num;
	}

	public override string ToString()
	{
		if (!IsNull)
		{
			if (_srid == 0)
			{
				return string.Format(CultureInfo.InvariantCulture.NumberFormat, "POINT({0} {1})", new object[2] { _xValue, _yValue });
			}
			return string.Format(CultureInfo.InvariantCulture.NumberFormat, "SRID={2};POINT({0} {1})", new object[3] { _xValue, _yValue, _srid });
		}
		return string.Empty;
	}

	public static MySqlGeometry Parse(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			throw new ArgumentNullException("value");
		}
		if (!value.Contains("SRID") && !value.Contains("POINT(") && !value.Contains("POINT ("))
		{
			throw new FormatException("String does not contain a valid geometry value");
		}
		MySqlGeometry mySqlGeometryValue = new MySqlGeometry(0.0, 0.0);
		TryParse(value, out mySqlGeometryValue);
		return mySqlGeometryValue;
	}

	public static bool TryParse(string value, out MySqlGeometry mySqlGeometryValue)
	{
		string[] array = new string[0];
		string text = string.Empty;
		bool flag = false;
		bool flag2 = false;
		double result = 0.0;
		double result2 = 0.0;
		int result3 = 0;
		try
		{
			if (value.Contains(";"))
			{
				array = value.Split(new char[1] { ';' });
			}
			else
			{
				text = value;
			}
			if (array.Length > 1 || text != string.Empty)
			{
				string[] array2 = ((text != string.Empty) ? text : array[1]).Replace("POINT (", "").Replace("POINT(", "").Replace(")", "")
					.Split(new char[1] { ' ' });
				if (array2.Length > 1)
				{
					flag = double.TryParse(array2[0], out result);
					flag2 = double.TryParse(array2[1], out result2);
				}
				if (array.Length >= 1)
				{
					int.TryParse(array[0].Replace("SRID=", ""), out result3);
				}
			}
			if (flag && flag2)
			{
				mySqlGeometryValue = new MySqlGeometry(result, result2, result3);
				return true;
			}
		}
		catch
		{
		}
		mySqlGeometryValue = new MySqlGeometry(isNull: true);
		return false;
	}

	public static void SetDSInfo(MySqlSchemaCollection dsTable)
	{
		MySqlSchemaRow mySqlSchemaRow = dsTable.AddRow();
		mySqlSchemaRow["TypeName"] = "GEOMETRY";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.Geometry;
		mySqlSchemaRow["ColumnSize"] = 25;
		mySqlSchemaRow["CreateFormat"] = "GEOMETRY";
		mySqlSchemaRow["CreateParameters"] = DBNull.Value;
		mySqlSchemaRow["DataType"] = "System.Byte[]";
		mySqlSchemaRow["IsAutoincrementable"] = false;
		mySqlSchemaRow["IsBestMatch"] = true;
		mySqlSchemaRow["IsCaseSensitive"] = false;
		mySqlSchemaRow["IsFixedLength"] = false;
		mySqlSchemaRow["IsFixedPrecisionScale"] = true;
		mySqlSchemaRow["IsLong"] = false;
		mySqlSchemaRow["IsNullable"] = true;
		mySqlSchemaRow["IsSearchable"] = true;
		mySqlSchemaRow["IsSearchableWithLike"] = false;
		mySqlSchemaRow["IsUnsigned"] = false;
		mySqlSchemaRow["MaximumScale"] = 0;
		mySqlSchemaRow["MinimumScale"] = 0;
		mySqlSchemaRow["IsConcurrencyType"] = DBNull.Value;
		mySqlSchemaRow["IsLiteralSupported"] = false;
		mySqlSchemaRow["LiteralPrefix"] = DBNull.Value;
		mySqlSchemaRow["LiteralSuffix"] = DBNull.Value;
		mySqlSchemaRow["NativeDataType"] = DBNull.Value;
	}

	public string GetWKT()
	{
		if (!IsNull)
		{
			return string.Format(CultureInfo.InvariantCulture.NumberFormat, "POINT({0} {1})", new object[2] { _xValue, _yValue });
		}
		return string.Empty;
	}
}
