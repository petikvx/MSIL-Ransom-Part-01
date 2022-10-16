using System.Runtime.CompilerServices;

internal class Class30 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_19;
	}

	public unsafe void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef384 = class58_0.c73f45d8.a9bb6dff(uint_);
		facef383 facef383_;
		if (facef384.method_8() is Interface0)
		{
			facef383_ = ((Interface0)facef384.method_8()).b3037b45(class58_0, (Enum1)3);
		}
		else
		{
			ulong* ptr = (ulong*)facef384.method_0();
			facef383 facef385 = default(facef383);
			facef385.method_1(*ptr);
			facef383_ = facef385;
		}
		class58_0.c73f45d8.method_0(uint_, facef383_);
		enum0_0 = (Enum0)0;
	}
}
