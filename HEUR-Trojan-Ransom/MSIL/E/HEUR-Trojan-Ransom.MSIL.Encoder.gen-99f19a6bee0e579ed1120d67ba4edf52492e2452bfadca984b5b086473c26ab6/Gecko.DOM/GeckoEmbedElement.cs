namespace Gecko.DOM;

public class GeckoEmbedElement : GeckoHtmlElement
{
	private nsIDOMHTMLEmbedElement DOMHTMLElement;

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

	internal GeckoEmbedElement(nsIDOMHTMLEmbedElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoEmbedElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLEmbedElement;
	}
}
