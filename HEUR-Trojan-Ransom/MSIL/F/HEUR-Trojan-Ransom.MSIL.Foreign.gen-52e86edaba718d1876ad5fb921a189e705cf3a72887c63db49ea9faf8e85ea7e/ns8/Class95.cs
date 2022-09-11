using System;
using Google.Protobuf;
using ns13;
using ns14;

namespace ns8;

internal sealed class Class95 : Class87
{
	public override void vmethod_0()
	{
		base.Column.Type = Enum49.const_12;
		base.Column.ClrType = typeof(TimeSpan);
		delegate1_0 = method_0;
	}

	public object method_0(byte[] byte_0)
	{
		CodedInputStream codedInputStream = new CodedInputStream(byte_0);
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
