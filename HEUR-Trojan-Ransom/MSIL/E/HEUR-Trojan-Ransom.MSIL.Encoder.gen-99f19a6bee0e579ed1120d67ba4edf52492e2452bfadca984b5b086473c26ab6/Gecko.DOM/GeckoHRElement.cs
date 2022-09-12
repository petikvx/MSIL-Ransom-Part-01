namespace Gecko.DOM;

public class GeckoHRElement : GeckoHtmlElement
{
	private nsIDOMHTMLHRElement DOMHTMLElement;

	public string Align
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetAlignAttribute);
		}
		set
		{
			DOMHTMLElement.SetAlignAttribute(new nsAString(value));
		}
	}

	public bool NoShade
	{
		get
		{
			return DOMHTMLElement.GetNoShadeAttribute();
		}
		set
		{
			DOMHTMLElement.SetNoShadeAttribute(value);
		}
	}

	public string Size
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetSizeAttribute);
		}
		set
		{
			DOMHTMLElement.SetSizeAttribute(new nsAString(value));
		}
	}

	public string Width
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetWidthAttribute);
		}
		set
		{
			DOMHTMLElement.SetWidthAttribute(new nsAString(value));
		}
	}

	internal GeckoHRElement(nsIDOMHTMLHRElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoHRElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLHRElement;
	}
}
