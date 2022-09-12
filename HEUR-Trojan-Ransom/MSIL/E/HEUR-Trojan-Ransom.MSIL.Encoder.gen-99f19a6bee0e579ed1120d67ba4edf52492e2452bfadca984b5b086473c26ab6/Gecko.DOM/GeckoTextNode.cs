using Gecko.Interop;

namespace Gecko.DOM;

public class GeckoTextNode : DomCharacterData
{
	private nsIDOMText _domText;

	public string WholeText => nsString.Get(_domText.GetWholeTextAttribute);

	private GeckoTextNode(nsIDOMText domText)
		: base(domText)
	{
		_domText = domText;
	}

	public static GeckoTextNode CreateTextNodeWrapper(nsIDOMText domText)
	{
		return new GeckoTextNode(domText);
	}

	public GeckoTextNode SplitText(uint offset)
	{
		return _domText.SplitText(offset).Wrap(CreateTextNodeWrapper);
	}
}
