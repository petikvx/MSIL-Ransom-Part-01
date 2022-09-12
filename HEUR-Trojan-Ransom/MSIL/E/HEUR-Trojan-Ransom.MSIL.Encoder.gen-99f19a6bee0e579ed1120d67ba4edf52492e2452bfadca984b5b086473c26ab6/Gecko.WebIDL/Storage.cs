namespace Gecko.WebIDL;

public class Storage : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public Storage(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public string Key(uint index)
	{
		return CallMethod<string>("key", new object[1] { index });
	}
}
