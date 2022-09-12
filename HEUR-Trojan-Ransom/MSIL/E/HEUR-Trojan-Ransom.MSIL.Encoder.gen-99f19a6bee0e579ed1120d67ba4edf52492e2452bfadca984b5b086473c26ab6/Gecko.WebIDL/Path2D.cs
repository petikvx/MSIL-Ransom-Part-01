namespace Gecko.WebIDL;

public class Path2D : WebIDLBase
{
	public Path2D(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void AddPath(nsISupports path)
	{
		CallVoidMethod("addPath", path);
	}

	public void AddPath(nsISupports path, nsISupports transformation)
	{
		CallVoidMethod("addPath", path, transformation);
	}
}
