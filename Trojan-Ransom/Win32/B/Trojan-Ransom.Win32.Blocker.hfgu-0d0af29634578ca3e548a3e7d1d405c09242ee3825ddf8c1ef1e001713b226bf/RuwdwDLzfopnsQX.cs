using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class RuwdwDLzfopnsQX
{
	private TripleDESCryptoServiceProvider WRuwdwDLzfopnsQ;

	private UTF8Encoding XeIVUkoqiIXPzhj;

	private byte[] FhlzvesRSsCOqKo;

	private byte[] NfFfqkDlJsDJFRh;

	public RuwdwDLzfopnsQX(byte[] key, byte[] iv)
	{
		WRuwdwDLzfopnsQ = new TripleDESCryptoServiceProvider();
		XeIVUkoqiIXPzhj = new UTF8Encoding();
		FhlzvesRSsCOqKo = key;
		NfFfqkDlJsDJFRh = iv;
	}

	public byte[] hlzvesRSsCOqKoN(byte[] rqvgnuLlkBqtlKn)
	{
		return wEGPmhLNtzTbRwr(rqvgnuLlkBqtlKn, WRuwdwDLzfopnsQ.CreateDecryptor(FhlzvesRSsCOqKo, NfFfqkDlJsDJFRh));
	}

	public string hlzvesRSsCOqKoN(string text)
	{
		byte[] rqvgnuLlkBqtlKn = Convert.FromBase64String(text);
		byte[] bytes = wEGPmhLNtzTbRwr(rqvgnuLlkBqtlKn, WRuwdwDLzfopnsQ.CreateDecryptor(FhlzvesRSsCOqKo, NfFfqkDlJsDJFRh));
		return XeIVUkoqiIXPzhj.GetString(bytes);
	}

	private byte[] wEGPmhLNtzTbRwr(byte[] rqvgnuLlkBqtlKn, ICryptoTransform CryptoTransform)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, CryptoTransform, CryptoStreamMode.Write);
		cryptoStream.Write(rqvgnuLlkBqtlKn, 0, rqvgnuLlkBqtlKn.Length);
		cryptoStream.FlushFinalBlock();
		memoryStream.Position = 0L;
		byte[] array = new byte[checked((int)(memoryStream.Length - 1L) + 1)];
		memoryStream.Read(array, 0, array.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return array;
	}
}
