namespace Gecko.WebIDL;

public class SVGTransformList : WebIDLBase
{
	public uint NumberOfItems => GetProperty<uint>("numberOfItems");

	public uint Length => GetProperty<uint>("length");

	public SVGTransformList(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void Clear()
	{
		CallVoidMethod("clear");
	}

	public nsISupports Initialize(nsISupports newItem)
	{
		return CallMethod<nsISupports>("initialize", new object[1] { newItem });
	}

	public nsISupports InsertItemBefore(nsISupports newItem, uint index)
	{
		return CallMethod<nsISupports>("insertItemBefore", new object[2] { newItem, index });
	}

	public nsISupports ReplaceItem(nsISupports newItem, uint index)
	{
		return CallMethod<nsISupports>("replaceItem", new object[2] { newItem, index });
	}

	public nsISupports RemoveItem(uint index)
	{
		return CallMethod<nsISupports>("removeItem", new object[1] { index });
	}

	public nsISupports AppendItem(nsISupports newItem)
	{
		return CallMethod<nsISupports>("appendItem", new object[1] { newItem });
	}

	public nsISupports CreateSVGTransformFromMatrix(nsISupports matrix)
	{
		return CallMethod<nsISupports>("createSVGTransformFromMatrix", new object[1] { matrix });
	}

	public nsISupports Consolidate()
	{
		return CallMethod<nsISupports>("consolidate", new object[0]);
	}
}
