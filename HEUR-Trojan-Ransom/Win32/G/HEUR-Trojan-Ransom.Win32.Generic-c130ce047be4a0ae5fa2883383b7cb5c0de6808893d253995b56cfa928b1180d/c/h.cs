using System.Security.Cryptography;

namespace c;

internal sealed class h
{
	public static SymmetricAlgorithm g(string string_0)
	{
		Rijndael rijndael = t.b(378, 311);
		DeriveBytes deriveBytes = h.smethod_0(string_0, y.h, 32768);
		d.g(rijndael, (Rfc2898DeriveBytes)deriveBytes);
		return rijndael;
	}

	static Rfc2898DeriveBytes smethod_0(string string_0, byte[] byte_0, int int_0)
	{
		return new Rfc2898DeriveBytes(string_0, byte_0, int_0);
	}
}
