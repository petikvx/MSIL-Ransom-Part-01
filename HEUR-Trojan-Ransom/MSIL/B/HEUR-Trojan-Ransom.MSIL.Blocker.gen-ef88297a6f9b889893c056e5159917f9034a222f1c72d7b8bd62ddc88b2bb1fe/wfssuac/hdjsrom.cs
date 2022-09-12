using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using nclou;
using vsvzs;

namespace wfssuac;

internal sealed class hdjsrom : MethodBody
{
	internal static byte[] X = new byte[48]
	{
		13, 34, 80, 62, 127, 115, 133, 142, 81, 8,
		43, 116, 22, 6, 35, 45, 59, 15, 29, 67,
		120, 20, 121, 16, 69, 128, 3, 75, 94, 84,
		63, 93, 76, 18, 110, 105, 132, 33, 21, 1,
		28, 38, 82, 101, 122, 46, 2, 54
	};

	internal static byte[] B = new byte[48]
	{
		62, 106, 61, 70, 80, 96, 74, 16, 117, 88,
		29, 65, 118, 72, 125, 71, 107, 4, 41, 6,
		78, 2, 111, 94, 55, 115, 59, 87, 39, 114,
		92, 102, 60, 98, 38, 45, 89, 122, 91, 54,
		141, 101, 63, 75, 112, 17, 64, 7
	};

	internal static byte[] T(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, byte_2, 32768);
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		using MemoryStream memoryStream = new MemoryStream();
		new wlqzy(memoryStream, aes.CreateDecryptor(), gwdjc.Write, bool_0: true).O(byte_0, 0, byte_0.Length);
		return memoryStream.ToArray();
	}
}
