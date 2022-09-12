namespace Gecko;

public class nsIDocShellConsts
{
	public const long INTERNAL_LOAD_FLAGS_NONE = 0L;

	public const long INTERNAL_LOAD_FLAGS_INHERIT_OWNER = 1L;

	public const long INTERNAL_LOAD_FLAGS_DONT_SEND_REFERRER = 2L;

	public const long INTERNAL_LOAD_FLAGS_ALLOW_THIRD_PARTY_FIXUP = 4L;

	public const long INTERNAL_LOAD_FLAGS_FIRST_LOAD = 8L;

	public const long INTERNAL_LOAD_FLAGS_BYPASS_CLASSIFIER = 16L;

	public const long INTERNAL_LOAD_FLAGS_FORCE_ALLOW_COOKIES = 32L;

	public const long INTERNAL_LOAD_FLAGS_IS_SRCDOC = 64L;

	public const long INTERNAL_LOAD_FLAGS_NO_OPENER = 256L;

	public const long ENUMERATE_FORWARDS = 0L;

	public const long ENUMERATE_BACKWARDS = 1L;

	public const ulong APP_TYPE_UNKNOWN = 0uL;

	public const ulong APP_TYPE_MAIL = 1uL;

	public const ulong APP_TYPE_EDITOR = 2uL;

	public const ulong BUSY_FLAGS_NONE = 0uL;

	public const ulong BUSY_FLAGS_BUSY = 1uL;

	public const ulong BUSY_FLAGS_BEFORE_PAGE_LOAD = 2uL;

	public const ulong BUSY_FLAGS_PAGE_LOADING = 4uL;

	public const ulong LOAD_CMD_NORMAL = 1uL;

	public const ulong LOAD_CMD_RELOAD = 2uL;

	public const ulong LOAD_CMD_HISTORY = 4uL;

	public const ulong LOAD_CMD_PUSHSTATE = 8uL;
}
