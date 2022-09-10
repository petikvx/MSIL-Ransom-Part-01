using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace QQCaptor.Tools;

public class SymmetricMethod
{
	private SymmetricAlgorithm mobjCryptoService;

	private string Key;

	public SymmetricMethod()
	{
		mobjCryptoService = new RijndaelManaged();
		Key = "lijianfufaicaixiaoke";
	}

	private byte[] GetLegalKey()
	{
		string text = Key;
		mobjCryptoService.GenerateKey();
		byte[] key = mobjCryptoService.Key;
		int num = key.Length;
		if (text.Length > num)
		{
			text = text.Substring(0, num);
		}
		else if (text.Length < num)
		{
			text = text.PadRight(num, ' ');
		}
		return Encoding.ASCII.GetBytes(text);
	}

	private byte[] GetLegalIV()
	{
		string text = "caoxiaokeailijianfu";
		mobjCryptoService.GenerateIV();
		byte[] iV = mobjCryptoService.IV;
		int num = iV.Length;
		if (text.Length > num)
		{
			text = text.Substring(0, num);
		}
		else if (text.Length < num)
		{
			text = text.PadRight(num, ' ');
		}
		return Encoding.ASCII.GetBytes(text);
	}

	public string Encrypto(string Source)
	{
		if (!(Source == "") && Source != null)
		{
			try
			{
				byte[] bytes = Encoding.UTF8.GetBytes(Source);
				MemoryStream memoryStream = new MemoryStream();
				mobjCryptoService.Key = GetLegalKey();
				mobjCryptoService.IV = GetLegalIV();
				ICryptoTransform transform = mobjCryptoService.CreateEncryptor();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Close();
				byte[] inArray = memoryStream.ToArray();
				return Convert.ToBase64String(inArray);
			}
			catch
			{
			}
			return "";
		}
		return "";
	}

	public string Decrypto(string Source)
	{
		if (!(Source == "") && Source != null)
		{
			try
			{
				byte[] array = Convert.FromBase64String(Source);
				MemoryStream stream = new MemoryStream(array, 0, array.Length);
				mobjCryptoService.Key = GetLegalKey();
				mobjCryptoService.IV = GetLegalIV();
				ICryptoTransform transform = mobjCryptoService.CreateDecryptor();
				CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
				StreamReader streamReader = new StreamReader(stream2);
				return streamReader.ReadToEnd();
			}
			catch
			{
			}
			return "";
		}
		return "";
	}
}
