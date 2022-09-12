namespace Gecko.DOM;

public class GeckoPreElement : GeckoHtmlElement
{
	private nsIDOMHTMLPreElement DOMHTMLElement;

	public int Width
	{
		get
		{
			return DOMHTMLElement.GetWidthAttribute();
		}
		set
		{
			DOMHTMLElement.SetWidthAttribute(value);
		}
	}

	internal GeckoPreElement(nsIDOMHTMLPreElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoPreElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLPreElement;
	}
}
