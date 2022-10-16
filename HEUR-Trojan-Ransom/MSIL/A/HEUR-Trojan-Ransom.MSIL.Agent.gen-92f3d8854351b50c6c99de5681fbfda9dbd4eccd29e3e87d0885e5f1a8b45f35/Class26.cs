using System.Runtime.CompilerServices;

internal class Class26 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_39;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(num);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(num - 1);
		num -= 2;
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		if (facef385.method_0() > 0L)
		{
			class58_0.a6890f1d[b13312b0.a2230221].method_1(facef384.method_0());
		}
		enum0_0 = (Enum0)0;
	}
}
