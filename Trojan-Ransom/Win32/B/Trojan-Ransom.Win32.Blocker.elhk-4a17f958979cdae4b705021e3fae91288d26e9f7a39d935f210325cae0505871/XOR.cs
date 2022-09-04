using System;
using System.Text;

public class XOR
{
	public static byte[] XorDecrypt(byte[] PM, string KHJ)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(KHJ);
		int num = Convert.ToInt32(PM[^1] ^ 0x70);
		byte[] array = new byte[PM.Length + 1];
		int num2 = 0;
		for (int i = 0; i <= PM.Length - 1; i++)
		{
			array[i] = Convert.ToByte(PM[i] ^ num ^ bytes[num2]);
			num2 = ((num2 != KHJ.Length - 1) ? (num2 + 1) : 0);
		}
		Array.Resize(ref array, PM.Length - 2 + 1);
		return array;
	}
}
