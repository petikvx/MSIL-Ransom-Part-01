namespace Gecko.DOM;

public class GeckoMapElement : GeckoHtmlElement
{
	private nsIDOMHTMLMapElement DOMHTMLElement;

	public GeckoHtmlElementCollection Areas => new GeckoHtmlElementCollection(DOMHTMLElement.GetAreasAttribute());

	public string Name
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetNameAttribute);
		}
		set
		{
			DOMHTMLElement.SetNameAttribute(new nsAString(value));
		}
	}

	internal GeckoMapElement(nsIDOMHTMLMapElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoMapElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLMapElement;
	}
}
