namespace Gecko.WebIDL;

public class MimeType : WebIDLBase
{
	public string Description => GetProperty<string>("description");

	public nsISupports EnabledPlugin => GetProperty<nsISupports>("enabledPlugin");

	public string Suffixes => GetProperty<string>("suffixes");

	public string Type => GetProperty<string>("type");

	public MimeType(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
