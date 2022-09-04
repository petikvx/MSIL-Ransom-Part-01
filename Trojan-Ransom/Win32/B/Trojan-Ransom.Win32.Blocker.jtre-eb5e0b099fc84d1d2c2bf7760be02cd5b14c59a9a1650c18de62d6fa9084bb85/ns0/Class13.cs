using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class13 : Interface0
{
	private static readonly uint uint_0 = 65521u;

	private uint uint_1;

	public Class13()
	{
		imethod_1();
	}

	[SpecialName]
	public long imethod_0()
	{
		return uint_1;
	}

	public void imethod_1()
	{
		uint_1 = 1u;
	}

	public void imethod_2(int int_0)
	{
		uint num = uint_1 & 0xFFFFu;
		uint num2 = uint_1 >> 16;
		num = (uint)((int)num + (int_0 & 0xFF)) % uint_0;
		num2 = (num + num2) % uint_0;
		uint_1 = (num2 << 16) + num;
	}

	public void imethod_3(byte[] byte_0)
	{
		imethod_4(byte_0, 0, byte_0.Length);
	}

	public void imethod_4(byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(Class14.smethod_0(968175555, 1670084565, 264926176));
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
