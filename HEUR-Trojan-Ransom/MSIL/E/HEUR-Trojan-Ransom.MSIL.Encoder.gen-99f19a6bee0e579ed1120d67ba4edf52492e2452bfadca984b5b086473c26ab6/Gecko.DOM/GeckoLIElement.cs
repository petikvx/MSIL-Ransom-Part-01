namespace Gecko.DOM;

public class GeckoLIElement : GeckoHtmlElement
{
	private nsIDOMHTMLLIElement DOMHTMLElement;

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

	public int Value
	{
		get
		{
			return DOMHTMLElement.GetValueAttribute();
		}
		set
		{
			DOMHTMLElement.SetValueAttribute(value);
		}
	}

	internal GeckoLIElement(nsIDOMHTMLLIElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoLIElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLLIElement;
	}
}
