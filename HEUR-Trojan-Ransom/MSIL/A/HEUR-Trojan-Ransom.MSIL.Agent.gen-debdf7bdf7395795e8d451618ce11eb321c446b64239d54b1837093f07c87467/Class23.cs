using System.Runtime.CompilerServices;

internal class Class23 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.d00362b7;
	}

	public unsafe void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(uint_);
		Struct2 struct2_;
		if (@struct.method_6() is da5e0024)
		{
			struct2_ = ((da5e0024)@struct.method_6()).imethod_0(class49_0, Class0.eef71fab ? ((Enum2)3) : ((Enum2)2));
		}
		else if (Class0.eef71fab)
		{
			ulong* ptr = (ulong*)@struct.method_0();
			Struct2 struct2 = default(Struct2);
			struct2.method_1(*ptr);
			struct2_ = struct2;
		}
		else
		{
			uint* ptr2 = (uint*)@struct.method_0();
			Struct2 struct2 = default(Struct2);
			struct2.c85fac38(*ptr2);
			struct2_ = struct2;
		}
		class49_0.ec45936d.d1cb88cf(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
