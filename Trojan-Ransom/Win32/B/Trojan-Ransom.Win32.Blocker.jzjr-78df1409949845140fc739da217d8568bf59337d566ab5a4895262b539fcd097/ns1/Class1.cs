using System;

namespace ns1;

internal sealed class Class1
{
	public Random random_0;

	public int int_0;

	public Class1(int int_1)
	{
		random_0 = new Random(int_1);
		int num = (int_1 ^ random_0.Next()) & 0xFFFFFF;
		while (num-- > 0)
		{
			int_0 += random_0.Next();
		}
	}

	public unsafe byte method_0()
	{
		void* ptr = stackalloc byte[5];
		((byte*)ptr)[4] = (byte)(random_0.Next() % 256);
		return ((byte*)ptr)[4];
	}
}
