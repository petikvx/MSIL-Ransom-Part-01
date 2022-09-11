using System;

internal class Class4
{
	private Random[] random_0 = new Random[2];

	public Class4(int int_0, int int_1)
	{
		random_0[0] = new Random(int_0);
		random_0[1] = new Random(int_1);
	}

	public byte[] method_0(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length];
		int num = 0;
		while (true)
		{
			int num2 = -1511997007;
			while (true)
			{
				int num3 = num2;
				uint num4;
				switch ((num4 = (uint)((~(num3 ^ -1975735355) - -1831372556 + -109159684) * 1564313259)) % 6u)
				{
				case 5u:
				{
					int num5;
					if (num < byte_0.Length)
					{
						num2 = 345206481;
						num5 = 345206481;
					}
					else
					{
						num2 = 474111548;
						num5 = 474111548;
					}
					continue;
				}
				case 3u:
					num2 = (int)(num4 * 1373547942) ^ -717817943;
					continue;
				case 2u:
					num++;
					num2 = ((int)num4 * -519468154) ^ -1169586789;
					continue;
				case 1u:
					array[num] = (byte)(byte_0[num] ^ (byte)((byte)random_0[0].Next() ^ (byte)random_0[1].Next()));
					num2 = 1457335752;
					continue;
				case 0u:
					break;
				default:
					return array;
				}
				break;
			}
		}
	}

	public int method_1(int int_0)
	{
		return random_0[0].Next() * int_0 % 256;
	}
}
