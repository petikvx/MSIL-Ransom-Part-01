using System;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class SignatureScheme
{
	public const int rsa_pkcs1_sha1 = 513;

	public const int ecdsa_sha1 = 515;

	public const int rsa_pkcs1_sha256 = 1025;

	public const int rsa_pkcs1_sha384 = 1281;

	public const int rsa_pkcs1_sha512 = 1537;

	public const int ecdsa_secp256r1_sha256 = 1027;

	public const int ecdsa_secp384r1_sha384 = 1283;

	public const int ecdsa_secp521r1_sha512 = 1539;

	public const int rsa_pss_rsae_sha256 = 2052;

	public const int rsa_pss_rsae_sha384 = 2053;

	public const int rsa_pss_rsae_sha512 = 2054;

	public const int ed25519 = 2055;

	public const int ed448 = 2056;

	public const int rsa_pss_pss_sha256 = 2057;

	public const int rsa_pss_pss_sha384 = 2058;

	public const int rsa_pss_pss_sha512 = 2059;

	public const int ecdsa_brainpoolP256r1tls13_sha256 = 2074;

	public const int ecdsa_brainpoolP384r1tls13_sha384 = 2075;

	public const int ecdsa_brainpoolP512r1tls13_sha512 = 2076;

	public const int sm2sig_sm3 = 1800;

	public static int From(SignatureAndHashAlgorithm sigAndHashAlg)
	{
		if (sigAndHashAlg == null)
		{
			throw new ArgumentNullException();
		}
		return From(sigAndHashAlg.Hash, sigAndHashAlg.Signature);
	}

	public static int From(short hashAlgorithm, short signatureAlgorithm)
	{
		return ((hashAlgorithm & 0xFF) << 8) | (signatureAlgorithm & 0xFF);
	}

	public static int GetCryptoHashAlgorithm(int signatureScheme)
	{
		switch (signatureScheme)
		{
		default:
		{
			short hashAlgorithm = GetHashAlgorithm(signatureScheme);
			if (8 != hashAlgorithm && HashAlgorithm.IsRecognized(hashAlgorithm))
			{
				return TlsCryptoUtilities.GetHash(GetHashAlgorithm(signatureScheme));
			}
			return -1;
		}
		case 2055:
		case 2056:
			return -1;
		case 2052:
		case 2057:
		case 2074:
			return 4;
		case 2053:
		case 2058:
		case 2075:
			return 5;
		case 2054:
		case 2059:
		case 2076:
			return 6;
		case 1800:
			return 7;
		}
	}

	public static string GetName(int signatureScheme)
	{
		return signatureScheme switch
		{
			515 => "ecdsa_sha1", 
			513 => "rsa_pkcs1_sha1", 
			1281 => "rsa_pkcs1_sha384", 
			1027 => "ecdsa_secp256r1_sha256", 
			1025 => "rsa_pkcs1_sha256", 
			1539 => "ecdsa_secp521r1_sha512", 
			1537 => "rsa_pkcs1_sha512", 
			1283 => "ecdsa_secp384r1_sha384", 
			2074 => "ecdsa_brainpoolP256r1tls13_sha256", 
			2075 => "ecdsa_brainpoolP384r1tls13_sha384", 
			2076 => "ecdsa_brainpoolP512r1tls13_sha512", 
			2052 => "rsa_pss_rsae_sha256", 
			2053 => "rsa_pss_rsae_sha384", 
			2054 => "rsa_pss_rsae_sha512", 
			2055 => "ed25519", 
			2056 => "ed448", 
			2057 => "rsa_pss_pss_sha256", 
			2058 => "rsa_pss_pss_sha384", 
			2059 => "rsa_pss_pss_sha512", 
			1800 => "sm2sig_sm3", 
			_ => "UNKNOWN", 
		};
	}

	public static int GetNamedGroup(int signatureScheme)
	{
		return signatureScheme switch
		{
			1283 => 24, 
			1027 => 23, 
			2074 => 31, 
			2075 => 32, 
			2076 => 33, 
			1800 => 41, 
			1539 => 25, 
			_ => -1, 
		};
	}

	public static short GetHashAlgorithm(int signatureScheme)
	{
		return (short)((signatureScheme >> 8) & 0xFF);
	}

	public static short GetSignatureAlgorithm(int signatureScheme)
	{
		return (short)(signatureScheme & 0xFF);
	}

	public static SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(int signatureScheme)
	{
		return SignatureAndHashAlgorithm.GetInstance(GetHashAlgorithm(signatureScheme), GetSignatureAlgorithm(signatureScheme));
	}

	public static string GetText(int signatureScheme)
	{
		string text = Platform.ToUpperInvariant(Convert.ToString(signatureScheme, 16));
		return GetName(signatureScheme) + "(0x" + text + ")";
	}

	public static bool IsPrivate(int signatureScheme)
	{
		return signatureScheme >> 9 == 254;
	}

	public static bool IsECDsa(int signatureScheme)
	{
		if ((uint)(signatureScheme - 2074) <= 2u)
		{
			return true;
		}
		return 3 == GetSignatureAlgorithm(signatureScheme);
	}

	public static bool IsRsaPss(int signatureScheme)
	{
		if ((uint)(signatureScheme - 2052) > 2u && (uint)(signatureScheme - 2057) > 2u)
		{
			return false;
		}
		return true;
	}
}
