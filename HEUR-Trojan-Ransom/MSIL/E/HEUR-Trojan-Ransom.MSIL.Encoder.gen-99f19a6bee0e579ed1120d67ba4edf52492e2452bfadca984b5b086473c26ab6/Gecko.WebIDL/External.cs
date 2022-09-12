namespace Gecko.WebIDL;

public class External : WebIDLBase
{
	public External(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void AddSearchProvider(string aDescriptionURL)
	{
		CallVoidMethod("AddSearchProvider", aDescriptionURL);
	}

	public uint IsSearchProviderInstalled(string aSearchURL)
	{
		return CallMethod<uint>("IsSearchProviderInstalled", new object[1] { aSearchURL });
	}

	public void AddSearchEngine(string engineURL, string iconURL, string suggestedTitle, string suggestedCategory)
	{
		CallVoidMethod("addSearchEngine", engineURL, iconURL, suggestedTitle, suggestedCategory);
	}
}
