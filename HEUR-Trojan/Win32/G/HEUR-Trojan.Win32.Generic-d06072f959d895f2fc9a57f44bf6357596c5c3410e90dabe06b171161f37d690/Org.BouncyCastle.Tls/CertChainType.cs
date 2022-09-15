namespace Org.BouncyCastle.Tls;

public abstract class CertChainType
{
	public const short individual_certs = 0;

	public const short pkipath = 1;

	public static string GetName(short certChainType)
	{
		return certChainType switch
		{
			1 => "pkipath", 
			0 => "individual_certs", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short certChainType)
	{
		return GetName(certChainType) + "(" + certChainType + ")";
	}

	public static bool IsValid(short certChainType)
	{
		if (certChainType >= 0)
		{
			return certChainType <= 1;
		}
		return false;
	}
}
