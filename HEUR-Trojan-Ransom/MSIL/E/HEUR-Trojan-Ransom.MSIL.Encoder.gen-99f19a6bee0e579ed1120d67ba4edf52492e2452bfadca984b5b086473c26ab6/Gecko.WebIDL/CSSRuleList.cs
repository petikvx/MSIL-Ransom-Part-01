namespace Gecko.WebIDL;

public class CSSRuleList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public CSSRuleList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
