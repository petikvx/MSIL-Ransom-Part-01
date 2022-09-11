using System;

namespace ns0;

internal class Class2
{
	public Random random_0;

	public int int_0;

	public Class2(int int_1)
	{
		random_0 = new Random(int_1);
		int num = (int_1 ^ random_0.Next()) & 0xFFFFFF;
		while (num-- > 0)
		{
			int_0 += random_0.Next();
		}
	}

	public byte method_0()
	{
		return (byte)(random_0.Next() % 256);
	}
}
