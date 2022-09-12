namespace Gecko.DOM;

public class GeckoBaseElement : GeckoHtmlElement
{
	private nsIDOMHTMLBaseElement DOMHTMLElement;

	public string Href
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetHrefAttribute);
		}
		set
		{
			DOMHTMLElement.SetHrefAttribute(new nsAString(value));
		}
	}

	public string Target
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetTargetAttribute);
		}
		set
		{
			DOMHTMLElement.SetTargetAttribute(new nsAString(value));
		}
	}

	internal GeckoBaseElement(nsIDOMHTMLBaseElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoBaseElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLBaseElement;
	}
}
