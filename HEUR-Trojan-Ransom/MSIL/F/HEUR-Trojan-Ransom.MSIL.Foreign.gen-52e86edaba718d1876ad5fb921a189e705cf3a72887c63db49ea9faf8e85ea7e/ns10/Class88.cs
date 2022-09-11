using Google.Protobuf;
using ns13;
using ns14;

namespace ns10;

internal sealed class Class88 : Class87
{
	public override void vmethod_0()
	{
		base.Column.Type = Enum49.const_0;
		base.Column.ClrType = typeof(ulong);
		delegate1_0 = method_1;
	}

	private ulong method_0(byte[] byte_0)
	{
		return new CodedInputStream(byte_0).ReadUInt64();
	}

	private object method_1(byte[] byte_0)
	{
		return method_0(byte_0);
	}
}
