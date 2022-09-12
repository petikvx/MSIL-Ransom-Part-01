namespace Gecko.WebIDL;

public class BluetoothPbapRequestHandle : WebIDLBase
{
	public BluetoothPbapRequestHandle(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports ReplyTovCardPulling(nsIDOMBlob vcardObject)
	{
		return CallMethod<nsISupports>("replyTovCardPulling", new object[1] { vcardObject });
	}

	public nsISupports ReplyToPhonebookPulling(nsIDOMBlob vcardObject, ulong phonebookSize)
	{
		return CallMethod<nsISupports>("replyToPhonebookPulling", new object[2] { vcardObject, phonebookSize });
	}

	public nsISupports ReplyTovCardListing(nsIDOMBlob vcardObject, ulong phonebookSize)
	{
		return CallMethod<nsISupports>("replyTovCardListing", new object[2] { vcardObject, phonebookSize });
	}
}
