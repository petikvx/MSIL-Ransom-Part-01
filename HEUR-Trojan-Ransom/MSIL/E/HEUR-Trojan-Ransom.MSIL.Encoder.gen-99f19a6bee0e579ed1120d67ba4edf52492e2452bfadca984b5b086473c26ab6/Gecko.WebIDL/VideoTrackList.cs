namespace Gecko.WebIDL;

public class VideoTrackList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public int SelectedIndex => GetProperty<int>("selectedIndex");

	public VideoTrackList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetTrackById(string id)
	{
		return CallMethod<nsISupports>("getTrackById", new object[1] { id });
	}
}
