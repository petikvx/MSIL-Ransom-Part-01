using System;

namespace ns3;

internal class Class14
{
	internal static int int_0;

	internal short[] short_0;

	public static Class14 class14_0;

	public static Class14 class14_1;

	static Class14()
	{
		int_0 = 15;
		try
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			class14_0 = new Class14(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class14_1 = new Class14(array);
		}
		catch (Exception)
		{
			throw new ApplicationException("InflaterHuffmanTree: static tree length illegal");
		}
	}

	public Class14(byte[] byte_0)
	{
		Class33.smethod_112(this, byte_0);
	}
}
