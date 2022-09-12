namespace Gecko.DOM;

public class GeckoQuoteElement : GeckoHtmlElement
{
	private nsIDOMHTMLQuoteElement DOMHTMLElement;

	public string Cite
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetCiteAttribute);
		}
		set
		{
			DOMHTMLElement.SetCiteAttribute(new nsAString(value));
		}
	}

	internal GeckoQuoteElement(nsIDOMHTMLQuoteElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoQuoteElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLQuoteElement;
	}
}
