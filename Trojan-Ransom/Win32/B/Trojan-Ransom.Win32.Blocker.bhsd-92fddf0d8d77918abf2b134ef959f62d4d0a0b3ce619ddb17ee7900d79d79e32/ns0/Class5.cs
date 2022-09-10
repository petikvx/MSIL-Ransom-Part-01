using System.IO;

namespace ns0;

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

	public uint method_2(int int_0)
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
}
