using System.IO;
using ns4;

namespace ns1;

internal class Class5
{
	public const uint uint_0 = 16777216u;

	private Stream stream_0;

	public ulong ulong_0;

	public uint uint_1;

	private uint uint_2;

	private byte byte_0;

	private long long_0;

	public void method_0(Stream stream_1)
	{
		stream_0 = stream_1;
	}

	public void method_1()
	{
		stream_0 = null;
	}

	public void method_2()
	{
		long_0 = Class18.smethod_1(stream_0, 18514);
		ulong_0 = 0uL;
		uint_1 = uint.MaxValue;
		uint_2 = 1u;
		byte_0 = 0;
	}

	public void method_3()
	{
		for (int i = 0; i < 5; i++)
		{
			method_7();
		}
	}

	public void method_4()
	{
		Class18.smethod_2(stream_0, 35275);
	}

	public void method_5()
	{
		Class18.smethod_2(stream_0, 35274);
	}

	public void method_6(uint uint_3, uint uint_4, uint uint_5)
	{
		ulong_0 += uint_3 * (uint_1 /= uint_5);
		uint_1 *= uint_4;
		while (uint_1 < 16777216)
		{
			uint_1 <<= 8;
			method_7();
		}
	}

	public void method_7()
	{
		if ((uint)ulong_0 < 4278190080u || (int)(ulong_0 >> 32) == 1)
		{
			byte b = byte_0;
			do
			{
				Class18.smethod_3(stream_0, (byte)(b + (ulong_0 >> 32)), 1150);
				b = byte.MaxValue;
			}
			while (--uint_2 != 0);
			byte_0 = (byte)((uint)ulong_0 >> 24);
		}
		uint_2++;
		ulong_0 = (uint)((int)ulong_0 << 8);
	}

	public void method_8(uint uint_3, int int_0)
	{
		for (int num = int_0 - 1; num >= 0; num--)
		{
			uint_1 >>= 1;
			if (((uint_3 >> num) & 1) == 1)
			{
				ulong_0 += uint_1;
			}
			if (uint_1 < 16777216)
			{
				uint_1 <<= 8;
				method_7();
			}
		}
	}

	public void method_9(uint uint_3, int int_0, uint uint_4)
	{
		uint num = (uint_1 >> int_0) * uint_3;
		if (uint_4 == 0)
		{
			uint_1 = num;
		}
		else
		{
			ulong_0 += num;
			uint_1 -= num;
		}
		while (uint_1 < 16777216)
		{
			uint_1 <<= 8;
			method_7();
		}
	}

	public long method_10()
	{
		return uint_2 + Class18.smethod_1(stream_0, 18514) - long_0 + 4L;
	}
}
