namespace Gecko.DOM;

public class GeckoAreaElement : GeckoHtmlElement
{
	private nsIDOMHTMLAreaElement DOMHTMLElement;

	public string Alt
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetAltAttribute);
		}
		set
		{
			DOMHTMLElement.SetAltAttribute(new nsAString(value));
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

	public bool NoHref
	{
		get
		{
			return DOMHTMLElement.GetNoHrefAttribute();
		}
		set
		{
			DOMHTMLElement.SetNoHrefAttribute(value);
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

	internal GeckoAreaElement(nsIDOMHTMLAreaElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoAreaElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLAreaElement;
	}
}
