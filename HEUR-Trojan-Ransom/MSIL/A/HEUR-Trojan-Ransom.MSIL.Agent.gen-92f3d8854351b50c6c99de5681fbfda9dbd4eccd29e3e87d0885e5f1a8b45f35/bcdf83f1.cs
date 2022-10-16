using System.Runtime.CompilerServices;

internal class bcdf83f1 : df7d42ac
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_31;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		facef383 facef383_ = class58_0.c73f45d8.a9bb6dff(uint_);
		if ((facef383_.a42951dc() & 0x80u) != 0)
		{
			facef383_.method_2(facef383_.a42951dc() | 0xFFFFFF00u);
		}
		class58_0.c73f45d8.method_0(uint_, facef383_);
		enum0_0 = (Enum0)0;
	}
}
