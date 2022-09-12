namespace Gecko.WebIDL;

public class NavigatorLanguage : WebIDLBase
{
	public string Language => GetProperty<string>("language");

	public string[] Languages => GetProperty<string[]>("languages");

	public NavigatorLanguage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
