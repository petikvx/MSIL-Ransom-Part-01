namespace Gecko.DOM;

public class GeckoScriptElement : GeckoHtmlElement
{
	private nsIDOMHTMLScriptElement DOMHTMLElement;

	public string Text
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetTextAttribute);
		}
		set
		{
			DOMHTMLElement.SetTextAttribute(new nsAString(value));
		}
	}

	public string HtmlFor
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetHtmlForAttribute);
		}
		set
		{
			DOMHTMLElement.SetHtmlForAttribute(new nsAString(value));
		}
	}

	public string Event
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetEventAttribute);
		}
		set
		{
			DOMHTMLElement.SetEventAttribute(new nsAString(value));
		}
	}

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

	public bool Defer
	{
		get
		{
			return DOMHTMLElement.GetDeferAttribute();
		}
		set
		{
			DOMHTMLElement.SetDeferAttribute(value);
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

	internal GeckoScriptElement(nsIDOMHTMLScriptElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoScriptElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLScriptElement;
	}
}
