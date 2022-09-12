namespace Gecko.WebIDL;

public class NotifyPaintEvent : WebIDLBase
{
	public nsISupports ClientRects => GetProperty<nsISupports>("clientRects");

	public nsISupports BoundingClientRect => GetProperty<nsISupports>("boundingClientRect");

	public nsISupports PaintRequests => GetProperty<nsISupports>("paintRequests");

	public NotifyPaintEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
