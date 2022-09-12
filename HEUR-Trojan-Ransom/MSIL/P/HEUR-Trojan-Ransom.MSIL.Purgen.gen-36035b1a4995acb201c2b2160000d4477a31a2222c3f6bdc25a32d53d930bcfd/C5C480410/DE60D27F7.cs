using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace C5C480410;

internal static class DE60D27F7
{
	internal static byte[] CFF28FBFF = Convert.FromBase64String("PwV2RkXm4sxj2pIGE/mZaoUNICV0we06nbF2YWVut2c=");

	internal static byte[] AAB9B024D = Convert.FromBase64String("wDMnNFsuREcS7GitGCrKFg==");

	internal static byte[] EC67E5C95(this byte[] D085B8A26)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = CFF28FBFF.Length * 8;
		rijndaelManaged.Key = CFF28FBFF;
		rijndaelManaged.BlockSize = AAB9B024D.Length * 8;
		rijndaelManaged.IV = AAB9B024D;
		using ICryptoTransform transform = rijndaelManaged.CreateDecryptor();
		using MemoryStream stream = new MemoryStream(D085B8A26);
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[D085B8A26.Length];
		int count = cryptoStream.Read(array, 0, D085B8A26.Length);
		return array.Take(count).ToArray();
	}
}
