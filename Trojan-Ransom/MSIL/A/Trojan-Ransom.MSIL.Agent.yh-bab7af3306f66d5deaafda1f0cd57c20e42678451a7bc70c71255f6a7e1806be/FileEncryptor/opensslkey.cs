using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FileEncryptor;

public class opensslkey
{
	private const string pemprivheader = "-----BEGIN RSA PRIVATE KEY-----";

	private const string pemprivfooter = "-----END RSA PRIVATE KEY-----";

	private const string pempubheader = "-----BEGIN PUBLIC KEY-----";

	private const string pempubfooter = "-----END PUBLIC KEY-----";

	private const string pemp8header = "-----BEGIN PRIVATE KEY-----";

	private const string pemp8footer = "-----END PRIVATE KEY-----";

	private const string pemp8encheader = "-----BEGIN ENCRYPTED PRIVATE KEY-----";

	private const string pemp8encfooter = "-----END ENCRYPTED PRIVATE KEY-----";

	private static bool verbose = false;

	public static void DecodePEMKey(string pemstr, out string publicKey, out string privateKey)
	{
		publicKey = null;
		privateKey = null;
		if (pemstr.StartsWith("-----BEGIN PUBLIC KEY-----") && pemstr.EndsWith("-----END PUBLIC KEY-----"))
		{
			Console.WriteLine("Trying to decode and parse a PEM public key ..");
			byte[] array = DecodeOpenSSLPublicKey(pemstr);
			if (array != null)
			{
				if (verbose)
				{
					showBytes("\nRSA public key", array);
				}
				RSACryptoServiceProvider rSACryptoServiceProvider = DecodeX509PublicKey(array);
				publicKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
			}
		}
		else if (pemstr.StartsWith("-----BEGIN RSA PRIVATE KEY-----") && pemstr.EndsWith("-----END RSA PRIVATE KEY-----"))
		{
			Console.WriteLine("Trying to decrypt and parse a PEM private key ..");
			byte[] array2 = DecodeOpenSSLPrivateKey(pemstr);
			if (array2 != null)
			{
				if (verbose)
				{
					showBytes("\nRSA private key", array2);
				}
				RSACryptoServiceProvider rSACryptoServiceProvider = DecodeRSAPrivateKey(array2);
				privateKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
				ProcessRSA(rSACryptoServiceProvider);
			}
		}
		else if (pemstr.StartsWith("-----BEGIN PRIVATE KEY-----") && pemstr.EndsWith("-----END PRIVATE KEY-----"))
		{
			Console.WriteLine("Trying to decode and parse as PEM PKCS #8 PrivateKeyInfo ..");
			byte[] array3 = DecodePkcs8PrivateKey(pemstr);
			if (array3 != null)
			{
				if (verbose)
				{
					showBytes("\nPKCS #8 PrivateKeyInfo", array3);
				}
				RSACryptoServiceProvider rSACryptoServiceProvider = DecodePrivateKeyInfo(array3);
				if (rSACryptoServiceProvider == null)
				{
					throw new Exception("\nFailed to create an RSACryptoServiceProvider");
				}
				privateKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
				ProcessRSA(rSACryptoServiceProvider);
			}
		}
		else if (pemstr.StartsWith("-----BEGIN ENCRYPTED PRIVATE KEY-----") && pemstr.EndsWith("-----END ENCRYPTED PRIVATE KEY-----"))
		{
			byte[] array4 = DecodePkcs8EncPrivateKey(pemstr);
			if (array4 != null)
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = DecodeEncryptedPrivateKeyInfo(array4);
				if (rSACryptoServiceProvider != null)
				{
					privateKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
					ProcessRSA(rSACryptoServiceProvider);
				}
				else
				{
					Console.WriteLine("\nFailed to create an RSACryptoServiceProvider");
				}
			}
		}
		else
		{
			Console.WriteLine("Not a PEM public, private key or a PKCS #8");
		}
	}

	public static void DecodeDERKey(string filename)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		byte[] fileBytes = GetFileBytes(filename);
		if (fileBytes == null)
		{
			return;
		}
		rSACryptoServiceProvider = DecodeX509PublicKey(fileBytes);
		if (rSACryptoServiceProvider != null)
		{
			Console.WriteLine("\nA valid SubjectPublicKeyInfo\n");
			Console.WriteLine("\nCreated an RSACryptoServiceProvider instance\n");
			string arg = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
			Console.WriteLine("\nXML RSA public key:  {0} bits\n{1}\n", rSACryptoServiceProvider.KeySize, arg);
			return;
		}
		rSACryptoServiceProvider = DecodeRSAPrivateKey(fileBytes);
		if (rSACryptoServiceProvider != null)
		{
			Console.WriteLine("\nA valid RSAPrivateKey\n");
			Console.WriteLine("\nCreated an RSACryptoServiceProvider instance\n");
			string arg2 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
			Console.WriteLine("\nXML RSA private key:  {0} bits\n{1}\n", rSACryptoServiceProvider.KeySize, arg2);
			ProcessRSA(rSACryptoServiceProvider);
			return;
		}
		rSACryptoServiceProvider = DecodePrivateKeyInfo(fileBytes);
		if (rSACryptoServiceProvider != null)
		{
			Console.WriteLine("\nA valid PKCS #8 PrivateKeyInfo\n");
			Console.WriteLine("\nCreated an RSACryptoServiceProvider instance\n");
			string arg2 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
			Console.WriteLine("\nXML RSA private key:  {0} bits\n{1}\n", rSACryptoServiceProvider.KeySize, arg2);
			ProcessRSA(rSACryptoServiceProvider);
			return;
		}
		rSACryptoServiceProvider = DecodeEncryptedPrivateKeyInfo(fileBytes);
		if (rSACryptoServiceProvider != null)
		{
			Console.WriteLine("\nA valid PKCS #8 EncryptedPrivateKeyInfo\n");
			Console.WriteLine("\nCreated an RSACryptoServiceProvider instance\n");
			string arg2 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
			Console.WriteLine("\nXML RSA private key:  {0} bits\n{1}\n", rSACryptoServiceProvider.KeySize, arg2);
			ProcessRSA(rSACryptoServiceProvider);
		}
		else
		{
			Console.WriteLine("Not a binary DER public, private or PKCS #8 key");
		}
	}

	public static void ProcessRSA(RSACryptoServiceProvider rsa)
	{
	}

	public static void RSAtoPKCS12(RSACryptoServiceProvider rsa)
	{
		CspKeyContainerInfo cspKeyContainerInfo = rsa.CspKeyContainerInfo;
		string keyContainerName = cspKeyContainerInfo.KeyContainerName;
		uint keyNumber = (uint)cspKeyContainerInfo.KeyNumber;
		string providerName = cspKeyContainerInfo.ProviderName;
		string text = keyContainerName + ".p12";
		byte[] pkcs = GetPkcs12(rsa, keyContainerName, providerName, keyNumber, 0u);
		if (pkcs != null && verbose)
		{
			showBytes("\npkcs #12", pkcs);
		}
		if (pkcs != null)
		{
			PutFileBytes(text, pkcs, pkcs.Length);
			Console.WriteLine("\nWrote pkc #12 file '{0}'\n", text);
		}
		else
		{
			Console.WriteLine("\nProblem getting pkcs#12");
		}
	}

	public static byte[] DecodePkcs8PrivateKey(string instr)
	{
		string text = instr.Trim();
		if (!text.StartsWith("-----BEGIN PRIVATE KEY-----") || !text.EndsWith("-----END PRIVATE KEY-----"))
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(text);
		stringBuilder.Replace("-----BEGIN PRIVATE KEY-----", "");
		stringBuilder.Replace("-----END PRIVATE KEY-----", "");
		string s = stringBuilder.ToString().Trim();
		byte[] result;
		try
		{
			result = Convert.FromBase64String(s);
		}
		catch (FormatException)
		{
			return null;
		}
		return result;
	}

	public static RSACryptoServiceProvider DecodePrivateKeyInfo(byte[] pkcs8)
	{
		byte[] b = new byte[15]
		{
			48, 13, 6, 9, 42, 134, 72, 134, 247, 13,
			1, 1, 1, 5, 0
		};
		byte[] array = new byte[15];
		MemoryStream memoryStream = new MemoryStream(pkcs8);
		int num = (int)memoryStream.Length;
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		byte b2 = 0;
		ushort num2 = 0;
		try
		{
			num2 = binaryReader.ReadUInt16();
			if (num2 == 33072)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num2 != 33328)
				{
					return null;
				}
				binaryReader.ReadInt16();
			}
			b2 = binaryReader.ReadByte();
			if (b2 != 2)
			{
				return null;
			}
			num2 = binaryReader.ReadUInt16();
			if (num2 != 1)
			{
				return null;
			}
			array = binaryReader.ReadBytes(15);
			if (!CompareBytearrays(array, b))
			{
				return null;
			}
			b2 = binaryReader.ReadByte();
			if (b2 != 4)
			{
				return null;
			}
			switch (binaryReader.ReadByte())
			{
			case 129:
				binaryReader.ReadByte();
				break;
			case 130:
				binaryReader.ReadUInt16();
				break;
			}
			byte[] privkey = binaryReader.ReadBytes((int)(num - memoryStream.Position));
			return DecodeRSAPrivateKey(privkey);
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			binaryReader.Close();
		}
	}

	public static byte[] DecodePkcs8EncPrivateKey(string instr)
	{
		string text = instr.Trim();
		if (!text.StartsWith("-----BEGIN ENCRYPTED PRIVATE KEY-----") || !text.EndsWith("-----END ENCRYPTED PRIVATE KEY-----"))
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(text);
		stringBuilder.Replace("-----BEGIN ENCRYPTED PRIVATE KEY-----", "");
		stringBuilder.Replace("-----END ENCRYPTED PRIVATE KEY-----", "");
		string s = stringBuilder.ToString().Trim();
		byte[] result;
		try
		{
			result = Convert.FromBase64String(s);
		}
		catch (FormatException)
		{
			return null;
		}
		return result;
	}

	public static RSACryptoServiceProvider DecodeEncryptedPrivateKeyInfo(byte[] encpkcs8)
	{
		byte[] b = new byte[11]
		{
			6, 9, 42, 134, 72, 134, 247, 13, 1, 5,
			13
		};
		byte[] b2 = new byte[11]
		{
			6, 9, 42, 134, 72, 134, 247, 13, 1, 5,
			12
		};
		byte[] b3 = new byte[10] { 6, 8, 42, 134, 72, 134, 247, 13, 3, 7 };
		byte[] array = new byte[10];
		byte[] array2 = new byte[11];
		MemoryStream memoryStream = new MemoryStream(encpkcs8);
		_ = memoryStream.Length;
		BinaryReader binaryReader = new BinaryReader(memoryStream);
		byte b4 = 0;
		ushort num = 0;
		try
		{
			num = binaryReader.ReadUInt16();
			if (num == 33072)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num != 33328)
				{
					return null;
				}
				binaryReader.ReadInt16();
			}
			switch (binaryReader.ReadUInt16())
			{
			case 33072:
				binaryReader.ReadByte();
				break;
			case 33328:
				binaryReader.ReadInt16();
				break;
			}
			array2 = binaryReader.ReadBytes(11);
			if (!CompareBytearrays(array2, b))
			{
				return null;
			}
			switch (binaryReader.ReadUInt16())
			{
			case 33072:
				binaryReader.ReadByte();
				break;
			case 33328:
				binaryReader.ReadInt16();
				break;
			}
			switch (binaryReader.ReadUInt16())
			{
			case 33072:
				binaryReader.ReadByte();
				break;
			case 33328:
				binaryReader.ReadInt16();
				break;
			}
			array2 = binaryReader.ReadBytes(11);
			if (!CompareBytearrays(array2, b2))
			{
				return null;
			}
			switch (binaryReader.ReadUInt16())
			{
			case 33072:
				binaryReader.ReadByte();
				break;
			case 33328:
				binaryReader.ReadInt16();
				break;
			}
			b4 = binaryReader.ReadByte();
			if (b4 != 4)
			{
				return null;
			}
			int count = binaryReader.ReadByte();
			byte[] array3 = binaryReader.ReadBytes(count);
			if (verbose)
			{
				showBytes("Salt for pbkd", array3);
			}
			b4 = binaryReader.ReadByte();
			if (b4 != 2)
			{
				return null;
			}
			int num2 = binaryReader.ReadByte();
			int num3;
			if (num2 == 1)
			{
				num3 = binaryReader.ReadByte();
			}
			else
			{
				if (num2 != 2)
				{
					return null;
				}
				num3 = 256 * binaryReader.ReadByte() + binaryReader.ReadByte();
			}
			if (verbose)
			{
				Console.WriteLine("PBKD2 iterations {0}", num3);
			}
			switch (binaryReader.ReadUInt16())
			{
			case 33072:
				binaryReader.ReadByte();
				break;
			case 33328:
				binaryReader.ReadInt16();
				break;
			}
			array = binaryReader.ReadBytes(10);
			if (!CompareBytearrays(array, b3))
			{
				return null;
			}
			b4 = binaryReader.ReadByte();
			if (b4 != 4)
			{
				return null;
			}
			int count2 = binaryReader.ReadByte();
			byte[] array4 = binaryReader.ReadBytes(count2);
			if (verbose)
			{
				showBytes("IV for des-EDE3-CBC", array4);
			}
			b4 = binaryReader.ReadByte();
			if (b4 != 4)
			{
				return null;
			}
			b4 = binaryReader.ReadByte();
			byte[] edata = binaryReader.ReadBytes(b4 switch
			{
				129 => binaryReader.ReadByte(), 
				130 => 256 * binaryReader.ReadByte() + binaryReader.ReadByte(), 
				_ => b4, 
			});
			SecureString secPswd = GetSecPswd("Enter password for Encrypted PKCS #8 ==>");
			byte[] array5 = DecryptPBDK2(edata, array3, array4, secPswd, num3);
			if (array5 == null)
			{
				return null;
			}
			return DecodePrivateKeyInfo(array5);
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			binaryReader.Close();
		}
	}

	public static byte[] DecryptPBDK2(byte[] edata, byte[] salt, byte[] IV, SecureString secpswd, int iterations)
	{
		CryptoStream cryptoStream = null;
		IntPtr zero = IntPtr.Zero;
		byte[] array = new byte[secpswd.Length];
		zero = Marshal.SecureStringToGlobalAllocAnsi(secpswd);
		Marshal.Copy(zero, array, 0, array.Length);
		Marshal.ZeroFreeGlobalAllocAnsi(zero);
		try
		{
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(array, salt, iterations);
			TripleDES tripleDES = TripleDES.Create();
			tripleDES.Key = rfc2898DeriveBytes.GetBytes(24);
			tripleDES.IV = IV;
			MemoryStream memoryStream = new MemoryStream();
			cryptoStream = new CryptoStream(memoryStream, tripleDES.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(edata, 0, edata.Length);
			cryptoStream.Flush();
			cryptoStream.Close();
			return memoryStream.ToArray();
		}
		catch (Exception ex)
		{
			Console.WriteLine("Problem decrypting: {0}", ex.Message);
			return null;
		}
	}

	public static byte[] DecodeOpenSSLPublicKey(string instr)
	{
		string text = instr.Trim();
		if (!text.StartsWith("-----BEGIN PUBLIC KEY-----") || !text.EndsWith("-----END PUBLIC KEY-----"))
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(text);
		stringBuilder.Replace("-----BEGIN PUBLIC KEY-----", "");
		stringBuilder.Replace("-----END PUBLIC KEY-----", "");
		string s = stringBuilder.ToString().Trim();
		byte[] result;
		try
		{
			result = Convert.FromBase64String(s);
		}
		catch (FormatException)
		{
			return null;
		}
		return result;
	}

	public static RSACryptoServiceProvider DecodeX509PublicKey(byte[] x509key)
	{
		byte[] b = new byte[15]
		{
			48, 13, 6, 9, 42, 134, 72, 134, 247, 13,
			1, 1, 1, 5, 0
		};
		byte[] array = new byte[15];
		MemoryStream input = new MemoryStream(x509key);
		BinaryReader binaryReader = new BinaryReader(input);
		byte b2 = 0;
		ushort num = 0;
		try
		{
			num = binaryReader.ReadUInt16();
			if (num == 33072)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num != 33328)
				{
					return null;
				}
				binaryReader.ReadInt16();
			}
			array = binaryReader.ReadBytes(15);
			if (!CompareBytearrays(array, b))
			{
				return null;
			}
			num = binaryReader.ReadUInt16();
			if (num == 33027)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num != 33283)
				{
					return null;
				}
				binaryReader.ReadInt16();
			}
			if (binaryReader.ReadByte() != 0)
			{
				return null;
			}
			num = binaryReader.ReadUInt16();
			if (num == 33072)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num != 33328)
				{
					return null;
				}
				binaryReader.ReadInt16();
			}
			num = binaryReader.ReadUInt16();
			byte b3 = 0;
			byte b4 = 0;
			if (num == 33026)
			{
				b3 = binaryReader.ReadByte();
			}
			else
			{
				if (num != 33282)
				{
					return null;
				}
				b4 = binaryReader.ReadByte();
				b3 = binaryReader.ReadByte();
			}
			byte[] value = new byte[4] { b3, b4, 0, 0 };
			int num2 = BitConverter.ToInt32(value, 0);
			byte b5 = binaryReader.ReadByte();
			binaryReader.BaseStream.Seek(-1L, SeekOrigin.Current);
			if (b5 == 0)
			{
				binaryReader.ReadByte();
				num2--;
			}
			byte[] array2 = binaryReader.ReadBytes(num2);
			if (binaryReader.ReadByte() != 2)
			{
				return null;
			}
			int count = binaryReader.ReadByte();
			byte[] array3 = binaryReader.ReadBytes(count);
			showBytes("\nExponent", array3);
			showBytes("\nModulus", array2);
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			RSAParameters parameters = default(RSAParameters);
			parameters.Modulus = array2;
			parameters.Exponent = array3;
			rSACryptoServiceProvider.ImportParameters(parameters);
			return rSACryptoServiceProvider;
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			binaryReader.Close();
		}
	}

	public static RSACryptoServiceProvider DecodeRSAPrivateKey(byte[] privkey)
	{
		MemoryStream input = new MemoryStream(privkey);
		BinaryReader binaryReader = new BinaryReader(input);
		byte b = 0;
		ushort num = 0;
		int num2 = 0;
		try
		{
			num = binaryReader.ReadUInt16();
			if (num == 33072)
			{
				binaryReader.ReadByte();
			}
			else
			{
				if (num != 33328)
				{
					return null;
				}
				binaryReader.ReadInt16();
			}
			num = binaryReader.ReadUInt16();
			if (num != 258)
			{
				return null;
			}
			if (binaryReader.ReadByte() != 0)
			{
				return null;
			}
			num2 = GetIntegerSize(binaryReader);
			byte[] array = binaryReader.ReadBytes(num2);
			num2 = GetIntegerSize(binaryReader);
			byte[] array2 = binaryReader.ReadBytes(num2);
			num2 = GetIntegerSize(binaryReader);
			byte[] array3 = binaryReader.ReadBytes(num2);
			num2 = GetIntegerSize(binaryReader);
			byte[] array4 = binaryReader.ReadBytes(num2);
			num2 = GetIntegerSize(binaryReader);
			byte[] array5 = binaryReader.ReadBytes(num2);
			num2 = GetIntegerSize(binaryReader);
			byte[] array6 = binaryReader.ReadBytes(num2);
			num2 = GetIntegerSize(binaryReader);
			byte[] array7 = binaryReader.ReadBytes(num2);
			num2 = GetIntegerSize(binaryReader);
			byte[] array8 = binaryReader.ReadBytes(num2);
			Console.WriteLine("showing components ..");
			if (verbose)
			{
				showBytes("\nModulus", array);
				showBytes("\nExponent", array2);
				showBytes("\nD", array3);
				showBytes("\nP", array4);
				showBytes("\nQ", array5);
				showBytes("\nDP", array6);
				showBytes("\nDQ", array7);
				showBytes("\nIQ", array8);
			}
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			RSAParameters parameters = default(RSAParameters);
			parameters.Modulus = array;
			parameters.Exponent = array2;
			parameters.D = array3;
			parameters.P = array4;
			parameters.Q = array5;
			parameters.DP = array6;
			parameters.DQ = array7;
			parameters.InverseQ = array8;
			rSACryptoServiceProvider.ImportParameters(parameters);
			return rSACryptoServiceProvider;
		}
		catch (Exception)
		{
			return null;
		}
		finally
		{
			binaryReader.Close();
		}
	}

	private static int GetIntegerSize(BinaryReader binr)
	{
		byte b = 0;
		byte b2 = 0;
		byte b3 = 0;
		int num = 0;
		b = binr.ReadByte();
		if (b != 2)
		{
			return 0;
		}
		b = binr.ReadByte();
		switch (b)
		{
		case 129:
			num = binr.ReadByte();
			break;
		case 130:
		{
			b3 = binr.ReadByte();
			b2 = binr.ReadByte();
			byte[] value = new byte[4] { b2, b3, 0, 0 };
			num = BitConverter.ToInt32(value, 0);
			break;
		}
		default:
			num = b;
			break;
		}
		while (binr.ReadByte() == 0)
		{
			num--;
		}
		binr.BaseStream.Seek(-1L, SeekOrigin.Current);
		return num;
	}

	public static byte[] DecodeOpenSSLPrivateKey(string instr)
	{
		string text = instr.Trim();
		if (!text.StartsWith("-----BEGIN RSA PRIVATE KEY-----") || !text.EndsWith("-----END RSA PRIVATE KEY-----"))
		{
			return null;
		}
		StringBuilder stringBuilder = new StringBuilder(text);
		stringBuilder.Replace("-----BEGIN RSA PRIVATE KEY-----", "");
		stringBuilder.Replace("-----END RSA PRIVATE KEY-----", "");
		string s = stringBuilder.ToString().Trim();
		try
		{
			return Convert.FromBase64String(s);
		}
		catch (FormatException)
		{
		}
		StringReader stringReader = new StringReader(s);
		if (!stringReader.ReadLine()!.StartsWith("Proc-Type: 4,ENCRYPTED"))
		{
			return null;
		}
		string text2 = stringReader.ReadLine();
		if (!text2.StartsWith("DEK-Info: DES-EDE3-CBC,"))
		{
			return null;
		}
		string text3 = text2.Substring(text2.IndexOf(",") + 1).Trim();
		byte[] array = new byte[text3.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Convert.ToByte(text3.Substring(i * 2, 2), 16);
		}
		if (!(stringReader.ReadLine() == ""))
		{
			return null;
		}
		string s2 = stringReader.ReadToEnd();
		byte[] cipherData;
		try
		{
			cipherData = Convert.FromBase64String(s2);
		}
		catch (FormatException)
		{
			return null;
		}
		SecureString secPswd = GetSecPswd("Enter password to derive 3DES key==>");
		byte[] openSSL3deskey = GetOpenSSL3deskey(array, secPswd, 1, 2);
		if (openSSL3deskey == null)
		{
			return null;
		}
		byte[] array2 = DecryptKey(cipherData, openSSL3deskey, array);
		if (array2 != null)
		{
			return array2;
		}
		Console.WriteLine("Failed to decrypt RSA private key; probably wrong password.");
		return null;
	}

	public static byte[] DecryptKey(byte[] cipherData, byte[] desKey, byte[] IV)
	{
		MemoryStream memoryStream = new MemoryStream();
		TripleDES tripleDES = TripleDES.Create();
		tripleDES.Key = desKey;
		tripleDES.IV = IV;
		try
		{
			CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDES.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(cipherData, 0, cipherData.Length);
			cryptoStream.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			return null;
		}
		return memoryStream.ToArray();
	}

	private static byte[] GetOpenSSL3deskey(byte[] salt, SecureString secpswd, int count, int miter)
	{
		IntPtr zero = IntPtr.Zero;
		int num = 16;
		byte[] array = new byte[16 * miter];
		byte[] array2 = new byte[secpswd.Length];
		zero = Marshal.SecureStringToGlobalAllocAnsi(secpswd);
		Marshal.Copy(zero, array2, 0, array2.Length);
		Marshal.ZeroFreeGlobalAllocAnsi(zero);
		byte[] array3 = new byte[array2.Length + salt.Length];
		Array.Copy(array2, array3, array2.Length);
		Array.Copy(salt, 0, array3, array2.Length, salt.Length);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array4 = null;
		byte[] array5 = new byte[16 + array3.Length];
		for (int i = 0; i < miter; i++)
		{
			if (i == 0)
			{
				array4 = array3;
			}
			else
			{
				Array.Copy(array4, array5, array4.Length);
				Array.Copy(array3, 0, array5, array4.Length, array3.Length);
				array4 = array5;
			}
			for (int j = 0; j < count; j++)
			{
				array4 = mD.ComputeHash(array4);
			}
			Array.Copy(array4, 0, array, i * num, array4.Length);
		}
		byte[] array6 = new byte[24];
		Array.Copy(array, array6, array6.Length);
		Array.Clear(array2, 0, array2.Length);
		Array.Clear(array3, 0, array3.Length);
		Array.Clear(array4, 0, array4.Length);
		Array.Clear(array5, 0, array5.Length);
		Array.Clear(array, 0, array.Length);
		return array6;
	}

	private static byte[] GetPkcs12(RSA rsa, string keycontainer, string cspprovider, uint KEYSPEC, uint cspflags)
	{
		byte[] array = null;
		IntPtr zero = IntPtr.Zero;
		string dN = "CN=Opensslkey Unsigned Certificate";
		zero = CreateUnsignedCertCntxt(keycontainer, cspprovider, KEYSPEC, cspflags, dN);
		if (zero == IntPtr.Zero)
		{
			Console.WriteLine("Couldn't create an unsigned-cert\n");
			return null;
		}
		try
		{
			X509Certificate x509Certificate = new X509Certificate(zero);
			SecureString secPswd = GetSecPswd("Set PFX Password ==>");
			array = x509Certificate.Export(X509ContentType.Pfx, secPswd);
		}
		catch (Exception ex)
		{
			Console.WriteLine("BAD RESULT" + ex.Message);
			array = null;
		}
		rsa.Clear();
		if (zero != IntPtr.Zero)
		{
			KeyConverter.CertFreeCertificateContext(zero);
		}
		return array;
	}

	private static IntPtr CreateUnsignedCertCntxt(string keycontainer, string provider, uint KEYSPEC, uint cspflags, string DN)
	{
		IntPtr zero = IntPtr.Zero;
		byte[] array = null;
		uint pcbEncoded = 0u;
		if (provider != "Microsoft Base Cryptographic Provider v1.0" && provider != "Microsoft Strong Cryptographic Provider" && provider != "Microsoft Enhanced Cryptographic Provider v1.0")
		{
			return IntPtr.Zero;
		}
		if (keycontainer == "")
		{
			return IntPtr.Zero;
		}
		if (KEYSPEC != 2 && KEYSPEC != 1)
		{
			return IntPtr.Zero;
		}
		if (cspflags != 0 && cspflags != 32)
		{
			return IntPtr.Zero;
		}
		if (DN == "")
		{
			return IntPtr.Zero;
		}
		if (KeyConverter.CertStrToName(1u, DN, 3u, IntPtr.Zero, null, ref pcbEncoded, IntPtr.Zero))
		{
			array = new byte[pcbEncoded];
			KeyConverter.CertStrToName(1u, DN, 3u, IntPtr.Zero, array, ref pcbEncoded, IntPtr.Zero);
		}
		CERT_NAME_BLOB pSubjectIssuerBlob = default(CERT_NAME_BLOB);
		pSubjectIssuerBlob.pbData = Marshal.AllocHGlobal(array.Length);
		Marshal.Copy(array, 0, pSubjectIssuerBlob.pbData, array.Length);
		pSubjectIssuerBlob.cbData = array.Length;
		CRYPT_KEY_PROV_INFO pKeyProvInfo = default(CRYPT_KEY_PROV_INFO);
		pKeyProvInfo.pwszContainerName = keycontainer;
		pKeyProvInfo.pwszProvName = provider;
		pKeyProvInfo.dwProvType = 1u;
		pKeyProvInfo.dwFlags = cspflags;
		pKeyProvInfo.cProvParam = 0u;
		pKeyProvInfo.rgProvParam = IntPtr.Zero;
		pKeyProvInfo.dwKeySpec = KEYSPEC;
		zero = KeyConverter.CertCreateSelfSignCertificate(IntPtr.Zero, ref pSubjectIssuerBlob, 1u, ref pKeyProvInfo, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
		if (zero == IntPtr.Zero)
		{
			showWin32Error(Marshal.GetLastWin32Error());
		}
		Marshal.FreeHGlobal(pSubjectIssuerBlob.pbData);
		return zero;
	}

	private static SecureString GetSecPswd(string prompt)
	{
		SecureString secureString = new SecureString();
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.Write(prompt);
		Console.ForegroundColor = ConsoleColor.Magenta;
		while (true)
		{
			ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(intercept: true);
			if (consoleKeyInfo.Key != ConsoleKey.Enter)
			{
				if (consoleKeyInfo.Key == ConsoleKey.Backspace)
				{
					if (secureString.Length > 0)
					{
						Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
						Console.Write(" ");
						Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
						secureString.RemoveAt(secureString.Length - 1);
					}
					continue;
				}
				if (consoleKeyInfo.Key == ConsoleKey.Escape)
				{
					break;
				}
				if (char.IsLetterOrDigit(consoleKeyInfo.KeyChar) || char.IsSymbol(consoleKeyInfo.KeyChar))
				{
					if (secureString.Length < 20)
					{
						secureString.AppendChar(consoleKeyInfo.KeyChar);
						Console.Write("*");
					}
					else
					{
						Console.Beep();
					}
				}
				else
				{
					Console.Beep();
				}
				continue;
			}
			Console.ForegroundColor = ConsoleColor.Gray;
			Console.WriteLine();
			return secureString;
		}
		Console.ForegroundColor = ConsoleColor.Gray;
		Console.WriteLine();
		return secureString;
	}

	private static bool CompareBytearrays(byte[] a, byte[] b)
	{
		if (a.Length != b.Length)
		{
			return false;
		}
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < a.Length)
			{
				byte b2 = a[num2];
				if (b2 != b[num])
				{
					break;
				}
				num++;
				num2++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static void showRSAProps(RSACryptoServiceProvider rsa)
	{
		Console.WriteLine("RSA CSP key information:");
		CspKeyContainerInfo cspKeyContainerInfo = rsa.CspKeyContainerInfo;
		Console.WriteLine("Accessible property: " + cspKeyContainerInfo.Accessible);
		Console.WriteLine("Exportable property: " + cspKeyContainerInfo.Exportable);
		Console.WriteLine("HardwareDevice property: " + cspKeyContainerInfo.HardwareDevice);
		Console.WriteLine("KeyContainerName property: " + cspKeyContainerInfo.KeyContainerName);
		Console.WriteLine("KeyNumber property: " + cspKeyContainerInfo.KeyNumber);
		Console.WriteLine("MachineKeyStore property: " + cspKeyContainerInfo.MachineKeyStore);
		Console.WriteLine("Protected property: " + cspKeyContainerInfo.Protected);
		Console.WriteLine("ProviderName property: " + cspKeyContainerInfo.ProviderName);
		Console.WriteLine("ProviderType property: " + cspKeyContainerInfo.ProviderType);
		Console.WriteLine("RandomlyGenerated property: " + cspKeyContainerInfo.RandomlyGenerated);
		Console.WriteLine("Removable property: " + cspKeyContainerInfo.Removable);
		Console.WriteLine("UniqueKeyContainerName property: " + cspKeyContainerInfo.UniqueKeyContainerName);
	}

	private static void showBytes(string info, byte[] data)
	{
		Console.WriteLine("{0}  [{1} bytes]", info, data.Length);
		for (int i = 1; i <= data.Length; i++)
		{
			Console.Write("{0:X2}  ", data[i - 1]);
			if (i % 16 == 0)
			{
				Console.WriteLine();
			}
		}
		Console.WriteLine("\n\n");
	}

	private static byte[] GetFileBytes(string filename)
	{
		if (!File.Exists(filename))
		{
			return null;
		}
		Stream stream = new FileStream(filename, FileMode.Open);
		int num = (int)stream.Length;
		byte[] array = new byte[num];
		stream.Seek(0L, SeekOrigin.Begin);
		stream.Read(array, 0, num);
		stream.Close();
		return array;
	}

	private static void PutFileBytes(string outfile, byte[] data, int bytes)
	{
		FileStream fileStream = null;
		if (bytes > data.Length)
		{
			Console.WriteLine("Too many bytes");
			return;
		}
		try
		{
			fileStream = new FileStream(outfile, FileMode.Create);
			fileStream.Write(data, 0, bytes);
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			fileStream.Close();
		}
	}

	private static void showWin32Error(int errorcode)
	{
		Win32Exception ex = new Win32Exception(errorcode);
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Error code:\t 0x{0:X}", ex.ErrorCode);
		Console.WriteLine("Error message:\t {0}\n", ex.Message);
		Console.ForegroundColor = ConsoleColor.Gray;
	}
}
