namespace Org.BouncyCastle.Tls;

public class SignatureAlgorithm
{
	public const short anonymous = 0;

	public const short rsa = 1;

	public const short dsa = 2;

	public const short ecdsa = 3;

	public const short ed25519 = 7;

	public const short ed448 = 8;

	public const short rsa_pss_rsae_sha256 = 4;

	public const short rsa_pss_rsae_sha384 = 5;

	public const short rsa_pss_rsae_sha512 = 6;

	public const short rsa_pss_pss_sha256 = 9;

	public const short rsa_pss_pss_sha384 = 10;

	public const short rsa_pss_pss_sha512 = 11;

	public const short ecdsa_brainpoolP256r1tls13_sha256 = 26;

	public const short ecdsa_brainpoolP384r1tls13_sha384 = 27;

	public const short ecdsa_brainpoolP512r1tls13_sha512 = 28;

	public const short gostr34102012_256 = 64;

	public const short gostr34102012_512 = 65;

	public static short GetClientCertificateType(short signatureAlgorithm)
	{
		switch (signatureAlgorithm)
		{
		default:
			return -1;
		case 65:
			return 68;
		case 64:
			return 67;
		case 2:
			return 2;
		case 3:
		case 7:
		case 8:
			return 64;
		case 1:
		case 4:
		case 5:
		case 6:
		case 9:
		case 10:
		case 11:
			return 1;
		}
	}

	public static string GetName(short signatureAlgorithm)
	{
		return signatureAlgorithm switch
		{
			65 => "gostr34102012_512", 
			64 => "gostr34102012_256", 
			0 => "anonymous", 
			1 => "rsa", 
			2 => "dsa", 
			3 => "ecdsa", 
			4 => "rsa_pss_rsae_sha256", 
			5 => "rsa_pss_rsae_sha384", 
			6 => "rsa_pss_rsae_sha512", 
			7 => "ed25519", 
			8 => "ed448", 
			9 => "rsa_pss_pss_sha256", 
			10 => "rsa_pss_pss_sha384", 
			11 => "rsa_pss_pss_sha512", 
			26 => "ecdsa_brainpoolP256r1tls13_sha256", 
			27 => "ecdsa_brainpoolP384r1tls13_sha384", 
			28 => "ecdsa_brainpoolP512r1tls13_sha512", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short signatureAlgorithm)
	{
		return GetName(signatureAlgorithm) + "(" + signatureAlgorithm + ")";
	}
}
