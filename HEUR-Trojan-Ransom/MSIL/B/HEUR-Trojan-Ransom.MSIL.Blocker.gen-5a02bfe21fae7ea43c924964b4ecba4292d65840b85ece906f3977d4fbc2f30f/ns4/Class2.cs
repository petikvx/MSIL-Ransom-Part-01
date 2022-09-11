using System.Security.Cryptography;

namespace ns4;

internal sealed class Class2
{
	internal static Rijndael smethod_0(string string_0)
	{
		if (string_0 != null)
		{
			return smethod_1(string_0) as Rijndael;
		}
		return null;
	}

	internal static object smethod_1(string string_0)
	{
		return CryptoConfig.CreateFromName(string_0, null);
	}
}
