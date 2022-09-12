namespace Gecko.DOM;

public class GeckoLabelElement : GeckoHtmlElement
{
	private nsIDOMHTMLLabelElement DOMHTMLElement;

	public GeckoFormElement Form => new GeckoFormElement(DOMHTMLElement.GetFormAttribute());

	public string HtmlFor
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetHtmlForAttribute);
		}
		set
		{
			DOMHTMLElement.SetHtmlForAttribute(new nsAString(value));
		}
	}

	internal GeckoLabelElement(nsIDOMHTMLLabelElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoLabelElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLLabelElement;
	}
}
