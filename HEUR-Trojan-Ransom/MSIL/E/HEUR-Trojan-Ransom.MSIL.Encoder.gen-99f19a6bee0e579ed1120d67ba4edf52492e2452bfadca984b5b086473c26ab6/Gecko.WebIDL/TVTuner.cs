namespace Gecko.WebIDL;

public class TVTuner : WebIDLBase
{
	public string Id => GetProperty<string>("id");

	public nsISupports CurrentSource => GetProperty<nsISupports>("currentSource");

	public nsISupports Stream => GetProperty<nsISupports>("stream");

	public TVTuner(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public TVSourceType[] GetSupportedSourceTypes()
	{
		return CallMethod<TVSourceType[]>("getSupportedSourceTypes", new object[0]);
	}

	public Promise<nsISupports[]> GetSources()
	{
		return CallMethod<Promise<nsISupports[]>>("getSources", new object[0]);
	}

	public Promise SetCurrentSource(TVSourceType sourceType)
	{
		return CallMethod<Promise>("setCurrentSource", new object[1] { sourceType });
	}
}
