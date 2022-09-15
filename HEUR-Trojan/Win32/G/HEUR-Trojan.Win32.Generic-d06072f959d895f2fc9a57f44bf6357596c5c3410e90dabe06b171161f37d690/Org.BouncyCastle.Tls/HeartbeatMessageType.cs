namespace Org.BouncyCastle.Tls;

public abstract class HeartbeatMessageType
{
	public const short heartbeat_request = 1;

	public const short heartbeat_response = 2;

	public static string GetName(short heartbeatMessageType)
	{
		return heartbeatMessageType switch
		{
			2 => "heartbeat_response", 
			1 => "heartbeat_request", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short heartbeatMessageType)
	{
		return GetName(heartbeatMessageType) + "(" + heartbeatMessageType + ")";
	}

	public static bool IsValid(short heartbeatMessageType)
	{
		if (heartbeatMessageType >= 1)
		{
			return heartbeatMessageType <= 2;
		}
		return false;
	}
}
