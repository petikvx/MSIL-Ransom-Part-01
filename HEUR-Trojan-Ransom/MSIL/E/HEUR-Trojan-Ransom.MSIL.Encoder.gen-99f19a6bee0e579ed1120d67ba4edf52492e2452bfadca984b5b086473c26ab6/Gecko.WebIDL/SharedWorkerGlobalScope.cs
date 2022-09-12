namespace Gecko.WebIDL;

public class SharedWorkerGlobalScope : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public SharedWorkerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
