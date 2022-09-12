namespace Gecko.WebIDL;

public class ImageCaptureErrorEvent : WebIDLBase
{
	public nsISupports ImageCaptureError => GetProperty<nsISupports>("imageCaptureError");

	public ImageCaptureErrorEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
