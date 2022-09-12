namespace Gecko.DOM;

public class GeckoFieldSetElement : GeckoHtmlElement
{
	private nsIDOMHTMLFieldSetElement DOMHTMLElement;

	public GeckoFormElement Form => new GeckoFormElement(DOMHTMLElement.GetFormAttribute());

	internal GeckoFieldSetElement(nsIDOMHTMLFieldSetElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoFieldSetElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLFieldSetElement;
	}
}
