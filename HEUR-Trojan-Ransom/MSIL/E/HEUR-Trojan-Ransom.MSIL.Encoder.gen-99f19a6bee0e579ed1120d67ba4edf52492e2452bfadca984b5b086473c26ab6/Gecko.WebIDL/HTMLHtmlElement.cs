namespace Gecko.WebIDL;

public class HTMLHtmlElement : WebIDLBase
{
	public string Version
	{
		get
		{
			return GetProperty<string>("version");
		}
		set
		{
			SetProperty("version", value);
		}
	}

	public HTMLHtmlElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
