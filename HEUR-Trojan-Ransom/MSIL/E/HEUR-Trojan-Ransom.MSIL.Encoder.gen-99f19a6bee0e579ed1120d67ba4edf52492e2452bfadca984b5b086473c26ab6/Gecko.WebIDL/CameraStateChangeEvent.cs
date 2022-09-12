namespace Gecko.WebIDL;

public class CameraStateChangeEvent : WebIDLBase
{
	public string NewState => GetProperty<string>("newState");

	public CameraStateChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
