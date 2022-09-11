namespace ReportGenerator;

public class Alphabet
{
	private static byte[] CharToWordByte(char c)
	{
		char c2 = 'А';
		while (true)
		{
			if (c2 <= 'я')
			{
				if (c2 == c)
				{
					break;
				}
				c2 = (char)(c2 + 1);
				continue;
			}
			return new byte[2]
			{
				(byte)c,
				0
			};
		}
		return new byte[2]
		{
			(byte)(c2 - 1024),
			4
		};
	}

	public static byte[] ConvertStringToWordBytes(string input)
	{
		char[] array = input.ToCharArray();
		byte[] array2 = new byte[input.Length * 2];
		for (int i = 0; i < array.Length * 2; i += 2)
		{
			byte[] array3 = CharToWordByte(array[i / 2]);
			array2[i] = array3[0];
			array2[i + 1] = array3[1];
		}
		char[] array4 = input.ToCharArray();
		for (int j = 0; j < array4.Length; j++)
		{
		}
		return array2;
	}

	private static char DecodeWordChar(byte[] b)
	{
		if (b[1] == 4)
		{
			byte b2 = 16;
			while (true)
			{
				if (b2 <= 79)
				{
					if (b[0] == b2)
					{
						break;
					}
					b2 = (byte)(b2 + 1);
					continue;
				}
				return ' ';
			}
			return (char)(b2 + 1024);
		}
		return (char)b[0];
	}

	public static string DecodeWordString(byte[] b)
	{
		string text = "";
		for (int i = 0; i < b.Length; i += 2)
		{
			text += DecodeWordChar(new byte[2]
			{
				b[i],
				b[i + 1]
			});
		}
		return text.Trim();
	}
}
