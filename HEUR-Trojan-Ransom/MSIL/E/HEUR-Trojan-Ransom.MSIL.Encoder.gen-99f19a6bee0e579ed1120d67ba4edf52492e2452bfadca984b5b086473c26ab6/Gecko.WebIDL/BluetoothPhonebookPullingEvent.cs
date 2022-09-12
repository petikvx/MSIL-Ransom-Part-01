namespace Gecko.WebIDL;

public class BluetoothPhonebookPullingEvent : WebIDLBase
{
	public string Name => GetProperty<string>("name");

	public VCardVersion Format => GetProperty<VCardVersion>("format");

	public VCardProperties[] PropSelector => GetProperty<VCardProperties[]>("propSelector");

	public uint MaxListCount => GetProperty<uint>("maxListCount");

	public uint ListStartOffset => GetProperty<uint>("listStartOffset");

	public VCardProperties[] VcardSelector => GetProperty<VCardProperties[]>("vcardSelector");

	public VCardSelectorOp VcardSelectorOperator => GetProperty<VCardSelectorOp>("vcardSelectorOperator");

	public nsISupports Handle => GetProperty<nsISupports>("handle");

	public BluetoothPhonebookPullingEvent(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
