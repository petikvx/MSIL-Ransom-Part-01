using System.Collections.Generic;

internal class fdc40966
{
	public readonly Struct3[] struct3_0 = new Struct3[16];

	public readonly Class58 class58_0 = new Class58();

	public readonly Class2 class2_0;

	public readonly List<Struct0> list_0 = new List<Struct0>();

	public readonly List<Class54> list_1 = new List<Class54>();

	public fdc40966(Class2 class2_1)
	{
		class2_0 = class2_1;
	}

	public unsafe byte method_0()
	{
		uint num = struct3_0[fb3c043f.byte_6].method_1();
		ref Struct3 reference = ref struct3_0[fb3c043f.ce86f7bc];
		ulong num2 = reference.ba535d1d();
		reference.method_0(num2 + 1L);
		byte* ptr = (byte*)num2;
		byte b = (byte)(*ptr ^ num);
		num = num * 7 + b;
		struct3_0[fb3c043f.byte_6].e63a4aca(num);
		return b;
	}
}
