#define TRACE
using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;

namespace C3904355907;

public sealed class C3463352047
{
	private static global::C3554254475.C2181537457 m_C3554254475;

	private static global::C3554254475.C2181537457 m_C3904355907;

	public static byte[] C3554254475;

	public static byte[] C3904355907;

	public static byte[] C1255198513;

	public static byte[] C1908338681;

	public static string C3554254475;

	private C3463352047()
	{
	}

	public static void C3554254475(ref byte[] byte_0, ref byte[] byte_1, ref global::C3554254475.C2181537457 c2181537457_0)
	{
		C1255198513 = new byte[byte_0.Length];
		C1908338681 = new byte[byte_1.Length];
		Array.Copy(byte_0, C1255198513, byte_0.Length);
		Array.Copy(byte_1, C1908338681, byte_1.Length);
		string string_ = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz();
		C878818188.C3554254475(ref string_, ref c2181537457_0);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(string_);
		byte_0 = rSACryptoServiceProvider.Encrypt(byte_0, fOAEP: true);
		byte_1 = rSACryptoServiceProvider.Encrypt(byte_1, fOAEP: true);
	}

	public static void C3554254475(ref byte[] byte_0, ref byte[] byte_1, ref byte[] byte_2, ref byte[] byte_3)
	{
		string string_ = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz();
		C878818188.C3554254475(ref string_, ref C3463352047.m_C3904355907);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(string_);
		byte_1 = rSACryptoServiceProvider.Decrypt(byte_0, fOAEP: true);
		byte_3 = rSACryptoServiceProvider.Decrypt(byte_2, fOAEP: true);
	}

	public static void C3554254475(ref byte[] byte_0, ref byte[] byte_1)
	{
		byte_0 = new byte[32];
		byte_1 = new byte[12];
		using SHA512Managed sHA512Managed = new SHA512Managed();
		byte[] byte_2 = C2746444292.C3554254475().C3554254475(64u);
		byte[] byte_3 = sHA512Managed.ComputeHash(byte_2);
		C878818188.C3554254475(ref byte_2);
		Array.Copy(byte_3, byte_0, 32);
		Array.Copy(byte_3, 32, byte_1, 0, 12);
		C878818188.C3554254475(ref byte_3);
	}

	public static void C3554254475(ref global::C3554254475.C2181537457 c2181537457_0, ref global::C3554254475.C2181537457 c2181537457_1)
	{
		using RSA rSA = new RSACryptoServiceProvider();
		rSA.KeySize = 2048;
		string string_ = rSA.ToXmlString(includePrivateParameters: true);
		byte[] byte_ = global::C3554254475.C1130791706.C1255198513().GetBytes(string_);
		c2181537457_0 = new global::C3554254475.C2181537457(bool_0: true, byte_);
		C878818188.C3554254475(ref string_);
		C878818188.C3554254475(ref byte_);
		string string_2 = rSA.ToXmlString(includePrivateParameters: false);
		byte[] byte_2 = global::C3554254475.C1130791706.C1255198513().GetBytes(string_2);
		c2181537457_1 = new global::C3554254475.C2181537457(bool_0: true, byte_2);
		C878818188.C3554254475(ref string_2);
		C878818188.C3554254475(ref byte_2);
	}

	public static string C3554254475(string string_0, string string_1)
	{
		SHA256 sHA = SHA256.Create();
		byte[] sourceArray = sHA.ComputeHash(Encoding.ASCII.GetBytes(string_1));
		byte[] iV = new byte[16];
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		byte[] array = new byte[32];
		Array.Copy(sourceArray, 0, array, 0, 32);
		aes.Key = array;
		aes.IV = iV;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateDecryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		string result = string.Empty;
		try
		{
			byte[] array2 = Convert.FromBase64String(string_0);
			cryptoStream.Write(array2, 0, array2.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array3 = memoryStream.ToArray();
			result = Encoding.ASCII.GetString(array3, 0, array3.Length);
		}
		finally
		{
			memoryStream.Close();
			cryptoStream.Close();
		}
		return result;
	}

	public static void C3554254475()
	{
		if (C3463352047.C3554254475 == null)
		{
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.IT());
			C3554254475(ref C3463352047.C3554254475, ref C3463352047.C3904355907);
			C3554254475(ref C3463352047.C3554254475, ref C3463352047.C3904355907, ref C3463352047.m_C3554254475);
		}
		else if (C878818188.C3554254475.Next(1, 100) <= 5)
		{
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.It());
			C3554254475(ref C3463352047.C3554254475, ref C3463352047.C3904355907);
			C3554254475(ref C3463352047.C3554254475, ref C3463352047.C3904355907, ref C3463352047.m_C3554254475);
		}
	}

	public static byte[] C3554254475(string string_0, RSAParameters rsaparameters_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return null;
		}
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(rsaparameters_0);
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
	}

	public static RSAParameters C3554254475(string string_0)
	{
		StringReader textReader = new StringReader(string_0);
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(RSAParameters));
		return (RSAParameters)xmlSerializer.Deserialize(textReader);
	}

	private static byte[] C3554254475(byte[] byte_0, byte[] byte_1)
	{
		int num = byte_0.Length + byte_1.Length;
		byte[] array = new byte[num];
		int num2 = 0;
		for (int i = 0; i < byte_0.Length; i++)
		{
			array[num2] = byte_0[i];
			num2++;
		}
		for (int j = 0; j < byte_1.Length; j++)
		{
			array[num2] = byte_1[j];
			num2++;
		}
		return array;
	}

	public static byte[] C3554254475(byte[] byte_0, int int_0, string string_0, bool bool_0, bool bool_1)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
		rSACryptoServiceProvider.FromXmlString(string_0);
		int num = int_0 / 8;
		int num2 = num - 42;
		int num3 = byte_0.Length;
		int num4 = num3 / num2;
		byte[] array = new byte[0];
		for (int i = 0; i <= num4; i++)
		{
			byte[] array2 = new byte[(num3 - num2 * i > num2) ? num2 : (num3 - num2 * i)];
			Buffer.BlockCopy(byte_0, num2 * i, array2, 0, array2.Length);
			byte[] array3 = rSACryptoServiceProvider.Encrypt(array2, bool_1);
			if (bool_0)
			{
				Array.Reverse((Array)array3);
			}
			array = C3554254475(array, BitConverter.GetBytes(array3.Length));
			array = C3554254475(array, array3);
		}
		rSACryptoServiceProvider.Clear();
		return array;
	}

	public static string C3554254475(string string_0, byte[] byte_0, byte[] byte_1)
	{
		Aes aes = Aes.Create();
		aes.Mode = CipherMode.CBC;
		aes.Key = byte_0;
		aes.IV = byte_1;
		MemoryStream memoryStream = new MemoryStream();
		ICryptoTransform transform = aes.CreateDecryptor();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		string result = string.Empty;
		try
		{
			byte[] array = Convert.FromBase64String(string_0);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array2 = memoryStream.ToArray();
			result = Encoding.ASCII.GetString(array2, 0, array2.Length);
		}
		finally
		{
			memoryStream.Close();
			cryptoStream.Close();
		}
		return result;
	}

	public static void C3904355907()
	{
		Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.IU());
		Trace.Indent();
		if (File.Exists(C3110715001.C1255198513))
		{
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Iu());
			C878818188.C3554254475(C3110715001.C1255198513, ref C3463352047.m_C3554254475);
		}
		else
		{
			Trace.WriteLine(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.IV());
			C3554254475(ref C3463352047.m_C3904355907, ref C3463352047.m_C3554254475);
			C878818188.C3904355907(C3110715001.C1255198513, ref C3463352047.m_C3554254475);
			string string_ = DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cz();
			C878818188.C3554254475(ref string_, ref C3463352047.m_C3904355907);
			byte[] inArray = C3554254475(Encoding.Default.GetBytes(string_), 2048, C3463352047.C3554254475, bool_0: false, bool_1: true);
			string string_2 = Convert.ToBase64String(inArray);
			C878818188.C3554254475(ref string_);
			C1801730948.C3554254475(string_2);
		}
		Trace.Unindent();
	}
}
