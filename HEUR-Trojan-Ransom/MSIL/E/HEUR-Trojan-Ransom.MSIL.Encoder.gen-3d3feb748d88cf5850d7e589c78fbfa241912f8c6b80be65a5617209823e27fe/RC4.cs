public class RC4
{
	public static byte[] Encrypt(byte[] x0x0x0, byte[] fsdfdsdfds)
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[fsdfdsdfds.Length];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = x0x0x0[i % x0x0x0.Length];
			array2[i] = i;
		}
		int num = (i = 0);
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			int num2 = array2[i];
			array2[i] = array2[num];
			array2[num] = num2;
		}
		int num3 = (num = (i = 0));
		for (; i < fsdfdsdfds.Length; i++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[i] = (byte)(fsdfdsdfds[i] ^ num4);
		}
		return array3;
	}
}
