namespace Gecko.WebIDL;

public class NavigatorFeatures : WebIDLBase
{
	public NavigatorFeatures(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public Promise<object> GetFeature(string name)
	{
		return CallMethod<Promise<object>>("getFeature", new object[1] { name });
	}

	public Promise<object> HasFeature(string name)
	{
		return CallMethod<Promise<object>>("hasFeature", new object[1] { name });
	}
}
