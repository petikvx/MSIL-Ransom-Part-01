namespace Gecko.DOM;

public class GeckoStyleElement : GeckoHtmlElement
{
	private nsIDOMHTMLStyleElement DOMHTMLElement;

	public bool Disabled
	{
		get
		{
			return DOMHTMLElement.GetDisabledAttribute();
		}
		set
		{
			DOMHTMLElement.SetDisabledAttribute(value);
		}
	}

	public string Media
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetMediaAttribute);
		}
		set
		{
			DOMHTMLElement.SetMediaAttribute(new nsAString(value));
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

	internal GeckoStyleElement(nsIDOMHTMLStyleElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoStyleElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLStyleElement;
	}
}
