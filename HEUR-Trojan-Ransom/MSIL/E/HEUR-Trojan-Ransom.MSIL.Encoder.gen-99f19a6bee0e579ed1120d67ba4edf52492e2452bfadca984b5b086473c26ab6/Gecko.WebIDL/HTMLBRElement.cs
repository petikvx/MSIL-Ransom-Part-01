namespace Gecko.WebIDL;

public class HTMLBRElement : WebIDLBase
{
	public string Clear
	{
		get
		{
			return GetProperty<string>("clear");
		}
		set
		{
			SetProperty("clear", value);
		}
	}

	public HTMLBRElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
