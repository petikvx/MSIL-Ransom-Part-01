namespace Gecko.WebIDL;

public class MediaStreamError : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public string Message => GetProperty<string>("message");

	public string Constraint => GetProperty<string>("constraint");

	public MediaStreamError(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
