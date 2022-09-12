namespace Gecko;

public class nsIHttpAuthenticatorConsts
{
	public const ulong USING_INTERNAL_IDENTITY = 1uL;

	public const ulong REQUEST_BASED = 1uL;

	public const ulong CONNECTION_BASED = 2uL;

	public const ulong REUSABLE_CREDENTIALS = 4uL;

	public const ulong REUSABLE_CHALLENGE = 8uL;

	public const ulong IDENTITY_IGNORED = 1024uL;

	public const ulong IDENTITY_INCLUDES_DOMAIN = 2048uL;

	public const ulong IDENTITY_ENCRYPTED = 4096uL;
}
