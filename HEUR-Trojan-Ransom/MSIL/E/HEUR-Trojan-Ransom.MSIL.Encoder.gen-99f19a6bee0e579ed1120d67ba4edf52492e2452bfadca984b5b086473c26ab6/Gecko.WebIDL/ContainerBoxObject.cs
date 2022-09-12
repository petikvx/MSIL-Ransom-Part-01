namespace Gecko.WebIDL;

public class ContainerBoxObject : WebIDLBase
{
	public nsISupports DocShell => GetProperty<nsISupports>("docShell");

	public ContainerBoxObject(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
