namespace Gecko;

public class nsIRequestConsts
{
	public const ulong LOAD_REQUESTMASK = 65535uL;

	public const ulong LOAD_NORMAL = 0uL;

	public const ulong LOAD_BACKGROUND = 1uL;

	public const ulong INHIBIT_PIPELINE = 64uL;

	public const ulong INHIBIT_CACHING = 128uL;

	public const ulong INHIBIT_PERSISTENT_CACHING = 256uL;

	public const ulong LOAD_BYPASS_CACHE = 512uL;

	public const ulong LOAD_FROM_CACHE = 1024uL;

	public const ulong VALIDATE_ALWAYS = 2048uL;

	public const ulong VALIDATE_NEVER = 4096uL;

	public const ulong VALIDATE_ONCE_PER_SESSION = 8192uL;

	public const ulong LOAD_ANONYMOUS = 16384uL;

	public const ulong LOAD_FRESH_CONNECTION = 32768uL;
}
