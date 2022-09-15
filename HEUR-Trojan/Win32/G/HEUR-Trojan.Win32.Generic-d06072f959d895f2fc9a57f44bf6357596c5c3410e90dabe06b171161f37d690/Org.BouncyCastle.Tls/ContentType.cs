namespace Org.BouncyCastle.Tls;

public abstract class ContentType
{
	public const short change_cipher_spec = 20;

	public const short alert = 21;

	public const short handshake = 22;

	public const short application_data = 23;

	public const short heartbeat = 24;

	public static string GetName(short contentType)
	{
		return contentType switch
		{
			20 => "change_cipher_spec", 
			21 => "alert", 
			22 => "handshake", 
			23 => "application_data", 
			24 => "heartbeat", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short contentType)
	{
		return GetName(contentType) + "(" + contentType + ")";
	}
}
