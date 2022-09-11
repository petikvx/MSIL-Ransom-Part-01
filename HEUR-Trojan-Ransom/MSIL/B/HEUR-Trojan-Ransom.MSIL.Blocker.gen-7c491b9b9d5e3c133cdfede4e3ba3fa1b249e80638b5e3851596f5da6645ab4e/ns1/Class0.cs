using System.Security.Cryptography;

namespace ns1;

internal sealed class Class0
{
	internal static TripleDES smethod_0(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		return smethod_1(string_0) as TripleDES;
	}

	internal static object smethod_1(string string_0)
	{
		return CryptoConfig.CreateFromName(string_0, null);
	}
}
