namespace Gecko.WebIDL;

public class CSSStyleSheet : WebIDLBase
{
	public nsISupports OwnerRule => GetProperty<nsISupports>("ownerRule");

	public nsISupports CssRules => GetProperty<nsISupports>("cssRules");

	public CSSStyleSheet(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public uint InsertRule(string rule, uint index)
	{
		return CallMethod<uint>("insertRule", new object[2] { rule, index });
	}

	public void DeleteRule(uint index)
	{
		CallVoidMethod("deleteRule", index);
	}
}
