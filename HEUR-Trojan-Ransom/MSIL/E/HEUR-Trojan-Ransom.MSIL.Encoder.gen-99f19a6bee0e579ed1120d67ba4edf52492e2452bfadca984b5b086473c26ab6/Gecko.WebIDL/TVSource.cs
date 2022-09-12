namespace Gecko.WebIDL;

public class TVSource : WebIDLBase
{
	public nsISupports Tuner => GetProperty<nsISupports>("tuner");

	public TVSourceType Type => GetProperty<TVSourceType>("type");

	public bool IsScanning => GetProperty<bool>("isScanning");

	public nsISupports CurrentChannel => GetProperty<nsISupports>("currentChannel");

	public TVSource(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> GetChannels()
	{
		return CallMethod<Promise<nsISupports[]>>("getChannels", new object[0]);
	}

	public Promise SetCurrentChannel(string channelNumber)
	{
		return CallMethod<Promise>("setCurrentChannel", new object[1] { channelNumber });
	}

	public Promise StartScanning()
	{
		return CallMethod<Promise>("startScanning", new object[0]);
	}

	public Promise StartScanning(object options)
	{
		return CallMethod<Promise>("startScanning", new object[1] { options });
	}

	public Promise StopScanning()
	{
		return CallMethod<Promise>("stopScanning", new object[0]);
	}
}
