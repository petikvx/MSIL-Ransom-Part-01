namespace Gecko;

public class nsIX509CertDBConsts
{
	public const ulong UNTRUSTED = 0uL;

	public const ulong TRUSTED_SSL = 1uL;

	public const ulong TRUSTED_EMAIL = 2uL;

	public const ulong TRUSTED_OBJSIGN = 4uL;

	public const long AppMarketplaceProdPublicRoot = 1L;

	public const long AppMarketplaceProdReviewersRoot = 2L;

	public const long AppMarketplaceDevPublicRoot = 3L;

	public const long AppMarketplaceDevReviewersRoot = 4L;

	public const long AppMarketplaceStageRoot = 5L;

	public const long AppXPCShellRoot = 6L;

	public const long AddonsPublicRoot = 7L;

	public const long AddonsStageRoot = 8L;

	public const long PrivilegedPackageRoot = 9L;

	public const long DeveloperImportedRoot = 10L;

	public const long FLAG_LOCAL_ONLY = 1L;

	public const long FLAG_MUST_BE_EV = 2L;
}
