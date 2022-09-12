namespace Gecko.WebIDL;

public class MozNFCPeer : WebIDLBase
{
	public bool IsLost => GetProperty<bool>("isLost");

	public string Session
	{
		get
		{
			return GetProperty<string>("session");
		}
		set
		{
			SetProperty("session", value);
		}
	}

	public MozNFCPeer(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise SendNDEF(nsISupports[] records)
	{
		return CallMethod<Promise>("sendNDEF", records);
	}

	public Promise SendFile(nsIDOMBlob blob)
	{
		return CallMethod<Promise>("sendFile", new object[1] { blob });
	}

	public void NotifyLost()
	{
		CallVoidMethod("notifyLost");
	}
}
