namespace Gecko.WebIDL;

public class SVGStringList : WebIDLBase
{
	public uint Length => GetProperty<uint>("length");

	public uint NumberOfItems => GetProperty<uint>("numberOfItems");

	public SVGStringList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Clear()
	{
		CallVoidMethod("clear");
	}

	public string Initialize(string newItem)
	{
		return CallMethod<string>("initialize", new object[1] { newItem });
	}

	public string GetItem(uint index)
	{
		return CallMethod<string>("getItem", new object[1] { index });
	}

	public string InsertItemBefore(string newItem, uint index)
	{
		return CallMethod<string>("insertItemBefore", new object[2] { newItem, index });
	}

	public string ReplaceItem(string newItem, uint index)
	{
		return CallMethod<string>("replaceItem", new object[2] { newItem, index });
	}

	public string RemoveItem(uint index)
	{
		return CallMethod<string>("removeItem", new object[1] { index });
	}

	public string AppendItem(string newItem)
	{
		return CallMethod<string>("appendItem", new object[1] { newItem });
	}
}
