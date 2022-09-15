namespace Org.BouncyCastle.Tls;

public abstract class HandshakeType
{
	public const short hello_request = 0;

	public const short client_hello = 1;

	public const short server_hello = 2;

	public const short certificate = 11;

	public const short server_key_exchange = 12;

	public const short certificate_request = 13;

	public const short server_hello_done = 14;

	public const short certificate_verify = 15;

	public const short client_key_exchange = 16;

	public const short finished = 20;

	public const short certificate_url = 21;

	public const short certificate_status = 22;

	public const short hello_verify_request = 3;

	public const short supplemental_data = 23;

	public const short new_session_ticket = 4;

	public const short end_of_early_data = 5;

	public const short hello_retry_request = 6;

	public const short encrypted_extensions = 8;

	public const short key_update = 24;

	public const short message_hash = 254;

	public static string GetName(short handshakeType)
	{
		return handshakeType switch
		{
			254 => "message_hash", 
			0 => "hello_request", 
			1 => "client_hello", 
			2 => "server_hello", 
			3 => "hello_verify_request", 
			4 => "new_session_ticket", 
			5 => "end_of_early_data", 
			6 => "hello_retry_request", 
			8 => "encrypted_extensions", 
			11 => "certificate", 
			12 => "server_key_exchange", 
			13 => "certificate_request", 
			14 => "server_hello_done", 
			15 => "certificate_verify", 
			16 => "client_key_exchange", 
			20 => "finished", 
			21 => "certificate_url", 
			22 => "certificate_status", 
			23 => "supplemental_data", 
			24 => "key_update", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short handshakeType)
	{
		return GetName(handshakeType) + "(" + handshakeType + ")";
	}

	public static bool IsRecognized(short handshakeType)
	{
		switch (handshakeType)
		{
		default:
			return false;
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 8:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
		case 254:
			return true;
		}
	}
}
