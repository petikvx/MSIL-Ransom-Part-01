namespace Gecko.WebIDL;

public class TouchList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public TouchList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports IdentifiedTouch(int identifier)
	{
		return CallMethod<nsISupports>("identifiedTouch", new object[1] { identifier });
	}
}
