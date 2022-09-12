namespace Gecko.WebIDL;

public class PerformanceObserverEntryList : WebIDLBase
{
	public PerformanceObserverEntryList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports[] GetEntries()
	{
		return CallMethod<nsISupports[]>("getEntries", new object[0]);
	}

	public nsISupports[] GetEntries(object filter)
	{
		return CallMethod<nsISupports[]>("getEntries", new object[1] { filter });
	}

	public nsISupports[] GetEntriesByType(string entryType)
	{
		return CallMethod<nsISupports[]>("getEntriesByType", new object[1] { entryType });
	}

	public nsISupports[] GetEntriesByName(string name)
	{
		return CallMethod<nsISupports[]>("getEntriesByName", new object[1] { name });
	}

	public nsISupports[] GetEntriesByName(string name, string entryType)
	{
		return CallMethod<nsISupports[]>("getEntriesByName", new object[2] { name, entryType });
	}
}
