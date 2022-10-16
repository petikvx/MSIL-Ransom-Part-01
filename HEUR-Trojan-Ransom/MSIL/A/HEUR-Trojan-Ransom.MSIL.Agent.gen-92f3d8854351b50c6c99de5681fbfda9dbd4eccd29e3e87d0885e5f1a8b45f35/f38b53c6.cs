using System.Runtime.CompilerServices;

internal class f38b53c6 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_20;
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
			((Interface0)facef384.method_8()).c076b3e0(class58_0, facef383_, Class0.bool_0 ? ((Enum1)3) : ((Enum1)2));
		}
		else if (Class0.bool_0)
		{
			ulong* ptr = (ulong*)facef384.method_0();
			*ptr = facef383_.method_0();
		}
		else
		{
			uint* ptr2 = (uint*)facef384.method_0();
			*ptr2 = facef383_.df1ed028();
		}
		enum0_0 = (Enum0)0;
	}
}
