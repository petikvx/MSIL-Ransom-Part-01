namespace Gecko.DOM;

public class GeckoOptionElement : GeckoHtmlElement
{
	private nsIDOMHTMLOptionElement DOMHTMLElement;

	public GeckoFormElement Form => new GeckoFormElement(DOMHTMLElement.GetFormAttribute());

	public bool DefaultSelected
	{
		get
		{
			return DOMHTMLElement.GetDefaultSelectedAttribute();
		}
		set
		{
			DOMHTMLElement.SetDefaultSelectedAttribute(value);
		}
	}

	public string Text => nsString.Get(DOMHTMLElement.GetTextAttribute);

	public int Index => DOMHTMLElement.GetIndexAttribute();

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

	public bool Selected
	{
		get
		{
			return DOMHTMLElement.GetSelectedAttribute();
		}
		set
		{
			DOMHTMLElement.SetSelectedAttribute(value);
		}
	}

	public string Value
	{
		get
		{
			return nsString.Get(DOMHTMLElement.GetValueAttribute);
		}
		set
		{
			DOMHTMLElement.SetValueAttribute(new nsAString(value));
		}
	}

	internal GeckoOptionElement(nsIDOMHTMLOptionElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoOptionElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLOptionElement;
	}
}
