using System;
using System.Runtime.CompilerServices;

internal class Class22 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.c9cee0aa;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint uint_ = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		Struct2 @struct = class49_0.ec45936d.a59d7f30(uint_);
		if (!(@struct.method_6() is da5e0024))
		{
			throw new ExecutionEngineException();
		}
		Struct2 struct2_ = ((da5e0024)@struct.method_6()).imethod_0(class49_0, (Enum2)4);
		class49_0.ec45936d.d1cb88cf(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
