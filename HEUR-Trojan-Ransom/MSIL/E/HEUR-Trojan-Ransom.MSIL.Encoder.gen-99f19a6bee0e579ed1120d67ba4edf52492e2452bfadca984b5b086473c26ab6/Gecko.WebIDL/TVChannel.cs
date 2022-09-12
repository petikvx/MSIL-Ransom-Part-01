namespace Gecko.WebIDL;

public class TVChannel : WebIDLBase
{
	public string NetworkId => GetProperty<string>("networkId");

	public string TransportStreamId => GetProperty<string>("transportStreamId");

	public string ServiceId => GetProperty<string>("serviceId");

	public nsISupports Source => GetProperty<nsISupports>("source");

	public TVChannelType Type => GetProperty<TVChannelType>("type");

	public string Name => GetProperty<string>("name");

	public string Number => GetProperty<string>("number");

	public bool IsEmergency => GetProperty<bool>("isEmergency");

	public bool IsFree => GetProperty<bool>("isFree");

	public TVChannel(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports[]> GetPrograms()
	{
		return CallMethod<Promise<nsISupports[]>>("getPrograms", new object[0]);
	}

	public Promise<nsISupports[]> GetPrograms(object options)
	{
		return CallMethod<Promise<nsISupports[]>>("getPrograms", new object[1] { options });
	}

	public Promise<nsISupports> GetCurrentProgram()
	{
		return CallMethod<Promise<nsISupports>>("getCurrentProgram", new object[0]);
	}
}
