namespace Gecko.WebIDL;

public class HTMLExtAppElement : WebIDLBase
{
	public HTMLExtAppElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string GetCustomProperty(string name)
	{
		return CallMethod<string>("getCustomProperty", new object[1] { name });
	}

	public void PostMessage(string name)
	{
		CallVoidMethod("postMessage", name);
	}
}
