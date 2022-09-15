namespace Org.BouncyCastle.Tls;

public abstract class IdentifierType
{
	public const short pre_agreed = 0;

	public const short key_sha1_hash = 1;

	public const short x509_name = 2;

	public const short cert_sha1_hash = 3;

	public static string GetName(short identifierType)
	{
		return identifierType switch
		{
			0 => "pre_agreed", 
			1 => "key_sha1_hash", 
			2 => "x509_name", 
			3 => "cert_sha1_hash", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short identifierType)
	{
		return GetName(identifierType) + "(" + identifierType + ")";
	}
}
