namespace Gecko.WebIDL;

public class PopupBlockedEvent : WebIDLBase
{
	public nsIDOMWindow RequestingWindow => GetProperty<nsIDOMWindow>("requestingWindow");

	public nsISupports PopupWindowURI => GetProperty<nsISupports>("popupWindowURI");

	public string PopupWindowName => GetProperty<string>("popupWindowName");

	public string PopupWindowFeatures => GetProperty<string>("popupWindowFeatures");

	public PopupBlockedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
