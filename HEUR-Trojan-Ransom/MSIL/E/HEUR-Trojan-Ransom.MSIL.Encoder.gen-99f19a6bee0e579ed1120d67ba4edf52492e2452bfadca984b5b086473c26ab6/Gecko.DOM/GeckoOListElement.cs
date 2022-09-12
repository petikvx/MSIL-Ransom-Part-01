namespace Gecko.DOM;

public class GeckoOListElement : GeckoHtmlElement
{
	private nsIDOMHTMLOListElement DOMHTMLElement;

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

	public int Start
	{
		get
		{
			return DOMHTMLElement.GetStartAttribute();
		}
		set
		{
			DOMHTMLElement.SetStartAttribute(value);
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

	internal GeckoOListElement(nsIDOMHTMLOListElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoOListElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLOListElement;
	}
}
