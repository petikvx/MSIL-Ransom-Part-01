namespace Gecko;

public class nsIProtocolHandlerConsts
{
	public const ulong URI_STD = 0uL;

	public const ulong URI_NORELATIVE = 1uL;

	public const ulong URI_NOAUTH = 2uL;

	public const ulong ALLOWS_PROXY = 4uL;

	public const ulong ALLOWS_PROXY_HTTP = 8uL;

	public const ulong URI_INHERITS_SECURITY_CONTEXT = 16uL;

	public const ulong URI_FORBIDS_AUTOMATIC_DOCUMENT_REPLACEMENT = 32uL;

	public const ulong URI_LOADABLE_BY_ANYONE = 64uL;

	public const ulong URI_DANGEROUS_TO_LOAD = 128uL;

	public const ulong URI_IS_UI_RESOURCE = 256uL;

	public const ulong URI_IS_LOCAL_FILE = 512uL;

	public const ulong URI_LOADABLE_BY_SUBSUMERS = 1024uL;

	public const ulong URI_DOES_NOT_RETURN_DATA = 2048uL;

	public const ulong URI_IS_LOCAL_RESOURCE = 4096uL;

	public const ulong URI_OPENING_EXECUTES_SCRIPT = 8192uL;

	public const ulong URI_NON_PERSISTABLE = 16384uL;

	public const ulong URI_FORBIDS_COOKIE_ACCESS = 32768uL;

	public const ulong URI_CROSS_ORIGIN_NEEDS_WEBAPPS_PERM = 65536uL;

	public const ulong URI_SYNC_LOAD_IS_OK = 131072uL;

	public const ulong URI_SAFE_TO_LOAD_IN_SECURE_CONTEXT = 262144uL;

	public const ulong URI_FETCHABLE_BY_ANYONE = 524288uL;
}
