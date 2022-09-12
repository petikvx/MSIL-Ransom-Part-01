using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using ns1;
using ns2;

namespace ns7;

internal sealed class Class3
{
	[DllImport("WindowsCodecs.dll")]
	internal static extern int IWICStream_InitializeFromMemory_Proxy(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	public static Aes smethod_0(string string_0)
	{
		if (string_0 == null)
		{
			throw new ArgumentNullException("algorithmName");
		}
		return smethod_2(string_0) as Aes;
	}

	internal static byte[] smethod_1(byte[] byte_0)
	{
		byte[] byte_ = new byte[16]
		{
			199, 13, 141, 219, 87, 129, 246, 167, 25, 111,
			240, 238, 161, 38, 23, 154
		};
		using Aes aes_ = smethod_0("AES");
		if (GClass0.smethod_0(aes_, byte_, out var byte_2))
		{
			return byte_2;
		}
		return Class0.smethod_0(byte_0, aes_);
	}

	public static object smethod_2(string string_0)
	{
		return CryptoConfig.CreateFromName(string_0, null);
	}
}
