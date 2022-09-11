namespace ns3;

internal class Class8
{
	public class Class9
	{
		public short[] short_0;

		public short[] short_1;

		public byte[] byte_0;

		public int[] int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		internal Class8 class8_0;

		public Class9(Class8 class8_1, int int_4, int int_5, int int_6)
		{
			class8_0 = class8_1;
			int_1 = int_5;
			int_3 = int_6;
			checked
			{
				short_0 = new short[(uint)int_4];
				int_0 = new int[(uint)int_6];
			}
		}
	}

	internal static int int_0;

	internal static int int_1;

	internal static int int_2;

	private static int int_3;

	internal static int int_4;

	internal static int int_5;

	internal static int int_6;

	internal static int int_7;

	internal static int[] int_8;

	internal static byte[] byte_0;

	public Class11 class11_0;

	internal Class9 class9_0;

	internal Class9 class9_1;

	internal Class9 class9_2;

	internal short[] short_0;

	internal byte[] byte_1;

	internal int int_9;

	internal int int_10;

	internal static short[] short_1;

	internal static byte[] byte_2;

	internal static short[] short_2;

	internal static byte[] byte_3;

	static Class8()
	{
		int_0 = 16384;
		int_1 = 286;
		int_2 = 30;
		int_3 = 19;
		int_4 = 16;
		int_5 = 17;
		int_6 = 18;
		int_7 = 256;
		int_8 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
		byte_0 = new byte[16]
		{
			0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
			5, 13, 3, 11, 7, 15
		};
		int num;
		checked
		{
			short_1 = new short[(uint)int_1];
			byte_2 = new byte[(uint)int_1];
			num = 0;
		}
		while (num < 144)
		{
			short_1[num] = Class33.smethod_19(48 + num << 8);
			byte_2[num++] = 8;
		}
		while (num < 256)
		{
			short_1[num] = Class33.smethod_19(256 + num << 7);
			byte_2[num++] = 9;
		}
		while (num < 280)
		{
			short_1[num] = Class33.smethod_19(-256 + num << 9);
			byte_2[num++] = 7;
		}
		while (num < int_1)
		{
			short_1[num] = Class33.smethod_19(-88 + num << 8);
			byte_2[num++] = 8;
		}
		checked
		{
			short_2 = new short[(uint)int_2];
			byte_3 = new byte[(uint)int_2];
		}
		for (num = 0; num < int_2; num++)
		{
			short_2[num] = Class33.smethod_19(num << 11);
			byte_3[num] = 5;
		}
	}

	public Class8(Class11 class11_1)
	{
		class11_0 = class11_1;
		class9_0 = new Class9(this, int_1, 257, 15);
		class9_1 = new Class9(this, int_2, 1, 15);
		class9_2 = new Class9(this, int_3, 4, 7);
		checked
		{
			short_0 = new short[(uint)int_0];
			byte_1 = new byte[(uint)int_0];
		}
	}
}
