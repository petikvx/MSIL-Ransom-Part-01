namespace Gecko.DOM;

public class GeckoDirectoryElement : GeckoHtmlElement
{
	private nsIDOMHTMLDirectoryElement DOMHTMLElement;

	internal GeckoDirectoryElement(nsIDOMHTMLDirectoryElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoDirectoryElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLDirectoryElement;
	}
}
