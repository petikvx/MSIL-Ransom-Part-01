namespace Org.BouncyCastle.Tls;

public abstract class PrfAlgorithm
{
	public const int ssl_prf_legacy = 0;

	public const int tls_prf_legacy = 1;

	public const int tls_prf_sha256 = 2;

	public const int tls_prf_sha384 = 3;

	public const int tls13_hkdf_sha256 = 4;

	public const int tls13_hkdf_sha384 = 5;

	public const int tls13_hkdf_sm3 = 7;

	public static string GetName(int prfAlgorithm)
	{
		return prfAlgorithm switch
		{
			0 => "ssl_prf_legacy", 
			1 => "tls_prf_legacy", 
			2 => "tls_prf_sha256", 
			3 => "tls_prf_sha384", 
			4 => "tls13_hkdf_sha256", 
			5 => "tls13_hkdf_sha384", 
			7 => "tls13_hkdf_sm3", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(int prfAlgorithm)
	{
		return GetName(prfAlgorithm) + "(" + prfAlgorithm + ")";
	}
}
