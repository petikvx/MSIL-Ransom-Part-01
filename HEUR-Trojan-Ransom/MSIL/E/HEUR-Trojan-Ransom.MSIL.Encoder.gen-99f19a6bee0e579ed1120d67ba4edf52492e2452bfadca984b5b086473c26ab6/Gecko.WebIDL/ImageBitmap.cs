namespace Gecko.WebIDL;

public class ImageBitmap : WebIDLBase
{
	public uint Width => GetProperty<uint>("width");

	public uint Height => GetProperty<uint>("height");

	public ImageBitmap(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
