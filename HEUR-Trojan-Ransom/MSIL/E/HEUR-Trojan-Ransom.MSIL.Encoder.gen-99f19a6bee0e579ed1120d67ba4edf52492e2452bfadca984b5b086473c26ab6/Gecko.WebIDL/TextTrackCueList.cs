namespace Gecko.WebIDL;

public class TextTrackCueList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public TextTrackCueList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetCueById(string id)
	{
		return CallMethod<nsISupports>("getCueById", new object[1] { id });
	}
}
