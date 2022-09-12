using System.Collections.Generic;

internal class Class49
{
	public readonly Struct2[] struct2_0 = new Struct2[16];

	public readonly a5c16fd5 ec45936d = new a5c16fd5();

	public readonly Class2 class2_0;

	public readonly List<Struct0> list_0 = new List<Struct0>();

	public readonly List<d10246d4> list_1 = new List<d10246d4>();

	public Class49(Class2 class2_1)
	{
		class2_0 = class2_1;
	}

	public unsafe byte method_0()
	{
		uint num = struct2_0[cb1fcba5.dcbee61c].method_2();
		ref Struct2 reference = ref struct2_0[cb1fcba5.byte_9];
		ulong num2 = reference.method_0();
		reference.method_1(num2 + 1L);
		byte* ptr = (byte*)num2;
		byte b = (byte)(*ptr ^ num);
		num = num * 7 + b;
		struct2_0[cb1fcba5.dcbee61c].c85fac38(num);
		return b;
	}
}
