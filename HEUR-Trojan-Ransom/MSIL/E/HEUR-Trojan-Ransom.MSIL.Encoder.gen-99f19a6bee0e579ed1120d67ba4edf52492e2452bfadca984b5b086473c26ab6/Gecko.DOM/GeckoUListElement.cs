namespace Gecko.DOM;

public class GeckoUListElement : GeckoHtmlElement
{
	private nsIDOMHTMLUListElement DOMHTMLElement;

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

	public string Type
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetTypeAttribute);
		}
		set
		{
			DOMHTMLElement.SetTypeAttribute(new nsAString(value));
		}
	}

	internal GeckoUListElement(nsIDOMHTMLUListElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoUListElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLUListElement;
	}
}
