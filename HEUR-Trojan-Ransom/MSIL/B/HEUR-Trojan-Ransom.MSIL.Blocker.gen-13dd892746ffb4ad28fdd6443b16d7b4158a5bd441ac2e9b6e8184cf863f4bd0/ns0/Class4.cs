namespace ns0;

internal sealed class Class4
{
	public static void smethod_0(byte[] byte_0, int int_0)
	{
		for (int i = 0; i < byte_0.Length; i++)
		{
			byte_0[i] ^= Class2.smethod_4(int_0, i);
		}
	}
}
