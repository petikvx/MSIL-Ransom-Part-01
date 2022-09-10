using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using _003CPrivateImplementationDetails_003E_007B18A11B1C_002D3AA7_002D4357_002DAAD9_002DCC83BB5216E3_007D;
using A;

namespace MOISHE.Core;

public static class RSAExtensions
{
	[Serializable]
	[CompilerGenerated]
	private sealed class A
	{
		public static readonly A A = new A();

		public static Func<string, string> A;

		public static Func<string, bool> A;

		internal string A(string string_0)
		{
			return string_0.Trim();
		}

		internal bool a(string string_0)
		{
			return !string_0.StartsWith(Class0.bk());
		}
	}

	private const string m_A = "-----BEGIN RSA PUBLIC KEY-----";

	private const string a = "-----END RSA PUBLIC KEY-----";

	private const string B = "-----BEGIN PUBLIC KEY-----";

	private const string b = "-----END PUBLIC KEY-----";

	private const string C = "1.2.840.113549.1.1.1";

	private static void A(RSA rsa_0, byte[] byte_0)
	{
		if (!(rsa_0 is RSACryptoServiceProvider rSACryptoServiceProvider))
		{
			throw new ArgumentException(Class0.bd());
		}
		rSACryptoServiceProvider.ImportCspBlob(byte_0);
	}

	private static byte[] A(RSA rsa_0, out uint uint_0)
	{
		if (!(rsa_0 is RSACryptoServiceProvider rSACryptoServiceProvider))
		{
			throw new ArgumentException(Class0.bd());
		}
		uint_0 = 19u;
		return rSACryptoServiceProvider.ExportCspBlob(includePrivateParameters: false);
	}

	public static byte[] ExportSubjectPublicKeyInfo(this RSA key)
	{
		uint uint_;
		byte[] array = A(key, out uint_);
		using c c = c.A(array.Length);
		Marshal.Copy(array, 0, c.DangerousGetHandle(), array.Length);
		if (global::A.C.CryptEncodeObjectEx(65537u, uint_, c.DangerousGetHandle(), 32768u, IntPtr.Zero, out var c_, out var uint_2))
		{
			using (c_)
			{
				C.B b = default(C.B);
				b.A = new C.A
				{
					A = Class0.bE()
				};
				b.A = new C.a
				{
					A = c_.DangerousGetHandle(),
					A = uint_2
				};
				C.B b2 = b;
				using c c2 = c.A(Marshal.SizeOf(typeof(C.B)));
				Marshal.StructureToPtr((object)b2, c2.DangerousGetHandle(), fDeleteOld: false);
				if (global::A.C.CryptEncodeObjectEx(65537u, 8u, c2.DangerousGetHandle(), 32768u, IntPtr.Zero, out var c_2, out var uint_3))
				{
					using (c_2)
					{
						byte[] array2 = new byte[uint_3];
						Marshal.Copy(c_2.DangerousGetHandle(), array2, 0, (int)uint_3);
						return array2;
					}
				}
				throw new CryptographicException(Class0.be(), new Win32Exception());
			}
		}
		throw new CryptographicException(Class0.bF(), new Win32Exception());
	}

	public static byte[] ExportRSAPublicKey(this RSA key)
	{
		uint uint_;
		byte[] array = A(key, out uint_);
		using c c = c.A(array.Length);
		Marshal.Copy(array, 0, c.DangerousGetHandle(), array.Length);
		if (global::A.C.CryptEncodeObjectEx(65537u, uint_, c.DangerousGetHandle(), 32768u, IntPtr.Zero, out var c_, out var uint_2))
		{
			using (c_)
			{
				byte[] array2 = new byte[uint_2];
				Marshal.Copy(c_.DangerousGetHandle(), array2, 0, (int)uint_2);
				return array2;
			}
		}
		throw new CryptographicException(Class0.bF(), new Win32Exception());
	}

	public static void ImportRSAPublicKey(this RSA key, byte[] derBlob, out int bytesRead)
	{
		using c c = c.A(derBlob.Length);
		Marshal.Copy(derBlob, 0, c.DangerousGetHandle(), derBlob.Length);
		if (global::A.C.CryptDecodeObjectEx(65537u, 19u, c.DangerousGetHandle(), (uint)derBlob.Length, 32768u, IntPtr.Zero, out var c_, out var uint_))
		{
			using (c_)
			{
				byte[] array = new byte[uint_];
				Marshal.Copy(c_.DangerousGetHandle(), array, 0, (int)uint_);
				bytesRead = derBlob.Length;
				A(key, array);
				return;
			}
		}
		throw new CryptographicException(Class0.bf(), new Win32Exception());
	}

	public static void ImportSubjectPublicKeyInfo(this RSA key, byte[] certKeyInfoDer, out int bytesRead)
	{
		using c c = c.A(certKeyInfoDer.Length);
		Marshal.Copy(certKeyInfoDer, 0, c.DangerousGetHandle(), certKeyInfoDer.Length);
		if (global::A.C.CryptDecodeObjectEx(65537u, 8u, c.DangerousGetHandle(), (uint)certKeyInfoDer.Length, 32768u, IntPtr.Zero, out var c_, out var _))
		{
			using (c_)
			{
				C.B b = (C.B)Marshal.PtrToStructure(c_.DangerousGetHandle(), typeof(C.B));
				if (b.A.A != Class0.bE())
				{
					throw new CryptographicException(Class0.bG());
				}
				if (global::A.C.CryptDecodeObjectEx(65537u, 19u, b.A.A, b.A.A, 32768u, IntPtr.Zero, out var c_2, out var uint_2))
				{
					using (c_2)
					{
						byte[] array = new byte[uint_2];
						Marshal.Copy(c_2.DangerousGetHandle(), array, 0, (int)uint_2);
						bytesRead = certKeyInfoDer.Length;
						A(key, array);
						return;
					}
				}
				throw new CryptographicException(Class0.bg(), new Win32Exception());
			}
		}
		throw new CryptographicException(Class0.bH(), new Win32Exception());
	}

	public static void ImportFromPem(this RSA key, string source, out RsaPublicKeyFormat format)
	{
		source = source.Trim();
		if (source.StartsWith(Class0.bh()) && source.EndsWith(Class0.bI()))
		{
			format = RsaPublicKeyFormat.SubjectPublicKeyInfo;
		}
		else
		{
			if (!source.StartsWith(Class0.ap()) || !source.EndsWith(Class0.aQ()))
			{
				throw new FormatException(Class0.bi());
			}
			format = RsaPublicKeyFormat.RsaPublicKey;
		}
		byte[] array = Convert.FromBase64String(string.Concat(from string_0 in source.Split(new char[1] { '\n' })
			select string_0.Trim() into string_0
			where !string_0.StartsWith(Class0.bk())
			select string_0));
		int bytesRead;
		if (format == RsaPublicKeyFormat.RsaPublicKey)
		{
			ImportRSAPublicKey(key, array, out bytesRead);
		}
		else
		{
			ImportSubjectPublicKeyInfo(key, array, out bytesRead);
		}
	}

	public static string ExportToPem(this RSA key, RsaPublicKeyFormat format)
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (format)
		{
		case RsaPublicKeyFormat.RsaPublicKey:
			stringBuilder.AppendLine(Class0.ap());
			stringBuilder.AppendLine(Convert.ToBase64String(ExportRSAPublicKey(key), Base64FormattingOptions.InsertLineBreaks));
			stringBuilder.AppendLine(Class0.aQ());
			break;
		case RsaPublicKeyFormat.SubjectPublicKeyInfo:
			stringBuilder.AppendLine(Class0.bh());
			stringBuilder.AppendLine(Convert.ToBase64String(ExportSubjectPublicKeyInfo(key), Base64FormattingOptions.InsertLineBreaks));
			stringBuilder.AppendLine(Class0.bI());
			break;
		default:
			throw new ArgumentException(Class0.bJ());
		}
		return stringBuilder.ToString();
	}
}
