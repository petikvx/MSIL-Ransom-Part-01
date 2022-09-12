using System.IO;
using System.Security.Cryptography;

namespace ns1;

internal sealed class Class0
{
	internal static MemoryStream e = new MemoryStream();

	internal static CryptoStream smethod_0(ICryptoTransform icryptoTransform_0)
	{
		return new CryptoStream(e, icryptoTransform_0, CryptoStreamMode.Write);
	}

	internal static TripleDES smethod_1(string string_0)
	{
		if (string_0 == null)
		{
			return null;
		}
		return smethod_2(string_0) as TripleDES;
	}

	internal static object smethod_2(string string_0)
	{
		return CryptoConfig.CreateFromName(string_0, null);
	}
}
