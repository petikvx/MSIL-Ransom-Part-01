namespace Gecko.WebIDL;

public class History : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public object State => GetProperty<object>("state");

	public History(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Go()
	{
		CallVoidMethod("go");
	}

	public void Go(int delta)
	{
		CallVoidMethod("go", delta);
	}

	public void Back()
	{
		CallVoidMethod("back");
	}

	public void Forward()
	{
		CallVoidMethod("forward");
	}

	public void PushState(object data, string title)
	{
		CallVoidMethod("pushState", data, title);
	}

	public void PushState(object data, string title, string url)
	{
		CallVoidMethod("pushState", data, title, url);
	}

	public void ReplaceState(object data, string title)
	{
		CallVoidMethod("replaceState", data, title);
	}

	public void ReplaceState(object data, string title, string url)
	{
		CallVoidMethod("replaceState", data, title, url);
	}
}
