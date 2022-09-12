using System;
using System.Runtime.CompilerServices;

internal class Class18 : efe82791
{
	[SpecialName]
	public byte imethod_0()
	{
		return cb1fcba5.f0f5241;
	}

	public void imethod_1(Class49 class49_0, out Enum1 enum1_0)
	{
		uint num = class49_0.struct2_0[cb1fcba5.byte_8].method_2();
		ulong num2 = class49_0.ec45936d.a59d7f30(num--).method_0();
		int index = class49_0.list_0.Count - 1;
		Struct0 @struct = class49_0.list_0[index];
		if (@struct.ulong_0 != num2)
		{
			throw new InvalidProgramException();
		}
		class49_0.list_0.RemoveAt(index);
		if (@struct.byte_0 == cb1fcba5.byte_68)
		{
			class49_0.ec45936d.d1cb88cf(++num, class49_0.struct2_0[cb1fcba5.byte_9]);
			class49_0.struct2_0[cb1fcba5.dcbee61c].dc0866ec(0);
			class49_0.struct2_0[cb1fcba5.byte_9].method_1(@struct.ulong_0);
		}
		class49_0.ec45936d.method_0(num);
		class49_0.struct2_0[cb1fcba5.byte_8].c85fac38(num);
		enum1_0 = (Enum1)0;
	}
}
