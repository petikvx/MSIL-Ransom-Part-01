namespace Gecko.WebIDL;

public class BrowserElementCommon : WebIDLBase
{
	public BrowserElementCommon(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetVisible(bool visible)
	{
		CallVoidMethod("setVisible", visible);
	}

	public nsISupports GetVisible()
	{
		return CallMethod<nsISupports>("getVisible", new object[0]);
	}

	public void SetActive(bool active)
	{
		CallVoidMethod("setActive", active);
	}

	public bool GetActive()
	{
		return CallMethod<bool>("getActive", new object[0]);
	}
}
