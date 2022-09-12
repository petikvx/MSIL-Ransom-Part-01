namespace Gecko.WebIDL;

public class TreeColumn : WebIDLBase
{
	public nsIDOMElement Element => GetProperty<nsIDOMElement>("element");

	public nsISupports Columns => GetProperty<nsISupports>("columns");

	public int X => GetProperty<int>("x");

	public int Width => GetProperty<int>("width");

	public string Id => GetProperty<string>("id");

	public int Index => GetProperty<int>("index");

	public bool Primary => GetProperty<bool>("primary");

	public bool Cycler => GetProperty<bool>("cycler");

	public bool Editable => GetProperty<bool>("editable");

	public bool Selectable => GetProperty<bool>("selectable");

	public short Type => GetProperty<short>("type");

	public TreeColumn(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports GetNext()
	{
		return CallMethod<nsISupports>("getNext", new object[0]);
	}

	public nsISupports GetPrevious()
	{
		return CallMethod<nsISupports>("getPrevious", new object[0]);
	}

	public void Invalidate()
	{
		CallVoidMethod("invalidate");
	}
}
