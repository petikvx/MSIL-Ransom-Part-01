namespace Gecko.WebIDL;

public class IdentityManager : WebIDLBase
{
	public IdentityManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Watch()
	{
		CallVoidMethod("watch");
	}

	public void Watch(object options)
	{
		CallVoidMethod("watch", options);
	}

	public void Request()
	{
		CallVoidMethod("request");
	}

	public void Request(object options)
	{
		CallVoidMethod("request", options);
	}

	public void Logout()
	{
		CallVoidMethod("logout");
	}
}
