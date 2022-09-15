namespace Org.BouncyCastle.Tls;

public abstract class ClientCertificateType
{
	public const short rsa_sign = 1;

	public const short dss_sign = 2;

	public const short rsa_fixed_dh = 3;

	public const short dss_fixed_dh = 4;

	public const short rsa_ephemeral_dh_RESERVED = 5;

	public const short dss_ephemeral_dh_RESERVED = 6;

	public const short fortezza_dms_RESERVED = 20;

	public const short ecdsa_sign = 64;

	public const short rsa_fixed_ecdh = 65;

	public const short ecdsa_fixed_ecdh = 66;

	public const short gost_sign256 = 67;

	public const short gost_sign512 = 68;

	public static string GetName(short clientCertificateType)
	{
		return clientCertificateType switch
		{
			64 => "ecdsa_sign", 
			65 => "rsa_fixed_ecdh", 
			66 => "ecdsa_fixed_ecdh", 
			67 => "gost_sign256", 
			68 => "gost_sign512", 
			20 => "fortezza_dms_RESERVED", 
			1 => "rsa_sign", 
			2 => "dss_sign", 
			3 => "rsa_fixed_dh", 
			4 => "dss_fixed_dh", 
			5 => "rsa_ephemeral_dh_RESERVED", 
			6 => "dss_ephemeral_dh_RESERVED", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short clientCertificateType)
	{
		return GetName(clientCertificateType) + "(" + clientCertificateType + ")";
	}
}
