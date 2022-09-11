namespace ns0;

internal sealed class Class3
{
	public static byte smethod_0(byte[] byte_0, byte[] byte_1, int int_0)
	{
		return (byte)(byte_0[int_0] ^ byte_1[int_0 % byte_1.Length]);
	}
}
