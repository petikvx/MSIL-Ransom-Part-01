namespace Gecko.WebIDL;

public class UserProximityEvent : WebIDLBase
{
	public bool Near => GetProperty<bool>("near");

	public UserProximityEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
