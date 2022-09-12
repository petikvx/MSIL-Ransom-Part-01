namespace Gecko.WebIDL;

public class PropertyNodeList : WebIDLBase
{
	public PropertyNodeList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object[] GetValues()
	{
		return CallMethod<object[]>("getValues", new object[0]);
	}
}
