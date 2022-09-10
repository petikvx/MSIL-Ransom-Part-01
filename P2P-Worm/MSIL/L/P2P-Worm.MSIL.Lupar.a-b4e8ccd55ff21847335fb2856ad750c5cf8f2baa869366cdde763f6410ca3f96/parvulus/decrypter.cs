namespace parvulus;

public class decrypter
{
	private char[] source;

	private int length;

	private int length2;

	private int length3;

	private int blockCount;

	private int paddingCount;

	public decrypter(char[] input)
	{
		int num = 0;
		source = input;
		length = input.Length;
		for (int i = 0; i < 2; i++)
		{
			if (input[length - i - 1] == '=')
			{
				num++;
			}
		}
		paddingCount = num;
		blockCount = length / 4;
		length2 = blockCount * 3;
	}

	public byte[] GetDecoded()
	{
		byte[] array = new byte[length];
		byte[] array2 = new byte[length2];
		for (int i = 0; i < length; i++)
		{
			array[i] = char2sixbit(source[i]);
		}
		for (int j = 0; j < blockCount; j++)
		{
			byte b = array[j * 4];
			byte b2 = array[j * 4 + 1];
			byte b3 = array[j * 4 + 2];
			byte b4 = array[j * 4 + 3];
			byte b5 = (byte)(b << 2);
			byte b6 = (byte)((b2 & 0x30) >> 4);
			b6 = (byte)(b6 + b5);
			b5 = (byte)((b2 & 0xF) << 4);
			byte b7 = (byte)((b3 & 0x3C) >> 2);
			b7 = (byte)(b7 + b5);
			b5 = (byte)((b3 & 3) << 6);
			byte b8 = b4;
			b8 = (byte)(b8 + b5);
			array2[j * 3] = b6;
			array2[j * 3 + 1] = b7;
			array2[j * 3 + 2] = b8;
		}
		length3 = length2 - paddingCount;
		byte[] array3 = new byte[length3];
		for (int k = 0; k < length3; k++)
		{
			array3[k] = array2[k];
		}
		return array3;
	}

	private byte char2sixbit(char c)
	{
		char[] array = new char[64]
		{
			'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
			'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
			'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd',
			'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
			'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
			'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7',
			'8', '9', '+', '/'
		};
		if (c == '=')
		{
			return 0;
		}
		int num = 0;
		while (true)
		{
			if (num < 64)
			{
				if (array[num] == c)
				{
					break;
				}
				num++;
				continue;
			}
			return 0;
		}
		return (byte)num;
	}
}
