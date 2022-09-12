using System.Runtime.CompilerServices;

internal class Class29 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.fd4e78e3;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num);
		class49_0.ec45936d.method_0(--num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		byte b = class49_0.method_0();
		if ((b == cb1fcba5.byte_8 || b == cb1fcba5.byte_7) && @struct.method_6() is Class48)
		{
			Struct2[] struct2_ = class49_0.struct2_0;
			Struct2 struct2 = default(Struct2);
			struct2.c85fac38(((Class48)@struct.method_6()).a4a01217());
			struct2_[b] = struct2;
		}
		else
		{
			class49_0.struct2_0[b] = @struct;
		}
		enum1_0 = (Enum1)0;
	}
}
