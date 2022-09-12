namespace Gecko.DOM;

public class GeckoOptGroupElement : GeckoHtmlElement
{
	private nsIDOMHTMLOptGroupElement DOMHTMLElement;

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

	public string Label
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetLabelAttribute);
		}
		set
		{
			DOMHTMLElement.SetLabelAttribute(new nsAString(value));
		}
	}

	internal GeckoOptGroupElement(nsIDOMHTMLOptGroupElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoOptGroupElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLOptGroupElement;
	}
}
