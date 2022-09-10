using System;
using System.Text;

public class GClass0
{
	public static byte[] XorDecrypt(byte[] byte_0, string string_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		int num = Convert.ToInt32(byte_0[^1] ^ 0x70);
		byte[] array = new byte[byte_0.Length + 1];
		int num2 = 0;
		for (int i = 0; i <= byte_0.Length - 1; i++)
		{
			array[i] = Convert.ToByte(byte_0[i] ^ num ^ bytes[num2]);
			num2 = ((num2 != string_0.Length - 1) ? (num2 + 1) : 0);
		}
		Array.Resize(ref array, byte_0.Length - 2 + 1);
		return array;
	}
}
