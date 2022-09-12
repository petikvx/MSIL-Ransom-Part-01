namespace Gecko.WebIDL;

public class BrowserElementAudioChannel : WebIDLBase
{
	public AudioChannel Name => GetProperty<AudioChannel>("name");

	public BrowserElementAudioChannel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetVolume()
	{
		return CallMethod<nsISupports>("getVolume", new object[0]);
	}

	public nsISupports SetVolume(float aVolume)
	{
		return CallMethod<nsISupports>("setVolume", new object[1] { aVolume });
	}

	public nsISupports GetMuted()
	{
		return CallMethod<nsISupports>("getMuted", new object[0]);
	}

	public nsISupports SetMuted(bool aMuted)
	{
		return CallMethod<nsISupports>("setMuted", new object[1] { aMuted });
	}

	public nsISupports IsActive()
	{
		return CallMethod<nsISupports>("isActive", new object[0]);
	}

	public nsISupports NotifyChannel(string aEvent)
	{
		return CallMethod<nsISupports>("notifyChannel", new object[1] { aEvent });
	}
}
