namespace Gecko.WebIDL;

public class BluetoothVCardListingEvent : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public VCardOrderType Order => GetProperty<VCardOrderType>("order");

	public string SearchValue => GetProperty<string>("searchValue");

	public VCardSearchKeyType SearchKey => GetProperty<VCardSearchKeyType>("searchKey");

	public uint MaxListCount => GetProperty<uint>("maxListCount");

	public uint ListStartOffset => GetProperty<uint>("listStartOffset");

	public VCardProperties[] VcardSelector => GetProperty<VCardProperties[]>("vcardSelector");

	public VCardSelectorOp VcardSelectorOperator => GetProperty<VCardSelectorOp>("vcardSelectorOperator");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothVCardListingEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
