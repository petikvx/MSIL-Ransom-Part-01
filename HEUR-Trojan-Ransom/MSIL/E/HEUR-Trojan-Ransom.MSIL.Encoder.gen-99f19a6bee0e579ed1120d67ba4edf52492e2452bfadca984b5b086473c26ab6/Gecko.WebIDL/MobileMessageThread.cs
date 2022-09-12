namespace Gecko.WebIDL;

public class MobileMessageThread : WebIDLBase
{
	public ulong Id => GetProperty<ulong>("id");

	public string LastMessageSubject => GetProperty<string>("lastMessageSubject");

	public string Body => GetProperty<string>("body");

	public ulong UnreadCount => GetProperty<ulong>("unreadCount");

	public string[] Participants => GetProperty<string[]>("participants");

	public nsISupports Timestamp => GetProperty<nsISupports>("timestamp");

	public string LastMessageType => GetProperty<string>("lastMessageType");

	public MobileMessageThread(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
