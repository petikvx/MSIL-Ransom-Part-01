using System;
using MySql.Data.MySqlClient;

namespace MySql.Data.Types;

internal struct MySqlTimeSpan : IMySqlValue
{
	public bool IsNull { get; private set; }

	MySqlDbType IMySqlValue.MySqlDbType => MySqlDbType.Time;

	object IMySqlValue.Value => Value;

	public TimeSpan Value { get; private set; }

	Type IMySqlValue.SystemType => typeof(TimeSpan);

	string IMySqlValue.MySqlTypeName => "TIME";

	public MySqlTimeSpan(bool isNull)
	{
		IsNull = isNull;
		Value = TimeSpan.MinValue;
	}

	public MySqlTimeSpan(TimeSpan val)
	{
		IsNull = false;
		Value = val;
	}

	void IMySqlValue.WriteValue(MySqlPacket packet, bool binary, object val, int length)
	{
		if (!(val is TimeSpan timeSpan))
		{
			throw new MySqlException("Only TimeSpan objects can be serialized by MySqlTimeSpan");
		}
		bool flag = timeSpan.TotalMilliseconds < 0.0;
		TimeSpan timeSpan2 = timeSpan.Duration();
		if (binary)
		{
			if (timeSpan2.Milliseconds > 0)
			{
				packet.WriteByte(12);
			}
			else
			{
				packet.WriteByte(8);
			}
			packet.WriteByte((byte)(flag ? 1u : 0u));
			packet.WriteInteger(timeSpan2.Days, 4);
			packet.WriteByte((byte)timeSpan2.Hours);
			packet.WriteByte((byte)timeSpan2.Minutes);
			packet.WriteByte((byte)timeSpan2.Seconds);
			if (timeSpan2.Milliseconds > 0)
			{
				long v = timeSpan2.Milliseconds * 1000;
				packet.WriteInteger(v, 4);
			}
		}
		else
		{
			string v2 = string.Format("'{0}{1} {2:00}:{3:00}:{4:00}.{5:000000}'", flag ? "-" : "", timeSpan2.Days, timeSpan2.Hours, timeSpan2.Minutes, timeSpan2.Seconds, timeSpan2.Ticks % 10000000L / 10L);
			packet.WriteStringNoNull(v2);
		}
	}

	IMySqlValue IMySqlValue.ReadValue(MySqlPacket packet, long length, bool nullVal)
	{
		if (nullVal)
		{
			return new MySqlTimeSpan(isNull: true);
		}
		if (length >= 0L)
		{
			string s = packet.ReadString(length);
			ParseMySql(s);
			return this;
		}
		long num = packet.ReadByte();
		int num2 = 0;
		if (num > 0L)
		{
			num2 = packet.ReadByte();
		}
		IsNull = false;
		switch (num)
		{
		case 0L:
			IsNull = true;
			break;
		case 5L:
			Value = new TimeSpan(packet.ReadInteger(4), 0, 0, 0);
			break;
		case 8L:
			Value = new TimeSpan(packet.ReadInteger(4), packet.ReadByte(), packet.ReadByte(), packet.ReadByte());
			break;
		default:
			Value = new TimeSpan(packet.ReadInteger(4), packet.ReadByte(), packet.ReadByte(), packet.ReadByte(), packet.ReadInteger(4) / 1000000);
			break;
		}
		if (num2 == 1)
		{
			Value = Value.Negate();
		}
		return this;
	}

	void IMySqlValue.SkipValue(MySqlPacket packet)
	{
		int num = packet.ReadByte();
		packet.Position += num;
	}

	internal static void SetDSInfo(MySqlSchemaCollection sc)
	{
		MySqlSchemaRow mySqlSchemaRow = sc.AddRow();
		mySqlSchemaRow["TypeName"] = "TIME";
		mySqlSchemaRow["ProviderDbType"] = MySqlDbType.Time;
		mySqlSchemaRow["ColumnSize"] = 0;
		mySqlSchemaRow["CreateFormat"] = "TIME";
		mySqlSchemaRow["CreateParameters"] = null;
		mySqlSchemaRow["DataType"] = "System.TimeSpan";
		mySqlSchemaRow["IsAutoincrementable"] = false;
		mySqlSchemaRow["IsBestMatch"] = true;
		mySqlSchemaRow["IsCaseSensitive"] = false;
		mySqlSchemaRow["IsFixedLength"] = true;
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
		mySqlSchemaRow["LiteralPrefix"] = null;
		mySqlSchemaRow["LiteralSuffix"] = null;
		mySqlSchemaRow["NativeDataType"] = null;
	}

	public override string ToString()
	{
		return $"{Value.Days} {Value.Hours:00}:{Value.Minutes:00}:{Value.Seconds:00}";
	}

	private void ParseMySql(string s)
	{
		string[] array = s.Split(':', '.');
		int num = int.Parse(array[0]);
		int num2 = int.Parse(array[1]);
		int num3 = int.Parse(array[2]);
		int num4 = 0;
		if (array.Length > 3)
		{
			array[3] = array[3].PadRight(7, '0');
			num4 = int.Parse(array[3]);
		}
		if (num < 0 || array[0].StartsWith("-", StringComparison.Ordinal))
		{
			num2 *= -1;
			num3 *= -1;
			num4 *= -1;
		}
		int num5 = num / 24;
		num -= num5 * 24;
		Value = new TimeSpan(num5, num, num2, num3).Add(new TimeSpan(num4));
		IsNull = false;
	}
}
