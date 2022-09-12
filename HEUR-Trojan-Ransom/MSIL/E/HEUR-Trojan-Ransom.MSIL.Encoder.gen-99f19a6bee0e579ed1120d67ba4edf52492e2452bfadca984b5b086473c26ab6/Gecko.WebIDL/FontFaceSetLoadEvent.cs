namespace Gecko.WebIDL;

public class FontFaceSetLoadEvent : WebIDLBase
{
	public nsISupports[] Fontfaces => GetProperty<nsISupports[]>("fontfaces");

	public FontFaceSetLoadEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
