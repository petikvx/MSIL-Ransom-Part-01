namespace Org.BouncyCastle.Tls;

public abstract class PskKeyExchangeMode
{
	public const short psk_ke = 0;

	public const short psk_dhe_ke = 1;

	public static string GetName(short pskKeyExchangeMode)
	{
		return pskKeyExchangeMode switch
		{
			1 => "psk_dhe_ke", 
			0 => "psk_ke", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short pskKeyExchangeMode)
	{
		return GetName(pskKeyExchangeMode) + "(" + pskKeyExchangeMode + ")";
	}
}
