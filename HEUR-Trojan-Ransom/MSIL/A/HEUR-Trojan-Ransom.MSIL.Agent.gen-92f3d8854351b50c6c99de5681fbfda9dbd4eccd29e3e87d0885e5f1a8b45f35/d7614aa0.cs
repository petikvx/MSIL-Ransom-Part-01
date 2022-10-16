using System.Runtime.CompilerServices;

internal class d7614aa0 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_40;
	}

	public unsafe void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(num);
		facef383 facef385 = class58_0.c73f45d8.a9bb6dff(num - 1);
		num -= 2;
		class58_0.c73f45d8.a85b6a89(num);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		uint num2 = facef385.df1ed028();
		ushort num3 = *(ushort*)(facef384.method_0() - 2L);
		if (num2 < num3)
		{
			ref facef383 reference = ref class58_0.a6890f1d[b13312b0.a2230221];
			reference.method_1(reference.method_0() + (ulong)(*(int*)((nint)facef384.method_0() + (nint)((long)num2 * 4L))));
		}
		enum0_0 = (Enum0)0;
	}
}
