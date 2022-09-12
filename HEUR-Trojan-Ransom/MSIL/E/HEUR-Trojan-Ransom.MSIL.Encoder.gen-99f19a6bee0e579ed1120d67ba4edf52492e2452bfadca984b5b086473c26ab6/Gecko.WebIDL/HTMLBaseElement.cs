namespace Gecko.WebIDL;

public class HTMLBaseElement : WebIDLBase
{
	public string Href
	{
		get
		{
			return GetProperty<string>("href");
		}
		set
		{
			SetProperty("href", value);
		}
	}

	public string Target
	{
		get
		{
			return GetProperty<string>("target");
		}
		set
		{
			SetProperty("target", value);
		}
	}

	public HTMLBaseElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
