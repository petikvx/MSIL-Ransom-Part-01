using System;
using MySql.Data;
using MySql.Data.MySqlClient.X.XDevAPI.Common;

namespace MySqlX.Protocol.X;

internal class DecimalDecoder : ValueDecoder
{
	public override void SetMetadata()
	{
		base.Column.Type = ColumnType.Decimal;
		base.Column.ClrType = typeof(decimal);
		ClrValueDecoder = DecimalValueDecoder;
	}

	private object DecimalValueDecoder(byte[] bytes)
	{
		int num = bytes[0];
		byte b = bytes[^1];
		string empty = string.Empty;
		string text = string.Empty;
		switch (b)
		{
		case 192:
			empty = "+";
			goto IL_0070;
		case 208:
			empty = "-";
			goto IL_0070;
		default:
			{
				if ((b & 0xF) == 12)
				{
					empty = "+";
					text = (b >> 4).ToString();
				}
				else
				{
					if ((b & 0xF) != 13)
					{
						throw new FormatException(ResourcesX.InvalidDecimalFormat);
					}
					empty = "-";
					text = (b >> 4).ToString();
				}
				goto IL_0070;
			}
			IL_0070:
			for (int i = 1; i < bytes.Length - 1; i++)
			{
				empty += bytes[i].ToString("x2");
			}
			empty += text;
			empty = empty.Insert(empty.Length - num, ".");
			return decimal.Parse(empty);
		}
	}
}
