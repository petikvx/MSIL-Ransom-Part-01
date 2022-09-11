using System.IO;

namespace x;

internal sealed class S : InternalBufferOverflowException
{
	internal static byte smethod_0(byte[] byte_0, int int_0)
	{
		return (byte)(byte_0[int_0] ^ N.byte_0[int_0 % N.byte_0.Length]);
	}
}
