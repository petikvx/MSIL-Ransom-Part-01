using System.Collections.Generic;

internal class Class58
{
	public readonly facef383[] a6890f1d = new facef383[16];

	public readonly Class59 c73f45d8 = new Class59();

	public readonly a49ada94 a3d704e3;

	public readonly List<d9c52c2e> list_0 = new List<d9c52c2e>();

	public readonly List<Class54> list_1 = new List<Class54>();

	public Class58(a49ada94 a49ada94_0)
	{
		a3d704e3 = a49ada94_0;
	}

	public unsafe byte method_0()
	{
		uint num = a6890f1d[b13312b0.byte_8].df1ed028();
		ref facef383 reference = ref a6890f1d[b13312b0.a2230221];
		ulong num2 = reference.method_0();
		reference.method_1(num2 + 1L);
		byte* ptr = (byte*)num2;
		byte b = (byte)(*ptr ^ num);
		num = num * 7 + b;
		a6890f1d[b13312b0.byte_8].method_2(num);
		return b;
	}
}
