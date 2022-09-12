namespace Gecko;

public class nsIHttpActivityObserverConsts
{
	public const ulong ACTIVITY_TYPE_SOCKET_TRANSPORT = 1uL;

	public const ulong ACTIVITY_TYPE_HTTP_TRANSACTION = 2uL;

	public const ulong ACTIVITY_SUBTYPE_REQUEST_HEADER = 20481uL;

	public const ulong ACTIVITY_SUBTYPE_REQUEST_BODY_SENT = 20482uL;

	public const ulong ACTIVITY_SUBTYPE_RESPONSE_START = 20483uL;

	public const ulong ACTIVITY_SUBTYPE_RESPONSE_HEADER = 20484uL;

	public const ulong ACTIVITY_SUBTYPE_RESPONSE_COMPLETE = 20485uL;

	public const ulong ACTIVITY_SUBTYPE_TRANSACTION_CLOSE = 20486uL;
}
