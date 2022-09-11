#define DEBUG
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography;
using _003Cdion2ntty2ic0uyoe_003E_007B43570453_002D3AD8_002D4A5B_002DB273_002D83DF8156D820_007D;
using C3554254475;
using C3904355907;

namespace C1255198513;

public sealed class C2852464175 : C856455061
{
	private const CipherMode m_C3554254475 = CipherMode.CBC;

	private const PaddingMode m_C3554254475 = PaddingMode.PKCS7;

	private static global::C3554254475.C3865851505 m_C3554254475;

	[SpecialName]
	public static global::C3554254475.C3865851505 C1037565863()
	{
		global::C3554254475.C3865851505 c3865851505 = C2852464175.m_C3554254475;
		if (c3865851505 == null)
		{
			c3865851505 = (C2852464175.m_C3554254475 = new global::C3554254475.C3865851505(new byte[16]
			{
				49, 193, 242, 230, 191, 113, 67, 80, 190, 88,
				5, 33, 106, 252, 90, 255
			}));
		}
		return c3865851505;
	}

	[SpecialName]
	public global::C3554254475.C3865851505 C3554254475()
	{
		return C1037565863();
	}

	[SpecialName]
	public string C3904355907()
	{
		return DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kp() + global::C3554254475.C4110462503.C878818188().Replace(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kn(), DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KQ()) + DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kq();
	}

	private static void C3554254475(Stream stream_0, bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		if (stream_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.C453955339());
		}
		if (byte_0 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cA());
		}
		if (byte_0.Length != 32)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.cA());
		}
		if (byte_1 == null)
		{
			Debug.Assert(condition: false);
			throw new ArgumentNullException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KR());
		}
		if (byte_1.Length != 16)
		{
			Debug.Assert(condition: false);
			throw new ArgumentOutOfRangeException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KR());
		}
		if (bool_0)
		{
			Debug.Assert(stream_0.CanWrite);
			if (!stream_0.CanWrite)
			{
				throw new ArgumentException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Kr());
			}
		}
		else
		{
			Debug.Assert(stream_0.CanRead);
			if (!stream_0.CanRead)
			{
				throw new ArgumentException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.KS());
			}
		}
	}

	private static Stream C3904355907(Stream stream_0, bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		C3554254475(stream_0, bool_0, byte_0, byte_1);
		SymmetricAlgorithm symmetricAlgorithm = global::C3904355907.C1304234792.C3904355907();
		if (symmetricAlgorithm.BlockSize != 128)
		{
			Debug.Assert(condition: false);
			symmetricAlgorithm.BlockSize = 128;
		}
		symmetricAlgorithm.KeySize = 256;
		symmetricAlgorithm.Mode = CipherMode.CBC;
		symmetricAlgorithm.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = ((!bool_0) ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1));
		if (cryptoTransform == null)
		{
			Debug.Assert(condition: false);
			throw new SecurityException(DC0DFFA6_002DD07E_002D4569_002D8923_002D61FED0540CB3.Ks());
		}
		return new global::C3904355907.C4024072794(stream_0, cryptoTransform, bool_0 ? CryptoStreamMode.Write : CryptoStreamMode.Read, symmetricAlgorithm);
	}

	public Stream C3554254475(Stream stream_0, byte[] byte_0, byte[] byte_1)
	{
		return C3904355907(stream_0, bool_0: true, byte_0, byte_1);
	}

	public Stream C3904355907(Stream stream_0, byte[] byte_0, byte[] byte_1)
	{
		return C3904355907(stream_0, bool_0: false, byte_0, byte_1);
	}
}
