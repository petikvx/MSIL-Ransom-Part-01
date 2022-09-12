using System.Text;

namespace AES_EnDecryptor.Basement;

public class Security
{
	public static byte[] IV => new byte[16]
	{
		33, 53, 81, 123, 144, 205, 26, 223, 44, 21,
		18, 151, 154, 162, 124, 215
	};

	private static byte[] Key => new byte[32]
	{
		1, 83, 37, 7, 145, 17, 119, 25, 97, 54,
		84, 167, 185, 22, 86, 10, 8, 83, 37, 15,
		145, 31, 120, 217, 98, 58, 93, 247, 25, 21,
		86, 4
	};

	public static byte[] GetKey(string key)
	{
		byte[] array = new byte[16];
		if (string.IsNullOrEmpty(key))
		{
			return Key;
		}
		byte[] bytes = Encoding.ASCII.GetBytes(key);
		for (int i = 0; i < 16; i++)
		{
			if (bytes.Length > i)
			{
				array[i] = bytes[i];
			}
			else
			{
				array[i] = Key[i];
			}
		}
		return array;
	}
}
