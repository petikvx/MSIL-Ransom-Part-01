using System;
using System.Runtime.CompilerServices;

internal class Class27 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_60;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		ulong num2 = class58_0.c73f45d8.a9bb6dff(num--).method_0();
		int index = class58_0.list_0.Count - 1;
		d9c52c2e d9c52c2e2 = class58_0.list_0[index];
		if (d9c52c2e2.ulong_0 != num2)
		{
			throw new InvalidProgramException();
		}
		class58_0.list_0.RemoveAt(index);
		if (d9c52c2e2.byte_0 == b13312b0.b66edc8d)
		{
			class58_0.c73f45d8.method_0(++num, class58_0.a6890f1d[b13312b0.a2230221]);
			class58_0.a6890f1d[b13312b0.byte_8].method_4(0);
			class58_0.a6890f1d[b13312b0.a2230221].method_1(d9c52c2e2.ulong_0);
		}
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		enum0_0 = (Enum0)0;
	}
}
