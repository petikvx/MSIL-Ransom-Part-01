namespace Gecko.WebIDL;

public class WorkerGlobalScope : WebIDLBase
{
	public nsISupports Self => GetProperty<nsISupports>("self");

	public nsISupports Console => GetProperty<nsISupports>("console");

	public nsISupports Location => GetProperty<nsISupports>("location");

	public nsISupports Navigator => GetProperty<nsISupports>("navigator");

	public nsISupports Caches => GetProperty<nsISupports>("caches");

	public nsISupports Performance => GetProperty<nsISupports>("performance");

	public WorkerGlobalScope(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Close()
	{
		CallVoidMethod("close");
	}

	public void ImportScripts(string urls)
	{
		CallVoidMethod("importScripts", urls);
	}

	public void Dump()
	{
		CallVoidMethod("dump");
	}

	public void Dump(string str)
	{
		CallVoidMethod("dump", str);
	}
}
