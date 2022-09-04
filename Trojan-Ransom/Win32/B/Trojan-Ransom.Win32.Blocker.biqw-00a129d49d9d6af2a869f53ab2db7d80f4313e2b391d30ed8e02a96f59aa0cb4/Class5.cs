using System.IO;

internal sealed class Class5
{
	public uint uint_0;

	public uint uint_1;

	public Stream stream_0;

	public void method_0(Stream stream_1)
	{
		stream_0 = stream_1;
		uint_1 = 0u;
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			uint_1 = (uint_1 << 8) | (byte)stream_0.ReadByte();
		}
	}

	public void method_1()
	{
		stream_0 = null;
	}

	public void method_2()
	{
		stream_0.Close();
	}

	public void method_3()
	{
		while (uint_0 < 16777216)
		{
			uint_1 = (uint_1 << 8) | (byte)stream_0.ReadByte();
			uint_0 <<= 8;
		}
	}

	public void method_4()
	{
		if (uint_0 < 16777216)
		{
			uint_1 = (uint_1 << 8) | (byte)stream_0.ReadByte();
			uint_0 <<= 8;
		}
	}

	public uint method_5(uint uint_2)
	{
		return uint_1 / (uint_0 /= uint_2);
	}

	public void method_6(uint uint_2, uint uint_3, uint uint_4)
	{
		uint_1 -= uint_2 * uint_0;
		uint_0 *= uint_3;
		method_3();
	}

	public uint method_7(int int_0)
	{
		uint num = uint_0;
		uint num2 = uint_1;
		uint num3 = 0u;
		for (int num4 = int_0; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)stream_0.ReadByte();
				num <<= 8;
			}
		}
		uint_0 = num;
		uint_1 = num2;
		return num3;
	}

	public uint method_8(uint uint_2, int int_0)
	{
		uint num = (uint_0 >> int_0) * uint_2;
		uint result;
		if (uint_1 < num)
		{
			result = 0u;
			uint_0 = num;
		}
		else
		{
			result = 1u;
			uint_1 -= num;
			uint_0 -= num;
		}
		method_3();
		return result;
	}
}
