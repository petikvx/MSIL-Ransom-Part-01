using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using ns5;

namespace ns2;

internal sealed class Class0 : AppDomainManager
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 124)]
	private struct Struct0
	{
	}

	private static readonly Array H;

	private static readonly Array m = new char[62];

	private static readonly object G;

	internal static byte E/* Not supported: data(00) */;

	internal static byte[] smethod_0(byte[] byte_0, Aes aes_0)
	{
		using ICryptoTransform icryptoTransform_ = aes_0.CreateDecryptor(aes_0.Key, aes_0.IV);
		return GClass1.smethod_0(byte_0, icryptoTransform_);
	}

	static Class0()
	{
		char[] array = new char[8];
		array[4] = 'ↅ';
		array[0] = 'ӗ';
		array[1] = '\u07ec';
		array[5] = '㘠';
		array[2] = '㽘';
		array[3] = '㩂';
		array[6] = '⾺';
		array[7] = '⅞';
		G = new string[4];
		H = array;
	}
}
