namespace Gecko.WebIDL;

public class XMLStylesheetProcessingInstruction : WebIDLBase
{
	public nsISupports Sheet => GetProperty<nsISupports>("sheet");

	public XMLStylesheetProcessingInstruction(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
