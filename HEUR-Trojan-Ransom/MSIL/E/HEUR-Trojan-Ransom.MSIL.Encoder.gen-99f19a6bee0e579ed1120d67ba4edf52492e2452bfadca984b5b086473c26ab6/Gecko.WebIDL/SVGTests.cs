namespace Gecko.WebIDL;

public class SVGTests : WebIDLBase
{
	public nsISupports RequiredFeatures => GetProperty<nsISupports>("requiredFeatures");

	public nsISupports RequiredExtensions => GetProperty<nsISupports>("requiredExtensions");

	public nsISupports SystemLanguage => GetProperty<nsISupports>("systemLanguage");

	public SVGTests(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public bool HasExtension(string extension)
	{
		return CallMethod<bool>("hasExtension", new object[1] { extension });
	}
}
