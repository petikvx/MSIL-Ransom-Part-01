namespace Gecko.WebIDL;

public class TextTrackList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public nsISupports MediaElement => GetProperty<nsISupports>("mediaElement");

	public TextTrackList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetTrackById(string id)
	{
		return CallMethod<nsISupports>("getTrackById", new object[1] { id });
	}
}
