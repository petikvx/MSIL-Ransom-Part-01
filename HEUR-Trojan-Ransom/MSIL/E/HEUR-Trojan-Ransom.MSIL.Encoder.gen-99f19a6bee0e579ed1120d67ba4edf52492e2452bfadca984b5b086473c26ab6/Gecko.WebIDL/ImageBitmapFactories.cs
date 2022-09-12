namespace Gecko.WebIDL;

public class ImageBitmapFactories : WebIDLBase
{
	public ImageBitmapFactories(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<nsISupports> CreateImageBitmap(WebIDLUnion<nsIDOMHTMLImageElement, nsISupports, nsIDOMHTMLCanvasElement> aImage)
	{
		return CallMethod<Promise<nsISupports>>("createImageBitmap", new object[1] { aImage });
	}

	public Promise<nsISupports> CreateImageBitmap(WebIDLUnion<nsIDOMHTMLImageElement, nsISupports, nsIDOMHTMLCanvasElement> aImage, int aSx, int aSy, int aSw, int aSh)
	{
		return CallMethod<Promise<nsISupports>>("createImageBitmap", new object[5] { aImage, aSx, aSy, aSw, aSh });
	}
}
