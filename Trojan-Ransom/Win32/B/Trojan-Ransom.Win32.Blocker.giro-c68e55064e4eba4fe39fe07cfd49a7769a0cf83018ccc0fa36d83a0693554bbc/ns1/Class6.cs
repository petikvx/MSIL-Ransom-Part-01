using System.IO;
using ns3;
using ns4;

namespace ns1;

internal class Class6
{
	public const uint uint_0 = 16777216u;

	public uint uint_1;

	public uint uint_2;

	public Stream stream_0;

	public void method_0(Stream stream_1)
	{
		stream_0 = stream_1;
		uint_2 = 0u;
		uint_1 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			uint_2 = (uint_2 << 8) | (byte)Class17.smethod_19(stream_0, 39689);
		}
	}

	public void method_1()
	{
		stream_0 = null;
	}

	public void method_2()
	{
		Class18.smethod_2(stream_0, 35274);
	}

	public void method_3()
	{
		while (uint_1 < 16777216)
		{
			uint_2 = (uint_2 << 8) | (byte)Class17.smethod_19(stream_0, 39689);
			uint_1 <<= 8;
		}
	}

	public void method_4()
	{
		if (uint_1 < 16777216)
		{
			uint_2 = (uint_2 << 8) | (byte)Class17.smethod_19(stream_0, 39689);
			uint_1 <<= 8;
		}
	}

	public uint method_5(uint uint_3)
	{
		return uint_2 / (uint_1 /= uint_3);
	}

	public void method_6(uint uint_3, uint uint_4, uint uint_5)
	{
		uint_2 -= uint_3 * uint_1;
		uint_1 *= uint_4;
		method_3();
	}

	public uint method_7(int int_0)
	{
		uint num = uint_1;
		uint num2 = uint_2;
		uint num3 = 0u;
		for (int num4 = int_0; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)Class17.smethod_19(stream_0, 39689);
				num <<= 8;
			}
		}
		uint_1 = num;
		uint_2 = num2;
		return num3;
	}

	public uint method_8(uint uint_3, int int_0)
	{
		uint num = (uint_1 >> int_0) * uint_3;
		uint result;
		if (uint_2 < num)
		{
			result = 0u;
			uint_1 = num;
		}
		else
		{
			result = 1u;
			uint_2 -= num;
			uint_1 -= num;
		}
		method_3();
		return result;
	}
}
