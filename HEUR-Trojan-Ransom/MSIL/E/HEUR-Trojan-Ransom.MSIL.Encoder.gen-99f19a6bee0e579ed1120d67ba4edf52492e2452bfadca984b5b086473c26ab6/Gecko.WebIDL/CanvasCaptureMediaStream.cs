namespace Gecko.WebIDL;

public class CanvasCaptureMediaStream : WebIDLBase
{
	public nsIDOMHTMLCanvasElement Canvas => GetProperty<nsIDOMHTMLCanvasElement>("canvas");

	public CanvasCaptureMediaStream(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void RequestFrame()
	{
		CallVoidMethod("requestFrame");
	}
}
