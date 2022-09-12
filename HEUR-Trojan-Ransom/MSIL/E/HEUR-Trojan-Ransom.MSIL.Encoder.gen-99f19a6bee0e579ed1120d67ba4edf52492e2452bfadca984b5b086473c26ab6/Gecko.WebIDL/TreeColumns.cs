namespace Gecko.WebIDL;

public class TreeColumns : WebIDLBase
{
	public nsISupports Tree => GetProperty<nsISupports>("tree");

	public uint Count => GetProperty<uint>("count");

	public uint Length => GetProperty<uint>("length");

	public TreeColumns(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetFirstColumn()
	{
		return CallMethod<nsISupports>("getFirstColumn", new object[0]);
	}

	public nsISupports GetLastColumn()
	{
		return CallMethod<nsISupports>("getLastColumn", new object[0]);
	}

	public nsISupports GetPrimaryColumn()
	{
		return CallMethod<nsISupports>("getPrimaryColumn", new object[0]);
	}

	public nsISupports GetSortedColumn()
	{
		return CallMethod<nsISupports>("getSortedColumn", new object[0]);
	}

	public nsISupports GetKeyColumn()
	{
		return CallMethod<nsISupports>("getKeyColumn", new object[0]);
	}

	public nsISupports GetColumnFor(nsIDOMElement element)
	{
		return CallMethod<nsISupports>("getColumnFor", new object[1] { element });
	}

	public void InvalidateColumns()
	{
		CallVoidMethod("invalidateColumns");
	}

	public void RestoreNaturalOrder()
	{
		CallVoidMethod("restoreNaturalOrder");
	}
}
