namespace Gecko.DOM;

public class GeckoAnchorElement : GeckoHtmlElement
{
	private nsIDOMHTMLAnchorElement DOMHTMLElement;

	public string Charset
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetCharsetAttribute);
		}
		set
		{
			DOMHTMLElement.SetCharsetAttribute(new nsAString(value));
		}
	}

	public string Coords
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetCoordsAttribute);
		}
		set
		{
			DOMHTMLElement.SetCoordsAttribute(new nsAString(value));
		}
	}

	public string Href
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetHrefAttribute);
		}
		set
		{
			DOMHTMLElement.SetHrefAttribute(new nsAString(value));
		}
	}

	public string Hreflang
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetHreflangAttribute);
		}
		set
		{
			DOMHTMLElement.SetHreflangAttribute(new nsAString(value));
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

	public string Rel
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetRelAttribute);
		}
		set
		{
			DOMHTMLElement.SetRelAttribute(new nsAString(value));
		}
	}

	public string Rev
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetRevAttribute);
		}
		set
		{
			DOMHTMLElement.SetRevAttribute(new nsAString(value));
		}
	}

	public string Shape
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetShapeAttribute);
		}
		set
		{
			DOMHTMLElement.SetShapeAttribute(new nsAString(value));
		}
	}

	public string Target
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetTargetAttribute);
		}
		set
		{
			DOMHTMLElement.SetTargetAttribute(new nsAString(value));
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

	internal GeckoAnchorElement(nsIDOMHTMLAnchorElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoAnchorElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLAnchorElement;
	}
}
