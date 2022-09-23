using System.Text;

internal static class CryptoHelper
{
	public static byte[] EncryptXor(byte[] input, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		byte[] array = new byte[input.Length];
		for (int i = 0; i < input.Length; i++)
		{
			array[i] = (byte)(input[i] ^ bytes[i % bytes.Length]);
		}
		return array;
	}
}
