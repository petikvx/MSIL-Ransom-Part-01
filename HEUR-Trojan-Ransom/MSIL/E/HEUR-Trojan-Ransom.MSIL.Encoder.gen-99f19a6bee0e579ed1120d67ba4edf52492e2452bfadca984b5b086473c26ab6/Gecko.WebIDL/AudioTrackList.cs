namespace Gecko.WebIDL;

public class AudioTrackList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public AudioTrackList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetTrackById(string id)
	{
		return CallMethod<nsISupports>("getTrackById", new object[1] { id });
	}
}
