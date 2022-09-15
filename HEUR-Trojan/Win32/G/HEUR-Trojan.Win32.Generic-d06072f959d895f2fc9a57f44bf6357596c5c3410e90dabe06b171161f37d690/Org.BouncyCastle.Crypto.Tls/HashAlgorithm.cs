namespace Org.BouncyCastle.Crypto.Tls;

public abstract class HashAlgorithm
{
	public const byte none = 0;

	public const byte md5 = 1;

	public const byte sha1 = 2;

	public const byte sha224 = 3;

	public const byte sha256 = 4;

	public const byte sha384 = 5;

	public const byte sha512 = 6;

	public static string GetName(byte hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			0 => "none", 
			1 => "md5", 
			2 => "sha1", 
			3 => "sha224", 
			4 => "sha256", 
			5 => "sha384", 
			6 => "sha512", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(byte hashAlgorithm)
	{
		return GetName(hashAlgorithm) + "(" + hashAlgorithm + ")";
	}

	public static bool IsPrivate(byte hashAlgorithm)
	{
		if (224 <= hashAlgorithm)
		{
			return hashAlgorithm <= byte.MaxValue;
		}
		return false;
	}

	public static bool IsRecognized(byte hashAlgorithm)
	{
		if ((uint)(hashAlgorithm - 1) <= 5u)
		{
			return true;
		}
		return false;
	}
}
