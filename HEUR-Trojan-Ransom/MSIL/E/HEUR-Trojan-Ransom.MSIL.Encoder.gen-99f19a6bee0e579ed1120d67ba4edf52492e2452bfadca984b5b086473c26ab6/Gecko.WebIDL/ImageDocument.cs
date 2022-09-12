namespace Gecko.WebIDL;

public class ImageDocument : WebIDLBase
{
	public bool ImageResizingEnabled => GetProperty<bool>("imageResizingEnabled");

	public bool ImageIsOverflowing => GetProperty<bool>("imageIsOverflowing");

	public bool ImageIsResized => GetProperty<bool>("imageIsResized");

	public nsISupports ImageRequest => GetProperty<nsISupports>("imageRequest");

	public ImageDocument(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void ShrinkToFit()
	{
		CallVoidMethod("shrinkToFit");
	}

	public void RestoreImage()
	{
		CallVoidMethod("restoreImage");
	}

	public void RestoreImageTo(int x, int y)
	{
		CallVoidMethod("restoreImageTo", x, y);
	}

	public void ToggleImageSize()
	{
		CallVoidMethod("toggleImageSize");
	}
}
