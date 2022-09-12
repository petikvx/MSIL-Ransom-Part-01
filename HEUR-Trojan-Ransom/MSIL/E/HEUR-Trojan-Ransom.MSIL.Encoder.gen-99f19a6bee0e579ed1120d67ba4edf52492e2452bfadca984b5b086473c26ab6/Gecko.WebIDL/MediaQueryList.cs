namespace Gecko.WebIDL;

public class MediaQueryList : WebIDLBase
{
	public string Media => GetProperty<string>("media");

	public bool Matches => GetProperty<bool>("matches");

	public MediaQueryList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
