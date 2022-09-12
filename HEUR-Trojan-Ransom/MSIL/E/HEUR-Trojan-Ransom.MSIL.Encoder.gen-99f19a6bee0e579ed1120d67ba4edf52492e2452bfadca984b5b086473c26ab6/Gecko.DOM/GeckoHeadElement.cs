namespace Gecko.DOM;

public class GeckoHeadElement : GeckoHtmlElement
{
	private nsIDOMHTMLHeadElement DOMHTMLElement;

	internal GeckoHeadElement(nsIDOMHTMLHeadElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoHeadElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLHeadElement;
	}
}
