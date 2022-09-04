using System;

namespace Chrome;

public class 攘祛薄腋
{
	private int 入幄中而闻酒臭;

	public 攘祛薄腋(int k = 10)
	{
		入幄中而闻酒臭 = k;
	}

	public byte[] Decrypt(byte[] g, byte[] key)
	{
		checked
		{
			byte[] array = new byte[g.Length - 入幄中而闻酒臭 - 1 + 1];
			byte[] array2 = new byte[入幄中而闻酒臭 - 1 + 1];
			Buffer.BlockCopy(g, g.Length - 入幄中而闻酒臭, array2, 0, 入幄中而闻酒臭);
			Array.Resize(ref g, g.Length - 入幄中而闻酒臭);
			int num = g.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				array[num2] = unchecked((byte)(g[num2] ^ key[num2 % key.Length] ^ array2[num2 % array2.Length]));
				num2++;
			}
			return array;
		}
	}
}
