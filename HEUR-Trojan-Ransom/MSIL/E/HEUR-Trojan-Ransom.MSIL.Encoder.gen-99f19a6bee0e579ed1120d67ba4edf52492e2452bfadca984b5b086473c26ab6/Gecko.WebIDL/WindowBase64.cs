namespace Gecko.WebIDL;

public class WindowBase64 : WebIDLBase
{
	public WindowBase64(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string Btoa(string btoa)
	{
		return CallMethod<string>("btoa", new object[1] { btoa });
	}

	public string Atob(string atob)
	{
		return CallMethod<string>("atob", new object[1] { atob });
	}
}
