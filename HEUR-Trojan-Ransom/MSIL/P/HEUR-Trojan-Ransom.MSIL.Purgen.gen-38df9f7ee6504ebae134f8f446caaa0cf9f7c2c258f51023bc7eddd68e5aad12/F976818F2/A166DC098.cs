using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace F976818F2;

internal static class A166DC098
{
	internal static byte[] E2929844E = Convert.FromBase64String("Izr+3ou5nVenOzAe+HQMYTSzbLbhSB7oXKf0wGfEv/8=");

	internal static byte[] E9E8C742F = Convert.FromBase64String("NXCIOIAWiXzCcoc/ti7iqw==");

	internal static byte[] F4431A863(this byte[] C0EDD824A)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = E2929844E.Length * 8;
		rijndaelManaged.Key = E2929844E;
		rijndaelManaged.BlockSize = E9E8C742F.Length * 8;
		rijndaelManaged.IV = E9E8C742F;
		using ICryptoTransform transform = rijndaelManaged.CreateDecryptor();
		using MemoryStream stream = new MemoryStream(C0EDD824A);
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		byte[] array = new byte[C0EDD824A.Length];
		int count = cryptoStream.Read(array, 0, C0EDD824A.Length);
		return array.Take(count).ToArray();
	}
}
