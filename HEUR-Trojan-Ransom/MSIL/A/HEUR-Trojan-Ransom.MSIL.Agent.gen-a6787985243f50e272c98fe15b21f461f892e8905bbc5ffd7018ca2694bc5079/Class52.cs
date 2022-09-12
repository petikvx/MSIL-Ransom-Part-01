using System.Collections.Generic;

internal class Class52
{
	public readonly Struct2[] struct2_0 = new Struct2[16];

	public readonly c6a36180 c6a36180_0 = new c6a36180();

	public readonly c184d4f4 c8dafbc3;

	public readonly List<ef6a318e> b842fc37 = new List<ef6a318e>();

	public readonly List<b993a733> e9b2ac2a = new List<b993a733>();

	public Class52(c184d4f4 c184d4f4_0)
	{
		c8dafbc3 = c184d4f4_0;
	}

	public unsafe byte method_0()
	{
		uint num = struct2_0[fae0f10.ccfef7db].b5683088();
		ref Struct2 reference = ref struct2_0[fae0f10.d1e82201];
		ulong num2 = reference.method_0();
		reference.f6b2288d(num2 + 1L);
		byte* ptr = (byte*)num2;
		byte b7056385 = (byte)(*ptr ^ num);
		num = num * 7 + b7056385;
		struct2_0[fae0f10.ccfef7db].b3579a47(num);
		return b7056385;
	}
}
