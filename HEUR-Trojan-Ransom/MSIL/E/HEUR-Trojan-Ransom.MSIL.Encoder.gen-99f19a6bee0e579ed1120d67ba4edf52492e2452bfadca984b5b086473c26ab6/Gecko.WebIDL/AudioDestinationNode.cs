namespace Gecko.WebIDL;

public class AudioDestinationNode : WebIDLBase
{
	public uint MaxChannelCount => GetProperty<uint>("maxChannelCount");

	public AudioDestinationNode(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
