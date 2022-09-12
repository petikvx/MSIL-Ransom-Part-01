namespace Gecko.WebIDL;

public class DataContainerEvent : WebIDLBase
{
	public DataContainerEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetData(string key)
	{
		return CallMethod<nsISupports>("getData", new object[1] { key });
	}

	public void SetData(string key, object data)
	{
		CallVoidMethod("setData", key, data);
	}
}
