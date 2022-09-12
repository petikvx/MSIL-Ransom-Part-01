namespace Gecko.DOM;

public class GeckoOptionsCollection
{
	private nsIDOMHTMLOptionsCollection DOMHTMLElement;

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

	internal GeckoOptionsCollection(nsIDOMHTMLOptionsCollection element)
	{
		DOMHTMLElement = element;
	}

	public GeckoOptionElement item(uint index)
	{
		return new GeckoOptionElement(DOMHTMLElement.Item(index));
	}

	public GeckoOptionElement namedItem(string name)
	{
		return new GeckoOptionElement(DOMHTMLElement.NamedItem(new nsAString(name)));
	}
}
