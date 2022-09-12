namespace Gecko.WebIDL;

public class UndoManager : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public uint Position => GetProperty<uint>("position");

	public UndoManager(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Transact(nsISupports transaction, bool merge)
	{
		CallVoidMethod("transact", transaction, merge);
	}

	public void Undo()
	{
		CallVoidMethod("undo");
	}

	public void Redo()
	{
		CallVoidMethod("redo");
	}

	public nsISupports[] Item(uint index)
	{
		return CallMethod<nsISupports[]>("item", new object[1] { index });
	}

	public void ClearUndo()
	{
		CallVoidMethod("clearUndo");
	}

	public void ClearRedo()
	{
		CallVoidMethod("clearRedo");
	}
}
