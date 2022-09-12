namespace Gecko.WebIDL;

public class DataStoreChangeEvent : WebIDLBase
{
	public string RevisionId => GetProperty<string>("revisionId");

	public WebIDLUnion<string, uint> Id => GetProperty<WebIDLUnion<string, uint>>("id");

	public string Operation => GetProperty<string>("operation");

	public string Owner => GetProperty<string>("owner");

	public DataStoreChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
