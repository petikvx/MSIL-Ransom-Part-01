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
		CodedInputStream codedInputStream = new CodedInputStream(bytes);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		bool num5 = codedInputStream.ReadInt32() > 0;
		if (!codedInputStream.IsAtEnd)
		{
			num = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num2 = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num3 = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num4 = codedInputStream.ReadInt64();
		}
		if (num5)
		{
			num *= -1L;
		}
		return new TimeSpan(0, (int)num, (int)num2, (int)num3, (int)num4 * 1000);
	}
}
