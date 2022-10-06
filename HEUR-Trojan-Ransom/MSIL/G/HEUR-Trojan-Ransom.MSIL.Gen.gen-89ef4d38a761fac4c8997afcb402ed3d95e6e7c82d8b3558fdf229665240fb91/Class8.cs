using System.IO;

internal class Class8
{
	private uint uint_0 = 1u;

	public const uint uint_1 = 16777216u;

	public uint uint_2;

	public uint uint_3;

	public Stream stream_0;

	public void method_0(Stream stream_1)
	{
		stream_0 = stream_1;
		uint_3 = 0u;
		uint_2 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			uint_3 = (uint_3 << 8) | (byte)stream_0.ReadByte();
		}
	}

	public void method_1()
	{
		stream_0 = null;
	}

	public uint method_2(int int_0)
	{
		uint num = uint_2;
		uint num2 = uint_3;
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
		uint_2 = num;
		uint_3 = num2;
		return num3;
	}
}
