namespace Gecko.WebIDL;

public class CanvasPattern : WebIDLBase
{
	public CanvasPattern(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void SetTransform(nsISupports matrix)
	{
		CallVoidMethod("setTransform", matrix);
	}
}
