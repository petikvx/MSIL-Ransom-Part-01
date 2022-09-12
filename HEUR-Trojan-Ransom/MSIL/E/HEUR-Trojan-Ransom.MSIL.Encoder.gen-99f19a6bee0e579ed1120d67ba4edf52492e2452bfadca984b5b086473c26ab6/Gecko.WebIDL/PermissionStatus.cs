namespace Gecko.WebIDL;

public class PermissionStatus : WebIDLBase
{
	public PermissionState State => GetProperty<PermissionState>("state");

	public PermissionStatus(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
