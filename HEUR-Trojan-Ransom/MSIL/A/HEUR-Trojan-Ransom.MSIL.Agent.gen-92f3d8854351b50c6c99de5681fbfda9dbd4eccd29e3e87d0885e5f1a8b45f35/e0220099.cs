using System.Runtime.CompilerServices;

internal class e0220099 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_27;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint num = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		class58_0.c73f45d8.a85b6a89(++num);
		byte b = class58_0.method_0();
		facef383 facef384 = class58_0.a6890f1d[b];
		if (b == b13312b0.byte_7 || b == b13312b0.b7ea2fd7)
		{
			Class59 c73f45d = class58_0.c73f45d8;
			uint uint_ = num;
			facef383 facef383_ = default(facef383);
			facef383_.method_9(new dc3c6d47(facef384.df1ed028()));
			c73f45d.method_0(uint_, facef383_);
		}
		else
		{
			Class59 c73f45d2 = class58_0.c73f45d8;
			uint uint_2 = num;
			facef383 facef383_ = default(facef383);
			facef383_.method_2(facef384.df1ed028());
			c73f45d2.method_0(uint_2, facef383_);
		}
		class58_0.a6890f1d[b13312b0.byte_7].method_2(num);
		enum0_0 = (Enum0)0;
	}
}
