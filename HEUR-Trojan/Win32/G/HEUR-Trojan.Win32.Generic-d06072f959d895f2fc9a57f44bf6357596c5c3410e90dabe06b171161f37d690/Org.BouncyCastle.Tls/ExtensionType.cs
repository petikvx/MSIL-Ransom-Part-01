namespace Org.BouncyCastle.Tls;

public abstract class ExtensionType
{
	public const int server_name = 0;

	public const int max_fragment_length = 1;

	public const int client_certificate_url = 2;

	public const int trusted_ca_keys = 3;

	public const int truncated_hmac = 4;

	public const int status_request = 5;

	public const int user_mapping = 6;

	public const int client_authz = 7;

	public const int server_authz = 8;

	public const int cert_type = 9;

	public const int supported_groups = 10;

	public const int ec_point_formats = 11;

	public const int srp = 12;

	public const int signature_algorithms = 13;

	public const int use_srtp = 14;

	public const int heartbeat = 15;

	public const int application_layer_protocol_negotiation = 16;

	public const int status_request_v2 = 17;

	public const int signed_certificate_timestamp = 18;

	public const int client_certificate_type = 19;

	public const int server_certificate_type = 20;

	public const int padding = 21;

	public const int encrypt_then_mac = 22;

	public const int extended_master_secret = 23;

	public const int token_binding = 24;

	public const int cached_info = 25;

	public const int record_size_limit = 28;

	public const int session_ticket = 35;

	public const int pre_shared_key = 41;

	public const int early_data = 42;

	public const int supported_versions = 43;

	public const int cookie = 44;

	public const int psk_key_exchange_modes = 45;

	public const int certificate_authorities = 47;

	public const int oid_filters = 48;

	public const int post_handshake_auth = 49;

	public const int signature_algorithms_cert = 50;

	public const int key_share = 51;

	public const int renegotiation_info = 65281;

	public static string GetName(int extensionType)
	{
		return extensionType switch
		{
			65281 => "renegotiation_info", 
			0 => "server_name", 
			1 => "max_fragment_length", 
			2 => "client_certificate_url", 
			3 => "trusted_ca_keys", 
			4 => "truncated_hmac", 
			5 => "status_request", 
			6 => "user_mapping", 
			7 => "client_authz", 
			8 => "server_authz", 
			9 => "cert_type", 
			10 => "supported_groups", 
			11 => "ec_point_formats", 
			12 => "srp", 
			13 => "signature_algorithms", 
			14 => "use_srtp", 
			15 => "heartbeat", 
			16 => "application_layer_protocol_negotiation", 
			17 => "status_request_v2", 
			18 => "signed_certificate_timestamp", 
			19 => "client_certificate_type", 
			20 => "server_certificate_type", 
			21 => "padding", 
			22 => "encrypt_then_mac", 
			23 => "extended_master_secret", 
			24 => "token_binding", 
			25 => "cached_info", 
			28 => "record_size_limit", 
			35 => "session_ticket", 
			41 => "pre_shared_key", 
			42 => "early_data", 
			43 => "supported_versions", 
			44 => "cookie", 
			45 => "psk_key_exchange_modes", 
			47 => "certificate_authorities", 
			48 => "oid_filters", 
			49 => "post_handshake_auth", 
			50 => "signature_algorithms_cert", 
			51 => "key_share", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(int extensionType)
	{
		return GetName(extensionType) + "(" + extensionType + ")";
	}

	public static bool IsRecognized(int extensionType)
	{
		switch (extensionType)
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
		case 7:
		case 8:
		case 9:
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
		case 22:
		case 23:
		case 24:
		case 25:
		case 28:
		case 35:
		case 41:
		case 42:
		case 43:
		case 44:
		case 45:
		case 47:
		case 48:
		case 49:
		case 50:
		case 51:
		case 65281:
			return true;
		}
	}
}
