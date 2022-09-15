namespace Org.BouncyCastle.Tls;

public abstract class HashAlgorithm
{
	public const short none = 0;

	public const short md5 = 1;

	public const short sha1 = 2;

	public const short sha224 = 3;

	public const short sha256 = 4;

	public const short sha384 = 5;

	public const short sha512 = 6;

	public const short Intrinsic = 8;

	public static string GetName(short hashAlgorithm)
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
			8 => "Intrinsic", 
			_ => "UNKNOWN", 
		};
	}

	public static int GetOutputSize(short hashAlgorithm)
	{
		return hashAlgorithm switch
		{
			1 => 16, 
			2 => 20, 
			3 => 28, 
			4 => 32, 
			5 => 48, 
			6 => 64, 
			_ => -1, 
		};
	}

	public static string GetText(short hashAlgorithm)
	{
		return GetName(hashAlgorithm) + "(" + hashAlgorithm + ")";
	}

	public static bool IsPrivate(short hashAlgorithm)
	{
		if (224 <= hashAlgorithm)
		{
			return hashAlgorithm <= 255;
		}
		return false;
	}

	public static bool IsRecognized(short hashAlgorithm)
	{
		if ((uint)(hashAlgorithm - 1) > 5u && hashAlgorithm != 8)
		{
			return false;
		}
		return true;
	}
}
