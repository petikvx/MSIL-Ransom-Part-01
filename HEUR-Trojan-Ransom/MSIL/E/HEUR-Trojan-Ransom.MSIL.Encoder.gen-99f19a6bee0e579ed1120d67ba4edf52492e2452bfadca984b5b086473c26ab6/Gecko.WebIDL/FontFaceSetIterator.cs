namespace Gecko.WebIDL;

public class FontFaceSetIterator : WebIDLBase
{
	public FontFaceSetIterator(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object Next()
	{
		return CallMethod<object>("next", new object[0]);
	}
}
