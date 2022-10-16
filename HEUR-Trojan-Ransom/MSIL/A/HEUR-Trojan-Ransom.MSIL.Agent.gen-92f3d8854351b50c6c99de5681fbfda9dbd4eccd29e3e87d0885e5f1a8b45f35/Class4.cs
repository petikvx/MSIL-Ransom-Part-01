using System;
using System.Runtime.CompilerServices;

internal class Class4 : d88be11e
{
	[SpecialName]
	public byte b4b1262()
	{
		return b13312b0.byte_65;
	}

	public void df3f437a(Class58 class58_0, out Enum0 enum0_0)
	{
		uint uint_ = class58_0.a6890f1d[b13312b0.byte_7].df1ed028();
		if (class58_0.c73f45d8.a9bb6dff(uint_--).df1ed028() != 0)
		{
			throw new OverflowException();
		}
		class58_0.c73f45d8.a85b6a89(uint_);
		class58_0.a6890f1d[b13312b0.byte_7].method_2(uint_);
		enum0_0 = (Enum0)0;
	}
}
