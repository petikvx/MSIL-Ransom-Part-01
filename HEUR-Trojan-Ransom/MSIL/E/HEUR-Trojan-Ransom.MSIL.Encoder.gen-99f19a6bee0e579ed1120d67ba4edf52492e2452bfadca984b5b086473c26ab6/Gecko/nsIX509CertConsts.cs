namespace Gecko;

public class nsIX509CertConsts
{
	public const ulong UNKNOWN_CERT = 0uL;

	public const ulong CA_CERT = 1uL;

	public const ulong USER_CERT = 2uL;

	public const ulong EMAIL_CERT = 4uL;

	public const ulong SERVER_CERT = 8uL;

	public const ulong ANY_CERT = 65535uL;

	public const ulong VERIFIED_OK = 0uL;

	public const ulong NOT_VERIFIED_UNKNOWN = 1uL;

	public const ulong CERT_REVOKED = 2uL;

	public const ulong CERT_EXPIRED = 4uL;

	public const ulong CERT_NOT_TRUSTED = 8uL;

	public const ulong ISSUER_NOT_TRUSTED = 16uL;

	public const ulong ISSUER_UNKNOWN = 32uL;

	public const ulong INVALID_CA = 64uL;

	public const ulong USAGE_NOT_ALLOWED = 128uL;

	public const ulong SIGNATURE_ALGORITHM_DISABLED = 256uL;

	public const ulong CERT_USAGE_SSLClient = 0uL;

	public const ulong CERT_USAGE_SSLServer = 1uL;

	public const ulong CERT_USAGE_SSLServerWithStepUp = 2uL;

	public const ulong CERT_USAGE_SSLCA = 3uL;

	public const ulong CERT_USAGE_EmailSigner = 4uL;

	public const ulong CERT_USAGE_EmailRecipient = 5uL;

	public const ulong CERT_USAGE_ObjectSigner = 6uL;

	public const ulong CERT_USAGE_UserCertImport = 7uL;

	public const ulong CERT_USAGE_VerifyCA = 8uL;

	public const ulong CERT_USAGE_ProtectedObjectSigner = 9uL;

	public const ulong CERT_USAGE_StatusResponder = 10uL;

	public const ulong CERT_USAGE_AnyCA = 11uL;

	public const ulong CMS_CHAIN_MODE_CertOnly = 1uL;

	public const ulong CMS_CHAIN_MODE_CertChain = 2uL;

	public const ulong CMS_CHAIN_MODE_CertChainWithRoot = 3uL;
}
