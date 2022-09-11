using System;

internal class Class5
{
	private Random[] random_0 = new Random[2];

	public Class5(int int_0, int int_1)
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
			int num2;
			int num3;
			if (num < byte_0.Length)
			{
				num2 = 95616937;
				num3 = 95616937;
			}
			else
			{
				num2 = -670405108;
				num3 = -670405108;
			}
			while (true)
			{
				int num4 = num2;
				switch ((uint)(~((-(num4 * -791408237) ^ -1103282710) - 1803256900 - 2142474713 + 23256796)) % 4u)
				{
				case 1u:
					array[num] = (byte)(byte_0[num] ^ (byte)((byte)random_0[0].Next() ^ (byte)random_0[1].Next()));
					num++;
					num2 = 1710251587;
					continue;
				case 0u:
					num2 = 95616937;
					continue;
				case 3u:
					break;
				default:
					return array;
				}
				break;
			}
		}
	}
}
