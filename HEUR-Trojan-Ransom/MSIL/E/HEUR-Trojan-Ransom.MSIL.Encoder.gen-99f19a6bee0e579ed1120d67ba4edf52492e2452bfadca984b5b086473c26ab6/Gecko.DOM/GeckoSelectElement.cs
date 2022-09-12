namespace Gecko.DOM;

public class GeckoSelectElement : GeckoHtmlElement
{
	private nsIDOMHTMLSelectElement DOMHTMLElement;

	public string Type => nsString.Get(DOMHTMLElement.GetTypeAttribute);

	public int SelectedIndex
	{
		get
		{
			return DOMHTMLElement.GetSelectedIndexAttribute();
		}
		set
		{
			DOMHTMLElement.SetSelectedIndexAttribute(value);
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

	public uint Length
	{
		get
		{
			return DOMHTMLElement.GetLengthAttribute();
		}
		set
		{
			DOMHTMLElement.SetLengthAttribute(value);
		}
	}

	public GeckoFormElement Form
	{
		get
		{
			nsIDOMHTMLFormElement formAttribute = DOMHTMLElement.GetFormAttribute();
			return (formAttribute == null) ? null : new GeckoFormElement(formAttribute);
		}
	}

	public GeckoOptionsCollection Options
	{
		get
		{
			nsIDOMHTMLOptionsCollection optionsAttribute = DOMHTMLElement.GetOptionsAttribute();
			return (optionsAttribute == null) ? null : new GeckoOptionsCollection(optionsAttribute);
		}
	}

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

	public bool Multiple
	{
		get
		{
			return DOMHTMLElement.GetMultipleAttribute();
		}
		set
		{
			DOMHTMLElement.SetMultipleAttribute(value);
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

	public uint Size
	{
		get
		{
			return DOMHTMLElement.GetSizeAttribute();
		}
		set
		{
			DOMHTMLElement.SetSizeAttribute(value);
		}
	}

	internal GeckoSelectElement(nsIDOMHTMLSelectElement element)
		: base(element)
	{
		DOMHTMLElement = element;
	}

	public GeckoSelectElement(object element)
		: base(element as nsIDOMHTMLElement)
	{
		DOMHTMLElement = element as nsIDOMHTMLSelectElement;
	}

	public void add(GeckoHtmlElement element, GeckoHtmlElement before)
	{
		DOMHTMLElement.Add(element.DomObject as nsIDOMHTMLElement, before.DomObject as nsIVariant);
	}

	public void remove(int index)
	{
		DOMHTMLElement.Remove(index);
	}
}
