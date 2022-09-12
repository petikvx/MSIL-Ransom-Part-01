namespace Gecko.WebIDL;

public class NetworkStatsData : WebIDLBase
{
	public ulong ReceivedBytes => GetProperty<ulong>("receivedBytes");

	public ulong SentBytes => GetProperty<ulong>("sentBytes");

	public nsISupports Timestamp => GetProperty<nsISupports>("timestamp");

	public NetworkStatsData(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
