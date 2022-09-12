namespace Gecko;

public class nsIWebNavigationConsts
{
	public const ulong LOAD_FLAGS_MASK = 65535uL;

	public const ulong LOAD_FLAGS_NONE = 0uL;

	public const ulong LOAD_FLAGS_IS_REFRESH = 16uL;

	public const ulong LOAD_FLAGS_IS_LINK = 32uL;

	public const ulong LOAD_FLAGS_BYPASS_HISTORY = 64uL;

	public const ulong LOAD_FLAGS_REPLACE_HISTORY = 128uL;

	public const ulong LOAD_FLAGS_BYPASS_CACHE = 256uL;

	public const ulong LOAD_FLAGS_BYPASS_PROXY = 512uL;

	public const ulong LOAD_FLAGS_CHARSET_CHANGE = 1024uL;

	public const ulong LOAD_FLAGS_STOP_CONTENT = 2048uL;

	public const ulong LOAD_FLAGS_FROM_EXTERNAL = 4096uL;

	public const ulong LOAD_FLAGS_ALLOW_MIXED_CONTENT = 8192uL;

	public const ulong LOAD_FLAGS_FIRST_LOAD = 16384uL;

	public const ulong LOAD_FLAGS_ALLOW_POPUPS = 32768uL;

	public const ulong LOAD_FLAGS_BYPASS_CLASSIFIER = 65536uL;

	public const ulong LOAD_FLAGS_FORCE_ALLOW_COOKIES = 131072uL;

	public const ulong LOAD_FLAGS_DISALLOW_INHERIT_OWNER = 262144uL;

	public const ulong LOAD_FLAGS_ERROR_LOAD_CHANGES_RV = 524288uL;

	public const ulong LOAD_FLAGS_ALLOW_THIRD_PARTY_FIXUP = 1048576uL;

	public const ulong LOAD_FLAGS_FIXUP_SCHEME_TYPOS = 2097152uL;

	public const ulong STOP_NETWORK = 1uL;

	public const ulong STOP_CONTENT = 2uL;

	public const ulong STOP_ALL = 3uL;
}
