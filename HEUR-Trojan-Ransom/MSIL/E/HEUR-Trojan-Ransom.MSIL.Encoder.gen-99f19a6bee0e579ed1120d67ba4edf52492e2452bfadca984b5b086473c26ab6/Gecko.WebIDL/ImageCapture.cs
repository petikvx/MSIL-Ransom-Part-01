namespace Gecko.WebIDL;

public class ImageCapture : WebIDLBase
{
	public nsISupports VideoStreamTrack => GetProperty<nsISupports>("videoStreamTrack");

	public ImageCapture(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void TakePhoto()
	{
		CallVoidMethod("takePhoto");
	}
}
