using Google.Protobuf;
using ns13;
using ns14;

namespace ns16;

internal sealed class Class91 : Class87
{
	private bool bool_0;

	public Class91(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public override void vmethod_0()
	{
		base.Column.Type = (bool_0 ? Enum49.const_6 : Enum49.const_8);
		base.Column.ClrType = (bool_0 ? typeof(float) : typeof(double));
		delegate1_0 = method_0;
		if (!bool_0)
		{
			delegate1_0 = method_1;
		}
	}

	private object method_0(byte[] byte_0)
	{
		return new CodedInputStream(byte_0).ReadFloat();
	}

	private object method_1(byte[] byte_0)
	{
		return new CodedInputStream(byte_0).ReadDouble();
	}
}
