namespace Gecko;

public class nsIWebProgressConsts
{
	public const ulong NOTIFY_STATE_REQUEST = 1uL;

	public const ulong NOTIFY_STATE_DOCUMENT = 2uL;

	public const ulong NOTIFY_STATE_NETWORK = 4uL;

	public const ulong NOTIFY_STATE_WINDOW = 8uL;

	public const ulong NOTIFY_STATE_ALL = 15uL;

	public const ulong NOTIFY_PROGRESS = 16uL;

	public const ulong NOTIFY_STATUS = 32uL;

	public const ulong NOTIFY_SECURITY = 64uL;

	public const ulong NOTIFY_LOCATION = 128uL;

	public const ulong NOTIFY_REFRESH = 256uL;

	public const ulong NOTIFY_ALL = 511uL;
}
