namespace Gecko.DOM;

public class GeckoHtmlHtmlElement : GeckoHtmlElement
{
	private nsIDOMHTMLHtmlElement DOMHTMLElement;

	public string Version
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetVersionAttribute);
		}
		set
		{
			DOMHTMLElement.SetVersionAttribute(new nsAString(value));
		}
	}

	internal GeckoHtmlHtmlElement(nsIDOMHTMLHtmlElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoHtmlHtmlElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLHtmlElement;
	}
}
