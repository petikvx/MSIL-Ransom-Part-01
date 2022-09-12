namespace Gecko.WebIDL;

public class WEBGL_lose_context : WebIDLBase
{
	public WEBGL_lose_context(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void LoseContext()
	{
		CallVoidMethod("loseContext");
	}

	public void RestoreContext()
	{
		CallVoidMethod("restoreContext");
	}
}
