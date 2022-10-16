using System.Runtime.CompilerServices;

internal class Class48 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_23;
	}

	public unsafe void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_--);
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_--);
		class58_0.c73f45d8.a85b6a89(uint_);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
		if (facef384.method_8() is Interface0)
		{
			((Interface0)facef384.method_8()).c076b3e0(class58_0, facef383_, (Enum1)2);
		}
		else
		{
			uint num = facef383_.df1ed028();
			uint* ptr = (uint*)facef384.method_0();
			*ptr = num;
		}
		enum0_0 = (Enum0)0;
	}
}
