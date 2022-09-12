using System;
using Google.Protobuf;
using MySql.Data.MySqlClient.X.XDevAPI.Common;

namespace MySqlX.Protocol.X;

internal class XDateTimeDecoder : ValueDecoder
{
	public override void SetMetadata()
	{
		base.Column.Type = GetDbType();
		base.Column.ClrType = typeof(DateTime);
		ClrValueDecoder = ValueDecoder;
	}

	private ColumnType GetDbType()
	{
		if ((base.Flags & (true ? 1u : 0u)) != 0)
		{
			return ColumnType.Timestamp;
		}
		if (base.Column.Length == 10)
		{
			return ColumnType.Date;
		}
		return ColumnType.DateTime;
	}

	public object ValueDecoder(byte[] bytes)
	{
		CodedInputStream codedInputStream = new CodedInputStream(bytes);
		ulong num = 0uL;
		ulong num2 = 0uL;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		ulong num7 = codedInputStream.ReadUInt64();
		num = codedInputStream.ReadUInt64();
		num2 = codedInputStream.ReadUInt64();
		if (!codedInputStream.IsAtEnd)
		{
			num3 = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num4 = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num5 = codedInputStream.ReadInt64();
		}
		if (!codedInputStream.IsAtEnd)
		{
			num6 = codedInputStream.ReadInt64();
		}
		return new DateTime((int)num7, (int)num, (int)num2, (int)num3, (int)num4, (int)num5).AddTicks(num6 * 10L);
	}
}
