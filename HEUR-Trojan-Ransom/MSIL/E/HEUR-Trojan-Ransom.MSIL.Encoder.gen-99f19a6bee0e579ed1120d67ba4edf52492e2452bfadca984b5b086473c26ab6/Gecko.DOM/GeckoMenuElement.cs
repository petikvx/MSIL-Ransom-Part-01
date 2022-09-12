namespace Gecko.DOM;

public class GeckoMenuElement : GeckoHtmlElement
{
	private nsIDOMHTMLMenuElement DOMHTMLElement;

	public bool Compact
	{
		get
		{
			return DOMHTMLElement.GetCompactAttribute();
		}
		set
		{
			DOMHTMLElement.SetCompactAttribute(value);
		}
	}

	internal GeckoMenuElement(nsIDOMHTMLMenuElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoMenuElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLMenuElement;
	}
}
