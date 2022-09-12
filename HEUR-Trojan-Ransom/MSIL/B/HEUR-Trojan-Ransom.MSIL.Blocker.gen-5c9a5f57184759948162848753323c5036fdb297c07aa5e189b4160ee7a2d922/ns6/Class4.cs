using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace ns6;

internal sealed class Class4
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 184)]
	private struct Struct0
	{
	}

	private static readonly Array g;

	private static readonly Array H = new char[92];

	private static readonly object o;

	internal static byte j/* Not supported: data(00) */;

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

	static Class4()
	{
		char[] array = new char[8];
		array[2] = 'Ổ';
		array[4] = '\u07f1';
		array[0] = '㟒';
		array[7] = '☽';
		array[1] = '⋆';
		array[3] = '\u197f';
		array[6] = '\u0a81';
		array[5] = '。';
		o = new string[5];
		g = array;
	}
}
