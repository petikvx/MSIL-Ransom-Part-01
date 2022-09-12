namespace Gecko.WebIDL;

public class ProcessingInstruction : WebIDLBase
{
	public string Target => GetProperty<string>("target");

	public ProcessingInstruction(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
