namespace Org.BouncyCastle.Tls;

public abstract class HeartbeatMode
{
	public const short peer_allowed_to_send = 1;

	public const short peer_not_allowed_to_send = 2;

	public static string GetName(short heartbeatMode)
	{
		return heartbeatMode switch
		{
			2 => "peer_not_allowed_to_send", 
			1 => "peer_allowed_to_send", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short heartbeatMode)
	{
		return GetName(heartbeatMode) + "(" + heartbeatMode + ")";
	}

	public static bool IsValid(short heartbeatMode)
	{
		if (heartbeatMode >= 1)
		{
			return heartbeatMode <= 2;
		}
		return false;
	}
}
