namespace Gecko.WebIDL;

public class ImageCaptureError : WebIDLBase
{
	public ushort Code => GetProperty<ushort>("code");

	public string Message => GetProperty<string>("message");

	public ImageCaptureError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
