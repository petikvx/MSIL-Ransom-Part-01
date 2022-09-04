using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class QtvcwCKzfoonrPW
{
	private TripleDESCryptoServiceProvider toSUBVaiYENNLQn;

	private UTF8Encoding uCgssIMPHfunXFI;

	private byte[] cFJXTDQppRZlOhN;

	private byte[] kDcDOIaKgQbgdoG;

	public QtvcwCKzfoonrPW(byte[] key, byte[] iv)
	{
		toSUBVaiYENNLQn = new TripleDESCryptoServiceProvider();
		uCgssIMPHfunXFI = new UTF8Encoding();
		cFJXTDQppRZlOhN = key;
		kDcDOIaKgQbgdoG = iv;
	}

	public byte[] gkyverRRsBNpJoM(byte[] QOTELSiJJZPRJiL)
	{
		return UcdmLFikRXqyoUP(QOTELSiJJZPRJiL, toSUBVaiYENNLQn.CreateDecryptor(cFJXTDQppRZlOhN, kDcDOIaKgQbgdoG));
	}

	public string gkyverRRsBNpJoM(string text)
	{
		byte[] qOTELSiJJZPRJiL = Convert.FromBase64String(text);
		byte[] bytes = UcdmLFikRXqyoUP(qOTELSiJJZPRJiL, toSUBVaiYENNLQn.CreateDecryptor(cFJXTDQppRZlOhN, kDcDOIaKgQbgdoG));
		return uCgssIMPHfunXFI.GetString(bytes);
	}

	private byte[] UcdmLFikRXqyoUP(byte[] QOTELSiJJZPRJiL, ICryptoTransform CryptoTransform)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, CryptoTransform, CryptoStreamMode.Write);
		cryptoStream.Write(QOTELSiJJZPRJiL, 0, QOTELSiJJZPRJiL.Length);
		cryptoStream.FlushFinalBlock();
		memoryStream.Position = 0L;
		byte[] array = new byte[checked((int)(memoryStream.Length - 1L) + 1)];
		memoryStream.Read(array, 0, array.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return array;
	}
}
