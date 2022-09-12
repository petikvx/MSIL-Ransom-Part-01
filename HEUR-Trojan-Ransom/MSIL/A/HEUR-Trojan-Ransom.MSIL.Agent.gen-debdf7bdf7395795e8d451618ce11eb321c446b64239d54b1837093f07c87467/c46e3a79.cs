using System.Runtime.CompilerServices;

internal class c46e3a79 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.d671e94;
	}

	public unsafe void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(num--);
		Struct2 struct2_ = class49_0.ec45936d.a59d7f30(num--);
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		if (@struct.method_6() is da5e0024)
		{
			((da5e0024)@struct.method_6()).bf75e195(class49_0, struct2_, (Enum2)3);
		}
		else
		{
			ulong num2 = struct2_.method_0();
			ulong* ptr = (ulong*)@struct.method_0();
			*ptr = num2;
		}
		enum1_0 = (Enum1)0;
	}
}
