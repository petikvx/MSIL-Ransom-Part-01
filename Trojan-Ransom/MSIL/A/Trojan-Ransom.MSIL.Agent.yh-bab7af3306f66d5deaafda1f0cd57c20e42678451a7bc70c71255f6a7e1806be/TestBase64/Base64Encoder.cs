namespace TestBase64;

public class Base64Encoder
{
	private byte[] source;

	private int length;

	private int length2;

	private int blockCount;

	private int paddingCount;

	public Base64Encoder(byte[] input)
	{
		source = input;
		length = input.Length;
		if (length % 3 == 0)
		{
			paddingCount = 0;
			blockCount = length / 3;
		}
		else
		{
			paddingCount = 3 - length % 3;
			blockCount = (length + paddingCount) / 3;
		}
		length2 = length + paddingCount;
	}

	public char[] GetEncoded()
	{
		byte[] array = new byte[length2];
		for (int i = 0; i < length2; i++)
		{
			if (i < length)
			{
				array[i] = source[i];
			}
			else
			{
				array[i] = 0;
			}
		}
		byte[] array2 = new byte[blockCount * 4];
		char[] array3 = new char[blockCount * 4];
		for (int i = 0; i < blockCount; i++)
		{
			byte b = array[i * 3];
			byte b2 = array[i * 3 + 1];
			byte b3 = array[i * 3 + 2];
			byte b4 = (byte)((b & 0xFC) >> 2);
			byte b5 = (byte)((b & 3) << 4);
			byte b6 = (byte)((b2 & 0xF0) >> 4);
			b6 = (byte)(b6 + b5);
			b5 = (byte)((b2 & 0xF) << 2);
			byte b7 = (byte)((b3 & 0xC0) >> 6);
			b7 = (byte)(b7 + b5);
			byte b8 = (byte)(b3 & 0x3Fu);
			array2[i * 4] = b4;
			array2[i * 4 + 1] = b6;
			array2[i * 4 + 2] = b7;
			array2[i * 4 + 3] = b8;
		}
		for (int i = 0; i < blockCount * 4; i++)
		{
			array3[i] = sixbit2char(array2[i]);
		}
		switch (paddingCount)
		{
		case 1:
			array3[blockCount * 4 - 1] = '=';
			break;
		case 2:
			array3[blockCount * 4 - 1] = '=';
			array3[blockCount * 4 - 2] = '=';
			break;
		}
		return array3;
	}

	private char sixbit2char(byte b)
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
		if (b >= 0 && b <= 63)
		{
			return array[b];
		}
		return ' ';
	}
}
