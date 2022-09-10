using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using _003CPrivateImplementationDetails_003E_007B18A11B1C_002D3AA7_002D4357_002DAAD9_002DCC83BB5216E3_007D;

namespace MOISHE.Core;

public class KeyGenerator
{
	public const string PEM_RSA_PRIVATE_START = "-----BEGIN RSA PRIVATE KEY-----";

	public const string PEM_RSA_PRIVATE_END = "-----END RSA PRIVATE KEY-----";

	public const string PEM_RSA_PUBLIC_START = "-----BEGIN RSA PUBLIC KEY-----";

	public const string PEM_RSA_PUBLIC_END = "-----END RSA PUBLIC KEY-----";

	[CompilerGenerated]
	private RSAParameters m_A;

	public RSAParameters keypair
	{
		[CompilerGenerated]
		get
		{
			return this.m_A;
		}
		[CompilerGenerated]
		set
		{
			this.m_A = value;
		}
	}

	public KeyGenerator()
	{
		Refresh();
	}

	public void Refresh()
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(4096);
		keypair = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: true);
	}

	public Session NewSession()
	{
		return new Session(keypair);
	}

	public void ImportPublicKeyDER(byte[] buffer)
	{
		keypair = ImportPublicKey(buffer);
	}

	public void ImportPublicKeyPEM(string encoded)
	{
		string s = encoded.Replace(Class0.ap(), Class0.F()).Replace(Class0.aQ(), Class0.F()).Replace(Class0.e(), Class0.F())
			.Replace(Class0.f(), Class0.F())
			.Replace(Class0.G(), Class0.F())
			.Replace(Class0.g(), Class0.F())
			.Trim();
		byte[] buffer = Convert.FromBase64String(s);
		ImportPublicKeyDER(buffer);
	}

	public string PublicKeyPEM()
	{
		byte[] inArray = ExportPublicKey(keypair);
		string text = Class0.ap();
		string text2 = Convert.ToBase64String(inArray, Base64FormattingOptions.InsertLineBreaks);
		string text3 = Class0.aQ();
		return text + Class0.aq() + text2 + Class0.aq() + text3;
	}

	public string PrivateKeyPEM()
	{
		byte[] inArray = ExportPrivateKey(keypair);
		string text = Class0.aR();
		string text2 = Convert.ToBase64String(inArray, Base64FormattingOptions.InsertLineBreaks);
		string text3 = Class0.ar();
		return text + Class0.aq() + text2 + Class0.aq() + text3;
	}

	public static byte[] ExportPrivateKey(RSAParameters KeyPair)
	{
		using MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
		binaryWriter.Write((byte)48);
		using (MemoryStream memoryStream2 = new MemoryStream())
		{
			BinaryWriter binaryWriter_ = new BinaryWriter(memoryStream2);
			A(binaryWriter_, new byte[1]);
			A(binaryWriter_, KeyPair.Modulus);
			A(binaryWriter_, KeyPair.Exponent);
			A(binaryWriter_, KeyPair.D);
			A(binaryWriter_, KeyPair.P);
			A(binaryWriter_, KeyPair.Q);
			A(binaryWriter_, KeyPair.DP);
			A(binaryWriter_, KeyPair.DQ);
			A(binaryWriter_, KeyPair.InverseQ);
			int num = (int)memoryStream2.Length;
			A(binaryWriter, num);
			binaryWriter.Write(memoryStream2.GetBuffer(), 0, num);
		}
		return memoryStream.GetBuffer();
	}

	public static byte[] ExportPublicKey(RSAParameters KeyPair)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(KeyPair);
		return RSAExtensions.ExportRSAPublicKey(rSACryptoServiceProvider);
	}

	public static RSAParameters ImportPublicKey(byte[] buffer)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		RSAExtensions.ImportRSAPublicKey(rSACryptoServiceProvider, buffer, out var _);
		return rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
	}

	private static void A(BinaryWriter binaryWriter_0, int int_0)
	{
		if (int_0 < 0)
		{
			throw new ArgumentOutOfRangeException(Class0.aS(), Class0.@as());
		}
		if (int_0 < 128)
		{
			binaryWriter_0.Write((byte)int_0);
			return;
		}
		int num = int_0;
		int num2 = 0;
		while (num > 0)
		{
			num >>= 8;
			num2++;
		}
		binaryWriter_0.Write((byte)((uint)num2 | 0x80u));
		for (int num3 = num2 - 1; num3 >= 0; num3--)
		{
			binaryWriter_0.Write((byte)((uint)(int_0 >> 8 * num3) & 0xFFu));
		}
	}

	private static void A(BinaryWriter binaryWriter_0, byte[] byte_0, bool bool_0 = true)
	{
		binaryWriter_0.Write((byte)2);
		int num = 0;
		for (int i = 0; i < byte_0.Length && byte_0[i] == 0; i++)
		{
			num++;
		}
		if (byte_0.Length - num == 0)
		{
			A(binaryWriter_0, 1);
			binaryWriter_0.Write((byte)0);
			return;
		}
		if (bool_0 && byte_0[num] > 127)
		{
			A(binaryWriter_0, byte_0.Length - num + 1);
			binaryWriter_0.Write((byte)0);
		}
		else
		{
			A(binaryWriter_0, byte_0.Length - num);
		}
		for (int j = num; j < byte_0.Length; j++)
		{
			binaryWriter_0.Write(byte_0[j]);
		}
	}

	public static byte[] DecodePEMToDER(string privateKey)
	{
		string text = File.ReadAllText(privateKey);
		text = text.Replace(Class0.aR(), Class0.F());
		text = text.Replace(Class0.ar(), Class0.F());
		text = text.Replace(Class0.e(), Class0.F()).Replace(Class0.f(), Class0.F()).Trim();
		return Convert.FromBase64String(text);
	}
}
