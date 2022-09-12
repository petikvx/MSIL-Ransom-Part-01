namespace Gecko;

public static class nsIHttpActivityObserverConstants
{
	public const uint ACTIVITY_TYPE_SOCKET_TRANSPORT = 1u;

	public const uint ACTIVITY_TYPE_HTTP_TRANSACTION = 2u;

	public const uint ACTIVITY_SUBTYPE_REQUEST_HEADER = 20481u;

	public const uint ACTIVITY_SUBTYPE_REQUEST_BODY_SENT = 20482u;

	public const uint ACTIVITY_SUBTYPE_RESPONSE_START = 20483u;

	public const uint ACTIVITY_SUBTYPE_RESPONSE_COMPLETE = 20485u;

	public const uint ACTIVITY_SUBTYPE_TRANSACTION_CLOSE = 20486u;
}
