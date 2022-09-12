namespace Gecko.WebIDL;

public class InputPort : WebIDLBase
{
	public string Id => GetProperty<string>("id");

	public nsISupports Stream => GetProperty<nsISupports>("stream");

	public bool Connected => GetProperty<bool>("connected");

	public InputPort(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
