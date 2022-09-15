namespace Org.BouncyCastle.Tls;

public abstract class KeyUpdateRequest
{
	public const short update_not_requested = 0;

	public const short update_requested = 1;

	public static string GetName(short keyUpdateRequest)
	{
		return keyUpdateRequest switch
		{
			1 => "update_requested", 
			0 => "update_not_requested", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short keyUpdateRequest)
	{
		return GetName(keyUpdateRequest) + "(" + keyUpdateRequest + ")";
	}

	public static bool IsValid(short keyUpdateRequest)
	{
		if (keyUpdateRequest >= 0)
		{
			return keyUpdateRequest <= 1;
		}
		return false;
	}
}
