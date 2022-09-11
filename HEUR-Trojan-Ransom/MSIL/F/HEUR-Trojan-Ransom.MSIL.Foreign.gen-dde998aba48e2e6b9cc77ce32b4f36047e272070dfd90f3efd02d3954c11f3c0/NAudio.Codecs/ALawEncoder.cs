namespace NAudio.Codecs;

public static class ALawEncoder
{
	private const int cBias = 132;

	private const int cClip = 32635;

	private static readonly byte[] ALawCompressTable = new byte[128]
	{
		1, 1, 2, 2, 3, 3, 3, 3, 4, 4,
		4, 4, 4, 4, 4, 4, 5, 5, 5, 5,
		5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
		5, 5, 6, 6, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
		6, 6, 6, 6, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
		7, 7, 7, 7, 7, 7, 7, 7
	};

	public static byte LinearToALawSample(short sample)
	{
		int num = (~sample >> 8) & 0x80;
		if (num == 0)
		{
			sample = (short)(-sample);
		}
		if (sample > 32635)
		{
			sample = 32635;
		}
		byte b;
		if (sample >= 256)
		{
			int num2 = ALawCompressTable[(sample >> 8) & 0x7F];
			int num3 = (sample >> num2 + 3) & 0xF;
			b = (byte)((num2 << 4) | num3);
		}
		else
		{
			b = (byte)(sample >> 4);
		}
		return (byte)(b ^ (byte)((uint)num ^ 0x55u));
	}
}
