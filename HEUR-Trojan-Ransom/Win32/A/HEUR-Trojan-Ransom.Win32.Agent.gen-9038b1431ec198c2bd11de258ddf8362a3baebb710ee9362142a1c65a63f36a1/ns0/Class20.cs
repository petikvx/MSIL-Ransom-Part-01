using System;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class20
{
	private byte[] byte_0;

	private int int_0;

	private int int_1;

	private uint uint_0;

	private int int_2;

	public int method_0(int int_3)
	{
		if (int_2 < int_3)
		{
			if (int_0 == int_1)
			{
				return -1;
			}
			uint_0 |= (uint)(((byte_0[int_0++] & 0xFF) | ((byte_0[int_0++] & 0xFF) << 8)) << int_2);
			int_2 += 16;
		}
		return (int)(uint_0 & ((1 << int_3) - 1));
	}

	public void method_1(int int_3)
	{
		uint_0 >>= int_3;
		int_2 -= int_3;
	}

	public int method_2(int int_3)
	{
		int num = method_0(int_3);
		if (num >= 0)
		{
			method_1(int_3);
		}
		return num;
	}

	[SpecialName]
	public int method_3()
	{
		return int_2;
	}

	[SpecialName]
	public int method_4()
	{
		return int_1 - int_0 + (int_2 >> 3);
	}

	public void method_5()
	{
		uint_0 >>= int_2 & 7;
		int_2 &= -8;
	}

	[SpecialName]
	public bool method_6()
	{
		return int_0 == int_1;
	}

	public int method_7(byte[] byte_1, int int_3, int int_4)
	{
		if (int_4 < 0)
		{
			throw new ArgumentOutOfRangeException(Class35.smethod_0(732371349, 1000403141, 1992550845));
		}
		if (((uint)int_2 & 7u) != 0)
		{
			throw new InvalidOperationException(Class35.smethod_0(1423623903, 1000403185, 1992550807));
		}
		int num = 0;
		while (int_2 > 0 && int_4 > 0)
		{
			byte_1[int_3++] = (byte)uint_0;
			uint_0 >>= 8;
			int_2 -= 8;
			int_4--;
			num++;
		}
		if (int_4 == 0)
		{
			return num;
		}
		int num2 = int_1 - int_0;
		if (int_4 > num2)
		{
			int_4 = num2;
		}
		Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
		int_0 += int_4;
		if (((uint)(int_0 - int_1) & (true ? 1u : 0u)) != 0)
		{
			uint_0 = byte_0[int_0++] & 0xFFu;
			int_2 = 8;
		}
		return num + int_4;
	}

	public void method_8()
	{
		int_2 = 0;
		int_1 = 0;
		int_0 = 0;
		uint_0 = 0u;
	}

	public void method_9(byte[] byte_1, int int_3, int int_4)
	{
		if (int_0 < int_1)
		{
			throw new InvalidOperationException(Class35.smethod_0(1550066292, 1000403107, 1992550895));
		}
		int num = int_3 + int_4;
		if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
		{
			if (((uint)int_4 & (true ? 1u : 0u)) != 0)
			{
				uint_0 |= (uint)((byte_1[int_3++] & 0xFF) << int_2);
				int_2 += 8;
			}
			byte_0 = byte_1;
			int_0 = int_3;
			int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}
}
