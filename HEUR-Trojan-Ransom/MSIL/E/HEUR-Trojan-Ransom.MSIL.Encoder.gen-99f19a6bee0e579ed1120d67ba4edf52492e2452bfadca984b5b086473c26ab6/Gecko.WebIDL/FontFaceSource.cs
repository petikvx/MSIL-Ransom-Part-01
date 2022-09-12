namespace Gecko.WebIDL;

public class FontFaceSource : WebIDLBase
{
	public nsISupports Fonts => GetProperty<nsISupports>("fonts");

	public FontFaceSource(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
