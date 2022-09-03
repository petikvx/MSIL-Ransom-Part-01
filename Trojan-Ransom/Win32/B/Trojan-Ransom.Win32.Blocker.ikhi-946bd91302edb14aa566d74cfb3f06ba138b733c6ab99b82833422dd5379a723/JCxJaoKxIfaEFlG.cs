using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class JCxJaoKxIfaEFlG
{
	private TripleDESCryptoServiceProvider bzrnzQfBoxVQtvc;

	private UTF8Encoding wCKzfnomrPWdHUT;

	private byte[] jnqhHWPygjEgkyu;

	private byte[] drRRrBNpJoMeEep;

	public JCxJaoKxIfaEFlG(byte[] key, byte[] iv)
	{
		bzrnzQfBoxVQtvc = new TripleDESCryptoServiceProvider();
		wCKzfnomrPWdHUT = new UTF8Encoding();
		jnqhHWPygjEgkyu = key;
		drRRrBNpJoMeEep = iv;
	}

	public byte[] FIzYngRyBVxDQNv(byte[] CfhOUnvkQMMLQBI)
	{
		return FXGdNXdZlCRYajH(CfhOUnvkQMMLQBI, bzrnzQfBoxVQtvc.CreateDecryptor(jnqhHWPygjEgkyu, drRRrBNpJoMeEep));
	}

	public string FIzYngRyBVxDQNv(string text)
	{
		byte[] cfhOUnvkQMMLQBI = Convert.FromBase64String(text);
		byte[] bytes = FXGdNXdZlCRYajH(cfhOUnvkQMMLQBI, bzrnzQfBoxVQtvc.CreateDecryptor(jnqhHWPygjEgkyu, drRRrBNpJoMeEep));
		return wCKzfnomrPWdHUT.GetString(bytes);
	}

	private byte[] FXGdNXdZlCRYajH(byte[] CfhOUnvkQMMLQBI, ICryptoTransform CryptoTransform)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, CryptoTransform, CryptoStreamMode.Write);
		cryptoStream.Write(CfhOUnvkQMMLQBI, 0, CfhOUnvkQMMLQBI.Length);
		cryptoStream.FlushFinalBlock();
		memoryStream.Position = 0L;
		byte[] array = new byte[checked((int)(memoryStream.Length - 1L) + 1)];
		memoryStream.Read(array, 0, array.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return array;
	}
}
