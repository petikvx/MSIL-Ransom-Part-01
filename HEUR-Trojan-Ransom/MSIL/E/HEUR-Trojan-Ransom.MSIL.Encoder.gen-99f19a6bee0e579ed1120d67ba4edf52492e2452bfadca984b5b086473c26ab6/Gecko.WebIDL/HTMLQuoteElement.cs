namespace Gecko.WebIDL;

public class HTMLQuoteElement : WebIDLBase
{
	public string Cite
	{
		get
		{
			return GetProperty<string>("cite");
		}
		set
		{
			SetProperty("cite", value);
		}
	}

	public HTMLQuoteElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
