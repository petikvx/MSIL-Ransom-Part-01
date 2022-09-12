namespace Gecko.WebIDL;

public class MozInterAppConnectionRequest : WebIDLBase
{
	public string Keyword => GetProperty<string>("keyword");

	public nsISupports Port => GetProperty<nsISupports>("port");

	public string From => GetProperty<string>("from");

	public MozInterAppConnectionRequest(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
