namespace Gecko.DOM;

public class GeckoIFrameElement : GeckoHtmlElement
{
	private nsIDOMHTMLIFrameElement DOMHTMLElement;

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

	public string FrameBorder
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetFrameBorderAttribute);
		}
		set
		{
			DOMHTMLElement.SetFrameBorderAttribute(new nsAString(value));
		}
	}

	public string Height
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetHeightAttribute);
		}
		set
		{
			DOMHTMLElement.SetHeightAttribute(new nsAString(value));
		}
	}

	public string LongDesc
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetLongDescAttribute);
		}
		set
		{
			DOMHTMLElement.SetLongDescAttribute(new nsAString(value));
		}
	}

	public string MarginHeight
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetMarginHeightAttribute);
		}
		set
		{
			DOMHTMLElement.SetMarginHeightAttribute(new nsAString(value));
		}
	}

	public string MarginWidth
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetMarginWidthAttribute);
		}
		set
		{
			DOMHTMLElement.SetMarginWidthAttribute(new nsAString(value));
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

	public string Scrolling
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetScrollingAttribute);
		}
		set
		{
			DOMHTMLElement.SetScrollingAttribute(new nsAString(value));
		}
	}

	public string Src
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetSrcAttribute);
		}
		set
		{
			DOMHTMLElement.SetSrcAttribute(new nsAString(value));
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

	public GeckoDocument ContentDocument => (!(DOMHTMLElement.GetContentDocumentAttribute() is nsIDOMHTMLDocument document)) ? null : new GeckoDocument(document);

	public GeckoWindow ContentWindow
	{
		get
		{
			nsIDOMWindow contentWindowAttribute = DOMHTMLElement.GetContentWindowAttribute();
			return (contentWindowAttribute == null) ? null : new GeckoWindow(contentWindowAttribute);
		}
	}

	internal GeckoIFrameElement(nsIDOMHTMLIFrameElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoIFrameElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLIFrameElement;
	}
}
