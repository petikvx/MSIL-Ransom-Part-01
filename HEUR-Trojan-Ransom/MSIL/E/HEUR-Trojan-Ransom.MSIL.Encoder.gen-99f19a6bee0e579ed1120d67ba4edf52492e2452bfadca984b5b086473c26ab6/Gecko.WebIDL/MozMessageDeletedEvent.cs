namespace Gecko.WebIDL;

public class MozMessageDeletedEvent : WebIDLBase
{
	public int[] DeletedMessageIds => GetProperty<int[]>("deletedMessageIds");

	public ulong[] DeletedThreadIds => GetProperty<ulong[]>("deletedThreadIds");

	public MozMessageDeletedEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
