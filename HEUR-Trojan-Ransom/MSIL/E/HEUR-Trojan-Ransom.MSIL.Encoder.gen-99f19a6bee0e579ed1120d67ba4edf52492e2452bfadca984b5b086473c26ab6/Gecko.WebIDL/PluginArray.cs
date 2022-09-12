namespace Gecko.WebIDL;

public class PluginArray : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public PluginArray(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Refresh()
	{
		CallVoidMethod("refresh");
	}

	public void Refresh(bool reloadDocuments)
	{
		CallVoidMethod("refresh", reloadDocuments);
	}
}
