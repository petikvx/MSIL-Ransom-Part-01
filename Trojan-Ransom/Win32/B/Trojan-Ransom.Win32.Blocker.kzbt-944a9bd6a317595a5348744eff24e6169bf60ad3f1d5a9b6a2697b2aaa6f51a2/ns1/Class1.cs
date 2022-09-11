using System;
using System.Runtime.CompilerServices;

namespace ns1;

internal sealed class Class1
{
	private static readonly uint uint_0 = 65521u;

	private uint uint_1;

	[SpecialName]
	public long vmethod_0()
	{
		return uint_1;
	}

	public Class1()
	{
		vmethod_1();
	}

	public void vmethod_1()
	{
		uint_1 = 1u;
	}

	public void vmethod_2(byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("buf");
		}
		if (int_0 >= 0 && int_1 >= 0 && int_0 + int_1 <= byte_0.Length)
		{
			uint num = uint_1 & 0xFFFFu;
			uint num2 = uint_1 >> 16;
			while (int_1 > 0)
			{
				int num3 = 3800;
				if (3800 > int_1)
				{
					num3 = int_1;
				}
				int_1 -= num3;
				while (--num3 >= 0)
				{
					num += (uint)(byte_0[int_0++] & 0xFF);
					num2 += num;
				}
				num %= uint_0;
				num2 %= uint_0;
			}
			uint_1 = (num2 << 16) | num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}
}
