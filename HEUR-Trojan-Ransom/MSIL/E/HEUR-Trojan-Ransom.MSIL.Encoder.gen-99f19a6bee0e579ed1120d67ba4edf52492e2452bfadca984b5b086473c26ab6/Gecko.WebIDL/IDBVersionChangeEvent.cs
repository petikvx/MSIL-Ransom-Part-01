namespace Gecko.WebIDL;

public class IDBVersionChangeEvent : WebIDLBase
{
	public ulong OldVersion => GetProperty<ulong>("oldVersion");

	public ulong? NewVersion => GetProperty<ulong?>("newVersion");

	public IDBVersionChangeEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
