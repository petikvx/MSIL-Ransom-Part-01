namespace Gecko.WebIDL;

public class HTMLTableCaptionElement : WebIDLBase
{
	public string Align
	{
		get
		{
			return GetProperty<string>("align");
		}
		set
		{
			SetProperty("align", value);
		}
	}

	public HTMLTableCaptionElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
