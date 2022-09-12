namespace Gecko.WebIDL;

public class CameraClosedEvent : WebIDLBase
{
	public string Reason => GetProperty<string>("reason");

	public CameraClosedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
