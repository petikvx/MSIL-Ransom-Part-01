using System.IO;

namespace d;

internal sealed class g : InternalBufferOverflowException
{
	internal sealed class Q
	{
	}

	internal static byte smethod_0(byte[] byte_0, int int_0)
	{
		return (byte)(byte_0[int_0] ^ r.byte_0[int_0 % r.byte_0.Length]);
	}
}
