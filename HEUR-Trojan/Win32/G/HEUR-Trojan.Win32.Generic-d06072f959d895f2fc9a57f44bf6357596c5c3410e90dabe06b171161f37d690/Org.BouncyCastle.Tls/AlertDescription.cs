namespace Org.BouncyCastle.Tls;

public abstract class AlertDescription
{
	public const short close_notify = 0;

	public const short unexpected_message = 10;

	public const short bad_record_mac = 20;

	public const short decryption_failed = 21;

	public const short record_overflow = 22;

	public const short decompression_failure = 30;

	public const short handshake_failure = 40;

	public const short no_certificate = 41;

	public const short bad_certificate = 42;

	public const short unsupported_certificate = 43;

	public const short certificate_revoked = 44;

	public const short certificate_expired = 45;

	public const short certificate_unknown = 46;

	public const short illegal_parameter = 47;

	public const short unknown_ca = 48;

	public const short access_denied = 49;

	public const short decode_error = 50;

	public const short decrypt_error = 51;

	public const short export_restriction = 60;

	public const short protocol_version = 70;

	public const short insufficient_security = 71;

	public const short internal_error = 80;

	public const short user_canceled = 90;

	public const short no_renegotiation = 100;

	public const short unsupported_extension = 110;

	public const short certificate_unobtainable = 111;

	public const short unrecognized_name = 112;

	public const short bad_certificate_status_response = 113;

	public const short bad_certificate_hash_value = 114;

	public const short unknown_psk_identity = 115;

	public const short no_application_protocol = 120;

	public const short inappropriate_fallback = 86;

	public const short missing_extension = 109;

	public const short certificate_required = 116;

	public static string GetName(short alertDescription)
	{
		return alertDescription switch
		{
			20 => "bad_record_mac", 
			21 => "decryption_failed", 
			22 => "record_overflow", 
			10 => "unexpected_message", 
			0 => "close_notify", 
			70 => "protocol_version", 
			60 => "export_restriction", 
			30 => "decompression_failure", 
			40 => "handshake_failure", 
			41 => "no_certificate", 
			42 => "bad_certificate", 
			43 => "unsupported_certificate", 
			44 => "certificate_revoked", 
			45 => "certificate_expired", 
			46 => "certificate_unknown", 
			47 => "illegal_parameter", 
			48 => "unknown_ca", 
			49 => "access_denied", 
			50 => "decode_error", 
			51 => "decrypt_error", 
			86 => "inappropriate_fallback", 
			80 => "internal_error", 
			71 => "insufficient_security", 
			120 => "no_application_protocol", 
			100 => "no_renegotiation", 
			109 => "missing_extension", 
			110 => "unsupported_extension", 
			111 => "certificate_unobtainable", 
			112 => "unrecognized_name", 
			113 => "bad_certificate_status_response", 
			114 => "bad_certificate_hash_value", 
			115 => "unknown_psk_identity", 
			116 => "certificate_required", 
			90 => "user_canceled", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short alertDescription)
	{
		return GetName(alertDescription) + "(" + alertDescription + ")";
	}
}
