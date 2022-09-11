public class GClass2 : GClass1
{
	public static byte[] smethod_0()
	{
		for (int num = GClass1.byte_0.Length * 2 + GClass1.byte_1.Length; num >= 0; num--)
		{
			GClass1.byte_0[num % GClass1.byte_0.Length] = (byte)(((GClass1.byte_0[num % GClass1.byte_0.Length] ^ GClass1.byte_1[num % GClass1.byte_1.Length]) - GClass1.byte_0[(num + 1) % GClass1.byte_0.Length] + 256) % 256);
		}
		return GClass1.byte_0;
	}
}
