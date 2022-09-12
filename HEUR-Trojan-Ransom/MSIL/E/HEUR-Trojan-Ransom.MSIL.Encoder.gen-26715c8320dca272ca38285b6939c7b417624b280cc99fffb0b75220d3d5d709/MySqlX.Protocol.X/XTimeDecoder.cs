using System;
using Google.Protobuf;
using MySql.Data.MySqlClient.X.XDevAPI.Common;

namespace MySqlX.Protocol.X;

internal class XTimeDecoder : ValueDecoder
{
	public override void SetMetadata()
	{
		base.Column.Type = ColumnType.Time;
		base.Column.ClrType = typeof(TimeSpan);
		ClrValueDecoder = ValueDecoder;
	}

	public object ValueDecoder(byte[] bytes)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		CodedInputStream val = new CodedInputStream(bytes);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		bool num5 = val.ReadInt32() > 0;
		if (!val.get_IsAtEnd())
		{
			num = val.ReadInt64();
		}
		if (!val.get_IsAtEnd())
		{
			num2 = val.ReadInt64();
		}
		if (!val.get_IsAtEnd())
		{
			num3 = val.ReadInt64();
		}
		if (!val.get_IsAtEnd())
		{
			num4 = val.ReadInt64();
		}
		if (num5)
		{
			num *= -1L;
		}
		return new TimeSpan(0, (int)num, (int)num2, (int)num3, (int)num4 * 1000);
	}
}
