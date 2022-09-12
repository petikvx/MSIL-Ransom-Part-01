namespace Gecko;

public class nsINSSErrorsServiceConsts
{
	public const ulong ERROR_CLASS_SSL_PROTOCOL = 1uL;

	public const ulong ERROR_CLASS_BAD_CERT = 2uL;

	public const long NSS_SEC_ERROR_BASE = -8192L;

	public const long NSS_SEC_ERROR_LIMIT = -7192L;

	public const long NSS_SSL_ERROR_BASE = -12288L;

	public const long NSS_SSL_ERROR_LIMIT = -11288L;

	public const long MOZILLA_PKIX_ERROR_BASE = -16384L;

	public const long MOZILLA_PKIX_ERROR_LIMIT = -15384L;
}
