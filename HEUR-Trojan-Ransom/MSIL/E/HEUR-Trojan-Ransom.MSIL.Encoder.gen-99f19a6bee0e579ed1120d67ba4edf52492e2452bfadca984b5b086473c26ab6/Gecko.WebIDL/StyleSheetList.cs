namespace Gecko.WebIDL;

public class StyleSheetList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public StyleSheetList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
