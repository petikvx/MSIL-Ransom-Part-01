namespace ns0;

internal sealed class Class9
{
	internal static void smethod_0(byte[] byte_0, int int_0)
	{
		Class2.byte_0[int_0] = (byte)(Class2.byte_0[int_0] ^ byte_0[int_0 % byte_0.Length]);
	}
}
