using System.Globalization;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal class MetaData
{
	public static bool IsNumericType(string typename)
	{
		switch (typename.ToLower(CultureInfo.InvariantCulture))
		{
		case "numeric":
		case "tinyint":
		case "decimal":
		case "bigint":
		case "smallint":
		case "int":
		case "mediumint":
		case "fixed":
		case "float":
		case "double":
		case "dec":
		case "integer":
		case "serial":
		case "real":
			return true;
		default:
			return false;
		}
	}

	public static bool IsTextType(string typename)
	{
		switch (typename.ToLower(CultureInfo.InvariantCulture))
		{
		case "nvarchar":
		case "mediumtext":
		case "enum":
		case "tinytext":
		case "longtext":
		case "text":
		case "char":
		case "varchar":
		case "nchar":
		case "set":
			return true;
		default:
			return false;
		}
	}

	public static bool SupportScale(string typename)
	{
		switch (StringUtility.ToLowerInvariant(typename))
		{
		case "numeric":
		case "decimal":
		case "dec":
		case "real":
			return true;
		default:
			return false;
		}
	}

	public static MySqlDbType NameToType(string typeName, bool unsigned, bool realAsFloat, MySqlConnection connection)
	{
		switch (StringUtility.ToUpperInvariant(typeName))
		{
		case "BIGINT":
			if (!unsigned)
			{
				return MySqlDbType.Int64;
			}
			return MySqlDbType.UInt64;
		case "MEDIUMTEXT":
			return MySqlDbType.MediumText;
		case "ENUM":
			return MySqlDbType.Enum;
		case "TIME":
			return MySqlDbType.Time;
		case "TIMESTAMP":
			return MySqlDbType.Timestamp;
		case "SERIAL":
			return MySqlDbType.UInt64;
		case "SET":
			return MySqlDbType.Set;
		case "BLOB":
			return MySqlDbType.Blob;
		case "LONGTEXT":
			return MySqlDbType.LongText;
		case "BINARY":
			return MySqlDbType.Binary;
		case "LONGBLOB":
			return MySqlDbType.LongBlob;
		case "TINYBLOB":
			return MySqlDbType.TinyBlob;
		case "TEXT":
			return MySqlDbType.Text;
		case "VARCHAR":
			return MySqlDbType.VarChar;
		case "VARBINARY":
			return MySqlDbType.VarBinary;
		case "SMALLINT":
			if (!unsigned)
			{
				return MySqlDbType.Int16;
			}
			return MySqlDbType.UInt16;
		case "FLOAT":
			return MySqlDbType.Float;
		case "TINYINT":
			if (!unsigned)
			{
				return MySqlDbType.Byte;
			}
			return MySqlDbType.UByte;
		case "DATETIME":
			return MySqlDbType.DateTime;
		case "CHAR":
			return MySqlDbType.String;
		case "YEAR":
			return MySqlDbType.Year;
		case "DECIMAL":
		case "DEC":
		case "FIXED":
		case "NUMERIC":
			if (connection.driver.Version.isAtLeast(5, 0, 3))
			{
				return MySqlDbType.NewDecimal;
			}
			return MySqlDbType.Decimal;
		case "DATE":
			return MySqlDbType.Date;
		case "BOOLEAN":
		case "BOOL":
			return MySqlDbType.Byte;
		case "MEDIUMINT":
			if (!unsigned)
			{
				return MySqlDbType.Int24;
			}
			return MySqlDbType.UInt24;
		case "TINYTEXT":
			return MySqlDbType.TinyText;
		case "INTEGER":
		case "INT":
			if (!unsigned)
			{
				return MySqlDbType.Int32;
			}
			return MySqlDbType.UInt32;
		case "REAL":
			if (!realAsFloat)
			{
				return MySqlDbType.Double;
			}
			return MySqlDbType.Float;
		case "BIT":
			return MySqlDbType.Bit;
		case "DOUBLE":
			return MySqlDbType.Double;
		default:
			throw new MySqlException("Unhandled type encountered");
		case "MEDIUMBLOB":
			return MySqlDbType.MediumBlob;
		}
	}
}
