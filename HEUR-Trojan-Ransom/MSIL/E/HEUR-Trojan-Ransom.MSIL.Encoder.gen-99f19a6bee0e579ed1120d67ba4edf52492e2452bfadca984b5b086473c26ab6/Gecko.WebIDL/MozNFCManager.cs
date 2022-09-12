namespace Gecko.WebIDL;

public class MozNFCManager : WebIDLBase
{
	public MozNFCManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<bool> CheckP2PRegistration(string manifestUrl)
	{
		return CallMethod<Promise<bool>>("checkP2PRegistration", new object[1] { manifestUrl });
	}

	public void NotifyUserAcceptedP2P(string manifestUrl)
	{
		CallVoidMethod("notifyUserAcceptedP2P", manifestUrl);
	}

	public void NotifySendFileStatus(byte status, string requestId)
	{
		CallVoidMethod("notifySendFileStatus", status, requestId);
	}

	public Promise StartPoll()
	{
		return CallMethod<Promise>("startPoll", new object[0]);
	}

	public Promise StopPoll()
	{
		return CallMethod<Promise>("stopPoll", new object[0]);
	}

	public Promise PowerOff()
	{
		return CallMethod<Promise>("powerOff", new object[0]);
	}
}
