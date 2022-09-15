namespace upd;

internal class Helper
{
	public static byte[] dfsfupd(byte[] data, byte[] key)
	{
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[data.Length];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = key[i % key.Length];
			array2[i] = i;
		}
		i = 0;
		int num = 0;
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			int num2 = array2[i];
			array2[i] = array2[num];
			array2[num] = num2;
		}
		i = 0;
		num = 0;
		int num3 = 0;
		for (; i < data.Length; i++)
		{
			num3++;
			num3 %= 256;
			num += array2[num3];
			num %= 256;
			int num2 = array2[num3];
			array2[num3] = array2[num];
			array2[num] = num2;
			int num4 = array2[(array2[num3] + array2[num]) % 256];
			array3[i] = (byte)(data[i] ^ num4);
		}
		return array3;
	}
}
