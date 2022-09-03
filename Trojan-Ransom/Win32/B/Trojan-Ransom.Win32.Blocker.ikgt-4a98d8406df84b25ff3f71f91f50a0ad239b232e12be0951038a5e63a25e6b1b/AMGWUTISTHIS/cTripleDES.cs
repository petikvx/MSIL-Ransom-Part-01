using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AMGWUTISTHIS;

internal class cTripleDES
{
	private TripleDESCryptoServiceProvider m_des;

	private UTF8Encoding m_utf8;

	private byte[] m_key;

	private byte[] m_iv;

	public cTripleDES(byte[] key, byte[] iv)
	{
		m_des = new TripleDESCryptoServiceProvider();
		m_utf8 = new UTF8Encoding();
		m_key = key;
		m_iv = iv;
	}

	public byte[] DEZOR(byte[] input)
	{
		return Transform(input, m_des.CreateDecryptor(m_key, m_iv));
	}

	public string DEZOR(string text)
	{
		byte[] input = Convert.FromBase64String(text);
		byte[] bytes = Transform(input, m_des.CreateDecryptor(m_key, m_iv));
		return m_utf8.GetString(bytes);
	}

	private byte[] Transform(byte[] input, ICryptoTransform CryptoTransform)
	{
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, CryptoTransform, CryptoStreamMode.Write);
		cryptoStream.Write(input, 0, input.Length);
		cryptoStream.FlushFinalBlock();
		memoryStream.Position = 0L;
		byte[] array = new byte[checked((int)(memoryStream.Length - 1L) + 1)];
		memoryStream.Read(array, 0, array.Length);
		memoryStream.Close();
		cryptoStream.Close();
		return array;
	}
}
