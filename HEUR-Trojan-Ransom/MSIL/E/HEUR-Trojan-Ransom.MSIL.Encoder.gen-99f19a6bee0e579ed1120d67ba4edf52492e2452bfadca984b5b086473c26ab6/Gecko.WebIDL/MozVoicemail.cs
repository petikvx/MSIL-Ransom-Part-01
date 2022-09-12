namespace Gecko.WebIDL;

public class MozVoicemail : WebIDLBase
{
	public MozVoicemail(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetStatus()
	{
		return CallMethod<nsISupports>("getStatus", new object[0]);
	}

	public nsISupports GetStatus(uint serviceId)
	{
		return CallMethod<nsISupports>("getStatus", new object[1] { serviceId });
	}

	public string GetNumber()
	{
		return CallMethod<string>("getNumber", new object[0]);
	}

	public string GetNumber(uint serviceId)
	{
		return CallMethod<string>("getNumber", new object[1] { serviceId });
	}

	public string GetDisplayName()
	{
		return CallMethod<string>("getDisplayName", new object[0]);
	}

	public string GetDisplayName(uint serviceId)
	{
		return CallMethod<string>("getDisplayName", new object[1] { serviceId });
	}
}
