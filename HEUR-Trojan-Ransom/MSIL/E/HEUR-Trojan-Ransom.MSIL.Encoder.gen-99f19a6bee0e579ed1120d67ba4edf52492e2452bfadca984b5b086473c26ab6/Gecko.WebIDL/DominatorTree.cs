namespace Gecko.WebIDL;

public class DominatorTree : WebIDLBase
{
	public ulong Root => GetProperty<ulong>("root");

	public DominatorTree(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public ulong GetRetainedSize(ulong node)
	{
		return CallMethod<ulong>("getRetainedSize", new object[1] { node });
	}

	public ulong[] GetImmediatelyDominated(ulong node)
	{
		return CallMethod<ulong[]>("getImmediatelyDominated", new object[1] { node });
	}

	public ulong GetImmediateDominator(ulong node)
	{
		return CallMethod<ulong>("getImmediateDominator", new object[1] { node });
	}
}
