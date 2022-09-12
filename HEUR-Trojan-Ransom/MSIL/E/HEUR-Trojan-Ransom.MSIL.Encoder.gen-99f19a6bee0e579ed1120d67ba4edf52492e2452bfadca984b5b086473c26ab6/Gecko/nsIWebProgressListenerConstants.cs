namespace Gecko;

public static class nsIWebProgressListenerConstants
{
	public const ulong STATE_START = 1uL;

	public const ulong STATE_REDIRECTING = 2uL;

	public const ulong STATE_TRANSFERRING = 4uL;

	public const ulong STATE_NEGOTIATING = 8uL;

	public const ulong STATE_STOP = 16uL;

	public const ulong STATE_IS_REQUEST = 65536uL;

	public const ulong STATE_IS_DOCUMENT = 131072uL;

	public const ulong STATE_IS_NETWORK = 262144uL;

	public const ulong STATE_IS_WINDOW = 524288uL;

	public const ulong STATE_RESTORING = 16777216uL;

	public const ulong STATE_IS_INSECURE = 4uL;

	public const ulong STATE_IS_BROKEN = 1uL;

	public const ulong STATE_IS_SECURE = 2uL;

	public const ulong STATE_SECURE_HIGH = 262144uL;

	public const ulong STATE_SECURE_MED = 65536uL;

	public const ulong STATE_SECURE_LOW = 131072uL;

	public const ulong LOCATION_CHANGE_SAME_DOCUMENT = 1uL;

	public const ulong LOCATION_CHANGE_ERROR_PAGE = 2uL;
}
