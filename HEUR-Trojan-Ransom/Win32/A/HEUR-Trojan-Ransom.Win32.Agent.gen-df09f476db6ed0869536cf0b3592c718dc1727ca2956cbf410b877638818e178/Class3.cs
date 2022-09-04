using System.Text;

internal class Class3
{
	public static void smethod_0(ref byte[] byte_0, string string_0)
	{
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes[i % bytes.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < byte_0.GetLength(0); j++)
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			byte b = array[i];
			array[i] = array[num];
			array[num] = b;
			int num2 = (array[i] + array[num]) % 256;
			byte_0[j] ^= array[num2];
		}
	}

	public Class3()
	{
		Class51.smethod_0();
		base._002Ector();
	}
}
