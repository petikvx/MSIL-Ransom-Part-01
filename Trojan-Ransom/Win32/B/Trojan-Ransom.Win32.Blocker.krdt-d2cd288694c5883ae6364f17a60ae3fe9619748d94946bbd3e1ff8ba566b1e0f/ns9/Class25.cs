using System;
using System.Runtime.CompilerServices;

namespace ns9;

internal class Class25
{
	protected byte[] byte_0;

	private int int_0;

	private int int_1;

	private uint uint_0;

	private int int_2;

	public Class25()
		: this(4096)
	{
	}

	public Class25(int int_3)
	{
		byte_0 = new byte[int_3];
	}

	public void method_0()
	{
		int_2 = 0;
		int_1 = 0;
		int_0 = 0;
	}

	public void method_1(int int_3)
	{
		byte_0[int_1++] = (byte)int_3;
	}

	public void method_2(int int_3)
	{
		byte_0[int_1++] = (byte)int_3;
		byte_0[int_1++] = (byte)(int_3 >> 8);
	}

	public void method_3(int int_3)
	{
		byte_0[int_1++] = (byte)int_3;
		byte_0[int_1++] = (byte)(int_3 >> 8);
		byte_0[int_1++] = (byte)(int_3 >> 16);
		byte_0[int_1++] = (byte)(int_3 >> 24);
	}

	public void method_4(byte[] byte_1, int int_3, int int_4)
	{
		Array.Copy(byte_1, int_3, byte_0, int_1, int_4);
		int_1 += int_4;
	}

	[SpecialName]
	public int method_5()
	{
		return int_2;
	}

	public void method_6()
	{
		if (int_2 > 0)
		{
			byte_0[int_1++] = (byte)uint_0;
			if (int_2 > 8)
			{
				byte_0[int_1++] = (byte)(uint_0 >> 8);
			}
		}
		uint_0 = 0u;
		int_2 = 0;
	}

	public void method_7(int int_3, int int_4)
	{
		uint_0 |= (uint)(int_3 << int_2);
		int_2 += int_4;
		if (int_2 >= 16)
		{
			byte_0[int_1++] = (byte)uint_0;
			byte_0[int_1++] = (byte)(uint_0 >> 8);
			uint_0 >>= 16;
			int_2 -= 16;
		}
	}

	public void method_8(int int_3)
	{
		byte_0[int_1++] = (byte)(int_3 >> 8);
		byte_0[int_1++] = (byte)int_3;
	}

	[SpecialName]
	public bool method_9()
	{
		return int_1 == 0;
	}

	public int method_10(byte[] byte_1, int int_3, int int_4)
	{
		if (int_2 >= 8)
		{
			byte_0[int_1++] = (byte)uint_0;
			uint_0 >>= 8;
			int_2 -= 8;
		}
		if (int_4 > int_1 - int_0)
		{
			int_4 = int_1 - int_0;
			Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
			int_0 = 0;
			int_1 = 0;
		}
		else
		{
			Array.Copy(byte_0, int_0, byte_1, int_3, int_4);
			int_0 += int_4;
		}
		return int_4;
	}

	public byte[] method_11()
	{
		byte[] array = new byte[int_1 - int_0];
		Array.Copy(byte_0, int_0, array, 0, array.Length);
		int_0 = 0;
		int_1 = 0;
		return array;
	}
}
