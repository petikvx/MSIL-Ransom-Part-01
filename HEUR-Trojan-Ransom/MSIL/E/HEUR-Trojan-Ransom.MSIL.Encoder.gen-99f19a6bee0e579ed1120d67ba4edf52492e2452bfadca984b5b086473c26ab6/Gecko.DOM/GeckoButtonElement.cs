namespace Gecko.DOM;

public class GeckoButtonElement : GeckoHtmlElement
{
	private nsIDOMHTMLButtonElement DOMHTMLElement;

	public GeckoFormElement Form => new GeckoFormElement(DOMHTMLElement.GetFormAttribute());

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

	public string Name
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetNameAttribute);
		}
		set
		{
			DOMHTMLElement.SetNameAttribute(new nsAString(value));
		}
	}

	public string Type => nsString.Get(DOMHTMLElement.GetTypeAttribute);

	public string Value
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetValueAttribute);
		}
		set
		{
			DOMHTMLElement.SetValueAttribute(new nsAString(value));
		}
	}

	internal GeckoButtonElement(nsIDOMHTMLButtonElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoButtonElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLButtonElement;
	}
}
