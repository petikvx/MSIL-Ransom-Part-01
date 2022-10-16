using System.Runtime.CompilerServices;

internal class e5768fea : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_56;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_);
		byte b = (byte)(class58_0.a6890f1d[b13312b0.a048350c].a42951dc() & ~b13312b0.byte_11);
		if (!Class0.bool_0 && facef383_.method_0() >> 32 > 0L)
		{
			b = (byte)(b | b13312b0.byte_11);
		}
		class58_0.a6890f1d[b13312b0.a048350c].method_4(b);
		class58_0.c73f45d8.method_0(uint_, facef383_);
		enum0_0 = (Enum0)0;
	}
}
