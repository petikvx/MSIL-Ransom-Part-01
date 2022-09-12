namespace Gecko.WebIDL;

public class SmsMessage : WebIDLBase
{
	public string Type => GetProperty<string>("type");

	public int Id => GetProperty<int>("id");

	public ulong ThreadId => GetProperty<ulong>("threadId");

	public string IccId => GetProperty<string>("iccId");

	public string Delivery => GetProperty<string>("delivery");

	public string DeliveryStatus => GetProperty<string>("deliveryStatus");

	public string Sender => GetProperty<string>("sender");

	public string Receiver => GetProperty<string>("receiver");

	public string Body => GetProperty<string>("body");

	public string MessageClass => GetProperty<string>("messageClass");

	public nsISupports Timestamp => GetProperty<nsISupports>("timestamp");

	public nsISupports SentTimestamp => GetProperty<nsISupports>("sentTimestamp");

	public nsISupports DeliveryTimestamp => GetProperty<nsISupports>("deliveryTimestamp");

	public bool Read => GetProperty<bool>("read");

	public SmsMessage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
