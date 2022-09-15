namespace Org.BouncyCastle.Tls;

public abstract class MacAlgorithm
{
	public const int cls_null = 0;

	public const int md5 = 1;

	public const int sha = 2;

	public const int hmac_md5 = 1;

	public const int hmac_sha1 = 2;

	public const int hmac_sha256 = 3;

	public const int hmac_sha384 = 4;

	public const int hmac_sha512 = 5;

	public static string GetName(int macAlgorithm)
	{
		return macAlgorithm switch
		{
			0 => "null", 
			1 => "hmac_md5", 
			2 => "hmac_sha1", 
			3 => "hmac_sha256", 
			4 => "hmac_sha384", 
			5 => "hmac_sha512", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(int macAlgorithm)
	{
		return GetName(macAlgorithm) + "(" + macAlgorithm + ")";
	}

	public static bool IsHmac(int macAlgorithm)
	{
		if ((uint)(macAlgorithm - 1) <= 4u)
		{
			return true;
		}
		return false;
	}
}
