namespace Gecko.DOM;

public class GeckoParagraphElement : GeckoHtmlElement
{
	private nsIDOMHTMLParagraphElement DOMHTMLElement;

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

	internal GeckoParagraphElement(nsIDOMHTMLParagraphElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoParagraphElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLParagraphElement;
	}
}
