namespace Gecko.WebIDL;

public class CameraConfigurationEvent : WebIDLBase
{
	public CameraMode Mode => GetProperty<CameraMode>("mode");

	public string RecorderProfile => GetProperty<string>("recorderProfile");

	public nsISupports PreviewSize => GetProperty<nsISupports>("previewSize");

	public nsISupports PictureSize => GetProperty<nsISupports>("pictureSize");

	public CameraConfigurationEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
