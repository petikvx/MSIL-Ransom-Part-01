using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using MySql.Data.Common;
using MySql.Data.Types;

namespace MySql.Data.MySqlClient;

internal class MySqlField
{
	public string CatalogName;

	public int ColumnLength;

	public string ColumnName;

	public string OriginalColumnName;

	public string TableName;

	public string RealTableName;

	public string DatabaseName;

	public Encoding Encoding;

	protected int charSetIndex;

	protected DBVersion connVersion;

	protected bool binaryOk;

	internal Driver driver;

	public int CharacterSetIndex
	{
		get
		{
			return charSetIndex;
		}
		set
		{
			charSetIndex = value;
			SetFieldEncoding();
		}
	}

	public MySqlDbType Type { get; protected set; }

	public byte Precision { get; set; }

	public byte Scale { get; set; }

	public int MaxLength { get; set; }

	public ColumnFlags Flags { get; protected set; }

	public bool IsAutoIncrement => (Flags & ColumnFlags.AUTO_INCREMENT) > (ColumnFlags)0;

	public bool IsNumeric => (Flags & ColumnFlags.NUMBER) > (ColumnFlags)0;

	public bool AllowsNull => (Flags & ColumnFlags.NOT_NULL) == 0;

	public bool IsUnique => (Flags & ColumnFlags.UNIQUE_KEY) > (ColumnFlags)0;

	public bool IsPrimaryKey => (Flags & ColumnFlags.PRIMARY_KEY) > (ColumnFlags)0;

	public bool IsBlob
	{
		get
		{
			if ((Type >= MySqlDbType.TinyBlob && Type <= MySqlDbType.Blob) || (Type >= MySqlDbType.TinyText && Type <= MySqlDbType.Text))
			{
				return true;
			}
			return (Flags & ColumnFlags.BLOB) > (ColumnFlags)0;
		}
	}

	public bool IsBinary
	{
		get
		{
			if (binaryOk)
			{
				return CharacterSetIndex == 63;
			}
			return false;
		}
	}

	public bool IsUnsigned => (Flags & ColumnFlags.UNSIGNED) > (ColumnFlags)0;

	public bool IsTextField
	{
		get
		{
			if (Type != MySqlDbType.VarString && Type != MySqlDbType.VarChar && Type != MySqlDbType.String)
			{
				if (Type == MySqlDbType.Guid)
				{
					return !driver.Settings.OldGuids;
				}
				return false;
			}
			return true;
		}
	}

	private int CharacterLength => ColumnLength / MaxLength;

	public List<Type> TypeConversions { get; } = new List<Type>();


	[SecuritySafeCritical]
	public MySqlField(Driver driver)
	{
		this.driver = driver;
		connVersion = driver.Version;
		MaxLength = 1;
		binaryOk = true;
	}

	public void SetTypeAndFlags(MySqlDbType type, ColumnFlags flags)
	{
		Flags = flags;
		Type = type;
		if (string.IsNullOrEmpty(TableName) && string.IsNullOrEmpty(RealTableName) && IsBinary && driver.Settings.FunctionsReturnString)
		{
			CharacterSetIndex = driver.ConnectionCharSetIndex;
		}
		if (IsUnsigned)
		{
			switch (type)
			{
			case MySqlDbType.Byte:
				Type = MySqlDbType.UByte;
				return;
			case MySqlDbType.Int16:
				Type = MySqlDbType.UInt16;
				return;
			case MySqlDbType.Int32:
				Type = MySqlDbType.UInt32;
				return;
			case MySqlDbType.Int64:
				Flags &= ColumnFlags.UNSIGNED;
				Type = MySqlDbType.UInt64;
				return;
			case MySqlDbType.Int24:
				Type = MySqlDbType.UInt24;
				return;
			}
		}
		if (IsBlob)
		{
			if (IsBinary && driver.Settings.TreatBlobsAsUTF8)
			{
				bool flag = false;
				Regex blobAsUTF8IncludeRegex = driver.Settings.GetBlobAsUTF8IncludeRegex();
				Regex blobAsUTF8ExcludeRegex = driver.Settings.GetBlobAsUTF8ExcludeRegex();
				if (blobAsUTF8IncludeRegex != null && blobAsUTF8IncludeRegex.IsMatch(ColumnName))
				{
					flag = true;
				}
				else if (blobAsUTF8IncludeRegex == null && blobAsUTF8ExcludeRegex != null && !blobAsUTF8ExcludeRegex.IsMatch(ColumnName))
				{
					flag = true;
				}
				if (flag)
				{
					binaryOk = false;
					Encoding = Encoding.GetEncoding("UTF-8");
					charSetIndex = -1;
					MaxLength = 4;
				}
			}
			if (!IsBinary)
			{
				switch (type)
				{
				case MySqlDbType.TinyBlob:
					Type = MySqlDbType.TinyText;
					break;
				case MySqlDbType.MediumBlob:
					Type = MySqlDbType.MediumText;
					break;
				case MySqlDbType.Blob:
					Type = MySqlDbType.Text;
					break;
				case MySqlDbType.LongBlob:
					Type = MySqlDbType.LongText;
					break;
				}
			}
		}
		if (driver.Settings.RespectBinaryFlags)
		{
			CheckForExceptions();
		}
		if (Type == MySqlDbType.String && CharacterLength == 36 && !driver.Settings.OldGuids)
		{
			Type = MySqlDbType.Guid;
		}
		if (!IsBinary)
		{
			return;
		}
		if (driver.Settings.RespectBinaryFlags)
		{
			switch (type)
			{
			case MySqlDbType.String:
				Type = MySqlDbType.Binary;
				break;
			case MySqlDbType.VarString:
			case MySqlDbType.VarChar:
				Type = MySqlDbType.VarBinary;
				break;
			}
		}
		if (CharacterSetIndex == 63)
		{
			CharacterSetIndex = driver.ConnectionCharSetIndex;
		}
		if (Type == MySqlDbType.Binary && ColumnLength == 16 && driver.Settings.OldGuids)
		{
			Type = MySqlDbType.Guid;
		}
	}

	public void AddTypeConversion(Type t)
	{
		if (!TypeConversions.Contains(t))
		{
			TypeConversions.Add(t);
		}
	}

	private void CheckForExceptions()
	{
		string text = string.Empty;
		if (OriginalColumnName != null)
		{
			text = StringUtility.ToUpperInvariant(OriginalColumnName);
		}
		if (text.StartsWith("CHAR(", StringComparison.Ordinal))
		{
			binaryOk = false;
		}
	}

	public IMySqlValue GetValueObject()
	{
		IMySqlValue mySqlValue = GetIMySqlValue(Type);
		if (mySqlValue is MySqlByte && ColumnLength == 1 && driver.Settings.TreatTinyAsBoolean)
		{
			MySqlByte mySqlByte = (MySqlByte)(object)mySqlValue;
			mySqlByte.TreatAsBoolean = true;
			mySqlValue = mySqlByte;
		}
		else if (mySqlValue is MySqlGuid mySqlGuid)
		{
			mySqlGuid.OldGuids = driver.Settings.OldGuids;
			mySqlValue = mySqlGuid;
		}
		return mySqlValue;
	}

	public static IMySqlValue GetIMySqlValue(MySqlDbType type)
	{
		switch (type)
		{
		case MySqlDbType.UByte:
			return default(MySqlUByte);
		case MySqlDbType.UInt16:
			return default(MySqlUInt16);
		case MySqlDbType.UInt64:
			return default(MySqlUInt64);
		case MySqlDbType.UInt32:
		case MySqlDbType.UInt24:
			return new MySqlUInt32(type, isNull: true);
		case MySqlDbType.Geometry:
			return new MySqlGeometry(type, isNull: true);
		case MySqlDbType.Decimal:
		case MySqlDbType.NewDecimal:
			return default(MySqlDecimal);
		case MySqlDbType.Byte:
			return default(MySqlByte);
		case MySqlDbType.Float:
			return default(MySqlSingle);
		case MySqlDbType.Double:
			return default(MySqlDouble);
		case MySqlDbType.Int64:
			return default(MySqlInt64);
		case MySqlDbType.Int32:
		case MySqlDbType.Int24:
			return new MySqlInt32(type, isNull: true);
		case MySqlDbType.Time:
			return default(MySqlTimeSpan);
		case MySqlDbType.Int16:
		case MySqlDbType.Year:
			return default(MySqlInt16);
		case MySqlDbType.Timestamp:
		case MySqlDbType.Date:
		case MySqlDbType.DateTime:
		case MySqlDbType.Newdate:
			return new MySqlDateTime(type, isNull: true);
		case MySqlDbType.Bit:
			return default(MySqlBit);
		default:
			throw new MySqlException("Unknown data type");
		case MySqlDbType.Guid:
			return default(MySqlGuid);
		case MySqlDbType.TinyBlob:
		case MySqlDbType.MediumBlob:
		case MySqlDbType.LongBlob:
		case MySqlDbType.Blob:
		case MySqlDbType.VarBinary:
		case MySqlDbType.Binary:
			return new MySqlBinary(type, isNull: true);
		case (MySqlDbType)6:
		case MySqlDbType.VarString:
		case MySqlDbType.JSON:
		case MySqlDbType.Enum:
		case MySqlDbType.Set:
		case MySqlDbType.VarChar:
		case MySqlDbType.String:
		case MySqlDbType.TinyText:
		case MySqlDbType.MediumText:
		case MySqlDbType.LongText:
		case MySqlDbType.Text:
			return new MySqlString(type, isNull: true);
		}
	}

	private void SetFieldEncoding()
	{
		Dictionary<int, string> characterSets = driver.CharacterSets;
		DBVersion version = driver.Version;
		if (characterSets != null && characterSets.Count != 0 && CharacterSetIndex != -1 && characterSets[CharacterSetIndex] != null)
		{
			CharacterSet characterSet = CharSetMap.GetCharacterSet(version, characterSets[CharacterSetIndex]);
			MaxLength = characterSet.byteCount;
			Encoding = CharSetMap.GetEncoding(version, characterSets[CharacterSetIndex]);
		}
	}
}
