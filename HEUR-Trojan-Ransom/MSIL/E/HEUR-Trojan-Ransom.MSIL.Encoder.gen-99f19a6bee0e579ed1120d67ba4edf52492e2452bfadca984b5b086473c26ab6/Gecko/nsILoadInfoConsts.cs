namespace Gecko;

public class nsILoadInfoConsts
{
	public const ulong SEC_NORMAL = 0uL;

	public const ulong SEC_REQUIRE_SAME_ORIGIN_DATA_INHERITS = 1uL;

	public const ulong SEC_REQUIRE_SAME_ORIGIN_DATA_IS_BLOCKED = 2uL;

	public const ulong SEC_ALLOW_CROSS_ORIGIN_DATA_INHERITS = 4uL;

	public const ulong SEC_ALLOW_CROSS_ORIGIN_DATA_IS_NULL = 8uL;

	public const ulong SEC_REQUIRE_CORS_DATA_INHERITS = 16uL;

	public const ulong SEC_COOKIES_DEFAULT = 0uL;

	public const ulong SEC_COOKIES_INCLUDE = 32uL;

	public const ulong SEC_COOKIES_SAME_ORIGIN = 64uL;

	public const ulong SEC_COOKIES_OMIT = 96uL;

	public const ulong SEC_FORCE_INHERIT_PRINCIPAL = 128uL;

	public const ulong SEC_SANDBOXED = 256uL;

	public const ulong SEC_ABOUT_BLANK_INHERITS = 512uL;

	public const ulong SEC_ALLOW_CHROME = 1024uL;

	public const ulong SEC_DONT_FOLLOW_REDIRECTS = 2048uL;

	public const ulong TAINTING_BASIC = 0uL;

	public const ulong TAINTING_CORS = 1uL;

	public const ulong TAINTING_OPAQUE = 2uL;
}
