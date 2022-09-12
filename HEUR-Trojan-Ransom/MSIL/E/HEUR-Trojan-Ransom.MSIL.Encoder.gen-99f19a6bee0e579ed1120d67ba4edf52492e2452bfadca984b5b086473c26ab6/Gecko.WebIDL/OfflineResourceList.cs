namespace Gecko.WebIDL;

public class OfflineResourceList : WebIDLBase
{
	public ushort Status => GetProperty<ushort>("status");

	public nsISupports MozItems => GetProperty<nsISupports>("mozItems");

	public uint MozLength => GetProperty<uint>("mozLength");

	public OfflineResourceList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Update()
	{
		CallVoidMethod("update");
	}

	public void SwapCache()
	{
		CallVoidMethod("swapCache");
	}

	public bool MozHasItem(string uri)
	{
		return CallMethod<bool>("mozHasItem", new object[1] { uri });
	}

	public void MozAdd(string uri)
	{
		CallVoidMethod("mozAdd", uri);
	}

	public void MozRemove(string uri)
	{
		CallVoidMethod("mozRemove", uri);
	}
}
