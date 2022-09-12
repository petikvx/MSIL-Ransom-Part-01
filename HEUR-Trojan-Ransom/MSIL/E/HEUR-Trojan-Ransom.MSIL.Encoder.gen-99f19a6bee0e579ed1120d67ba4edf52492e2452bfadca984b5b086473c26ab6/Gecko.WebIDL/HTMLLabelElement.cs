namespace Gecko.WebIDL;

public class HTMLLabelElement : WebIDLBase
{
	public nsISupports Form => GetProperty<nsISupports>("form");

	public string HtmlFor
	{
		get
		{
			return GetProperty<string>("htmlFor");
		}
		set
		{
			SetProperty("htmlFor", value);
		}
	}

	public nsISupports Control => GetProperty<nsISupports>("control");

	public HTMLLabelElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
