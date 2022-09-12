namespace Gecko.WebIDL;

public class CanvasGradient : WebIDLBase
{
	public CanvasGradient(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void AddColorStop(float offset, string color)
	{
		CallVoidMethod("addColorStop", offset, color);
	}
}
