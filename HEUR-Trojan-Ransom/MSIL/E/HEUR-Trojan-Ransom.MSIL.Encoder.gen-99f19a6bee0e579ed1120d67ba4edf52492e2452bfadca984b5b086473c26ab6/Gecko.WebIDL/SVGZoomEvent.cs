namespace Gecko.WebIDL;

public class SVGZoomEvent : WebIDLBase
{
	public float PreviousScale => GetProperty<float>("previousScale");

	public nsISupports PreviousTranslate => GetProperty<nsISupports>("previousTranslate");

	public float NewScale => GetProperty<float>("newScale");

	public nsISupports NewTranslate => GetProperty<nsISupports>("newTranslate");

	public SVGZoomEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
