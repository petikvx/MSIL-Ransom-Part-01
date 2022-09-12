namespace Gecko.WebIDL;

public class HTMLLegendElement : WebIDLBase
{
	public nsISupports Form => GetProperty<nsISupports>("form");

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

	public HTMLLegendElement(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
