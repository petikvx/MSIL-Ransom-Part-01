namespace Gecko.DOM;

public class GeckoFrameSetElement : GeckoHtmlElement
{
	private nsIDOMHTMLFrameSetElement DOMHTMLElement;

	public string Cols
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetColsAttribute);
		}
		set
		{
			DOMHTMLElement.SetColsAttribute(new nsAString(value));
		}
	}

	public string Rows
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetRowsAttribute);
		}
		set
		{
			DOMHTMLElement.SetRowsAttribute(new nsAString(value));
		}
	}

	internal GeckoFrameSetElement(nsIDOMHTMLFrameSetElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoFrameSetElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLFrameSetElement;
	}
}
