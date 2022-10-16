using System.Runtime.CompilerServices;

internal class Class21 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.b88a316d;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_);
		byte b = class58_0.a6890f1d[b13312b0.a048350c].a42951dc();
		if ((b & b13312b0.byte_12) != 0)
		{
			facef383_.b6c833f5(facef383_.method_0());
		}
		else
		{
			facef383_.b6c833f5((long)facef383_.method_0());
		}
		class58_0.a6890f1d[b13312b0.a048350c].method_4((byte)(b & ~b13312b0.byte_12));
		class58_0.c73f45d8.method_0(uint_, facef383_);
		enum0_0 = (Enum0)0;
	}
}
