using System.IO;

internal class _1C435DF5
{
	private uint _4B8F69D4 = 1u;

	public const uint _6C0A788A = 16777216u;

	public uint _5B141704;

	public uint _05792C7C;

	public Stream _14BC66D2;

	public void _382E08CA(Stream _24F82E4D)
	{
		_14BC66D2 = _24F82E4D;
		_05792C7C = 0u;
		_5B141704 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			_05792C7C = (_05792C7C << 8) | (byte)_14BC66D2.ReadByte();
		}
	}

	public void _018F7E21()
	{
		_14BC66D2 = null;
	}

	public uint _1FB5514D(int _0C402FC5)
	{
		uint num = _5B141704;
		uint num2 = _05792C7C;
		uint num3 = 0u;
		for (int num4 = _0C402FC5; num4 > 0; num4--)
		{
			num >>= 1;
			uint num5 = num2 - num >> 31;
			num2 -= num & (num5 - 1);
			num3 = (num3 << 1) | (1 - num5);
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)_14BC66D2.ReadByte();
				num <<= 8;
			}
		}
		_5B141704 = num;
		_05792C7C = num2;
		return num3;
	}
}
