namespace Gecko.WebIDL;

public class MmsMessage : WebIDLBase
{
	public string Type => GetProperty<string>("type");

	public int Id => GetProperty<int>("id");

	public ulong ThreadId => GetProperty<ulong>("threadId");

	public string IccId => GetProperty<string>("iccId");

	public string Delivery => GetProperty<string>("delivery");

	public object[] DeliveryInfo => GetProperty<object[]>("deliveryInfo");

	public string Sender => GetProperty<string>("sender");

	public string[] Receivers => GetProperty<string[]>("receivers");

	public nsISupports Timestamp => GetProperty<nsISupports>("timestamp");

	public nsISupports SentTimestamp => GetProperty<nsISupports>("sentTimestamp");

	public bool Read => GetProperty<bool>("read");

	public string Subject => GetProperty<string>("subject");

	public string Smil => GetProperty<string>("smil");

	public object[] Attachments => GetProperty<object[]>("attachments");

	public nsISupports ExpiryDate => GetProperty<nsISupports>("expiryDate");

	public bool ReadReportRequested => GetProperty<bool>("readReportRequested");

	public MmsMessage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
