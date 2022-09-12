namespace Gecko.WebIDL;

public class HeapSnapshot : WebIDLBase
{
	public ulong? CreationTime => GetProperty<ulong?>("creationTime");

	public HeapSnapshot(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public object TakeCensus(object options)
	{
		return CallMethod<object>("takeCensus", new object[1] { options });
	}

	public nsISupports ComputeDominatorTree()
	{
		return CallMethod<nsISupports>("computeDominatorTree", new object[0]);
	}
}
