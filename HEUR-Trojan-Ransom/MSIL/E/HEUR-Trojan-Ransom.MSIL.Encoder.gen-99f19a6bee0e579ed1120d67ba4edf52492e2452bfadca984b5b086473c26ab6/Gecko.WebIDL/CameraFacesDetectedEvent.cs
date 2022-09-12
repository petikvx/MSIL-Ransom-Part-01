namespace Gecko.WebIDL;

public class CameraFacesDetectedEvent : WebIDLBase
{
	public nsISupports[] Faces => GetProperty<nsISupports[]>("faces");

	public CameraFacesDetectedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
