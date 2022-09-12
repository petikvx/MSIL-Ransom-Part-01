namespace Gecko.WebIDL;

public class TrackEvent : WebIDLBase
{
	public WebIDLUnion<nsISupports, nsISupports, nsISupports> Track => GetProperty<WebIDLUnion<nsISupports, nsISupports, nsISupports>>("track");

	public TrackEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
